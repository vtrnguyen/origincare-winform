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
    public partial class DetailSpecialty : Form
    {
        private string specialtyID;
        private Database database = new Database();
        private ImageConverter imageConverter = new ImageConverter();

        public DetailSpecialty(string specialtyID)
        {
            this.specialtyID = specialtyID;

            InitializeComponent();
        }

        private void DetailSpecialty_Load(object sender, EventArgs e)
        {
            this.getSpecialtyInfor();
            this.loadProvinceComboBox();
            this.cboListProvince_SelectedIndexChanged(sender, e);
        }

        private void getSpecialtyInfor()
        {
            DataTable specialtyData = this.database.getSpecialtyInfor(this.specialtyID);

            if (specialtyData == null || specialtyData.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu chuyên khoa không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow specialtyInfor = specialtyData.Rows[0];
            this.lbSpecialtyName.Text = specialtyInfor["specialtyName"].ToString();
            this.lbSpecialtyDescription.Text = specialtyInfor["description"].ToString();

            byte[] imageData = (byte[])specialtyInfor["image"];
            Image specialtyImage = this.imageConverter.convertByteArrayToImage(imageData);
            Image transparentImage = this.imageConverter.makeImageTransparent(specialtyImage, 0.1f);

            this.pnlSpecialtyInfor.BackgroundImage = transparentImage;
            this.pnlSpecialtyInfor.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void loadProvinceComboBox()
        {
            DataTable provinceData = this.database.getComboBoxData("PROVINCE");

            if (provinceData == null || provinceData.Rows.Count == 0)
            {
                MessageBox.Show("Không tồn tại bảng ghi tỉnh thành nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow allRow = provinceData.NewRow();
            allRow["keyMap"] = "ALL";
            allRow["codeValue"] = "Tất cả";

            provinceData.Rows.InsertAt(allRow, 0);

            this.cboListProvince.DataSource = provinceData;
            this.cboListProvince.DisplayMember = "codeValue";
            this.cboListProvince.ValueMember = "keyMap";
        }

        private void cboListProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            string provinceID = this.cboListProvince.SelectedValue.ToString();

            DataTable doctorInfo = this.database.getInforDoctorForDetailSpecialty(this.specialtyID, provinceID);

            if (doctorInfo == null || doctorInfo.Rows.Count == 0)
            {
                var comboBoxProvince = this.cboListProvince;
                var labelDisplayZeroDoctor = this.lbDisplayZeroDoctor;

                foreach (Control control in this.pnlListDoctor.Controls.Cast<Control>().ToList())
                {
                    if (control != comboBoxProvince && control != labelDisplayZeroDoctor)
                    {
                        this.pnlListDoctor.Controls.Remove(control);
                    }
                }

                this.lbDisplayZeroDoctor.Visible = true;

                return;
            }

            this.lbDisplayZeroDoctor.Visible = false;
            this.loadListDoctor(doctorInfo);
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

        private void loadListDoctor(DataTable doctorInfo)
        {
            var comboBoxProvince = this.cboListProvince;

            foreach (Control control in this.pnlListDoctor.Controls.OfType<Control>().ToArray())
            {
                if (control != comboBoxProvince)
                {
                    this.pnlListDoctor.Controls.Remove(control);
                }
            }

            foreach (DataRow row in doctorInfo.Rows)
            {
                Panel doctorPanel = new Panel
                {
                    Size = new Size(800, 130),
                    Location = new Point(113, 77 + (154 * Array.IndexOf(doctorInfo.Rows.Cast<DataRow>().ToArray(), row))),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = row["doctorID"].ToString()
                };

                PictureBox picDoctor = new PictureBox
                {
                    Size = new Size(100, 100),
                    Location = new Point(30, 15),
                    Image = this.imageConverter.convertByteArrayToImage((byte[])row["doctorImage"]),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                Label doctorName = new Label
                {
                    Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold),
                    Width = 600,
                    Location = new Point(150, 14),
                    Text = row["positionName"].ToString() + " | " + row["doctorName"].ToString()
                };

                Label description = new Label
                {
                    Font = new Font("Microsoft Sans Serif", 7.8F),
                    Width = 700,
                    Height = 60,
                    Location = new Point(150, 35),
                    Text = row["description"].ToString()
                };

                Label address = new Label
                {
                    Font = new Font("Microsoft Sans Serif", 7.8F),
                    Location = new Point(150, 95),
                    Text = row["address"].ToString()
                };

                doctorPanel.Click += new EventHandler(pnlDoctorPanel_Click);
                picDoctor.Click += pnlDoctorPanel_Click;
                doctorName.Click += pnlDoctorPanel_Click;
                description.Click += pnlDoctorPanel_Click;
                address.Click += pnlDoctorPanel_Click;

                doctorPanel.Controls.Add(picDoctor);
                doctorPanel.Controls.Add(doctorName);
                doctorPanel.Controls.Add(description);
                doctorPanel.Controls.Add(address);
                doctorPanel.Cursor = Cursors.Hand;

                this.pnlListDoctor.Controls.Add(doctorPanel);
            }
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

        private void lbBackToListSpecialties_Click(object sender, EventArgs e)
        {
            Form listSpecialties = new ListInformationContainer.ListSpecialties();

            listSpecialties.Show();
            this.Hide();
        }
    }
}
