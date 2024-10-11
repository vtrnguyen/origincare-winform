namespace Bookingcare_Winform.AdminContainer
{
    partial class ManageClinic
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
            this.pnlManageClinicContent = new System.Windows.Forms.Panel();
            this.btnEmptyInput = new System.Windows.Forms.Button();
            this.btnEditClinic = new System.Windows.Forms.Button();
            this.btnDeleteClinic = new System.Windows.Forms.Button();
            this.dgvClinics = new System.Windows.Forms.DataGridView();
            this.btnAddAndEditClinic = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.picClinicImage = new System.Windows.Forms.PictureBox();
            this.txtClinicDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClinicAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClinicName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlManageClinicHeader.SuspendLayout();
            this.pnlManageClinicContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClinics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClinicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManageClinicHeader
            // 
            this.pnlManageClinicHeader.Controls.Add(this.label1);
            this.pnlManageClinicHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManageClinicHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlManageClinicHeader.Name = "pnlManageClinicHeader";
            this.pnlManageClinicHeader.Size = new System.Drawing.Size(1364, 89);
            this.pnlManageClinicHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CƠ SỞ KHÁM BỆNH";
            // 
            // pnlManageClinicContent
            // 
            this.pnlManageClinicContent.Controls.Add(this.btnEmptyInput);
            this.pnlManageClinicContent.Controls.Add(this.btnEditClinic);
            this.pnlManageClinicContent.Controls.Add(this.btnDeleteClinic);
            this.pnlManageClinicContent.Controls.Add(this.dgvClinics);
            this.pnlManageClinicContent.Controls.Add(this.btnAddAndEditClinic);
            this.pnlManageClinicContent.Controls.Add(this.label5);
            this.pnlManageClinicContent.Controls.Add(this.picClinicImage);
            this.pnlManageClinicContent.Controls.Add(this.txtClinicDescription);
            this.pnlManageClinicContent.Controls.Add(this.label4);
            this.pnlManageClinicContent.Controls.Add(this.txtClinicAddress);
            this.pnlManageClinicContent.Controls.Add(this.label3);
            this.pnlManageClinicContent.Controls.Add(this.txtClinicName);
            this.pnlManageClinicContent.Controls.Add(this.label2);
            this.pnlManageClinicContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageClinicContent.Location = new System.Drawing.Point(0, 89);
            this.pnlManageClinicContent.Name = "pnlManageClinicContent";
            this.pnlManageClinicContent.Size = new System.Drawing.Size(1364, 541);
            this.pnlManageClinicContent.TabIndex = 2;
            // 
            // btnEmptyInput
            // 
            this.btnEmptyInput.BackColor = System.Drawing.Color.Brown;
            this.btnEmptyInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmptyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyInput.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEmptyInput.Location = new System.Drawing.Point(1013, 105);
            this.btnEmptyInput.Name = "btnEmptyInput";
            this.btnEmptyInput.Size = new System.Drawing.Size(133, 33);
            this.btnEmptyInput.TabIndex = 12;
            this.btnEmptyInput.Text = "Làm mới ô nhập";
            this.btnEmptyInput.UseVisualStyleBackColor = false;
            this.btnEmptyInput.Click += new System.EventHandler(this.btnEmptyInput_Click);
            // 
            // btnEditClinic
            // 
            this.btnEditClinic.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditClinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClinic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClinic.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditClinic.Location = new System.Drawing.Point(1013, 268);
            this.btnEditClinic.Name = "btnEditClinic";
            this.btnEditClinic.Size = new System.Drawing.Size(214, 46);
            this.btnEditClinic.TabIndex = 11;
            this.btnEditClinic.Text = "Cập nhật thông tin";
            this.btnEditClinic.UseVisualStyleBackColor = false;
            this.btnEditClinic.Click += new System.EventHandler(this.btnEditClinic_Click);
            // 
            // btnDeleteClinic
            // 
            this.btnDeleteClinic.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDeleteClinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClinic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClinic.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeleteClinic.Location = new System.Drawing.Point(1013, 352);
            this.btnDeleteClinic.Name = "btnDeleteClinic";
            this.btnDeleteClinic.Size = new System.Drawing.Size(214, 46);
            this.btnDeleteClinic.TabIndex = 10;
            this.btnDeleteClinic.Text = "Xóa thông tin";
            this.btnDeleteClinic.UseVisualStyleBackColor = false;
            this.btnDeleteClinic.Click += new System.EventHandler(this.btnDeleteClinic_Click);
            // 
            // dgvClinics
            // 
            this.dgvClinics.AllowUserToAddRows = false;
            this.dgvClinics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClinics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClinics.Location = new System.Drawing.Point(148, 197);
            this.dgvClinics.Name = "dgvClinics";
            this.dgvClinics.RowHeadersWidth = 51;
            this.dgvClinics.RowTemplate.Height = 24;
            this.dgvClinics.Size = new System.Drawing.Size(766, 284);
            this.dgvClinics.TabIndex = 9;
            // 
            // btnAddAndEditClinic
            // 
            this.btnAddAndEditClinic.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAddAndEditClinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAndEditClinic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAndEditClinic.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddAndEditClinic.Location = new System.Drawing.Point(1013, 44);
            this.btnAddAndEditClinic.Name = "btnAddAndEditClinic";
            this.btnAddAndEditClinic.Size = new System.Drawing.Size(214, 46);
            this.btnAddAndEditClinic.TabIndex = 8;
            this.btnAddAndEditClinic.Text = "Thêm thông tin";
            this.btnAddAndEditClinic.UseVisualStyleBackColor = false;
            this.btnAddAndEditClinic.Click += new System.EventHandler(this.btnAddAndUpdateClinic_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(576, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hình ảnh:";
            // 
            // picClinicImage
            // 
            this.picClinicImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picClinicImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClinicImage.Image = global::Bookingcare_Winform.Properties.Resources.addPicture;
            this.picClinicImage.Location = new System.Drawing.Point(689, 28);
            this.picClinicImage.Name = "picClinicImage";
            this.picClinicImage.Size = new System.Drawing.Size(225, 110);
            this.picClinicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClinicImage.TabIndex = 6;
            this.picClinicImage.TabStop = false;
            this.picClinicImage.Click += new System.EventHandler(this.picClinicImage_Click);
            // 
            // txtClinicDescription
            // 
            this.txtClinicDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicDescription.Location = new System.Drawing.Point(274, 111);
            this.txtClinicDescription.Name = "txtClinicDescription";
            this.txtClinicDescription.Size = new System.Drawing.Size(225, 27);
            this.txtClinicDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mô tả:";
            // 
            // txtClinicAddress
            // 
            this.txtClinicAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicAddress.Location = new System.Drawing.Point(274, 67);
            this.txtClinicAddress.Name = "txtClinicAddress";
            this.txtClinicAddress.Size = new System.Drawing.Size(225, 27);
            this.txtClinicAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtClinicName
            // 
            this.txtClinicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClinicName.Location = new System.Drawing.Point(274, 25);
            this.txtClinicName.Name = "txtClinicName";
            this.txtClinicName.Size = new System.Drawing.Size(225, 27);
            this.txtClinicName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên cơ sở:";
            // 
            // ManageClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 630);
            this.Controls.Add(this.pnlManageClinicContent);
            this.Controls.Add(this.pnlManageClinicHeader);
            this.Name = "ManageClinic";
            this.Text = "Quản lý cơ sở khám bệnh";
            this.Load += new System.EventHandler(this.ManageClinic_Load);
            this.pnlManageClinicHeader.ResumeLayout(false);
            this.pnlManageClinicHeader.PerformLayout();
            this.pnlManageClinicContent.ResumeLayout(false);
            this.pnlManageClinicContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClinics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClinicImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManageClinicHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlManageClinicContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picClinicImage;
        private System.Windows.Forms.TextBox txtClinicDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClinicAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClinicName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAndEditClinic;
        private System.Windows.Forms.Button btnEditClinic;
        private System.Windows.Forms.Button btnDeleteClinic;
        private System.Windows.Forms.DataGridView dgvClinics;
        private System.Windows.Forms.Button btnEmptyInput;
    }
}