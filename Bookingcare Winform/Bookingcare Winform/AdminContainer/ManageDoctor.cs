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

namespace Bookingcare_Winform.AdminContainer
{
    public partial class ManageDoctor : Form
    {
        private Database database = new Database();
        private bool hasOldDoctorData = false;
        private ImageConverter imageConverter = new ImageConverter();

        public ManageDoctor()
        {
            InitializeComponent();
        }

        private void ManageDoctor_Load(object sender, EventArgs e)
        {
            this.getCboData();
            this.dgvDoctorInfor.DataSource = this.database.getAllDoctorInfor();
            this.rtbDescription.Text = ""; 
            this.cboDoctors_SelectedIndexChanged(sender, e);
        }

        private void btnSaveDoctorInfor_Click(object sender, EventArgs e)
        {
            if (this.cboDoctors.SelectedIndex.ToString() == "" || this.cboPrices.SelectedIndex.ToString() == "" ||
                this.cboPayments.SelectedIndex.ToString() == "" || this.cboProvinces.SelectedIndex.ToString() == "" ||
                this.cboClinics.SelectedIndex.ToString() == "" || this.cboSpecialties.ToString() == "" ||
                this.rtbDescription.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                string selectedDoctorID = this.cboDoctors.SelectedValue.ToString();
                string selectedSpecialty = this.cboSpecialties.SelectedValue.ToString();
                string selectedClinic = this.cboClinics.SelectedValue.ToString();
                string selectedPrice = this.cboPrices.SelectedValue.ToString();
                string selectedPayment = this.cboPayments.SelectedValue.ToString();
                string selectedProvince = this.cboProvinces.SelectedValue.ToString();
                string doctorDescription = this.rtbDescription.Text;
                byte[] clinicImage = this.imageConverter.changeImageToByteArray(this.picDoctorImage.Image);

                if (!this.hasOldDoctorData)
                {
                    if (this.database.createDoctorInfor(selectedDoctorID, selectedSpecialty, selectedClinic, selectedPrice,
                    selectedProvince, selectedPayment, doctorDescription, clinicImage))
                    {
                        MessageBox.Show("Thêm mới thông tin bác sĩ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ManageDoctor_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thông tin bác sĩ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    if (this.database.updateDoctorInfor(selectedDoctorID, selectedSpecialty, selectedClinic, selectedPrice,
                    selectedProvince, selectedPayment, doctorDescription, clinicImage))
                    {
                        MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ManageDoctor_Load(sender, e);
                    } else
                    {
                        MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void getCboData()
        {
            // get data for cbo doctor user
            this.cboDoctors.DataSource = this.database.getDoctorUserForDoctorComboBox();
            this.cboDoctors.DisplayMember = "fullName";
            this.cboDoctors.ValueMember = "id";

            // get data for cbo clinic
            this.cboClinics.DataSource = this.database.getClinicForClinicComboBox();
            this.cboClinics.DisplayMember = "clinicName";
            this.cboClinics.ValueMember = "id";

            // get data for cbo clinic
            this.cboSpecialties.DataSource = this.database.getSpecialtyForSpecialtyComboBox();
            this.cboSpecialties.DisplayMember = "specialtyName";
            this.cboSpecialties.ValueMember = "id";

            // get data for cbo price
            this.cboPrices.DataSource = this.database.getComboBoxData("PRICE");
            this.cboPrices.DisplayMember = "codeValue";
            this.cboPrices.ValueMember = "keyMap";

            // get data for cbo payment
            this.cboPayments.DataSource = this.database.getComboBoxData("PAYMENT");
            this.cboPayments.DisplayMember = "codeValue";
            this.cboPayments.ValueMember = "keyMap";

            // get data for cbo province
            this.cboProvinces.DataSource = this.database.getComboBoxData("PROVINCE");
            this.cboProvinces.DisplayMember = "codeValue";
            this.cboProvinces.ValueMember = "keyMap";
        }

        private void picDoctorImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.picDoctorImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void cboDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboDoctors.SelectedValue != null)
            {
                string selectedDoctorID = this.cboDoctors.SelectedValue.ToString();
                DataTable doctorData = this.database.getDoctorInfor(selectedDoctorID);

                if (doctorData == null || doctorData.Rows.Count == 0)
                {
                    this.hasOldDoctorData = false;
                    this.btnSaveDoctorInfor.BackColor = Color.Green;
                    this.btnSaveDoctorInfor.Text = "Thêm";
                }
                else
                {
                    this.hasOldDoctorData = true;
                    this.btnSaveDoctorInfor.BackColor = Color.Blue;
                    this.btnSaveDoctorInfor.Text = "Cập nhật";
                }
            }
        }
    }
}
