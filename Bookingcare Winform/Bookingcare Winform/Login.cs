using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcare_Winform
{
    public partial class Login : Form
    {
        Database connection = new Database();
        private string userID;
        private string userLastName;
        private string roleID;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txtUserNameLogin.KeyDown += new KeyEventHandler(this.handleEnterKeyDown);
            this.txtPasswordLogin.KeyDown += new KeyEventHandler(this.handleEnterKeyDown);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUserNameLogin.Text == "" || this.txtPasswordLogin.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                string userName = this.txtUserNameLogin.Text;
                string password = this.txtPasswordLogin.Text;

                (this.userID, this.userLastName, this.roleID) = this.connection.handleLogin(userName, password);

                if (this.userID != null && this.roleID != null)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.redirect(this.userID, this.userLastName, this.roleID);
                } else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void handleEnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void redirect(string userID, string userLastName, string roleID)
        {
            Form newForm = null;

            if (userID != null && roleID != null)
            {
                if (roleID == "R0")
                {
                    newForm = new Admin(userID, userLastName, roleID);
                }
                else if (roleID == "R1")
                {
                    newForm = new Doctor(userID, userLastName, roleID);
                }
                else if (roleID == "R2")
                {
                    newForm = new User(userID, userLastName, roleID);
                }

                if (newForm != null)
                {
                    newForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
