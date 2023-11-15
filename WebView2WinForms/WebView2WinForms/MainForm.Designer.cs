namespace WebView2WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PnlNavControl = new Panel();
            CbxURL = new ComboBox();
            PnlConfig = new Panel();
            BtnConfig = new Button();
            BtnGo = new Button();
            PnlNavButton = new Panel();
            BtnStop = new Button();
            BtnReload = new Button();
            BtnForward = new Button();
            BtnBack = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dEvToolsToolStripMenuItem = new ToolStripMenuItem();
            printToPDFToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            PnlNavControl.SuspendLayout();
            PnlConfig.SuspendLayout();
            PnlNavButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            statusStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PnlNavControl
            // 
            PnlNavControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PnlNavControl.Controls.Add(CbxURL);
            PnlNavControl.Controls.Add(PnlConfig);
            PnlNavControl.Controls.Add(PnlNavButton);
            PnlNavControl.Location = new Point(0, 0);
            PnlNavControl.Name = "PnlNavControl";
            PnlNavControl.Size = new Size(1008, 25);
            PnlNavControl.TabIndex = 0;
            // 
            // CbxURL
            // 
            CbxURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbxURL.FormattingEnabled = true;
            CbxURL.Items.AddRange(new object[] { "https://www.bing.com", "https://www.google.com", "https://www.whatismybrowser.com/detect/what-http-headers-is-my-browser-sending", "https://www.w3schools.com/js/tryit.asp?filename=tryjs_win_close", "https://www.w3schools.com/js/tryit.asp?filename=tryjs_alert", "https://www.w3schools.com/js/tryit.asp?filename=tryjs_loc_assign", "https://www.w3schools.com/jsref/tryit.asp?filename=tryjsref_style_backgroundcolor", "https://www.w3schools.com/Tags/tryit.asp?filename=tryhtml_iframe_name", "https://www.w3schools.com/html/html5_video.asp", "http://html5test.com/", "https://webrtc.github.io/samples/src/content/devices/input-output/", "https://test.webrtc.org/", "https://www.browserleaks.com/webrtc", "https://shaka-player-demo.appspot.com/demo/", "http://webglsamples.org/", "https://get.webgl.org/", "https://www.briskbard.com", "https://www.youtube.com", "https://html5demos.com/drag/", "https://frames-per-second.appspot.com/", "https://badssl.com/", "https://www.httpwatch.com/httpgallery/authentication/", "https://www.sede.fnmt.gob.es/certificados/persona-fisica/verificar-estado", "https://badssl.com/", "edge://flags/", "edge://gpu/", "edge://about/" });
            CbxURL.Location = new Point(120, 0);
            CbxURL.Name = "CbxURL";
            CbxURL.Size = new Size(821, 23);
            CbxURL.TabIndex = 2;
            CbxURL.Text = "https://www.briskbard.com";
            // 
            // PnlConfig
            // 
            PnlConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PnlConfig.Controls.Add(BtnConfig);
            PnlConfig.Controls.Add(BtnGo);
            PnlConfig.Location = new Point(943, 0);
            PnlConfig.Name = "PnlConfig";
            PnlConfig.Size = new Size(65, 25);
            PnlConfig.TabIndex = 1;
            // 
            // BtnConfig
            // 
            BtnConfig.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnConfig.Location = new Point(35, 0);
            BtnConfig.Name = "BtnConfig";
            BtnConfig.Size = new Size(25, 25);
            BtnConfig.TabIndex = 5;
            BtnConfig.Text = "≡";
            BtnConfig.UseVisualStyleBackColor = true;
            BtnConfig.Click += BtnConfig_Click;
            // 
            // BtnGo
            // 
            BtnGo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGo.Location = new Point(5, 0);
            BtnGo.Name = "BtnGo";
            BtnGo.Size = new Size(25, 25);
            BtnGo.TabIndex = 4;
            BtnGo.Text = "►";
            BtnGo.UseVisualStyleBackColor = true;
            BtnGo.Click += BtnGo_Click;
            // 
            // PnlNavButton
            // 
            PnlNavButton.Controls.Add(BtnStop);
            PnlNavButton.Controls.Add(BtnReload);
            PnlNavButton.Controls.Add(BtnForward);
            PnlNavButton.Controls.Add(BtnBack);
            PnlNavButton.Location = new Point(0, 0);
            PnlNavButton.Name = "PnlNavButton";
            PnlNavButton.Size = new Size(120, 25);
            PnlNavButton.TabIndex = 0;
            // 
            // BtnStop
            // 
            BtnStop.Font = new Font("Webdings", 12F);
            BtnStop.Location = new Point(90, 0);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(25, 25);
            BtnStop.TabIndex = 3;
            BtnStop.Text = "=";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // BtnReload
            // 
            BtnReload.Font = new Font("Webdings", 12F);
            BtnReload.Location = new Point(60, 0);
            BtnReload.Name = "BtnReload";
            BtnReload.Size = new Size(25, 25);
            BtnReload.TabIndex = 2;
            BtnReload.Text = "q";
            BtnReload.UseVisualStyleBackColor = true;
            BtnReload.Click += BtnReload_Click;
            // 
            // BtnForward
            // 
            BtnForward.Font = new Font("Webdings", 12F);
            BtnForward.Location = new Point(30, 0);
            BtnForward.Name = "BtnForward";
            BtnForward.Size = new Size(25, 25);
            BtnForward.TabIndex = 1;
            BtnForward.Text = "4";
            BtnForward.UseVisualStyleBackColor = true;
            BtnForward.Click += BtnForward_Click;
            // 
            // BtnBack
            // 
            BtnBack.Font = new Font("Webdings", 12F);
            BtnBack.Location = new Point(0, 0);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(25, 25);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "3";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 30);
            webView21.Name = "webView21";
            webView21.Size = new Size(1006, 674);
            webView21.Source = new Uri("https://www.briskbard.com/", UriKind.Absolute);
            webView21.TabIndex = 1;
            webView21.ZoomFactor = 1D;
            webView21.CoreWebView2InitializationCompleted += webView21_CoreWebView2InitializationCompleted;
            webView21.NavigationStarting += webView21_NavigationStarting;
            webView21.NavigationCompleted += webView21_NavigationCompleted;
            webView21.SourceChanged += webView21_SourceChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 707);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1008, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.AutoSize = false;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(150, 17);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.AutoSize = false;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(500, 17);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { dEvToolsToolStripMenuItem, printToPDFToolStripMenuItem, openFileToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(138, 98);
            // 
            // dEvToolsToolStripMenuItem
            // 
            dEvToolsToolStripMenuItem.Name = "dEvToolsToolStripMenuItem";
            dEvToolsToolStripMenuItem.Size = new Size(137, 22);
            dEvToolsToolStripMenuItem.Text = "DevTools";
            dEvToolsToolStripMenuItem.Click += dEvToolsToolStripMenuItem_Click;
            // 
            // printToPDFToolStripMenuItem
            // 
            printToPDFToolStripMenuItem.Name = "printToPDFToolStripMenuItem";
            printToPDFToolStripMenuItem.Size = new Size(137, 22);
            printToPDFToolStripMenuItem.Text = "Print to PDF";
            printToPDFToolStripMenuItem.Click += printToPDFToolStripMenuItem_Click;
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(137, 22);
            openFileToolStripMenuItem.Text = "Open File...";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(134, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(137, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "PDF files|*pdf";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "HTML files|*.htm;*.html|PDF files|*.pdf";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(statusStrip1);
            Controls.Add(webView21);
            Controls.Add(PnlNavControl);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniBrowser";
            PnlNavControl.ResumeLayout(false);
            PnlConfig.ResumeLayout(false);
            PnlNavButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlNavControl;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Panel PnlNavButton;
        private Panel PnlConfig;
        private ComboBox CbxURL;
        private Button BtnBack;
        private Button BtnStop;
        private Button BtnReload;
        private Button BtnForward;
        private Button BtnGo;
        private Button BtnConfig;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem printToPDFToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem dEvToolsToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
