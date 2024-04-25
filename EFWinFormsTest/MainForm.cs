using EFWinFormsTest.Data;
using EFWinFormsTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EFWinFormsTest
{
    public partial class MainForm : Form
    {
        private CustomContext? _context;
        private Int32 SelectedProductId
        {
            get
            {
                if (productsDataGridView.SelectedRows.Count > 0)
                {
                    return Convert.ToInt32(productsDataGridView.CurrentRow.Cells[0].Value);
                }
                return 0;
            }
        }
        private Int32 SelectedCustomerId
        {
            get
            {
                if (customersDataGridView.SelectedRows.Count > 0)
                {
                    return Convert.ToInt32(customersDataGridView.CurrentRow.Cells[0].Value);
                }
                return 0;
            }
        }
        private Int32 SelectedPhoneId
        {
            get
            {
                if (phonesDataGridView.SelectedRows.Count > 0)
                {
                    return Convert.ToInt32(phonesDataGridView.CurrentRow.Cells[0].Value);
                }
                return 0;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _context = new CustomContext();
            _context.Products.Load();
            this.productBindingSource.DataSource = _context.Products.Local.ToBindingList();
            this.customerBindingSource.DataSource = _context.Customers.Local.ToBindingList();
            this.phoneBindingSource.DataSource = _context.Phones.Local.ToBindingList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context?.Dispose();
            _context = null;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using ProductForm addForm = new ProductForm();
            DialogResult resultValue = addForm.ShowDialog();
            if (resultValue == DialogResult.OK)
            {
                Product product = new Product()
                {
                    Name = addForm.NameValue,
                    Description = addForm.DescriptionValue,
                    Price = addForm.PriceValue
                };
                _context?.Products.Add(product);
                _context?.SaveChanges();
                productsDataGridView.Refresh();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            removeButton.Enabled = SelectedProductId > 0;
            editButton.Enabled = removeButton.Enabled;
        }

        private void customersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            removeCustomerButton.Enabled = SelectedCustomerId > 0;
            editCustomerButton.Enabled = removeCustomerButton.Enabled;
        }

        private void phonesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            removePhoneButton.Enabled = SelectedPhoneId > 0;
            editPhoneButton.Enabled = removePhoneButton.Enabled;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove that product?", "Product removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Product? product = _context?.Products.Find(SelectedProductId);
                if (product != null)
                {
                    _context?.Products.Remove(product);
                    _context?.SaveChanges();
                    productsDataGridView.Refresh();
                }
            }
        }

        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove that customer?", "Customer removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Customer? customer = _context?.Customers.Find(SelectedCustomerId);
                if (customer != null)
                {
                    _context?.Customers.Remove(customer);
                    _context?.SaveChanges();
                    customersDataGridView.Refresh();
                    phonesDataGridView.Refresh();
                }
            }
        }

        private void removePhoneButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove that phone?", "Phone removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Phone? phone = _context?.Phones.Find(SelectedPhoneId);
                if (phone != null)
                {
                    _context?.Phones.Remove(phone);
                    _context?.SaveChanges();
                    phonesDataGridView.Refresh();
                }
            }
        }

        private void EditSelectedProduct()
        {
            Product? product = _context?.Products.Find(SelectedProductId);
            if (product != null)
            {
                using ProductForm editForm = new ProductForm();
                editForm.NameValue = product.Name;
                editForm.DescriptionValue = product.Description;
                editForm.PriceValue = product.Price;
                DialogResult resultValue = editForm.ShowDialog();
                if (resultValue == DialogResult.OK)
                {
                    product.Name = editForm.NameValue;
                    product.Description = editForm.DescriptionValue;
                    product.Price = editForm.PriceValue;
                    _context?.SaveChanges();
                    productsDataGridView.Refresh();
                }
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            EditSelectedProduct();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            EditSelectedProduct();
        }
    }
}
