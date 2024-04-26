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
    public partial class CustomerForm : Form
    {
        public string FirstNameValue { get { return firstNameTextBox.Text.Trim(); } set { firstNameTextBox.Text = value; } }
        public string LastNameValue { get { return lastNameTextBox.Text.Trim(); } set { lastNameTextBox.Text = value; } }
        public string AddressValue
        {
            get { return addressTextBox.Text.Trim(); }
            set
            {
                if (value != null)
                {
                    addressTextBox.Text = value;
                }
            }
        }
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void EnableButtons()
        {
            okButton.Enabled = (firstNameTextBox.Text.Trim().Length > 0) &&
                               (lastNameTextBox.Text.Trim().Length > 0);
        }

        private void CustomerForm_Shown(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }
    }
}
