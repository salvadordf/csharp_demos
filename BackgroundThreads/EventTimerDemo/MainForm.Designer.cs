namespace EventTimerDemo
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
            lblTime = new Label();
            lblTimeValue = new Label();
            chkTimerEnabled = new CheckBox();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(35, 42);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(86, 32);
            lblTime.TabIndex = 0;
            lblTime.Text = "Time : ";
            // 
            // lblTimeValue
            // 
            lblTimeValue.Location = new Point(142, 42);
            lblTimeValue.Name = "lblTimeValue";
            lblTimeValue.Size = new Size(500, 32);
            lblTimeValue.TabIndex = 1;
            // 
            // chkTimerEnabled
            // 
            chkTimerEnabled.AutoSize = true;
            chkTimerEnabled.Checked = true;
            chkTimerEnabled.CheckState = CheckState.Checked;
            chkTimerEnabled.Location = new Point(35, 100);
            chkTimerEnabled.Name = "chkTimerEnabled";
            chkTimerEnabled.Size = new Size(131, 36);
            chkTimerEnabled.TabIndex = 2;
            chkTimerEnabled.Text = "Enabled";
            chkTimerEnabled.UseVisualStyleBackColor = true;
            chkTimerEnabled.CheckedChanged += chkTimerEnabled_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 177);
            Controls.Add(chkTimerEnabled);
            Controls.Add(lblTimeValue);
            Controls.Add(lblTime);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventTimer demo";
            FormClosing += MainForm_FormClosing;
            Shown += MainForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblTimeValue;
        private CheckBox chkTimerEnabled;
    }
}