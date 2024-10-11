namespace Bookingcare_Winform.AdminContainer
{
    partial class ManageDoctor
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
            this.pnlManageDoctorHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDoctors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.cboPrices = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPayments = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSpecialties = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboProvinces = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboClinics = new System.Windows.Forms.ComboBox();
            this.pnlManageDoctorContent = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.picDoctorImage = new System.Windows.Forms.PictureBox();
            this.dgvDoctorInfor = new System.Windows.Forms.DataGridView();
            this.btnSaveDoctorInfor = new System.Windows.Forms.Button();
            this.pnlManageDoctorHeader.SuspendLayout();
            this.pnlManageDoctorContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoctorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManageDoctorHeader
            // 
            this.pnlManageDoctorHeader.Controls.Add(this.label1);
            this.pnlManageDoctorHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageDoctorHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlManageDoctorHeader.Name = "pnlManageDoctorHeader";
            this.pnlManageDoctorHeader.Size = new System.Drawing.Size(1364, 89);
            this.pnlManageDoctorHeader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THÔNG TIN BÁC SĨ";
            // 
            // cboDoctors
            // 
            this.cboDoctors.FormattingEnabled = true;
            this.cboDoctors.Location = new System.Drawing.Point(281, 33);
            this.cboDoctors.Name = "cboDoctors";
            this.cboDoctors.Size = new System.Drawing.Size(186, 24);
            this.cboDoctors.TabIndex = 0;
            this.cboDoctors.SelectedIndexChanged += new System.EventHandler(this.cboDoctors_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn bác sĩ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thông tin giới thiệu:";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(594, 33);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(503, 43);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            // 
            // cboPrices
            // 
            this.cboPrices.FormattingEnabled = true;
            this.cboPrices.Location = new System.Drawing.Point(280, 123);
            this.cboPrices.Name = "cboPrices";
            this.cboPrices.Size = new System.Drawing.Size(187, 24);
            this.cboPrices.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(591, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phương thức thanh toán:";
            // 
            // cboPayments
            // 
            this.cboPayments.FormattingEnabled = true;
            this.cboPayments.Location = new System.Drawing.Point(594, 123);
            this.cboPayments.Name = "cboPayments";
            this.cboPayments.Size = new System.Drawing.Size(187, 24);
            this.cboPayments.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá khám bệnh:";
            // 
            // cboSpecialties
            // 
            this.cboSpecialties.FormattingEnabled = true;
            this.cboSpecialties.Location = new System.Drawing.Point(594, 216);
            this.cboSpecialties.Name = "cboSpecialties";
            this.cboSpecialties.Size = new System.Drawing.Size(187, 24);
            this.cboSpecialties.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chuyên khoa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(907, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tỉnh thành:";
            // 
            // cboProvinces
            // 
            this.cboProvinces.FormattingEnabled = true;
            this.cboProvinces.Location = new System.Drawing.Point(910, 216);
            this.cboProvinces.Name = "cboProvinces";
            this.cboProvinces.Size = new System.Drawing.Size(187, 24);
            this.cboProvinces.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(278, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cơ sở công tác:";
            // 
            // cboClinics
            // 
            this.cboClinics.FormattingEnabled = true;
            this.cboClinics.Location = new System.Drawing.Point(281, 216);
            this.cboClinics.Name = "cboClinics";
            this.cboClinics.Size = new System.Drawing.Size(186, 24);
            this.cboClinics.TabIndex = 14;
            // 
            // pnlManageDoctorContent
            // 
            this.pnlManageDoctorContent.Controls.Add(this.label8);
            this.pnlManageDoctorContent.Controls.Add(this.picDoctorImage);
            this.pnlManageDoctorContent.Controls.Add(this.dgvDoctorInfor);
            this.pnlManageDoctorContent.Controls.Add(this.btnSaveDoctorInfor);
            this.pnlManageDoctorContent.Controls.Add(this.cboClinics);
            this.pnlManageDoctorContent.Controls.Add(this.label9);
            this.pnlManageDoctorContent.Controls.Add(this.cboProvinces);
            this.pnlManageDoctorContent.Controls.Add(this.label7);
            this.pnlManageDoctorContent.Controls.Add(this.label6);
            this.pnlManageDoctorContent.Controls.Add(this.cboSpecialties);
            this.pnlManageDoctorContent.Controls.Add(this.label5);
            this.pnlManageDoctorContent.Controls.Add(this.cboPayments);
            this.pnlManageDoctorContent.Controls.Add(this.label4);
            this.pnlManageDoctorContent.Controls.Add(this.cboPrices);
            this.pnlManageDoctorContent.Controls.Add(this.rtbDescription);
            this.pnlManageDoctorContent.Controls.Add(this.label3);
            this.pnlManageDoctorContent.Controls.Add(this.label2);
            this.pnlManageDoctorContent.Controls.Add(this.cboDoctors);
            this.pnlManageDoctorContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageDoctorContent.Location = new System.Drawing.Point(0, 89);
            this.pnlManageDoctorContent.Name = "pnlManageDoctorContent";
            this.pnlManageDoctorContent.Size = new System.Drawing.Size(1364, 541);
            this.pnlManageDoctorContent.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(907, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hình ảnh:";
            // 
            // picDoctorImage
            // 
            this.picDoctorImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDoctorImage.Image = global::Bookingcare_Winform.Properties.Resources.addPicture;
            this.picDoctorImage.Location = new System.Drawing.Point(992, 104);
            this.picDoctorImage.Name = "picDoctorImage";
            this.picDoctorImage.Size = new System.Drawing.Size(105, 69);
            this.picDoctorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoctorImage.TabIndex = 17;
            this.picDoctorImage.TabStop = false;
            this.picDoctorImage.Click += new System.EventHandler(this.picDoctorImage_Click);
            // 
            // dgvDoctorInfor
            // 
            this.dgvDoctorInfor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctorInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctorInfor.Location = new System.Drawing.Point(280, 326);
            this.dgvDoctorInfor.Name = "dgvDoctorInfor";
            this.dgvDoctorInfor.RowHeadersWidth = 51;
            this.dgvDoctorInfor.RowTemplate.Height = 24;
            this.dgvDoctorInfor.Size = new System.Drawing.Size(817, 173);
            this.dgvDoctorInfor.TabIndex = 16;
            // 
            // btnSaveDoctorInfor
            // 
            this.btnSaveDoctorInfor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveDoctorInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveDoctorInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDoctorInfor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveDoctorInfor.Location = new System.Drawing.Point(910, 262);
            this.btnSaveDoctorInfor.Name = "btnSaveDoctorInfor";
            this.btnSaveDoctorInfor.Size = new System.Drawing.Size(187, 42);
            this.btnSaveDoctorInfor.TabIndex = 15;
            this.btnSaveDoctorInfor.Text = "Lưu thông tin";
            this.btnSaveDoctorInfor.UseVisualStyleBackColor = false;
            this.btnSaveDoctorInfor.Click += new System.EventHandler(this.btnSaveDoctorInfor_Click);
            // 
            // ManageDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 630);
            this.Controls.Add(this.pnlManageDoctorContent);
            this.Controls.Add(this.pnlManageDoctorHeader);
            this.Name = "ManageDoctor";
            this.Text = "Quản lý thông tin bác sĩ";
            this.Load += new System.EventHandler(this.ManageDoctor_Load);
            this.pnlManageDoctorHeader.ResumeLayout(false);
            this.pnlManageDoctorHeader.PerformLayout();
            this.pnlManageDoctorContent.ResumeLayout(false);
            this.pnlManageDoctorContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoctorImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorInfor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManageDoctorHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDoctors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.ComboBox cboPrices;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPayments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSpecialties;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboProvinces;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboClinics;
        private System.Windows.Forms.Panel pnlManageDoctorContent;
        private System.Windows.Forms.Button btnSaveDoctorInfor;
        private System.Windows.Forms.DataGridView dgvDoctorInfor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picDoctorImage;
    }
}