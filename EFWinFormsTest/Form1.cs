using EFWinFormsTest.Data;
using EFWinFormsTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EFWinFormsTest
{
    public partial class MainForm : Form
    {
        private CustomContext? _context;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = nameTextBox.Text,
                Description = descriptionTextBox.Text,
                Price = priceNumericUpDown.Value
            };
            _context?.Products.Add(product);
            _context?.SaveChanges();
            dataGridView1.Refresh();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _context = new CustomContext();
            _context.Products.Load();
            this.productBindingSource.DataSource = _context.Products.Local.ToBindingList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context?.Dispose();
            _context = null;
        }
    }
}
