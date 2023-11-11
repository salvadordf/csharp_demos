using CefSharp;

namespace CefSharpWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LoadUrl();
        }
        private void LoadUrl()
        {
            chromiumWebBrowser1.LoadUrlAsync(CbxURL.Text);
        }

        private void addURL(string url)
        {
            if (CbxURL.Items.IndexOf(url) == -1)
            {
                CbxURL.Items.Add(url);
            }
            CbxURL.Text = url;
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Back();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Forward();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Reload();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Stop();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            LoadUrl();
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            Invoke(() =>
                {
                    BtnBack.Enabled = e.CanGoBack;
                    BtnForward.Enabled = e.CanGoForward;
                    BtnReload.Enabled = e.CanReload;

                    if (e.IsLoading)
                    {
                        toolStripStatusLabel1.Text = "Loading...";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "";
                    }
                });
        }

        private void chromiumWebBrowser1_StatusMessage(object sender, StatusMessageEventArgs e)
        {
            Invoke(() =>
                {
                    toolStripStatusLabel2.Text = e.Value;
                });
        }

        private void chromiumWebBrowser1_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            Invoke(() =>
                {
                    Text = "MiniBroser - " + e.Title;
                });
        }

        private void chromiumWebBrowser1_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            Invoke(() =>
            {
                addURL(e.Address);
            });
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            Point point = new Point(BtnConfig.Location.X, BtnConfig.Location.Y + BtnConfig.Size.Height);
            contextMenuStrip1.Show(PnlConfig.PointToScreen(point));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showDevToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.ShowDevTools();
        }

        private void printToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                chromiumWebBrowser1.PrintToPdfAsync(saveFileDialog1.FileName);
            }
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
                    chromiumWebBrowser1.LoadUrlAsync(uri);
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