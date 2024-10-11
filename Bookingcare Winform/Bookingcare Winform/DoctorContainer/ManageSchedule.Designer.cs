namespace Bookingcare_Winform.DoctorContainer
{
    partial class ManageSchedule
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
            this.pnlManageScheduleHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlManageScheduleContent = new System.Windows.Forms.Panel();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveBookingSchedule = new System.Windows.Forms.Button();
            this.pnlScheduleTimeButton = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlManageScheduleHeader.SuspendLayout();
            this.pnlManageScheduleContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManageScheduleHeader
            // 
            this.pnlManageScheduleHeader.Controls.Add(this.label1);
            this.pnlManageScheduleHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageScheduleHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlManageScheduleHeader.Name = "pnlManageScheduleHeader";
            this.pnlManageScheduleHeader.Size = new System.Drawing.Size(1364, 89);
            this.pnlManageScheduleHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐẶT LỊCH KHÁM";
            // 
            // pnlManageScheduleContent
            // 
            this.pnlManageScheduleContent.Controls.Add(this.dtpBookingDate);
            this.pnlManageScheduleContent.Controls.Add(this.btnSaveBookingSchedule);
            this.pnlManageScheduleContent.Controls.Add(this.pnlScheduleTimeButton);
            this.pnlManageScheduleContent.Controls.Add(this.label3);
            this.pnlManageScheduleContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageScheduleContent.Location = new System.Drawing.Point(0, 89);
            this.pnlManageScheduleContent.Name = "pnlManageScheduleContent";
            this.pnlManageScheduleContent.Size = new System.Drawing.Size(1364, 541);
            this.pnlManageScheduleContent.TabIndex = 2;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingDate.Location = new System.Drawing.Point(349, 36);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpBookingDate.Size = new System.Drawing.Size(200, 27);
            this.dtpBookingDate.TabIndex = 15;
            // 
            // btnSaveBookingSchedule
            // 
            this.btnSaveBookingSchedule.BackColor = System.Drawing.Color.Coral;
            this.btnSaveBookingSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveBookingSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBookingSchedule.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveBookingSchedule.Location = new System.Drawing.Point(860, 208);
            this.btnSaveBookingSchedule.Name = "btnSaveBookingSchedule";
            this.btnSaveBookingSchedule.Size = new System.Drawing.Size(155, 42);
            this.btnSaveBookingSchedule.TabIndex = 14;
            this.btnSaveBookingSchedule.Text = "Lưu thông tin";
            this.btnSaveBookingSchedule.UseVisualStyleBackColor = false;
            this.btnSaveBookingSchedule.Click += new System.EventHandler(this.btnSaveBookingSchedule_Click);
            // 
            // pnlScheduleTimeButton
            // 
            this.pnlScheduleTimeButton.Location = new System.Drawing.Point(349, 86);
            this.pnlScheduleTimeButton.Name = "pnlScheduleTimeButton";
            this.pnlScheduleTimeButton.Size = new System.Drawing.Size(666, 107);
            this.pnlScheduleTimeButton.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày khám bệnh:";
            // 
            // ManageSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 630);
            this.Controls.Add(this.pnlManageScheduleContent);
            this.Controls.Add(this.pnlManageScheduleHeader);
            this.Name = "ManageSchedule";
            this.Text = "Tạo lịch khám bệnh";
            this.Load += new System.EventHandler(this.ManageSchedule_Load);
            this.pnlManageScheduleHeader.ResumeLayout(false);
            this.pnlManageScheduleHeader.PerformLayout();
            this.pnlManageScheduleContent.ResumeLayout(false);
            this.pnlManageScheduleContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManageScheduleHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlManageScheduleContent;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Button btnSaveBookingSchedule;
        private System.Windows.Forms.Panel pnlScheduleTimeButton;
        private System.Windows.Forms.Label label3;
    }
}