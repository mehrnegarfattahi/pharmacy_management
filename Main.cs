using CafeeShopSample.Data.Entities;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }
    }
}
