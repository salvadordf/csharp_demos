using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace WebView2Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoadUrl(string url)
        {
            if (!string.IsNullOrEmpty(url) && (url != webView21.Source.ToString()))
            {
                webView21.CoreWebView2.Navigate(url);
            }
        }

        private void addURL(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                if (CbxURL.Items.IndexOf(url) == -1)
                {
                    CbxURL.Items.Add(url);
                }
                CbxURL.Text = url;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            webView21.GoBack();
        }

        private void BtnForward_Click(object sender, RoutedEventArgs e)
        {
            webView21.GoForward();
        }

        private void BtnReload_Click(object sender, RoutedEventArgs e)
        {
            webView21.Reload();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            webView21.Stop();
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            LoadUrl(CbxURL.Text);
        }

        private void BtnConfig_Click(object sender, RoutedEventArgs e)
        {
            BtnConfig.ContextMenu.IsOpen = true;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showDevToolsMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.OpenDevToolsWindow();
        }

        private void printToPDFMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.DefaultExt = ".pdf";
            dialog.Filter = "PDF files|*.pdf";
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                webView21.CoreWebView2.PrintToPdfAsync(dialog.FileName);
            }
        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "HTML files|*.htm;*.html|PDF files|*.pdf";
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                try
                {
                    byte[] bytes = File.ReadAllBytes(dialog.FileName);
                    String file = Convert.ToBase64String(bytes);
                    String mimeType;
                    if (dialog.FilterIndex == 1)
                    {
                        mimeType = @"text/html";
                    }
                    else
                    {
                        mimeType = @"application/pdf";
                    }

                    String uri = "data:" + mimeType + ";charset=utf-8;base64," + Uri.EscapeDataString(file);
                    addURL(uri);
                    LoadUrl(uri);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("There was an error opening that file.\n" + exception.Message,
                        "File error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            addURL(webView21.Source.ToString());
        }

        private void webView21_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            EnableNavigationButtons(true);
        }

        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            EnableNavigationButtons(false);
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            PnlNavControl.IsEnabled = true;
            EnableNavigationButtons(false);
            webView21.CoreWebView2.DocumentTitleChanged += webView21_DocumentTitleChanged;
        }
        private void webView21_DocumentTitleChanged(object? sender, object e)
        {
            Title = "MiniBroser - " + webView21.CoreWebView2.DocumentTitle;
        }

        private void EnableNavigationButtons(bool isNavigating)
        {
            BtnBack.IsEnabled = webView21.CanGoBack;
            BtnForward.IsEnabled = webView21.CanGoForward;
            BtnStop.IsEnabled = isNavigating;
            BtnReload.IsEnabled = !isNavigating;
        }
    }
}