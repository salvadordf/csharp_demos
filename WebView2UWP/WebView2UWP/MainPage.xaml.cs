using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WebView2UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void LoadUri(Uri source)
        {
            if ((source != null) && (!source.Equals(webView21.Source)))
            {
                webView21.Navigate(source);
                addURL(webView21.Source.ToString());
            }
        }

        private void addURL(string url)
        {
            if (!string.IsNullOrEmpty(url)) {
                if (CbxURL.Items.IndexOf(url) == -1)
                {
                    CbxURL.Items.Add(url);
                }
                CbxURL.Text = url;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (webView21.CanGoBack)
            {
                webView21.GoBack();
                addURL(webView21.Source.ToString());
            }
        }

        private void BtnForward_Click(object sender, RoutedEventArgs e)
        {
            if (webView21.CanGoForward)
            {
                webView21.GoForward();
                addURL(webView21.Source.ToString());
            }
        }

        private void BtnReload_Click(object sender, RoutedEventArgs e)
        {
            webView21.Navigate(webView21.Source);
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            webView21.Stop();
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            Uri uri;
            if (Uri.TryCreate(CbxURL.Text, UriKind.RelativeOrAbsolute, out uri))
            {
                LoadUri(uri);
            }
        }

        private void BtnConfig_Click(object sender, RoutedEventArgs e)
        {
            BtnConfig.ContextFlyout.ShowAt(BtnConfig);
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        // https://stackoverflow.com/questions/46565499/there-is-no-messagebox-in-uwp
        private async void ShowMessage(string title, string content, [Optional] object[][] buttons)
        {
            MessageDialog dialog = new MessageDialog(content, title);

            // Sets the default cancel and default indexes to zero. (incase no buttons are passed)
            dialog.CancelCommandIndex = 0;
            dialog.DefaultCommandIndex = 0;

            // If the optional buttons array is not empty or null.
            if (buttons != null)
            {
                // If there's multiple buttons
                if (buttons.Length > 1)
                {
                    // Loops through the given buttons array
                    for (Int32 i = 0; i < buttons.Length; i++)
                    {
                        /* Assigns text and handler variables from the current index subarray.
                         * The first object at the currentindex should be a string and 
                         * the second object should be a "UICommandInvokedHandler" 
                         */
                        string text = (string)buttons[i][0];

                        UICommandInvokedHandler handler = (UICommandInvokedHandler)buttons[i][1];

                        /* Checks whether both variables types actually are relevant and correct.
                         * If not, it will return and terminate this function and not display anything.
                         */
                        if (handler.GetType().Equals(typeof(UICommandInvokedHandler)) &&
                            text.GetType().Equals(typeof(string)))
                        {
                            /* Creates a new "UICommand" instance which is required for
                             * adding multiple buttons.
                             */
                            UICommand button = new UICommand(text, handler);

                            // Simply adds the newly created button to the dialog
                            dialog.Commands.Add(button);
                        }
                        else return;
                    }
                }
                else
                {
                    // Already described
                    string text = (string)buttons[0][0];

                    UICommandInvokedHandler handler = (UICommandInvokedHandler)buttons[0][1];

                    // Already described
                    if (handler.GetType().Equals(typeof(UICommandInvokedHandler)) &&
                        text.GetType().Equals(typeof(string)))
                    {
                        // Already described
                        UICommand button = new UICommand(text, handler);

                        // Already described
                        dialog.Commands.Add(button);
                    }
                    else return;
                }

                /* Sets the default command index to the length of the button array.
                 * The first, colored button will become the default button or index.
                 */
                dialog.DefaultCommandIndex = (UInt32)buttons.Length;
            }

            await dialog.ShowAsync();
        }

        private async void openFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".htm");
            openPicker.FileTypeFilter.Add(".pdf");
            StorageFile file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                try
                {
                    byte[] bytes = File.ReadAllBytes(file.Name);
                    String fileContents = Convert.ToBase64String(bytes);
                    String mimeType;
                    if (file.FileType == ".htm")
                    {
                        mimeType = @"text/html";
                    }
                    else
                    {
                        mimeType = @"application/pdf";
                    }

                    String dataUri = "data:" + mimeType + ";charset=utf-8;base64," + Uri.EscapeDataString(fileContents);
                    addURL(dataUri);
                    LoadUri(new Uri(dataUri));
                }
                catch (Exception exception)
                {
                    // UWP does not have direct access to files outside of the application folder and application data folder.  
                    ShowMessage("File open error", exception.Message);
                }
            }
        }

        private void EnableNavigationButtons(bool isNavigating)
        {
            BtnBack.IsEnabled = webView21.CanGoBack;
            BtnForward.IsEnabled = webView21.CanGoForward;
            BtnStop.IsEnabled = isNavigating;
            BtnReload.IsEnabled = !isNavigating;
        }

        private void webView21_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            EnableNavigationButtons(true);
            addURL(webView21.Source.ToString());
        }

        private void webView21_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            EnableNavigationButtons(false);
            addURL(webView21.Source.ToString());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EnableNavigationButtons(false);
            addURL(webView21.Source.ToString());
        }
    }
}
