using CafeeShopSample.Data.Context;
using CafeeShopSample.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeeShopSample
{
    public partial class Users : Form
    {
        private readonly MyAppContext context;
        public Users()
        {
            InitializeComponent();
            context = new MyAppContext();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedId = dgvUsers[1, dgvUsers.CurrentRow.Index].Value.ToString();

            var id = int.Parse(selectedId);

            var user = context.Users.Where(x => x.Id == id).FirstOrDefault();

            context.Users.Remove(user);
            context.SaveChanges();

            RefreshGrid();
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvUsers.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void RefreshGrid()
        {
            dgvUsers.DataSource = context.Users.ToList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                StopIfUsernameIsNull(txtUsername.Text);
                StopIfPasswordIsNull(txtPassword.Text);
                StopIfConfirmPasswordIsNull(txtConfirmPassword.Text);
                StopIfPasswordAndConfirmPasswordIsNotMatched(txtPassword.Text, txtConfirmPassword.Text);
                StopIfUserIsDuplicated(null, txtUsername.Text);

                context.Users.Add(new User
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                });
                context.SaveChanges();

                ClearInputs();

                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearInputs()
        {
            txtId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtUsername.Focus();
        }

        private void StopIfUserIsDuplicated(int? id, string username)
        {
            if (context.Users.Any(x => x.Id != id && x.Username.ToLower().Equals(username)))
                throw new Exception("این نام کاربری در سیستم موجود می باشد.\nلطفا نام کاربری دیگری انتخاب نمایید.");
        }

        private void StopIfPasswordIsNull(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new Exception("وارد کردن گذرواژه الزامی می باشد.");
        }

        private void StopIfUsernameIsNull(string username)
        {
            if (string.IsNullOrEmpty(username))
                throw new Exception("وارد کردن نام کاربری الزامی می باشد.");
        }

        private void StopIfPasswordAndConfirmPasswordIsNotMatched(string password, string confirmPassword)
        {
            if (!password.Equals(confirmPassword))
                throw new Exception("گذرواژه و تکرار آن باهم مطابقت ندارد.");
        }

        private void StopIfConfirmPasswordIsNull(string confirmPassword)
        {
            if (string.IsNullOrEmpty(confirmPassword))
                throw new Exception("وارد کردن فیلد تکرار گذرواژه الزامی می باشد.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                StopIfUsernameIsNull(txtUsername.Text);
                StopIfPasswordIsNull(txtPassword.Text);
                StopIfConfirmPasswordIsNull(txtConfirmPassword.Text);
                StopIfPasswordAndConfirmPasswordIsNotMatched(txtPassword.Text, txtConfirmPassword.Text);

                int.TryParse(txtId.Text, out int id);

                var user = context.Users.Where(x => x.Id == id).FirstOrDefault();

                StopIfUserNotExist(user);
                StopIfUserIsDuplicated(user.Id, txtUsername.Text);

                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;

                context.SaveChanges();

                ClearInputs();

                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StopIfUserNotExist(User user)
        {
            if (user == null)
                throw new Exception("کاربر موجود نمی باشد.\nلطفا مجددا تلاش کنید.");
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string selectedId = dgvUsers[1, dgvUsers.CurrentRow.Index].Value.ToString();

                int.TryParse(selectedId, out int id);

                var user = context.Users.Where(x => x.Id == id).FirstOrDefault();

                StopIfUserNotExist(user);

                txtId.Text = user.Id.ToString();
                txtUsername.Text = user.Username;
                txtPassword.Text = user.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
