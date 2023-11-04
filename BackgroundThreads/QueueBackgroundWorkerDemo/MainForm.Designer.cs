namespace QueueBackgroundWorkerDemo
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
            nudValue = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)nudValue).BeginInit();
            SuspendLayout();
            // 
            // nudValue
            // 
            nudValue.Location = new Point(135, 27);
            nudValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudValue.Name = "nudValue";
            nudValue.Size = new Size(120, 39);
            nudValue.TabIndex = 0;
            nudValue.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 1;
            label1.Text = "Value";
            // 
            // button1
            // 
            button1.Location = new Point(296, 27);
            button1.Name = "button1";
            button1.Size = new Size(291, 116);
            button1.TabIndex = 2;
            button1.Text = "Multiply value";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 101);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 3;
            label2.Text = "Result";
            // 
            // lblResult
            // 
            lblResult.Location = new Point(135, 101);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(120, 32);
            lblResult.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 178);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(nudValue);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QueueBackgroundWorker demo";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)nudValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudValue;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label lblResult;
    }
}