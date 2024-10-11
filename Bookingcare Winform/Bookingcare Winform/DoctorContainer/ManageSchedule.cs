using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcare_Winform.DoctorContainer
{
    public partial class ManageSchedule : Form
    {
        private string doctorID;
        private Database database = new Database();

        public ManageSchedule(string doctorID)
        {
            this.doctorID = doctorID;

            InitializeComponent();
        }
        private void ManageSchedule_Load(object sender, EventArgs e)
        {
            this.dtpBookingDate.MinDate = DateTime.Today;
            this.generateButtons();
        }

        private void btnSaveBookingSchedule_Click(object sender, EventArgs e)
        {
            if (this.dtpBookingDate.Value == null)
            {
                MessageBox.Show("Bạn chưa chọn ngày khám bệnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.getTimeBooking().Count() == 0)
            {
                MessageBox.Show("Phải chọn ít nhất một khung giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime bookingDate = this.dtpBookingDate.Value.Date;
            List<string> bookingTimes = this.getTimeBooking();

            if (this.database.bulkCreateDoctorSchedule(this.doctorID, bookingDate, bookingTimes))
            {
                MessageBox.Show("Tạo lịch khám bệnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.ManageSchedule_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Tạo lịch khám bệnh thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> getTimeBooking()
        {
            List<string> timeTypes = new List<string>();

            foreach (Control control in this.pnlScheduleTimeButton.Controls)
            {
                if (control is Button button)
                {
                    ButtonStatus buttonStatus = button.Tag as ButtonStatus;

                    if (buttonStatus != null && buttonStatus.isChecked)
                    {
                        timeTypes.Add(buttonStatus.keyMap);
                    }
                }
            }

            return timeTypes;
        }

        private void generateButtons()
        {
            DataTable bookingTimes = this.database.getAllBookingTime();

            if (bookingTimes != null && bookingTimes.Rows.Count > 0)
            {
                this.pnlScheduleTimeButton.Controls.Clear();

                int buttonWidth = 92;
                int buttonHeight = 35;
                int margin = 10;
                int currentX = 0;
                int currentY = 0;

                foreach (DataRow row in bookingTimes.Rows)
                {
                    Button button = new Button();
                    button.Text = row["codeValue"].ToString();
                    button.Tag = new ButtonStatus
                    {
                        keyMap = row["keyMap"].ToString(),
                        isChecked = false,
                    };
                    button.Width = buttonWidth;
                    button.Height = buttonHeight;
                    button.Click += btnBookingTime_Click;
                    button.Cursor = Cursors.Hand;

                    if (currentX + buttonWidth > this.pnlScheduleTimeButton.Width)
                    {
                        currentX = 0;
                        currentY += buttonHeight + margin;
                    }

                    button.Location = new Point(currentX, currentY);
                    this.pnlScheduleTimeButton.Controls.Add(button);

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

                if (buttonStatus != null)
                {
                    buttonStatus.isChecked = !buttonStatus.isChecked;

                    if (buttonStatus.isChecked)
                    {
                        clickedButton.BackColor = Color.Green;
                        clickedButton.ForeColor = Color.White;
                        clickedButton.Font = new Font(clickedButton.Font, FontStyle.Bold);
                    }
                    else
                    {
                        clickedButton.BackColor = SystemColors.Control;
                        clickedButton.ForeColor = Color.Black;
                        clickedButton.Font = new Font(clickedButton.Font, FontStyle.Regular);
                    }
                }
            }
        }
    }
}
