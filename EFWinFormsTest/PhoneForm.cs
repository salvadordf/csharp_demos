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
    public partial class PhoneForm : Form
    {
        public string NumberValue { get { return numberTextBox.Text.Trim(); } set { numberTextBox.Text = value; } }
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
        public PhoneForm()
        {
            InitializeComponent();
        }

        private void EnableButtons()
        {
            okButton.Enabled = (numberTextBox.Text.Trim().Length > 0) &&
                               (descriptionTextBox.Text.Trim().Length > 0);
        }

        private void PhoneForm_Shown(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }
    }
}
