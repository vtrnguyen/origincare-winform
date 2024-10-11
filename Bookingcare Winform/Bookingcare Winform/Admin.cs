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
    public partial class Admin : Form
    {
        private string adminID;
        private string adminLastName;
        private string adminRoleID;

        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string adminID, string adminLastName, string adminRoleID)
        {
            this.adminID = adminID;
            this.adminLastName = adminLastName;
            this.adminRoleID = adminRoleID;

            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.lbDisplayAdminName.Text = $"Xin chào, Quản trị {this.adminLastName}";
            this.btnManageUser_Click (sender, e);
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            this.pnlContentContainer.Controls.Clear();

            AdminContainer.ManageUser manageUserForm = new AdminContainer.ManageUser();

            manageUserForm.TopLevel = false;
            manageUserForm.FormBorderStyle = FormBorderStyle.None;
            manageUserForm.Dock = DockStyle.Fill;

            pnlContentContainer.Controls.Add(manageUserForm);

            manageUserForm.Show();
        }

        private void btnManageBooking_Click(object sender, EventArgs e)
        {
            this.pnlContentContainer.Controls.Clear();

            AdminContainer.ManageBooking manageBookingScheduleForm = new AdminContainer.ManageBooking();

            manageBookingScheduleForm.TopLevel = false;
            manageBookingScheduleForm.FormBorderStyle = FormBorderStyle.None;
            manageBookingScheduleForm.Dock = DockStyle.Fill;

            pnlContentContainer.Controls.Add(manageBookingScheduleForm);

            manageBookingScheduleForm.Show();
        }

        private void btnManageClinic_Click(object sender, EventArgs e)
        {
            this.pnlContentContainer.Controls.Clear();

            AdminContainer.ManageClinic manageClinicForm = new AdminContainer.ManageClinic();

            manageClinicForm.TopLevel = false;
            manageClinicForm.FormBorderStyle = FormBorderStyle.None;
            manageClinicForm.Dock = DockStyle.Fill;

            pnlContentContainer.Controls.Add(manageClinicForm);

            manageClinicForm.Show();
        }

        private void btnManageSpecialty_Click(object sender, EventArgs e)
        {
            this.pnlContentContainer.Controls.Clear();

            AdminContainer.ManageSpecialty manageSpecialtyForm = new AdminContainer.ManageSpecialty();

            manageSpecialtyForm.TopLevel = false;
            manageSpecialtyForm.FormBorderStyle = FormBorderStyle.None;
            manageSpecialtyForm.Dock = DockStyle.Fill;

            pnlContentContainer.Controls.Add(manageSpecialtyForm);

            manageSpecialtyForm.Show();
        }

        private void btnManageDoctor_Click(object sender, EventArgs e)
        {
            this.pnlContentContainer.Controls.Clear();

            AdminContainer.ManageDoctor manageDoctorForm = new AdminContainer.ManageDoctor();

            manageDoctorForm.TopLevel = false;
            manageDoctorForm.FormBorderStyle = FormBorderStyle.None;
            manageDoctorForm.Dock = DockStyle.Fill;

            pnlContentContainer.Controls.Add(manageDoctorForm);

            manageDoctorForm.Show();
        }

        private void picAdminAvatar_Click(object sender, EventArgs e)
        {
            Form login = new Login();

            login.Show();
            this.Hide();
        }
    }
}
