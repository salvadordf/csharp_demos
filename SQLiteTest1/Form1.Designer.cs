namespace SQLiteTest1
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
            CreateBtn = new Button();
            OpenBtn = new Button();
            InsertBtn = new Button();
            ReadBtn = new Button();
            LogBox = new TextBox();
            CreateTableBtn = new Button();
            CloseBtn = new Button();
            SuspendLayout();
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(12, 12);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(148, 23);
            CreateBtn.TabIndex = 0;
            CreateBtn.Text = "Create connection";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += button1_Click;
            // 
            // OpenBtn
            // 
            OpenBtn.Location = new Point(181, 12);
            OpenBtn.Name = "OpenBtn";
            OpenBtn.Size = new Size(75, 23);
            OpenBtn.TabIndex = 1;
            OpenBtn.Text = "Open";
            OpenBtn.UseVisualStyleBackColor = true;
            OpenBtn.Click += OpenBtn_Click;
            // 
            // InsertBtn
            // 
            InsertBtn.Location = new Point(502, 12);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(116, 23);
            InsertBtn.TabIndex = 2;
            InsertBtn.Text = "Insert";
            InsertBtn.UseVisualStyleBackColor = true;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // ReadBtn
            // 
            ReadBtn.Location = new Point(636, 12);
            ReadBtn.Name = "ReadBtn";
            ReadBtn.Size = new Size(116, 23);
            ReadBtn.TabIndex = 3;
            ReadBtn.Text = "Read";
            ReadBtn.UseVisualStyleBackColor = true;
            ReadBtn.Click += ReadBtn_Click;
            // 
            // LogBox
            // 
            LogBox.Dock = DockStyle.Bottom;
            LogBox.Location = new Point(0, 61);
            LogBox.Multiline = true;
            LogBox.Name = "LogBox";
            LogBox.ScrollBars = ScrollBars.Both;
            LogBox.Size = new Size(769, 389);
            LogBox.TabIndex = 4;
            // 
            // CreateTableBtn
            // 
            CreateTableBtn.Location = new Point(371, 12);
            CreateTableBtn.Name = "CreateTableBtn";
            CreateTableBtn.Size = new Size(116, 23);
            CreateTableBtn.TabIndex = 5;
            CreateTableBtn.Text = "Create table";
            CreateTableBtn.UseVisualStyleBackColor = true;
            CreateTableBtn.Click += CreateTableBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(278, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(75, 23);
            CloseBtn.TabIndex = 6;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 450);
            Controls.Add(CloseBtn);
            Controls.Add(CreateTableBtn);
            Controls.Add(LogBox);
            Controls.Add(ReadBtn);
            Controls.Add(InsertBtn);
            Controls.Add(OpenBtn);
            Controls.Add(CreateBtn);
            Name = "MainForm";
            Text = "SQLite test 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateBtn;
        private Button OpenBtn;
        private Button InsertBtn;
        private Button ReadBtn;
        private TextBox LogBox;
        private Button CreateTableBtn;
        private Button CloseBtn;
    }
}
