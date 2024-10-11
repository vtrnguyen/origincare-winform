namespace Bookingcare_Winform.AdminContainer
{
    partial class ManageSpecialty
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpecialtyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbSpecialtyDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picSpecialtyImage = new System.Windows.Forms.PictureBox();
            this.btnConfirmAddAndEditSpecialty = new System.Windows.Forms.Button();
            this.dgvSpecialties = new System.Windows.Forms.DataGridView();
            this.btnEditSpecialty = new System.Windows.Forms.Button();
            this.btnDeleteSpecialty = new System.Windows.Forms.Button();
            this.pnlManageClinicHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpecialtyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialties)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(452, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHUYÊN KHOA KHÁM BỆNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên chuyên khoa:";
            // 
            // txtSpecialtyName
            // 
            this.txtSpecialtyName.Location = new System.Drawing.Point(311, 119);
            this.txtSpecialtyName.Name = "txtSpecialtyName";
            this.txtSpecialtyName.Size = new System.Drawing.Size(235, 22);
            this.txtSpecialtyName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mô tả:";
            // 
            // rtbSpecialtyDescription
            // 
            this.rtbSpecialtyDescription.Location = new System.Drawing.Point(311, 165);
            this.rtbSpecialtyDescription.Name = "rtbSpecialtyDescription";
            this.rtbSpecialtyDescription.Size = new System.Drawing.Size(235, 76);
            this.rtbSpecialtyDescription.TabIndex = 7;
            this.rtbSpecialtyDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(613, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hình ảnh:";
            // 
            // picSpecialtyImage
            // 
            this.picSpecialtyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSpecialtyImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSpecialtyImage.Image = global::Bookingcare_Winform.Properties.Resources.addPicture;
            this.picSpecialtyImage.Location = new System.Drawing.Point(717, 119);
            this.picSpecialtyImage.Name = "picSpecialtyImage";
            this.picSpecialtyImage.Size = new System.Drawing.Size(225, 122);
            this.picSpecialtyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpecialtyImage.TabIndex = 9;
            this.picSpecialtyImage.TabStop = false;
            this.picSpecialtyImage.Click += new System.EventHandler(this.picSpecialtyImage_Click);
            // 
            // btnConfirmAddAndEditSpecialty
            // 
            this.btnConfirmAddAndEditSpecialty.BackColor = System.Drawing.Color.DarkBlue;
            this.btnConfirmAddAndEditSpecialty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmAddAndEditSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAddAndEditSpecialty.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConfirmAddAndEditSpecialty.Location = new System.Drawing.Point(1015, 154);
            this.btnConfirmAddAndEditSpecialty.Name = "btnConfirmAddAndEditSpecialty";
            this.btnConfirmAddAndEditSpecialty.Size = new System.Drawing.Size(214, 46);
            this.btnConfirmAddAndEditSpecialty.TabIndex = 10;
            this.btnConfirmAddAndEditSpecialty.Text = "Thêm thông tin";
            this.btnConfirmAddAndEditSpecialty.UseVisualStyleBackColor = false;
            this.btnConfirmAddAndEditSpecialty.Click += new System.EventHandler(this.btnConfirmAddAndEditSpecialty_Click);
            // 
            // dgvSpecialties
            // 
            this.dgvSpecialties.AllowUserToAddRows = false;
            this.dgvSpecialties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpecialties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialties.Location = new System.Drawing.Point(151, 306);
            this.dgvSpecialties.Name = "dgvSpecialties";
            this.dgvSpecialties.RowHeadersWidth = 51;
            this.dgvSpecialties.RowTemplate.Height = 24;
            this.dgvSpecialties.Size = new System.Drawing.Size(791, 282);
            this.dgvSpecialties.TabIndex = 11;
            // 
            // btnEditSpecialty
            // 
            this.btnEditSpecialty.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEditSpecialty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSpecialty.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditSpecialty.Location = new System.Drawing.Point(1015, 368);
            this.btnEditSpecialty.Name = "btnEditSpecialty";
            this.btnEditSpecialty.Size = new System.Drawing.Size(214, 46);
            this.btnEditSpecialty.TabIndex = 12;
            this.btnEditSpecialty.Text = "Cập nhật thông tin";
            this.btnEditSpecialty.UseVisualStyleBackColor = false;
            this.btnEditSpecialty.Click += new System.EventHandler(this.btnEditSpecialty_Click);
            // 
            // btnDeleteSpecialty
            // 
            this.btnDeleteSpecialty.BackColor = System.Drawing.Color.Olive;
            this.btnDeleteSpecialty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSpecialty.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeleteSpecialty.Location = new System.Drawing.Point(1015, 480);
            this.btnDeleteSpecialty.Name = "btnDeleteSpecialty";
            this.btnDeleteSpecialty.Size = new System.Drawing.Size(214, 46);
            this.btnDeleteSpecialty.TabIndex = 13;
            this.btnDeleteSpecialty.Text = "Xóa chuyên khoa";
            this.btnDeleteSpecialty.UseVisualStyleBackColor = false;
            this.btnDeleteSpecialty.Click += new System.EventHandler(this.btnDeleteSpecialty_Click);
            // 
            // ManageSpecialty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 630);
            this.Controls.Add(this.btnDeleteSpecialty);
            this.Controls.Add(this.btnEditSpecialty);
            this.Controls.Add(this.dgvSpecialties);
            this.Controls.Add(this.btnConfirmAddAndEditSpecialty);
            this.Controls.Add(this.picSpecialtyImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbSpecialtyDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSpecialtyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlManageClinicHeader);
            this.Name = "ManageSpecialty";
            this.Text = "Quản lý chuyên khoa";
            this.Load += new System.EventHandler(this.ManageSpecialty_Load);
            this.pnlManageClinicHeader.ResumeLayout(false);
            this.pnlManageClinicHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpecialtyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlManageClinicHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpecialtyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbSpecialtyDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picSpecialtyImage;
        private System.Windows.Forms.Button btnConfirmAddAndEditSpecialty;
        private System.Windows.Forms.DataGridView dgvSpecialties;
        private System.Windows.Forms.Button btnEditSpecialty;
        private System.Windows.Forms.Button btnDeleteSpecialty;
    }
}