using CafeeShopSample.Data.Context;
using CafeeShopSample.Data.Entities;
using CafeeShopSample.Extensions;
using CafeeShopSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeeShopSample
{
    public partial class Orders : Form
    {
        private List<Button> buttons;
        private readonly MyAppContext context;
        private List<OrdersViewModel> orders;
        public Orders()
        {
            InitializeComponent();
            context = new MyAppContext();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            CreateProductButtons();
            LoadCustomers();
            orders = new List<OrdersViewModel>();
            RefreshGrid();
            UpdateTotalValues();
        }

        private void CreateProductButtons()
        {
            buttons = new List<Button>();
            int x = 3, y = 3;

            var products = context.Products.ToList();

            if (products != null && products.Any())
                foreach (var item in products)
                    CreateButton(x, y, item);
        }

        private void CreateButton(int x, int y, Product item)
        {
            if (buttons.Any() && buttons != null)
            {
                x = buttons[buttons.Count - 1].Location.X + 83;
                y = buttons[buttons.Count - 1].Location.Y;
            }

            if (x + 83 > panel1.Location.X + panel1.Width)
            {
                x = 3;
                y += 83;
            }

            Button newButton = new Button();
            newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newButton.Location = new System.Drawing.Point(x, y);
            newButton.Name = "btnItem" + item.Id;
            newButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            newButton.Size = new System.Drawing.Size(80, 80);
            newButton.TabIndex = 29;
            newButton.Text = item.Caption;
            newButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new System.EventHandler(this.AddOrUpdateItem);
            buttons.Add(newButton);
            panel1.Controls.Add(newButton);
        }

        private void LoadCustomers()
        {
            var customers = context.Customers.Select(v => new AutoCompleteViewModel { Value = v.Id, Text = v.FullName }).ToList();
            cbCustomer.DataSource = new BindingSource(customers, null);
            cbCustomer.DisplayMember = "Text";
            cbCustomer.ValueMember = "Value";
        }

        private void AddOrUpdateItem(object sender, EventArgs e)
        {
            try
            {
                Button button = sender as Button;

                var productIdStr = button.Name.Replace("btnItem", "");

                int.TryParse(productIdStr, out int productId);

                var order = orders.Where(x => x.ProductId == productId).FirstOrDefault();

                AddOrder(productId, order);

                UpdateOrder(order);

                RefreshGrid();

                UpdateTotalValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshGrid()
        {
            dgvOrder.DataSource = orders.ToList();
        }

        private void UpdateTotalValues()
        {
            txtTotalPrices.Text = orders.Sum(x => x.Price).ToCurrencyFormat();
            txtOrdersCount.Text = orders.Sum(x => x.Count).ToString();
        }

        private void AddOrder(int productId, OrdersViewModel order)
        {
            if (order == null)
            {
                var product = context.Products.Where(x => x.Id == productId)
                    .Select(x => new { x.Caption, x.Price })
                    .FirstOrDefault();

                orders.Add(new OrdersViewModel
                {
                    ProductId = productId,
                    ProductCaption = product.Caption,
                    Price = product.Price,
                    Count = 1,
                });
            }
        }

        private void UpdateOrder(OrdersViewModel order)
        {
            if (order != null)
            {
                order.Count++;
                order.Price = order.Price * order.Count;
            }
        }

        private void dgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvOrder.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedId = dgvOrder[1, dgvOrder.CurrentRow.Index].Value.ToString();

            var id = int.Parse(selectedId);

            var order = orders.Where(x => x.ProductId == id).FirstOrDefault();

            orders.Remove(order);

            UpdateTotalValues();

            RefreshGrid();
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            try
            {
                InsertOrder();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertOrder()
        {
            var selectedItem = (AutoCompleteViewModel)cbCustomer.SelectedItem;

            StopIfCustomerIsntSelected(selectedItem);

            FinalizeOrder(selectedItem);

            MessageBox.Show("سفارش با موفقیت ثبت شد.");
        }

        private void FinalizeOrder(AutoCompleteViewModel selectedItem)
        {
            var finalOrders = orders.Select(x => new Order
            {
                ProductId = x.ProductId,
                CustomerId = selectedItem.Value,
                Count = x.Count
            }).ToList();

            context.Orders.AddRange(finalOrders);
            context.SaveChanges();
        }

        private void StopIfCustomerIsntSelected(AutoCompleteViewModel selectedItem)
        {
            if (selectedItem == null)
            {
                throw new Exception("جهت نهایی سازی سفارش لطفا مشتری را انتخاب نمایید.");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                InsertOrder();
                MessageBox.Show("لطفا پرینتر را به کامپیوتر وصل نمایید.", "توجه");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                InsertOrder();

                orders = new List<OrdersViewModel>();

                RefreshGrid();

                UpdateTotalValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
