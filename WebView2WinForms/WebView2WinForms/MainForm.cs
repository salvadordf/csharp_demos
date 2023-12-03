namespace WebView2WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            webView21.Stop();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            LoadUrl(CbxURL.Text);
        }

        private void webView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            addURL(webView21.Source.ToString());
        }

        private void webView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            PnlNavControl.Enabled = true;
            EnableNavigationButtons(false);
        }

        private void EnableNavigationButtons(bool isNavigating)
        {
            BtnBack.Enabled = webView21.CanGoBack;
            BtnForward.Enabled = webView21.CanGoForward;
            BtnStop.Enabled = isNavigating;
            BtnReload.Enabled = !isNavigating;
        }
        private void LoadUrl(string url)
        {
            if (!string.IsNullOrEmpty(url) && (url != webView21.Source.ToString()))
            {
                webView21.CoreWebView2.Navigate(url);
            }
        }

        private void webView21_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            EnableNavigationButtons(true);
        }

        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            EnableNavigationButtons(false);
        }

        private void printToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                webView21.CoreWebView2.PrintToPdfAsync(saveFileDialog1.FileName);
            }
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            Point point = new Point(BtnConfig.Location.X, BtnConfig.Location.Y + BtnConfig.Size.Height);
            contextMenuStrip1.Show(PnlConfig.PointToScreen(point));
        }

        private void dEvToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.OpenDevToolsWindow();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addURL(string url)
        {
            if (!string.IsNullOrEmpty(url) && (CbxURL.Items.IndexOf(url) == -1))
            {
                CbxURL.Items.Add(url);
            }
            CbxURL.Text = url;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] bytes = File.ReadAllBytes(openFileDialog1.FileName);
                    String file = Convert.ToBase64String(bytes);
                    String mimeType;
                    if (openFileDialog1.FilterIndex == 1)
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
                        "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
