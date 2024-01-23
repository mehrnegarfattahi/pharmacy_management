using CafeeShopSample.Data.Context;
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
    public partial class Login : Form
    {
        private readonly MyAppContext context;

        public Login()
        {
            InitializeComponent();
            context = new MyAppContext();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EnterToApp(txtUsername.Text, txtPassword.Text);
        }

        private void EnterToApp(string username, string password)
        {
            try
            {
                StopIfUsernameIsNullOrEmpty(username);

                StopIfPasswordIsNullOrEmpty(password);

                var user = FindUser(username, password);

                StopIfUserNotFound(user);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StopIfUsernameIsNullOrEmpty(string username)
        {
            if (string.IsNullOrEmpty(username))
                throw new Exception("وارد کردن نام کاربری الزامی می باشد.");
        }

        private void StopIfPasswordIsNullOrEmpty(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new Exception("وارد کردن گذرواژه الزامی می باشد.");
        }

        private void StopIfUserNotFound(User user)
        {
            if (user == null)
                throw new Exception("کاربر یافت نشد!\nلطفا با پشتیبانی تماس بگیرید.");
        }

        private User FindUser(string username, string password)
        {
            return context.Users
                .Where(x => x.Username.ToLower().Equals(username.ToLower()))
                .Where(x => x.Password.ToLower().Equals(password.ToLower()))
                .FirstOrDefault();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            EnterToApp(txtUsername.Text, txtPassword.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
