using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcare_Winform.ListInformationContainer
{
    public partial class ListDoctors : Form
    {
        private Database database = new Database();
        private ImageConverter imageConverter = new ImageConverter();

        public ListDoctors()
        {
            InitializeComponent();
            this.renderDoctorPanels();
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

        public void renderDoctorPanels()
        {
            DataTable doctorTable = this.database.getAllDoctorInfor();

            if (doctorTable == null || doctorTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu bác sĩ!");
                return;
            }

            int panelHeight = 100;
            int panelWidth = 850;
            int panelMargin = 10;

            int startX = 90;
            int startY = 70;

            for (int i = 0; i < doctorTable.Rows.Count; i++)
            {
                DataRow row = doctorTable.Rows[i];

                Panel doctorPanel = new Panel
                {
                    Width = panelWidth,
                    Height = panelHeight,
                    Location = new Point(startX, startY + (panelHeight + panelMargin) * i),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Tag = row["doctorID"].ToString(),
                };

                PictureBox picDoctorImage = new PictureBox
                {
                    Size = new Size(75, 75),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                if (row["image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])row["image"];

                    picDoctorImage.Image = this.imageConverter.convertByteArrayToImage(imageData);
                }
                else
                {
                    picDoctorImage.Image = Properties.Resources.doctor;
                }

                Label lblDoctorName = new Label
                {
                    Text = row["positionName"].ToString() + ": " + row["fullName"].ToString(),
                    Location = new Point(120, 10),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold)
                };

                Label lblSpecialty = new Label
                {
                    Text = "Chuyên khoa: " + row["specialtyName"].ToString(),
                    Location = new Point(120, 40),
                    AutoSize = true
                };

                Label lblClinic = new Label
                {
                    Text = "Phòng khám: " + row["clinicName"].ToString(),
                    Location = new Point(120, 70),
                    AutoSize = true
                };

                Label lblPrice = new Label
                {
                    Text = "Giá khám: " + row["priceName"].ToString(),
                    Location = new Point(560, 10),
                    AutoSize = true
                };

                Label lblPayment = new Label
                {
                    Text = "Phương thức thanh toán: " + row["paymentName"].ToString(),
                    Location = new Point(560, 40),
                    AutoSize = true
                };

                Label lblProvince = new Label
                {
                    Text = "Tỉnh/Thành phố: " + row["provinceName"].ToString(),
                    Location = new Point(560, 70),
                    AutoSize = true
                };

                doctorPanel.Click += new EventHandler(pnlDoctorPanel_Click);
                picDoctorImage.Click += new EventHandler(pnlDoctorPanel_Click);
                lblDoctorName.Click += new EventHandler(pnlDoctorPanel_Click);
                lblSpecialty.Click += new EventHandler(pnlDoctorPanel_Click);
                lblClinic.Click += new EventHandler(pnlDoctorPanel_Click);
                lblPrice.Click += new EventHandler(pnlDoctorPanel_Click);
                lblPayment.Click += new EventHandler(pnlDoctorPanel_Click);
                lblProvince.Click += new EventHandler(pnlDoctorPanel_Click);

                doctorPanel.Controls.Add(picDoctorImage);
                doctorPanel.Controls.Add(lblDoctorName);
                doctorPanel.Controls.Add(lblSpecialty);
                doctorPanel.Controls.Add(lblClinic);
                doctorPanel.Controls.Add(lblPrice);
                doctorPanel.Controls.Add(lblPayment);
                doctorPanel.Controls.Add(lblProvince);
                doctorPanel.Cursor = Cursors.Hand;

                this.pnlDisplayListDoctors.Controls.Add(doctorPanel);
            }
        }

        private void pnlDoctorPanel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            string doctorID = string.Empty;

            if (clickedPanel != null && clickedPanel.Tag != null)
            {
                doctorID = clickedPanel.Tag.ToString();
            }
            else
            {
                Control clickedControl = sender as Control;
                if (clickedControl != null && clickedControl.Parent != null)
                {
                    clickedPanel = clickedControl.Parent as Panel;
                    if (clickedPanel != null && clickedPanel.Tag != null)
                    {
                        doctorID = clickedPanel.Tag.ToString();
                    }
                }
            }

            if (!string.IsNullOrEmpty(doctorID))
            {
                Form detailDoctor = new UserContainer.DetailDoctor(doctorID);
                detailDoctor.Show();
                this.Hide();
            }
        }
    }
}
