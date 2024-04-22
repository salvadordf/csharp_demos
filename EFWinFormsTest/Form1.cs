using EFWinFormsTest.Data;
using EFWinFormsTest.Models;
using System.Linq.Expressions;

namespace EFWinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CustomContext context = new CustomContext())
            {
                Product product = new Product()
                {
                    Name = nameTextBox.Text,
                    Description = descriptionTextBox.Text,
                    Price = Convert.ToDecimal(priceTextBox.Text)
                };
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
