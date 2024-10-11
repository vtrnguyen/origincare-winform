using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcare_Winform.UserContainer
{
    public partial class DetailClinic : Form
    {
        private string clinicID;
        private Database database = new Database();
        private ImageConverter imageConverter = new ImageConverter();

        public DetailClinic(string clinicID)
        {
            this.clinicID = clinicID;

            InitializeComponent();
        }

        private void DetailClinic_Load(object sender, EventArgs e)
        {
            this.loadClinicInfor();
            this.loadListDoctor();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            this.redirectToHomePage();
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            this.redirectToHomePage();
        }

        private void redirectToHomePage()
        {
            Form homePage = new User();

            homePage.Show();
            this.Hide();
        }

        private void loadClinicInfor()
        {
            DataTable clinicData = this.database.getClinicInfor(this.clinicID);

            if (clinicData == null || clinicData.Rows.Count == 0)
            {
                MessageBox.Show("Không tồn tại dữ liệu cơ sở khám bênh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow clinicInfor = clinicData.Rows[0];
            this.lbClinicName.Text = clinicInfor["clinicName"].ToString();
            this.lbClinicAddress.Text = clinicInfor["address"].ToString();
            this.lbClinicDescription.Text = clinicInfor["description"].ToString();
            this.lbClinicDescription.AutoSize = true;
            this.lbClinicDescription.MaximumSize = new Size(650, 0);

            byte[] imageData = (byte[])clinicInfor["image"];
            Image clinicImage = this.imageConverter.convertByteArrayToImage(imageData);
            this.picClinicImage.Image = clinicImage;
            this.picClinicImage.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void loadListDoctor()
        {
            DataTable doctorData = this.database.getInforDoctorForDetailClinic(this.clinicID);

            if (doctorData == null || doctorData.Rows.Count == 0)
            {
                this.lbDisplayNoDoctorFound.Visible = true;
                return;
            }

            int startX = 113;
            int startY = 79;
            int panelSpacing = 180;

            for (int i = 0; i < doctorData.Rows.Count; i++)
            {
                DataRow row = doctorData.Rows[i];

                Panel doctorPanel = new Panel
                {
                    Location = new Point(startX, startY + i * panelSpacing),
                    Size = new Size(800, 170),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Tag = row["doctorID"].ToString(),
                    Cursor = Cursors.Hand
                };

                PictureBox picDoctor = new PictureBox
                {
                    Size = new Size(120, 120),
                    Location = new Point(30, 25),
                    Image = this.imageConverter.convertByteArrayToImage((byte[])row["doctorImage"]),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                Label lbDoctorName = new Label
                {
                    Text = row["doctorName"].ToString(),
                    Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold),
                    ForeColor = SystemColors.Highlight,
                    Location = new Point(168, 25),
                    AutoSize = true
                };

                Label lbSpecialtyName = new Label
                {
                    Text = row["specialtyName"].ToString(),
                    Font = new Font("Microsoft Sans Serif", 9F),
                    Location = new Point(170, 50),
                    AutoSize = true
                };

                Label lbDescription = new Label
                {
                    Text = row["description"].ToString(),
                    Font = new Font("Microsoft Sans Serif", 9F),
                    Location = new Point(170, 70),
                    AutoSize = true
                };

                Label lbAddress = new Label
                {
                    Text = row["address"].ToString(),
                    Font = new Font("Microsoft Sans Serif", 9F),
                    ForeColor = SystemColors.GrayText,
                    Location = new Point(170, 135),
                    AutoSize = true
                };

                doctorPanel.Click += new EventHandler(pnlDoctorPanel_Click);
                picDoctor.Click += new EventHandler(pnlDoctorPanel_Click);
                lbDoctorName.Click += new EventHandler(pnlDoctorPanel_Click);
                lbSpecialtyName.Click += new EventHandler(pnlDoctorPanel_Click);
                lbDescription.Click += new EventHandler(pnlDoctorPanel_Click);
                lbAddress.Click += new EventHandler(pnlDoctorPanel_Click);

                doctorPanel.Controls.Add(picDoctor);
                doctorPanel.Controls.Add(lbDoctorName);
                doctorPanel.Controls.Add(lbSpecialtyName);
                doctorPanel.Controls.Add(lbDescription);
                doctorPanel.Controls.Add(lbAddress);

                this.pnlListDoctor.Controls.Add(doctorPanel);
            }
        }

        private void btnSeeAllDoctor_Click(object sender, EventArgs e)
        {
            Form listDoctor = new ListInformationContainer.ListDoctors();

            listDoctor.Show();
            this.Hide();
        }

        private void lbBackToListClinics_Click(object sender, EventArgs e)
        {
            Form listClinics = new ListInformationContainer.ListClinics();

            listClinics.Show();
            this.Hide();
        }

        private void pnlDoctorPanel_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            string doctorID = string.Empty;

            if (clickedControl != null && clickedControl.Tag != null)
            {
                doctorID = clickedControl.Tag.ToString();
            }
            else if (clickedControl.Parent != null && clickedControl.Parent.Tag != null)
            {
                doctorID = clickedControl.Parent.Tag.ToString();
            }

            if (doctorID != string.Empty)
            {
                Form detailDoctor = new UserContainer.DetailDoctor(doctorID);

                detailDoctor.Show();
                this.Hide();
            }
        }
    }
}
