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
    public partial class Doctor : Form
    {
        private string doctorID;
        private string doctorLastName;
        private string doctorRoleID;

        public Doctor(string doctorID, string doctorLastName, string doctorRoleID)
        {
            this.doctorID = doctorID;
            this.doctorLastName = doctorLastName;
            this.doctorRoleID = doctorRoleID;

            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            this.lbDisplayDoctorName.Text = $"Xin chào, Bác sĩ {this.doctorLastName}";
            this.btnManageSchedule_Click(sender, e);
        }

        private void btnManageSchedule_Click(object sender, EventArgs e)
        {
            this.pnlContentContainer.Controls.Clear();

            DoctorContainer.ManageSchedule manageScheduleForm = new DoctorContainer.ManageSchedule(this.doctorID);

            manageScheduleForm.TopLevel = false;
            manageScheduleForm.FormBorderStyle = FormBorderStyle.None;
            manageScheduleForm.Dock = DockStyle.Fill;

            pnlContentContainer.Controls.Add(manageScheduleForm);

            manageScheduleForm.Show();
        }

        private void picDoctorAvatar_Click(object sender, EventArgs e)
        {
            Form login = new Login();

            login.Show();
            this.Hide();
        }
    }
}
