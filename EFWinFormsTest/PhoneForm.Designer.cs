namespace EFWinFormsTest
{
    partial class PhoneForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cancelButton = new Button();
            okButton = new Button();
            descriptionTextBox = new TextBox();
            numberTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(236, 76);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 26;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(13, 76);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 25;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(86, 39);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(225, 23);
            descriptionTextBox.TabIndex = 30;
            descriptionTextBox.Text = "Work";
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(86, 12);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(225, 23);
            numberTextBox.TabIndex = 29;
            numberTextBox.Text = "555-123456";
            numberTextBox.TextChanged += numberTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 42);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 28;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 27;
            label1.Text = "Number";
            // 
            // PhoneForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(323, 111);
            Controls.Add(descriptionTextBox);
            Controls.Add(numberTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PhoneForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhoneForm";
            TopMost = true;
            Shown += PhoneForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelButton;
        private Button okButton;
        private TextBox descriptionTextBox;
        private TextBox numberTextBox;
        private Label label2;
        private Label label1;
    }
}