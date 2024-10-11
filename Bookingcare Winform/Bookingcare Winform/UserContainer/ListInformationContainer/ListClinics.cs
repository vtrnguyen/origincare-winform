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
    public partial class ListClinics : Form
    {
        private Database database = new Database();
        private ImageConverter imageConverter = new ImageConverter();

        public ListClinics()
        {
            InitializeComponent();
        }

        private void ListClinics_Load(object sender, EventArgs e)
        {
            this.renderClinicPanels();
        }

        private void redirectToHomePage()
        {
            Form homePage = new User();

            homePage.Show();
            this.Hide();
        }

        public void renderClinicPanels()
        {
            DataTable clinicTable = this.database.getAllClinic();

            if (clinicTable == null || clinicTable.Rows.Count == 0)
            {
                MessageBox.Show("Không tồn tại cơ sở y tế nào!");
                return;
            }

            int panelHeight = 150;
            int panelWidth = 400;
            int panelMargin = 20;

            int startX = 90;
            int startY = 70;

            for (int i = 0; i < clinicTable.Rows.Count; i++)
            {
                DataRow row = clinicTable.Rows[i];

                Panel clinicPanel = new Panel
                {
                    Width = panelWidth,
                    Height = panelHeight,
                    Location = new Point(startX + (panelWidth + panelMargin) * (i % 2), startY + (panelHeight + panelMargin) * (i / 2)),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Tag = row["id"].ToString(),
                };

                PictureBox clinicImage = new PictureBox
                {
                    Size = new Size(120, 100),
                    Location = new Point(10, 25),
                    SizeMode = PictureBoxSizeMode.Zoom,
                };

                if (row["image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])row["image"];
                    clinicImage.Image = this.imageConverter.convertByteArrayToImage(imageData);
                }
                else
                {
                    clinicImage.Image = Properties.Resources.doctor;
                }

                Label lbClinicName = new Label
                {
                    Text = row["clinicName"].ToString(),
                    Location = new Point(140, 60),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    MaximumSize = new Size(240, 0)
                };

                clinicPanel.Click += new EventHandler(pnlClinicPanel_Click);
                clinicImage.Click += new EventHandler(pnlClinicPanel_Click);
                lbClinicName.Click += new EventHandler(pnlClinicPanel_Click);

                clinicPanel.Controls.Add(clinicImage);
                clinicPanel.Controls.Add(lbClinicName);
                clinicPanel.Cursor = Cursors.Hand;

                this.pnlListClnicContainer.Controls.Add(clinicPanel);
            }
        }

        private void pnlClinicPanel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            string clinicID = string.Empty;

            if (clickedPanel != null && clickedPanel.Tag != null)
            {
                clinicID = clickedPanel.Tag.ToString();
            }
            else
            {
                Control clickedControl = sender as Control;
                if (clickedControl != null && clickedControl.Parent != null)
                {
                    clickedPanel = clickedControl.Parent as Panel;
                    if (clickedPanel != null && clickedPanel.Tag != null)
                    {
                        clinicID = clickedPanel.Tag.ToString();
                    }
                }
            }

            if (!string.IsNullOrEmpty(clinicID))
            {
                Form detailClinicForm = new UserContainer.DetailClinic(clinicID);

                detailClinicForm.Show();
                this.Hide();
            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            this.redirectToHomePage();
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            this.redirectToHomePage();
        }
    }
}
