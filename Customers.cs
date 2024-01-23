using CafeeShopSample.Data.Context;
using CafeeShopSample.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeeShopSample
{
    public partial class Customers : Form
    {
        private readonly MyAppContext context;
        public Customers()
        {
            InitializeComponent();
            context = new MyAppContext();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ClearInputs();
        }

        private void RefreshGrid()
        {
            dgvCustomers.DataSource = context.Customers.ToList();
        }

        private void ClearInputs()
        {
            txtId.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtSubscriptionCode.Text = Guid.NewGuid().ToString().Substring(0,8);

            txtFullName.Focus();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                StopIfFullNameIsNull(txtFullName.Text);

                StopIfSubscriptionCodeIsNull(txtSubscriptionCode.Text);

                int.TryParse(txtId.Text, out int id);

                StopIfCustomerIsDuplicated(id, txtFullName.Text, txtSubscriptionCode.Text);

                StopIfSubscriptionCodeIsExist(id, txtSubscriptionCode.Text);

                var entity = new Customer
                {
                    FullName = txtFullName.Text,
                    Address = txtAddress.Text,
                    SubscriptionCode = txtSubscriptionCode.Text,
                };
                context.Customers.Add(entity);
                context.SaveChanges();

                RefreshGrid();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StopIfSubscriptionCodeIsExist(int id, string code)
        {
            if (context.Customers.Any(x => x.Id != id && x.SubscriptionCode.Equals(code)))
            {
                throw new Exception("کد اشتراک تکراری می باشد.");
            }
        }

        private void StopIfCustomerIsDuplicated(int? id, string fullName, string code)
        {
            if (context.Customers.Any(x => x.Id != id && x.FullName.Equals(fullName) && x.SubscriptionCode.Equals(code)))
            {
                throw new Exception("این کاربر در سیستم موجود می باشد.");
            }
        }

        private void StopIfSubscriptionCodeIsNull(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                throw new Exception("لطفا کد اشتراک را وارد نمایید.");
            }
        }

        private void StopIfFullNameIsNull(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                throw new Exception("لطفا نام مشتری را وارد نمایید.");
            }
        }

        private void dgvCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvCustomers.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dgvCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedId = dgvCustomers[1, dgvCustomers.CurrentRow.Index].Value.ToString();

            var id = int.Parse(selectedId);

            var customer = context.Customers.Where(x => x.Id == id).FirstOrDefault();

            txtId.Text = customer.Id.ToString();
            txtFullName.Text = customer.FullName;
            txtSubscriptionCode.Text = customer.SubscriptionCode;
            txtAddress.Text = customer.Address;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                StopIfFullNameIsNull(txtFullName.Text);

                StopIfSubscriptionCodeIsNull(txtSubscriptionCode.Text);

                int.TryParse(txtId.Text, out int id);

                StopIfCustomerIsDuplicated(id, txtFullName.Text, txtSubscriptionCode.Text);

                StopIfSubscriptionCodeIsExist(id, txtSubscriptionCode.Text);

                var customer = context.Customers.Where(x => x.Id == id).FirstOrDefault();

                customer.FullName = txtFullName.Text;
                customer.SubscriptionCode = txtSubscriptionCode.Text;
                customer.Address = txtAddress.Text;

                context.SaveChanges();

                RefreshGrid();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedId = dgvCustomers[1, dgvCustomers.CurrentRow.Index].Value.ToString();

            var id = int.Parse(selectedId);

            var customer = context.Customers.Where(x => x.Id == id).FirstOrDefault();

            context.Customers.Remove(customer);
            context.SaveChanges();

            RefreshGrid();
        }
    }
}
