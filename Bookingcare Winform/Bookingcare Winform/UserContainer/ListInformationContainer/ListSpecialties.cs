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
    public partial class ListSpecialties : Form
    {
        private Database database = new Database();
        private ImageConverter imageConverter = new ImageConverter();

        public ListSpecialties()
        {
            InitializeComponent();
        }

        private void ListSpecialties_Load(object sender, EventArgs e)
        {
            this.renderSpecialtyPanels();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            this.redirectToHomePage();
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            this.redirectToHomePage();
        }

        public void renderSpecialtyPanels()
        {
            DataTable specialtyTable = this.database.getAllSpecialty();

            if (specialtyTable == null || specialtyTable.Rows.Count == 0)
            {
                MessageBox.Show("Không tồn tại chuyên khoa nào!");
                return;
            }

            int panelHeight = 100;
            int panelWidth = 850;
            int panelMargin = 10;

            int startX = 90;
            int startY = 70;

            for (int i = 0; i < specialtyTable.Rows.Count; i++)
            {
                DataRow row = specialtyTable.Rows[i];

                Panel specialtyPanel = new Panel
                {
                    Width = panelWidth,
                    Height = panelHeight,
                    Location = new Point(startX, startY + (panelHeight + panelMargin) * i),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Tag = row["id"].ToString(),
                };

                PictureBox specialtyImage = new PictureBox
                {
                    Size = new Size(150, 75),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                if (row["image"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])row["image"];

                    specialtyImage.Image = this.imageConverter.convertByteArrayToImage(imageData);
                }
                else
                {
                    specialtyImage.Image = Properties.Resources.doctor;
                }

                Label lbSpecialtyName = new Label
                {
                    Text = row["specialtyName"].ToString(),
                    Location = new Point(170, 40),
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Regular)
                };

                specialtyPanel.Click += new EventHandler(pnlSpecialtyPanel_Click);

                specialtyPanel.Controls.Add(specialtyImage);
                specialtyPanel.Controls.Add(lbSpecialtyName);
                specialtyPanel.Cursor = Cursors.Hand;

                this.pnlDisplayListSpecialties.Controls.Add(specialtyPanel);
            }
        }

        private void pnlSpecialtyPanel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;

            if (clickedPanel != null && clickedPanel.Tag != null)
            {
                string specialtyID = clickedPanel.Tag.ToString();

                Form detailSpecialty = new UserContainer.DetailSpecialty(specialtyID);

                detailSpecialty.Show();
                this.Hide();
            }
        }

        private void redirectToHomePage()
        {
            Form homePage = new User();

            homePage.Show();
            this.Hide();
        }
    }
}
