using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcare_Winform.AdminContainer
{
    public partial class ManageUser : Form
    {
        private Database database = new Database();

        // constructor
        public ManageUser()
        {
            InitializeComponent();
        }

        // ManageUser Load
        private void ManageUser_Load(object sender, EventArgs e)
        {
            this.dgvUsers.DataSource = this.database.getAllUser();
            this.pnlAddUserForm.Visible = false;
            this.pnlUpdateUserForm.Visible = false;
        }

        // handle button AddUser click
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.displayUserForms("OPEN_ADD_FORM");
        }

        // handle button confirm add new user click
        private void btnConfirmAddUser_Click(object sender, EventArgs e)
        {
            if (this.txtCreatedEmail.Text == "" || this.txtCreatedPassword.Text == "" ||
                this.txtCreatedAddress.Text == "" || this.txtCreatedPhoneNumber.Text == "" ||
                this.txtCreatedFirstName.Text == "" || this.txtCreatedLastName.Text == "" ||
                this.cboCreatedGender.SelectedValue.ToString() == "" ||
                this.cboCreatedRole.SelectedValue.ToString() == "" ||
                this.cboCreatedPosition.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Không được để trống tham số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                // initialize validator to check valid input
                Validator validator = new Validator();

                if (!validator.isValidEmail(this.txtCreatedEmail.Text))
                {
                    MessageBox.Show("Email không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!validator.isValidPhoneNumber(this.txtCreatedPhoneNumber.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (this.database.isExistedEmail(this.txtCreatedEmail.Text) > 0)
                {
                    MessageBox.Show("Email đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string createdEmail = this.txtCreatedEmail.Text;
                string createdPassword = this.txtCreatedPassword.Text;
                string createdFirstName = this.txtCreatedFirstName.Text;
                string createdLastName = this.txtCreatedLastName.Text;
                string createdAddress = this.txtCreatedAddress.Text;
                string createdPhoneNumber = this.txtCreatedPhoneNumber.Text;
                string createdGender = this.cboCreatedGender.SelectedValue.ToString();
                string createdRole = this.cboCreatedRole.SelectedValue.ToString();
                string createdPosition = this.cboCreatedPosition.SelectedValue.ToString();

                if (this.database.createUser(createdEmail, createdPassword, createdFirstName, createdLastName,
                    createdAddress, createdPhoneNumber, createdGender, createdRole, createdPosition))
                {
                    MessageBox.Show("Thêm người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ManageUser_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // handle button EditUser click
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            this.displayUserForms("OPEN_UPDATE_FORM");
        }

        // handle button confirm update user click
        private void btnConfirmUpdateUser_Click(object sender, EventArgs e)
        {
            if (this.txtUpdatedEmail.Text == "" || this.txtUpdatedPassword.Text == "" ||
                this.txtUpdatedFirstName.Text == "" || this.txtUpdatedLastName.Text == "" ||
                this.txtUpdatedAddress.Text == "" || this.txtUpdatedPhoneNumber.Text == "" ||
                this.cboUpdatedGender.SelectedValue.ToString() == "" ||
                this.cboUpdatedRole.SelectedValue.ToString() == "" ||
                this.cboUpdatedPosition.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                Validator validator = new Validator();

                if (!validator.isValidPhoneNumber(this.txtUpdatedPhoneNumber.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string updatedEmail = this.txtUpdatedEmail.Text;
                string updatedPassword = this.txtUpdatedPassword.Text;
                string updatedFirstName = this.txtUpdatedFirstName.Text;
                string updatedLastName = this.txtUpdatedLastName.Text;
                string updatedAddress = this.txtUpdatedAddress.Text;
                string updatedPhoneNumber = this.txtUpdatedPhoneNumber.Text;
                string updatedGender = this.cboUpdatedGender.SelectedValue.ToString();
                string updatedRole = this.cboUpdatedRole.SelectedValue.ToString();
                string updatedPosition = this.cboUpdatedPosition.SelectedValue.ToString();

                if (this.database.updateUser(updatedEmail, updatedPassword, updatedFirstName, updatedLastName, 
                    updatedAddress, updatedPhoneNumber, updatedGender, updatedRole, updatedPosition))
                {
                    MessageBox.Show("Cập nhật người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.ManageUser_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật người dùng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // handle button DeleteUser click
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // get current row, current userID, userEmail to delete
            int currentRow = this.dgvUsers.CurrentCell.RowIndex;
            string deleteUserID = this.dgvUsers.Rows[currentRow].Cells[0].Value.ToString();
            string deleteUserEmail = this.dgvUsers.Rows[currentRow].Cells[1].Value.ToString();

            // popup to confirm deleting
            DialogResult confirmResult = 
                MessageBox.Show($"Bạn có chắc chắn muốn xóa người dùng {deleteUserEmail} không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (this.database.deleteUser(deleteUserID))
                {
                    MessageBox.Show($"Đã xóa thành công người dùng {deleteUserEmail}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.dgvUsers.DataSource = this.database.getAllUser();
                }
                else
                {
                    MessageBox.Show("Xóa người dùng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // handle button CloseAddUserForm click
        private void btnCloseAddUserForm_Click(object sender, EventArgs e)
        {
            this.displayUserForms("CLOSE_ADD_FORM");
        }

        // handle button UpdateUserForm click
        private void btnCloseUpdateUserForm_Click(object sender, EventArgs e)
        {
            this.displayUserForms("CLOSE_UPDATE_FORM");
        }

        // handle display AddUserForm
        private void displayUserForms(string formType)
        {

            if (formType == "OPEN_ADD_FORM")
            {
                this.loadCboData("ADD");
                this.pnlAddUserForm.Visible = !this.pnlAddUserForm.Visible;
                this.txtCreatedEmail.Focus();

                return;
            }

            if (formType == "CLOSE_ADD_FORM")
            {
                this.pnlAddUserForm.Visible = false;
                this.txtCreatedEmail.Text = "";
                this.txtCreatedPassword.Text = "";
                this.txtCreatedFirstName.Text = "";
                this.txtCreatedLastName.Text = "";
                this.txtCreatedAddress.Text = "";
                this.txtCreatedPhoneNumber.Text = "";

                return;
            }

            if (formType == "OPEN_UPDATE_FORM")
            {
                int currentRow = this.dgvUsers.CurrentCell.RowIndex;
                string updateUserID = this.dgvUsers.Rows[currentRow].Cells[0].Value.ToString();

                DataTable userInfor = this.database.getUser(updateUserID);

                if (userInfor != null && userInfor.Rows.Count != 0)
                {
                    DataRow userRow = userInfor.Rows[0];

                    this.txtUpdatedEmail.Text = userRow["email"].ToString();
                    this.txtUpdatedPassword.Text = userRow["password"].ToString();
                    this.txtUpdatedFirstName.Text = userRow["firstName"].ToString();
                    this.txtUpdatedLastName.Text = userRow["lastName"].ToString();
                    this.txtUpdatedAddress.Text = userRow["address"].ToString();
                    this.txtUpdatedPhoneNumber.Text = userRow["phoneNumber"].ToString();
                }

                this.loadCboData("UPDATE");
                this.pnlUpdateUserForm.Visible = !this.pnlUpdateUserForm.Visible;
                this.txtUpdatedEmail.Enabled = false;
                this.txtUpdatedPassword.Focus();

                return;
            }

            if (formType == "CLOSE_UPDATE_FORM")
            {
                this.pnlUpdateUserForm.Visible = false;
                this.txtCreatedEmail.Text = "";
                this.txtCreatedPassword.Text = "";
                this.txtCreatedFirstName.Text = "";
                this.txtCreatedLastName.Text = "";
                this.txtUpdatedAddress.Text = "";
                this.txtUpdatedPhoneNumber.Text = "";

                return;
            }
        }

        // handle load data for Combo Box
        private void loadCboData(string formType)
        {
            // assign data to Cbo Box after getting data from database
            // display member is codeValue
            // real value member to save in database is keyMap

            if (formType == "ADD")
            {
                this.cboCreatedGender.DataSource = this.database.getComboBoxData("GENDER");
                this.cboCreatedGender.DisplayMember = "codeValue";
                this.cboCreatedGender.ValueMember = "keyMap";

                this.cboCreatedRole.DataSource = this.database.getComboBoxData("ROLE");
                this.cboCreatedRole.DisplayMember = "codeValue";
                this.cboCreatedRole.ValueMember = "keyMap";

                this.cboCreatedPosition.DataSource = this.database.getComboBoxData("POSITION");
                this.cboCreatedPosition.DisplayMember = "codeValue";
                this.cboCreatedPosition.ValueMember = "keyMap";

                return;
            }

            if (formType == "UPDATE")
            {
                this.cboUpdatedGender.DataSource = this.database.getComboBoxData("GENDER");
                this.cboUpdatedGender.DisplayMember = "codeValue";
                this.cboUpdatedGender.ValueMember = "keyMap";

                this.cboUpdatedRole.DataSource = this.database.getComboBoxData("ROLE");
                this.cboUpdatedRole.DisplayMember = "codeValue";
                this.cboUpdatedRole.ValueMember = "keyMap";

                this.cboUpdatedPosition.DataSource = this.database.getComboBoxData("POSITION");
                this.cboUpdatedPosition.DisplayMember = "codeValue";
                this.cboUpdatedPosition.ValueMember = "keyMap";

                return;
            }
        }
    }
}
