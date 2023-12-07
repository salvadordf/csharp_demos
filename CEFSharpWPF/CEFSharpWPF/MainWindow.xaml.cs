using CefSharp;
using CefSharp.Wpf;
using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace CEFSharpWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChromiumWebBrowser? _ChromiumWebBrowser = null;
        public MainWindow()
        {
            InitializeComponent();
            InitializeCEF();
            _ChromiumWebBrowser = new ChromiumWebBrowser();
            BrdrBrowser.Child = _ChromiumWebBrowser;
            _ChromiumWebBrowser.Focus();
            _ChromiumWebBrowser.LoadingStateChanged += chromiumWebBrowser_LoadingStateChanged;
            _ChromiumWebBrowser.StatusMessage += chromiumWebBrowser_StatusMessage;
            var downloadHandler = new DownloadHandler();
            downloadHandler.OnDownloadUpdatedFired += DownloadHandler_OnDownloadUpdatedFired;
            _ChromiumWebBrowser.DownloadHandler = downloadHandler;
            CbxURL.DataContext = _ChromiumWebBrowser;
            
            LoadUrl(@"https://www.briskbard.com");
        }

        private void InitializeCEF()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
        }

        private void LoadUrl(string url)
        {
            if (!string.IsNullOrEmpty(url) && (_ChromiumWebBrowser != null) && (url != _ChromiumWebBrowser.Address))
            {
                _ChromiumWebBrowser?.LoadUrlAsync(url);
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
            _ChromiumWebBrowser.Back();
        }

        private void BtnForward_Click(object sender, RoutedEventArgs e)
        {
            _ChromiumWebBrowser.Forward();
        }

        private void BtnReload_Click(object sender, RoutedEventArgs e)
        {
            _ChromiumWebBrowser.Reload();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            _ChromiumWebBrowser.Stop();
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            LoadUrl(CbxURL.Text);
        }
        private void DownloadHandler_OnDownloadUpdatedFired(object? sender, DownloadItem e)
        {
            Dispatcher.Invoke(() =>
            {
                if (e.IsComplete || (e.PercentComplete == 100))
                {
                    StatusText1.Text = "Download complete.";
                }
                else if (e.IsInProgress)
                {
                    if (e.PercentComplete >= 0)
                    {
                        StatusText1.Text = $"Downloading: {e.PercentComplete}%";
                    }
                    else
                    {
                        StatusText1.Text = $"Downloading: {e.ReceivedBytes} bytes";
                    }
                }
                else
                {
                    StatusText1.Text = "";
                }
            });
        }
        private void chromiumWebBrowser_LoadingStateChanged(object? sender, LoadingStateChangedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                BtnBack.IsEnabled = e.CanGoBack;
                BtnForward.IsEnabled = e.CanGoForward;
                BtnReload.IsEnabled = e.CanReload;

                if (e.IsLoading)
                {
                    StatusText1.Text = "Loading...";
                }
                else
                {
                    StatusText1.Text = "";
                }
            });
        }

        private void chromiumWebBrowser_StatusMessage(object? sender, StatusMessageEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                StatusText2.Text = e.Value;
            });
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
            _ChromiumWebBrowser.ShowDevTools();
        }

        private void printToPDFMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.DefaultExt = ".pdf"; 
            dialog.Filter = "PDF files|*.pdf"; 
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                _ChromiumWebBrowser.PrintToPdfAsync(dialog.FileName);
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
                    _ChromiumWebBrowser.LoadUrlAsync(uri);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("There was an error opening that file.\n" + exception.Message,
                        "File error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}