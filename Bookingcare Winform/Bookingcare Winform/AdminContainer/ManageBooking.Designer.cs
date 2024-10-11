namespace Bookingcare_Winform.AdminContainer
{
    partial class ManageBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlManageClinicHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDoctors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlScheduleTimeButton = new System.Windows.Forms.Panel();
            this.btnSaveBookingSchedule = new System.Windows.Forms.Button();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.pnlManageClinicHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManageClinicHeader
            // 
            this.pnlManageClinicHeader.Controls.Add(this.label1);
            this.pnlManageClinicHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageClinicHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlManageClinicHeader.Name = "pnlManageClinicHeader";
            this.pnlManageClinicHeader.Size = new System.Drawing.Size(1364, 89);
            this.pnlManageClinicHeader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐẶT LỊCH KHÁM BỆNH";
            // 
            // cboDoctors
            // 
            this.cboDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoctors.FormattingEnabled = true;
            this.cboDoctors.Location = new System.Drawing.Point(327, 119);
            this.cboDoctors.Name = "cboDoctors";
            this.cboDoctors.Size = new System.Drawing.Size(227, 28);
            this.cboDoctors.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn bác sĩ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày khám bệnh:";
            // 
            // pnlScheduleTimeButton
            // 
            this.pnlScheduleTimeButton.Location = new System.Drawing.Point(327, 175);
            this.pnlScheduleTimeButton.Name = "pnlScheduleTimeButton";
            this.pnlScheduleTimeButton.Size = new System.Drawing.Size(666, 107);
            this.pnlScheduleTimeButton.TabIndex = 7;
            // 
            // btnSaveBookingSchedule
            // 
            this.btnSaveBookingSchedule.BackColor = System.Drawing.Color.Coral;
            this.btnSaveBookingSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveBookingSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBookingSchedule.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveBookingSchedule.Location = new System.Drawing.Point(838, 299);
            this.btnSaveBookingSchedule.Name = "btnSaveBookingSchedule";
            this.btnSaveBookingSchedule.Size = new System.Drawing.Size(155, 42);
            this.btnSaveBookingSchedule.TabIndex = 8;
            this.btnSaveBookingSchedule.Text = "Lưu thông tin";
            this.btnSaveBookingSchedule.UseVisualStyleBackColor = false;
            this.btnSaveBookingSchedule.Click += new System.EventHandler(this.btnSaveBookingSchedule_Click);
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingDate.Location = new System.Drawing.Point(793, 120);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpBookingDate.Size = new System.Drawing.Size(200, 27);
            this.dtpBookingDate.TabIndex = 9;
            // 
            // ManageBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 630);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.btnSaveBookingSchedule);
            this.Controls.Add(this.pnlScheduleTimeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDoctors);
            this.Controls.Add(this.pnlManageClinicHeader);
            this.Name = "ManageBooking";
            this.Text = "Quản lý đặt lịch khám bệnh";
            this.Load += new System.EventHandler(this.ManageBookingSchedule_Load);
            this.pnlManageClinicHeader.ResumeLayout(false);
            this.pnlManageClinicHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlManageClinicHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDoctors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlScheduleTimeButton;
        private System.Windows.Forms.Button btnSaveBookingSchedule;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
    }
}