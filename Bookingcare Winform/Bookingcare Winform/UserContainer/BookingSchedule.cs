using Bookingcare_Winform.Properties;
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
    public partial class BookingSchedule : Form
    {
        private string doctorID;
        private string bookingDate;
        private string bookingTimeKeyMap;
        private string bookingTimeValue;
        private string bookingPrice;
        private Database database = new Database();
        private ImageConverter imageConverter = new ImageConverter();
        private Validator validator = new Validator();
        private EmailSender emailSender = new EmailSender();

        public BookingSchedule(string doctorID, string bookingDate, string bookingTimeKeyMap, string bookingTimeValue, string bookingPrice)
        {
            this.doctorID = doctorID;
            this.bookingDate = bookingDate;
            this.bookingTimeKeyMap = bookingTimeKeyMap;
            this.bookingTimeValue = bookingTimeValue;
            this.bookingPrice = bookingPrice;

            InitializeComponent();
        }

        private void BookingSchedule_Load(object sender, EventArgs e)
        {
            this.cboPatientGender.SelectedIndex = 0;

            this.loadDoctorInfor();
        }

        private void loadDoctorInfor()
        {
            DataTable doctorData = this.database.getDetailInforDoctor(this.doctorID);

            if (doctorData == null && doctorData.Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu bác sĩ không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            DataRow doctorInfor = doctorData.Rows[0];

            this.lbDoctorInfor.Text = $"{doctorInfor["positionName"].ToString()} | {doctorInfor["doctorName"]}";
            this.lbBookingTime.Text = $"{this.bookingTimeValue} - {this.bookingDate}";
            this.lbClinicName.Text = $"{doctorInfor["clinicName"].ToString()}";
            this.lbClinicAddress.Text = $"{doctorInfor["address"].ToString()}";
            this.lbPaymentName.Text = $"{doctorInfor["paymentName"]}";
            this.lbBookingPrice.Text = $"{this.bookingPrice}";

            if (doctorInfor["doctorImage"] != DBNull.Value)
            {
                this.picDoctorImage.Image = this.imageConverter.convertByteArrayToImage((byte[])doctorInfor["doctorImage"]);
            }
            else
            {
                this.picDoctorImage.Image = Resources.doctor;
            }
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            if (this.txtPatientName.Text == "" || this.txtPatientPhoneNumber.Text == "" ||
                this.txtPatientEmail.Text == "" || this.txtPatientExaminationReason.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!this.validator.isValidPhoneNumber(this.txtPatientPhoneNumber.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!this.validator.isValidEmail(this.txtPatientEmail.Text))
            {
                MessageBox.Show("Email không hợp lê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string patientName = this.txtPatientName.Text;
            string patientGender = this.cboPatientGender.SelectedItem.ToString();
            string patientBirthDay = this.dtpPatientBirthday.Value.ToString("dd/MM/yyyy");
            string patientPhoneNumber = this.txtPatientPhoneNumber.Text;
            string patientEmail = this.txtPatientEmail.Text;
            string patientAddress = this.txtPatientAddress.Text;
            string examinationReason = this.txtPatientExaminationReason.Text;
            DateTime parsedBookingDate = DateTime.ParseExact(this.bookingDate, "dd/MM/yyyy", null);

            if (this.database.createBookingSchedule(this.doctorID, patientEmail, parsedBookingDate, this.bookingTimeKeyMap))
            {
                MessageBox.Show("Đặt lịch khám bệnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (this.emailSender.sendEmail(patientEmail, patientName, parsedBookingDate, this.bookingTimeValue, this.lbClinicName.Text))
                {
                    MessageBox.Show($"Đã gửi email thông báo đặt lịch khám thành công cho email: {patientEmail}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.txtPatientName.Text = "";
                this.txtPatientPhoneNumber.Text = "";
                this.txtPatientEmail.Text = "";
                this.txtPatientAddress.Text = "";
                this.txtPatientExaminationReason.Text = "";

                this.Hide();
            } else
            {
                MessageBox.Show("Ban đã đặt lịch khám vào thời gian này rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
