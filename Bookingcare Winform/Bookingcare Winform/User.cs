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
    public partial class User : Form
    {
        private string userID;
        private string userLastName;
        private string userRoleID;

        public User()
        {
            InitializeComponent();
        }

        public User(string userID, string userLastName, string userRoleID)
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void picSearchIcon_Click(object sender, EventArgs e)
        {
            this.txtFastSearching.Text = "";
            this.txtFastSearching.ReadOnly = false;
        }

        private void btnSeeAllSpecialty_Click(object sender, EventArgs e)
        {
            Form listSpecialties = new ListInformationContainer.ListSpecialties();

            listSpecialties.Show();
            this.Hide();
        }

        private void btnSeeAllClinic_Click(object sender, EventArgs e)
        {
            Form listClinics = new ListInformationContainer.ListClinics();

            listClinics.Show();
            this.Hide();
        }

        private void btnSeeAllDoctor_Click(object sender, EventArgs e)
        {
            Form listDoctors = new ListInformationContainer.ListDoctors();

            listDoctors.Show();
            this.Hide();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            this.scrollToTop();
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            this.scrollToTop();
        }

        private void btnSeeAllContent_Click(object sender, EventArgs e)
        {
            this.scrollToTop();
        }

        private void scrollToTop()
        {
            pnlHomeContent.AutoScrollPosition = new Point(0, 0);
        }
    }
}
