namespace EFWinFormsTest
{
    partial class ProductForm
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
            priceNumericUpDown = new NumericUpDown();
            label3 = new Label();
            descriptionTextBox = new TextBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            okButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.DecimalPlaces = 2;
            priceNumericUpDown.Location = new Point(106, 71);
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(100, 23);
            priceNumericUpDown.TabIndex = 21;
            priceNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 73);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 20;
            label3.Text = "Price";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(106, 42);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 23);
            descriptionTextBox.TabIndex = 19;
            descriptionTextBox.Text = "green";
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(106, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 18;
            nameTextBox.Text = "tomatoes";
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 45);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 17;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 16;
            label1.Text = "Product name";
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(18, 108);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 15;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(131, 108);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 22;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(225, 143);
            Controls.Add(cancelButton);
            Controls.Add(priceNumericUpDown);
            Controls.Add(label3);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            TopMost = true;
            Shown += ProductForm_Shown;
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown priceNumericUpDown;
        private Label label3;
        private TextBox descriptionTextBox;
        private TextBox nameTextBox;
        private Label label2;
        private Label label1;
        private Button okButton;
        private Button cancelButton;
    }
}