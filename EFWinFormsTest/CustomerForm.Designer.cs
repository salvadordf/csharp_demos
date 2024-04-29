namespace EFWinFormsTest
{
    partial class CustomerForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            addressTextBox = new TextBox();
            cancelButton = new Button();
            okButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 71);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(79, 14);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(231, 23);
            firstNameTextBox.TabIndex = 3;
            firstNameTextBox.Text = "John";
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(79, 41);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(231, 23);
            lastNameTextBox.TabIndex = 4;
            lastNameTextBox.Text = "Wick";
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(79, 68);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(231, 98);
            addressTextBox.TabIndex = 5;
            addressTextBox.Text = "121 Mill Neck Long Island, NY.";
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(235, 180);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 24;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(12, 180);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 23;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(323, 216);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(addressTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            TopMost = true;
            Shown += CustomerForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox addressTextBox;
        private Button cancelButton;
        private Button okButton;
    }
}