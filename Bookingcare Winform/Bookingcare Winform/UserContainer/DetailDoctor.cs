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
    public partial class DetailDoctor : Form
    {
        private string doctorID;
        private Database database = new Database();
        private ImageConverter imageConverter = new ImageConverter();

        public DetailDoctor(string doctorID)
        {
            this.doctorID = doctorID;

            InitializeComponent();
        }

        private void DetailDoctor_Load(object sender, EventArgs e)
        {
            this.pnlDetailtInsurance.Visible = false;
            this.dtpBookingDate.MinDate = DateTime.Now;
            this.getDoctorInfor();
            this.dtpBookingDate_ValueChanged(sender, e);
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

        private void lbSeeDetailInsurance_Click(object sender, EventArgs e)
        {
            this.pnlDetailtInsurance.Visible = true;
            this.lbShowDetailInsurance.Visible = false;
        }

        private void lbHideInsurance_Click(object sender, EventArgs e)
        {
            this.pnlDetailtInsurance.Visible = false;
            this.lbShowDetailInsurance.Visible = true;
        }

        private void getDoctorInfor()
        {
            DataTable doctorData = this.database.getDetailInforDoctor(this.doctorID);

            if (doctorData == null || doctorData.Rows.Count == 0) {
                MessageBox.Show("Dữ liệu bác sĩ không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }

            DataRow doctorInfor = doctorData.Rows[0];

            this.lbDoctorName.Text = $"{doctorInfor["positionName"].ToString()} | {doctorInfor["doctorName"]}";
            this.lbWorkPlace.Text = $"Bác sĩ chuyên khoa {doctorInfor["specialtyName"]} tại {doctorInfor["clinicName"]}";
            this.lbDoctorDescription.Text = $"{doctorInfor["description"]}";
            this.lbDoctorAddress.Text = $"{doctorInfor["provinceName"]}";
            this.lbClinicName.Text = $"{doctorInfor["clinicName"]}";
            this.lbClinicAddress.Text = $"{doctorInfor["address"]}";
            this.lbPrice.Text = $"{doctorInfor["price"]} VNĐ";
            this.lbPaymentName.Text = $"{doctorInfor["paymentName"]}";
            this.picDoctorImage.Image = this.imageConverter.convertByteArrayToImage((byte[])doctorInfor["doctorImage"]);
        }

        private void dtpBookingDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime bookingDate = this.dtpBookingDate.Value.Date;
            DataTable bookingTimeRange = this.database.getAllBookingSchedule(this.doctorID, bookingDate);

            if (bookingTimeRange == null || bookingTimeRange.Rows.Count == 0)
            {
                this.pnlBookingTimeRange.Controls.Clear();

                return;
            }

            this.generateButtons(bookingTimeRange);
        }

        private void generateButtons(DataTable bookingTimes)
        {
            if (bookingTimes != null && bookingTimes.Rows.Count > 0)
            {
                this.pnlBookingTimeRange.Controls.Clear();

                int buttonWidth = 106;
                int buttonHeight = 45;
                int margin = 10;
                int currentX = 0;
                int currentY = 0;

                foreach (DataRow row in bookingTimes.Rows)
                {
                    Button button = new Button();
                    button.Text = row["codeValue"].ToString();
                    button.Tag = new ButtonStatus
                    {
                        keyMap = row["timeType"].ToString(),
                        codeValue = row["codeValue"].ToString(),
                        isChecked = false,
                    };
                    button.Width = buttonWidth;
                    button.Height = buttonHeight;
                    button.Click += btnBookingTime_Click;
                    button.Cursor = Cursors.Hand;
                    button.BackColor = Color.White;

                    if (currentX + buttonWidth > this.pnlBookingTimeRange.Width)
                    {
                        currentX = 0;
                        currentY += buttonHeight + margin;
                    }

                    button.Location = new Point(currentX, currentY);
                    this.pnlBookingTimeRange.Controls.Add(button);

                    currentX += buttonWidth + margin;
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để tạo button.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBookingTime_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                ButtonStatus buttonStatus = clickedButton.Tag as ButtonStatus;

                Form bookingSchedule = new UserContainer.BookingSchedule(this.doctorID, this.dtpBookingDate.Value.ToString("dd/MM/yyyy"), buttonStatus.keyMap, buttonStatus.codeValue, this.lbPrice.Text);

                bookingSchedule.ShowDialog();
            }
        }

        private void lbBackToListDoctors_Click(object sender, EventArgs e)
        {
            Form listDoctors = new ListInformationContainer.ListDoctors();

            listDoctors.Show();
            this.Hide();
        }
    }
}
