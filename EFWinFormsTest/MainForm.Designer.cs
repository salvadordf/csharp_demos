namespace EFWinFormsTest
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
            productsDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            addButton = new Button();
            removeButton = new Button();
            editButton = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            customersDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phonesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            editCustomerButton = new Button();
            removeCustomerButton = new Button();
            addCustomerButton = new Button();
            phonesDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            numberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneBindingSource = new BindingSource(components);
            editPhoneButton = new Button();
            removePhoneButton = new Button();
            addPhoneButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phonesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phoneBindingSource).BeginInit();
            SuspendLayout();
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToAddRows = false;
            productsDataGridView.AllowUserToDeleteRows = false;
            productsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsDataGridView.AutoGenerateColumns = false;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            productsDataGridView.DataSource = productBindingSource;
            productsDataGridView.Location = new Point(6, 35);
            productsDataGridView.MultiSelect = false;
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.ReadOnly = true;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.ShowEditingIcon = false;
            productsDataGridView.Size = new Size(756, 357);
            productsDataGridView.TabIndex = 8;
            productsDataGridView.SelectionChanged += dataGridView1_SelectionChanged;
            productsDataGridView.DoubleClick += dataGridView1_DoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // addButton
            // 
            addButton.Location = new Point(6, 6);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(87, 6);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 11;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(168, 6);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 12;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(productsDataGridView);
            tabPage1.Controls.Add(editButton);
            tabPage1.Controls.Add(addButton);
            tabPage1.Controls.Add(removeButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = " Products ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = " Customers ";
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.White;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Transparent;
            splitContainer1.Panel1.Controls.Add(customersDataGridView);
            splitContainer1.Panel1.Controls.Add(editCustomerButton);
            splitContainer1.Panel1.Controls.Add(removeCustomerButton);
            splitContainer1.Panel1.Controls.Add(addCustomerButton);
            splitContainer1.Panel1.Padding = new Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(phonesDataGridView);
            splitContainer1.Panel2.Controls.Add(editPhoneButton);
            splitContainer1.Panel2.Controls.Add(removePhoneButton);
            splitContainer1.Panel2.Controls.Add(addPhoneButton);
            splitContainer1.Size = new Size(768, 398);
            splitContainer1.SplitterDistance = 199;
            splitContainer1.TabIndex = 1;
            // 
            // customersDataGridView
            // 
            customersDataGridView.AllowUserToAddRows = false;
            customersDataGridView.AllowUserToDeleteRows = false;
            customersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customersDataGridView.AutoGenerateColumns = false;
            customersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, phonesDataGridViewTextBoxColumn });
            customersDataGridView.DataSource = customerBindingSource;
            customersDataGridView.Location = new Point(6, 35);
            customersDataGridView.Name = "customersDataGridView";
            customersDataGridView.Size = new Size(756, 158);
            customersDataGridView.TabIndex = 3;
            customersDataGridView.SelectionChanged += customersDataGridView_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phonesDataGridViewTextBoxColumn
            // 
            phonesDataGridViewTextBoxColumn.DataPropertyName = "Phones";
            phonesDataGridViewTextBoxColumn.HeaderText = "Phones";
            phonesDataGridViewTextBoxColumn.Name = "phonesDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Customer);
            // 
            // editCustomerButton
            // 
            editCustomerButton.Location = new Point(168, 6);
            editCustomerButton.Name = "editCustomerButton";
            editCustomerButton.Size = new Size(75, 23);
            editCustomerButton.TabIndex = 2;
            editCustomerButton.Text = "Edit";
            editCustomerButton.UseVisualStyleBackColor = true;
            // 
            // removeCustomerButton
            // 
            removeCustomerButton.Location = new Point(87, 6);
            removeCustomerButton.Name = "removeCustomerButton";
            removeCustomerButton.Size = new Size(75, 23);
            removeCustomerButton.TabIndex = 1;
            removeCustomerButton.Text = "Remove";
            removeCustomerButton.UseVisualStyleBackColor = true;
            removeCustomerButton.Click += removeCustomerButton_Click;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(6, 6);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(75, 23);
            addCustomerButton.TabIndex = 0;
            addCustomerButton.Text = "Add";
            addCustomerButton.UseVisualStyleBackColor = true;
            // 
            // phonesDataGridView
            // 
            phonesDataGridView.AllowUserToAddRows = false;
            phonesDataGridView.AllowUserToDeleteRows = false;
            phonesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            phonesDataGridView.AutoGenerateColumns = false;
            phonesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phonesDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, numberDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn1, customerIdDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn });
            phonesDataGridView.DataSource = phoneBindingSource;
            phonesDataGridView.Location = new Point(6, 36);
            phonesDataGridView.Name = "phonesDataGridView";
            phonesDataGridView.Size = new Size(756, 153);
            phonesDataGridView.TabIndex = 3;
            phonesDataGridView.SelectionChanged += phonesDataGridView_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "Number";
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // phoneBindingSource
            // 
            phoneBindingSource.DataSource = typeof(Models.Phone);
            // 
            // editPhoneButton
            // 
            editPhoneButton.Location = new Point(168, 7);
            editPhoneButton.Name = "editPhoneButton";
            editPhoneButton.Size = new Size(75, 23);
            editPhoneButton.TabIndex = 2;
            editPhoneButton.Text = "Edit";
            editPhoneButton.UseVisualStyleBackColor = true;
            // 
            // removePhoneButton
            // 
            removePhoneButton.Location = new Point(87, 7);
            removePhoneButton.Name = "removePhoneButton";
            removePhoneButton.Size = new Size(75, 23);
            removePhoneButton.TabIndex = 1;
            removePhoneButton.Text = "Remove";
            removePhoneButton.UseVisualStyleBackColor = true;
            removePhoneButton.Click += removePhoneButton_Click;
            // 
            // addPhoneButton
            // 
            addPhoneButton.Location = new Point(6, 7);
            addPhoneButton.Name = "addPhoneButton";
            addPhoneButton.Size = new Size(75, 23);
            addPhoneButton.TabIndex = 0;
            addPhoneButton.Text = "Add";
            addPhoneButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EF WinForms Test";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)phonesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)phoneBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView productsDataGridView;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private Button addButton;
        private Button removeButton;
        private Button editButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private SplitContainer splitContainer1;
        private DataGridView customersDataGridView;
        private Button editCustomerButton;
        private Button removeCustomerButton;
        private Button addCustomerButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phonesDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private DataGridView phonesDataGridView;
        private Button editPhoneButton;
        private Button removePhoneButton;
        private Button addPhoneButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private BindingSource phoneBindingSource;
    }
}
