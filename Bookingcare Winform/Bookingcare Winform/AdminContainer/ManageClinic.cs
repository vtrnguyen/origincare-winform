using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bookingcare_Winform.AdminContainer
{
    public partial class ManageClinic : Form
    {
        private Database database = new Database();
        private ImageConverter imageConverter = new ImageConverter();
        private bool isAddClinicButton = true;

        public ManageClinic()
        {
            InitializeComponent();
        }

        private void ManageClinic_Load(object sender, EventArgs e)
        {
            this.isAddClinicButton = true;
            this.dgvClinics.DataSource = this.database.getAllClinic();

            if (this.isAddClinicButton)
            {
                this.btnAddAndEditClinic.Text = "Thêm thông tin";
            } else
            {
                this.btnAddAndEditClinic.Text = "Lưu thông tin";
            }
        }

        private void picClinicImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.picClinicImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAddAndUpdateClinic_Click(object sender, EventArgs e)
        {
            if (this.txtClinicName.Text == "" || this.txtClinicAddress.Text == "" ||
                this.txtClinicDescription.Text == "" || this.picClinicImage.Image == null)
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                string clinicName = this.txtClinicName.Text;
                string clinicAddress = this.txtClinicAddress.Text;
                string clinicDescription = this.txtClinicDescription.Text;
                byte[] clinicImage = this.imageConverter.changeImageToByteArray(this.picClinicImage.Image);

                if (this.isAddClinicButton)
                {
                    if (this.database.createClinic(clinicName, clinicAddress, clinicDescription, clinicImage))
                    {
                        MessageBox.Show("Thêm cơ sở mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.emptyInput();
                        this.ManageClinic_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm cơ sở thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (!this.isAddClinicButton)
                {
                    int currentUpdateRow = this.dgvClinics.CurrentCell.RowIndex;
                    string clinicID = this.dgvClinics.Rows[currentUpdateRow].Cells[0].Value.ToString();

                    if (this.database.updateClinic(clinicID, clinicName, clinicAddress, clinicDescription, clinicImage))
                    {
                        MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.emptyInput();
                        this.ManageClinic_Load(sender, e);
                    } else
                    {
                        MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditClinic_Click(object sender, EventArgs e)
        {
            this.btnAddAndEditClinic.Text = "Lưu thông tin";

            int currentRow = this.dgvClinics.CurrentCell.RowIndex;
            string updateClinicID = this.dgvClinics.Rows[currentRow].Cells[0].Value.ToString();
            string updateClinicName = this.dgvClinics.Rows[currentRow].Cells[1].Value.ToString();
            string updateClinicAddress = this.dgvClinics.Rows[currentRow].Cells[2].Value.ToString();
            string updateClinicDescription = this.dgvClinics.Rows[currentRow].Cells[3].Value.ToString();

            byte[] imageData = (byte[])this.dgvClinics.Rows[currentRow].Cells[4].Value;
            Image updateClinicImage = this.imageConverter.convertByteArrayToImage(imageData);

            this.txtClinicName.Text = updateClinicName;
            this.txtClinicAddress.Text = updateClinicAddress;
            this.txtClinicDescription.Text = updateClinicDescription;
            this.picClinicImage.Image = updateClinicImage;

            this.isAddClinicButton = false;
        }

        private void btnDeleteClinic_Click(object sender, EventArgs e)
        {
            int currentRow = this.dgvClinics.CurrentCell.RowIndex;
            string deleteClinicID = this.dgvClinics.Rows[currentRow].Cells[0].Value.ToString();
            string deleteClinicName = this.dgvClinics.Rows[currentRow].Cells[1].Value.ToString();

            DialogResult confirmResult =
                MessageBox.Show($"Bạn có chắc chắn muốn xóa cơ sở {deleteClinicName} không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (this.database.deleteClinic(deleteClinicID))
                {
                    MessageBox.Show($"Xóa cơ sở '{deleteClinicName}' thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.ManageClinic_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEmptyInput_Click(object sender, EventArgs e)
        {
            this.btnAddAndEditClinic.Text = "Thêm thông tin";
            this.emptyInput();
        }

        private void emptyInput()
        {
            this.isAddClinicButton = true;
            this.txtClinicName.Text = "";
            this.txtClinicAddress.Text = "";
            this.txtClinicDescription.Text = "";
            this.picClinicImage.Image = Properties.Resources.addPicture;
        }
    }
}
