namespace Bookingcare_Winform
{
    partial class Doctor
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnManageSchedule = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbDisplayDoctorName = new System.Windows.Forms.Label();
            this.pnlContentContainer = new System.Windows.Forms.Panel();
            this.picDoctorAvatar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoctorAvatar)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(925, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 76);
            this.panel3.TabIndex = 1;
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
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnManageSchedule, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnManageSchedule
            // 
            this.btnManageSchedule.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnManageSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnManageSchedule.ForeColor = System.Drawing.SystemColors.Window;
            this.btnManageSchedule.Location = new System.Drawing.Point(3, 3);
            this.btnManageSchedule.Name = "btnManageSchedule";
            this.btnManageSchedule.Size = new System.Drawing.Size(225, 70);
            this.btnManageSchedule.TabIndex = 0;
            this.btnManageSchedule.Text = "Tạo lịch khám bệnh";
            this.btnManageSchedule.UseVisualStyleBackColor = false;
            this.btnManageSchedule.Click += new System.EventHandler(this.btnManageSchedule_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.picDoctorAvatar);
            this.panel4.Controls.Add(this.lbDisplayDoctorName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 76);
            this.panel4.TabIndex = 2;
            // 
            // lbDisplayDoctorName
            // 
            this.lbDisplayDoctorName.AutoSize = true;
            this.lbDisplayDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayDoctorName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDisplayDoctorName.Location = new System.Drawing.Point(52, 26);
            this.lbDisplayDoctorName.MaximumSize = new System.Drawing.Size(260, 29);
            this.lbDisplayDoctorName.Name = "lbDisplayDoctorName";
            this.lbDisplayDoctorName.Size = new System.Drawing.Size(152, 25);
            this.lbDisplayDoctorName.TabIndex = 0;
            this.lbDisplayDoctorName.Text = "Xin chào, Bác sĩ";
            // 
            // pnlContentContainer
            // 
            this.pnlContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentContainer.Location = new System.Drawing.Point(0, 76);
            this.pnlContentContainer.Name = "pnlContentContainer";
            this.pnlContentContainer.Size = new System.Drawing.Size(1382, 677);
            this.pnlContentContainer.TabIndex = 2;
            // 
            // picDoctorAvatar
            // 
            this.picDoctorAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDoctorAvatar.Image = global::Bookingcare_Winform.Properties.Resources.doctor;
            this.picDoctorAvatar.Location = new System.Drawing.Point(330, 8);
            this.picDoctorAvatar.Name = "picDoctorAvatar";
            this.picDoctorAvatar.Size = new System.Drawing.Size(124, 61);
            this.picDoctorAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDoctorAvatar.TabIndex = 1;
            this.picDoctorAvatar.TabStop = false;
            this.picDoctorAvatar.Click += new System.EventHandler(this.picDoctorAvatar_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.pnlContentContainer);
            this.Controls.Add(this.panel1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoctorAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnManageSchedule;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picDoctorAvatar;
        private System.Windows.Forms.Label lbDisplayDoctorName;
        private System.Windows.Forms.Panel pnlContentContainer;
    }
}