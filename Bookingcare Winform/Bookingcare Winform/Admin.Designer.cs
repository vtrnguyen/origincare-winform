namespace Bookingcare_Winform
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picAdminAvatar = new System.Windows.Forms.PictureBox();
            this.lbDisplayAdminName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnManageSpecialty = new System.Windows.Forms.Button();
            this.btnManageClinic = new System.Windows.Forms.Button();
            this.btnManageBooking = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnManageDoctor = new System.Windows.Forms.Button();
            this.pnlContentContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 76);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picAdminAvatar);
            this.panel3.Controls.Add(this.lbDisplayAdminName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(925, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 76);
            this.panel3.TabIndex = 1;
            // 
            // picAdminAvatar
            // 
            this.picAdminAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdminAvatar.Image = global::Bookingcare_Winform.Properties.Resources.admin;
            this.picAdminAvatar.Location = new System.Drawing.Point(330, 8);
            this.picAdminAvatar.Name = "picAdminAvatar";
            this.picAdminAvatar.Size = new System.Drawing.Size(124, 61);
            this.picAdminAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdminAvatar.TabIndex = 1;
            this.picAdminAvatar.TabStop = false;
            this.picAdminAvatar.Click += new System.EventHandler(this.picAdminAvatar_Click);
            // 
            // lbDisplayAdminName
            // 
            this.lbDisplayAdminName.AutoSize = true;
            this.lbDisplayAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayAdminName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDisplayAdminName.Location = new System.Drawing.Point(52, 26);
            this.lbDisplayAdminName.MaximumSize = new System.Drawing.Size(260, 29);
            this.lbDisplayAdminName.Name = "lbDisplayAdminName";
            this.lbDisplayAdminName.Size = new System.Drawing.Size(155, 25);
            this.lbDisplayAdminName.TabIndex = 0;
            this.lbDisplayAdminName.Text = "Xin chào, Admin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 76);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnManageSpecialty, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnManageClinic, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnManageBooking, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnManageUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnManageDoctor, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnManageSpecialty
            // 
            this.btnManageSpecialty.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnManageSpecialty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSpecialty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSpecialty.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageSpecialty.Location = new System.Drawing.Point(558, 3);
            this.btnManageSpecialty.Name = "btnManageSpecialty";
            this.btnManageSpecialty.Size = new System.Drawing.Size(179, 70);
            this.btnManageSpecialty.TabIndex = 3;
            this.btnManageSpecialty.Text = "Chuyên khoa";
            this.btnManageSpecialty.UseVisualStyleBackColor = false;
            this.btnManageSpecialty.Click += new System.EventHandler(this.btnManageSpecialty_Click);
            // 
            // btnManageClinic
            // 
            this.btnManageClinic.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnManageClinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageClinic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageClinic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClinic.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageClinic.Location = new System.Drawing.Point(373, 3);
            this.btnManageClinic.Name = "btnManageClinic";
            this.btnManageClinic.Size = new System.Drawing.Size(179, 70);
            this.btnManageClinic.TabIndex = 2;
            this.btnManageClinic.Text = "Cơ sở khám bệnh";
            this.btnManageClinic.UseVisualStyleBackColor = false;
            this.btnManageClinic.Click += new System.EventHandler(this.btnManageClinic_Click);
            // 
            // btnManageBooking
            // 
            this.btnManageBooking.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnManageBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBooking.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageBooking.Location = new System.Drawing.Point(188, 3);
            this.btnManageBooking.Name = "btnManageBooking";
            this.btnManageBooking.Size = new System.Drawing.Size(179, 70);
            this.btnManageBooking.TabIndex = 1;
            this.btnManageBooking.Text = "Lịch khám bệnh";
            this.btnManageBooking.UseVisualStyleBackColor = false;
            this.btnManageBooking.Click += new System.EventHandler(this.btnManageBooking_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnManageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageUser.Location = new System.Drawing.Point(3, 3);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(179, 70);
            this.btnManageUser.TabIndex = 0;
            this.btnManageUser.Text = "Người dùng hệ thống";
            this.btnManageUser.UseVisualStyleBackColor = false;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnManageDoctor
            // 
            this.btnManageDoctor.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnManageDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnManageDoctor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageDoctor.Location = new System.Drawing.Point(743, 3);
            this.btnManageDoctor.Name = "btnManageDoctor";
            this.btnManageDoctor.Size = new System.Drawing.Size(179, 70);
            this.btnManageDoctor.TabIndex = 4;
            this.btnManageDoctor.Text = "Thông tin bác sĩ";
            this.btnManageDoctor.UseVisualStyleBackColor = false;
            this.btnManageDoctor.Click += new System.EventHandler(this.btnManageDoctor_Click);
            // 
            // pnlContentContainer
            // 
            this.pnlContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentContainer.Location = new System.Drawing.Point(0, 76);
            this.pnlContentContainer.Name = "pnlContentContainer";
            this.pnlContentContainer.Size = new System.Drawing.Size(1382, 677);
            this.pnlContentContainer.TabIndex = 2;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.pnlContentContainer);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdminAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDisplayAdminName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picAdminAvatar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnManageSpecialty;
        private System.Windows.Forms.Button btnManageClinic;
        private System.Windows.Forms.Button btnManageBooking;
        private System.Windows.Forms.Panel pnlContentContainer;
        private System.Windows.Forms.Button btnManageDoctor;
    }
}