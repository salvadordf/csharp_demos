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
using CefSharp;
using CefSharp.Wpf;

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
            LoadUrl();
        }

        private void InitializeCEF()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
        }

        private void LoadUrl()
        {
            _ChromiumWebBrowser?.LoadUrlAsync(CbxURL.Text);
        }

        private void addURL(string url)
        {
            if (!string.IsNullOrEmpty(url) && (CbxURL.Items.IndexOf(url) == -1))
            {
                CbxURL.Items.Add(url);
            }
            CbxURL.Text = url;
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
            LoadUrl();
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

                addURL(e.Browser.MainFrame.Url);
            });
        }

        private void chromiumWebBrowser_StatusMessage(object? sender, StatusMessageEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                StatusText2.Text = e.Value;
            });
        }
    }
}