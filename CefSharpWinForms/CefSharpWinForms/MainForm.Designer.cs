namespace CefSharpWinForms
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
            PnlConfig = new Panel();
            BtnConfig = new Button();
            BtnGo = new Button();
            CbxURL = new ComboBox();
            PnlNavButton = new Panel();
            BtnStop = new Button();
            BtnReload = new Button();
            BtnForward = new Button();
            BtnBack = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDevToolsToolStripMenuItem = new ToolStripMenuItem();
            printToPDFToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            PnlNavControl.SuspendLayout();
            PnlConfig.SuspendLayout();
            PnlNavButton.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PnlNavControl
            // 
            PnlNavControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PnlNavControl.Controls.Add(PnlConfig);
            PnlNavControl.Controls.Add(CbxURL);
            PnlNavControl.Controls.Add(PnlNavButton);
            PnlNavControl.Location = new Point(0, 0);
            PnlNavControl.Margin = new Padding(0);
            PnlNavControl.Name = "PnlNavControl";
            PnlNavControl.Size = new Size(926, 25);
            PnlNavControl.TabIndex = 0;
            // 
            // PnlConfig
            // 
            PnlConfig.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PnlConfig.Controls.Add(BtnConfig);
            PnlConfig.Controls.Add(BtnGo);
            PnlConfig.Location = new Point(861, 0);
            PnlConfig.Name = "PnlConfig";
            PnlConfig.Size = new Size(65, 25);
            PnlConfig.TabIndex = 2;
            // 
            // BtnConfig
            // 
            BtnConfig.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConfig.Location = new Point(35, 0);
            BtnConfig.Name = "BtnConfig";
            BtnConfig.Size = new Size(25, 25);
            BtnConfig.TabIndex = 1;
            BtnConfig.Text = "≡";
            BtnConfig.UseVisualStyleBackColor = true;
            BtnConfig.Click += BtnConfig_Click;
            // 
            // BtnGo
            // 
            BtnGo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGo.Location = new Point(5, 0);
            BtnGo.Name = "BtnGo";
            BtnGo.Size = new Size(25, 25);
            BtnGo.TabIndex = 0;
            BtnGo.Text = "►";
            BtnGo.UseVisualStyleBackColor = true;
            BtnGo.Click += BtnGo_Click;
            // 
            // CbxURL
            // 
            CbxURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CbxURL.FormattingEnabled = true;
            CbxURL.Items.AddRange(new object[] { "https://www.google.com", "https://www.whatismybrowser.com/detect/what-http-headers-is-my-browser-sending", "https://www.w3schools.com/js/tryit.asp?filename=tryjs_win_close", "https://www.w3schools.com/js/tryit.asp?filename=tryjs_alert", "https://www.w3schools.com/js/tryit.asp?filename=tryjs_loc_assign", "https://www.w3schools.com/jsref/tryit.asp?filename=tryjsref_style_backgroundcolor", "https://www.w3schools.com/Tags/tryit.asp?filename=tryhtml_iframe_name", "https://www.w3schools.com/tags/tryit.asp?filename=tryhtml5_input_type_file", "https://www.w3schools.com/jsref/tryit.asp?filename=tryjsref_state_throw_error", "https://www.htmlquick.com/es/reference/tags/input-file.html", "https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/file", "https://developer.mozilla.org/en-US/docs/Web/API/HTMLInputElement/webkitdirectory", "https://www.w3schools.com/html/html5_video.asp", "http://html5test.com/", "https://webrtc.github.io/samples/src/content/devices/input-output/", "https://test.webrtc.org/", "https://www.browserleaks.com/webrtc", "https://shaka-player-demo.appspot.com/demo/", "http://webglsamples.org/", "https://get.webgl.org/", "https://www.briskbard.com", "https://www.youtube.com", "https://html5demos.com/drag/", "https://frames-per-second.appspot.com/", "https://www.sede.fnmt.gob.es/certificados/persona-fisica/verificar-estado", "https://www.kirupa.com/html5/accessing_your_webcam_in_html5.htm", "https://www.xdumaine.com/enumerateDevices/test/", "https://dagrs.berkeley.edu/sites/default/files/2020-01/sample.pdf", "chrome://version/", "chrome://net-internals/", "chrome://tracing/", "chrome://appcache-internals/", "chrome://blob-internals/", "chrome://view-http-cache/", "chrome://credits/", "chrome://histograms/", "chrome://media-internals/", "chrome://kill", "chrome://crash", "chrome://hang", "chrome://shorthang", "chrome://gpuclean", "chrome://gpucrash", "chrome://gpuhang", "chrome://extensions-support", "chrome://process-internals" });
            CbxURL.Location = new Point(120, 0);
            CbxURL.Name = "CbxURL";
            CbxURL.Size = new Size(739, 23);
            CbxURL.TabIndex = 1;
            CbxURL.Text = "https://www.briskbard.com";
            // 
            // PnlNavButton
            // 
            PnlNavButton.Controls.Add(BtnStop);
            PnlNavButton.Controls.Add(BtnReload);
            PnlNavButton.Controls.Add(BtnForward);
            PnlNavButton.Controls.Add(BtnBack);
            PnlNavButton.Location = new Point(0, 0);
            PnlNavButton.Margin = new Padding(2, 1, 2, 1);
            PnlNavButton.Name = "PnlNavButton";
            PnlNavButton.Size = new Size(120, 25);
            PnlNavButton.TabIndex = 0;
            // 
            // BtnStop
            // 
            BtnStop.Font = new Font("Webdings", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            BtnReload.Font = new Font("Webdings", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            BtnForward.Font = new Font("Webdings", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            BtnBack.Font = new Font("Webdings", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBack.Location = new Point(0, 0);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(25, 25);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "3";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 631);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(926, 22);
            statusStrip1.TabIndex = 1;
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
            // chromiumWebBrowser1
            // 
            chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            chromiumWebBrowser1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chromiumWebBrowser1.Location = new Point(0, 31);
            chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            chromiumWebBrowser1.Size = new Size(924, 598);
            chromiumWebBrowser1.TabIndex = 2;
            chromiumWebBrowser1.AddressChanged += chromiumWebBrowser1_AddressChanged;
            chromiumWebBrowser1.TitleChanged += chromiumWebBrowser1_TitleChanged;
            chromiumWebBrowser1.LoadingStateChanged += chromiumWebBrowser1_LoadingStateChanged;
            chromiumWebBrowser1.StatusMessage += chromiumWebBrowser1_StatusMessage;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDevToolsToolStripMenuItem, printToPDFToolStripMenuItem, openFileToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(138, 98);
            // 
            // showDevToolsToolStripMenuItem
            // 
            showDevToolsToolStripMenuItem.Name = "showDevToolsToolStripMenuItem";
            showDevToolsToolStripMenuItem.Size = new Size(137, 22);
            showDevToolsToolStripMenuItem.Text = "DevTools";
            showDevToolsToolStripMenuItem.Click += showDevToolsToolStripMenuItem_Click;
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
            openFileToolStripMenuItem.Text = "Open file...";
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
            ClientSize = new Size(926, 653);
            Controls.Add(chromiumWebBrowser1);
            Controls.Add(statusStrip1);
            Controls.Add(PnlNavControl);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniBrowser";
            PnlNavControl.ResumeLayout(false);
            PnlConfig.ResumeLayout(false);
            PnlNavButton.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlNavControl;
        private Panel PnlNavButton;
        private Button BtnForward;
        private Button BtnBack;
        private Button BtnStop;
        private Button BtnReload;
        private ComboBox CbxURL;
        private Panel PnlConfig;
        private Button BtnConfig;
        private Button BtnGo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDevToolsToolStripMenuItem;
        private ToolStripMenuItem printToPDFToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}