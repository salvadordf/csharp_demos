using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFWinFormsTest
{
    public partial class ProductForm : Form
    {
        public string NameValue { get { return nameTextBox.Text.Trim(); } set { nameTextBox.Text = value; } }
        public string DescriptionValue
        {
            get { return descriptionTextBox.Text.Trim(); }
            set
            {
                if (value != null)
                {
                    descriptionTextBox.Text = value;
                }
            }
        }
        public decimal PriceValue { get { return priceNumericUpDown.Value; } set { priceNumericUpDown.Value = value; } }

        public ProductForm()
        {
            InitializeComponent();
        }

        private void EnableButtons()
        {
            okButton.Enabled = (nameTextBox.Text.Trim().Length > 0) &&
                               (descriptionTextBox.Text.Trim().Length > 0);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void ProductForm_Shown(object sender, EventArgs e)
        {
            EnableButtons();
        }
    }
}
