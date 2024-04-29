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
                    Product product = (Product)productsDataGridView.CurrentRow.DataBoundItem;
                    return product.Id; 
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
                    Customer customer = (Customer)customersDataGridView.CurrentRow.DataBoundItem;
                    return customer.Id;
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
                    Phone phone = (Phone)phonesDataGridView.CurrentRow.DataBoundItem;
                    return phone.Id;
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
            _context.Customers.Load();

            this.productBindingSource.DataSource = _context.Products.Local.ToBindingList();
            this.customerBindingSource1.DataSource = _context.Customers.Local.ToBindingList();
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

        private void EnableButtons()
        {
            removeButton.Enabled = SelectedProductId > 0;
            editButton.Enabled = removeButton.Enabled;

            removeCustomerButton.Enabled = SelectedCustomerId > 0;
            editCustomerButton.Enabled = removeCustomerButton.Enabled;
            addPhoneButton.Enabled = removeCustomerButton.Enabled;

            removePhoneButton.Enabled = addPhoneButton.Enabled && (SelectedPhoneId > 0);
            editPhoneButton.Enabled = removePhoneButton.Enabled;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void customersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            EnableButtons();
            if (_context != null)
            {
                Customer customer = (Customer)customersDataGridView.CurrentRow.DataBoundItem;

                if (customer != null)
                {
                    _context.Entry(customer).Collection(e => e.Phones).Load();
                }
            }
        }

        private void phonesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            EnableButtons();
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

        private void EditSelectedCustomer()
        {
            Customer? customer = _context?.Customers.Find(SelectedCustomerId);
            if (customer != null)
            {
                using CustomerForm editForm = new CustomerForm();
                editForm.FirstNameValue = customer.FirstName;
                editForm.LastNameValue = customer.LastName;
                editForm.AddressValue = customer.Address;

                DialogResult resultValue = editForm.ShowDialog();

                if (resultValue == DialogResult.OK)
                {
                    customer.FirstName = editForm.FirstNameValue;
                    customer.LastName = editForm.LastNameValue;
                    customer.Address = editForm.AddressValue;
                    _context?.SaveChanges();
                    customersDataGridView.Refresh();
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            using CustomerForm addForm = new CustomerForm();
            DialogResult resultValue = addForm.ShowDialog();
            if (resultValue == DialogResult.OK)
            {
                Customer customer = new Customer()
                {
                    FirstName = addForm.FirstNameValue,
                    LastName = addForm.LastNameValue,
                    Address = addForm.AddressValue
                };
                _context?.Customers.Add(customer);
                _context?.SaveChanges();
                customersDataGridView.Refresh();
                phonesDataGridView.Refresh();
            }
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            EditSelectedCustomer();
        }

        private void customersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            EditSelectedCustomer();
        }

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            using PhoneForm addForm = new PhoneForm();
            DialogResult resultValue = addForm.ShowDialog();
            if (resultValue == DialogResult.OK)
            {
                Phone phone = new Phone()
                {
                    Number = addForm.NumberValue,
                    Description = addForm.DescriptionValue,
                    CustomerId = SelectedCustomerId
                };
                _context?.Phones.Add(phone);
                _context?.SaveChanges();
                phonesDataGridView.Refresh();
            }
        }

        private void EditSelectedPhone()
        {
            Phone? phone = _context?.Phones.Find(SelectedPhoneId);
            if (phone != null)
            {
                using PhoneForm editForm = new PhoneForm();
                editForm.NumberValue = phone.Number;
                editForm.DescriptionValue = phone.Description;

                DialogResult resultValue = editForm.ShowDialog();

                if (resultValue == DialogResult.OK)
                {
                    phone.Number = editForm.NumberValue;
                    phone.Description = editForm.DescriptionValue;
                    _context?.SaveChanges();
                    phonesDataGridView.Refresh();
                }
            }
        }

        private void editPhoneButton_Click(object sender, EventArgs e)
        {
            EditSelectedPhone();
        }

        private void phonesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            EditSelectedPhone();
        }
    }
}
