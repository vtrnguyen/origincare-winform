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
    public partial class ManageSpecialty : Form
    {
        private Database database = new Database();
        private ImageConverter imageConverter = new ImageConverter();
        private bool isAddButton;

        public ManageSpecialty()
        {
            InitializeComponent();
        }

        private void ManageSpecialty_Load(object sender, EventArgs e)
        {
            this.dgvSpecialties.DataSource = this.database.getAllSpecialty();
            this.isAddButton = true;

            if (this.isAddButton)
            {
                this.btnConfirmAddAndEditSpecialty.Text = "Thêm thông tin";
            } else
            {
                this.btnConfirmAddAndEditSpecialty.Text = "Cập nhật";
            }
        }
        private void picSpecialtyImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.picSpecialtyImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnConfirmAddAndEditSpecialty_Click(object sender, EventArgs e)
        {
            if (this.txtSpecialtyName.Text == "" || this.rtbSpecialtyDescription.Text == "" ||
                this.picSpecialtyImage.Image == null)
            {
                MessageBox.Show("Không được để trống thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {

                string specialtyName = this.txtSpecialtyName.Text;
                string specialtyDescription = this.rtbSpecialtyDescription.Text;
                byte[] specialtyImage = this.imageConverter.changeImageToByteArray(this.picSpecialtyImage.Image);

                if (this.isAddButton)
                {
                    if (this.database.createSpecialty(specialtyName, specialtyDescription, specialtyImage))
                    {
                        MessageBox.Show("Tạo mới chuyên khoa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ManageSpecialty_Load(sender, e);
                        this.emptyInput();
                    }
                    else
                    {
                        MessageBox.Show("Tạo mới chuyên khoa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }

                if (!this.isAddButton)
                {
                    int currentRow = this.dgvSpecialties.CurrentCell.RowIndex;
                    string specialtyID = this.dgvSpecialties.Rows[currentRow].Cells[0].Value.ToString();

                    if (this.database.updateSpecialty(specialtyID, specialtyName, specialtyDescription, specialtyImage))
                    {
                        MessageBox.Show("Cập nhật chuyên khoa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.isAddButton = true;
                        this.ManageSpecialty_Load(sender, e);
                        this.emptyInput();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật chuyên khoa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditSpecialty_Click(object sender, EventArgs e)
        {
            this.isAddButton = false;
            this.btnConfirmAddAndEditSpecialty.Text = "Cập nhật";

            int currentRow = this.dgvSpecialties.CurrentCell.RowIndex;
            string updateSpecialtyName = this.dgvSpecialties.Rows[currentRow].Cells[1].Value.ToString();
            string updateSpecialtyDescription = this.dgvSpecialties.Rows[currentRow].Cells[2].Value.ToString();

            byte[] imageData = (byte[])this.dgvSpecialties.Rows[currentRow].Cells[3].Value;
            Image updateClinicImage = this.imageConverter.convertByteArrayToImage(imageData);

            this.txtSpecialtyName.Text = updateSpecialtyName;
            this.rtbSpecialtyDescription.Text = updateSpecialtyDescription;
            this.picSpecialtyImage.Image = updateClinicImage;
        }

        private void btnDeleteSpecialty_Click(object sender, EventArgs e)
        {
            int currentRow = this.dgvSpecialties.CurrentCell.RowIndex;
            string deleteSpecialtyID = this.dgvSpecialties.Rows[currentRow].Cells[0].Value.ToString();
            string deleteSpecialtyName = this.dgvSpecialties.Rows[currentRow].Cells[1].Value.ToString();

            DialogResult confirmResult =
                MessageBox.Show($"Bạn có chắc chắn muốn xóa người dùng {deleteSpecialtyName} không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (this.database.deleteSpecialty(deleteSpecialtyID))
                {
                    MessageBox.Show($"Xóa chuyên khoa '{deleteSpecialtyName}' thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.ManageSpecialty_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa chuyên khoa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void emptyInput()
        {
            this.txtSpecialtyName.Text = "";
            this.rtbSpecialtyDescription.Text = "";
            this.picSpecialtyImage.Image = Properties.Resources.addPicture;
        }
    }
}
