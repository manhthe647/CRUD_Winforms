using de1_TranManhThe_0205266.Controllers;
using de1_TranManhThe_0205266.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de1_TranManhThe_0205266.Views.QuanLy
{
    public partial class QuanLySv : Form
    {
        private readonly QuanLyHocSinhController _qlhsController;
        public QuanLySv()
        {
            InitializeComponent();
            _qlhsController = new QuanLyHocSinhController();
            LoadData();
            getSelectDataForComboBox();
        }

        private void LoadData()
        {

            dataGridView.DataSource = _qlhsController.loadData();
        }

        private void getSelectDataForComboBox()
        {
            List<tbl_lopquanly> listLopQuanLy = _qlhsController.getListLql();

            // Tạo đối tượng đại diện cho giá trị rỗng
            tbl_lopquanly emptyItem = new tbl_lopquanly()
            {
                lqlten = "",
                lqlma = null
            };

            // Thêm đối tượng đại diện cho giá trị rỗng vào đầu danh sách
            listLopQuanLy.Insert(0, emptyItem);


            classInput.DataSource = listLopQuanLy;
            classInput.DisplayMember = "lqlma";
            classInput.ValueMember = "lqlma";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị từ các cột của hàng được click
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                string id = row.Cells["svma"].Value.ToString().Trim();
                string name = row.Cells["svten"].Value.ToString().Trim();
                string dob = row.Cells["svngaysinh"].Value.ToString().Trim();
                string gender = row.Cells["svgioitinh"].Value.ToString();
                string address = row.Cells["svquequan"].Value.ToString().Trim();
                string lql = row.Cells["lqlma"].Value.ToString().Trim();

                // Xuất giá trị vào các trường tương ứng
                msvInput.Text = id;
                msvInput.ReadOnly = true;

                nameInput.Text = name;
                dobDtpicker.Text = dob;
                if (gender == "1")
                {
                    maleRadio.Checked = true;
                    femaleRadio.Checked = false;

                }
                else
                {
                    maleRadio.Checked = false;
                    femaleRadio.Checked = true;

                }
                addressInput.Text = address;
                classInput.Text = lql;
            }
            addBtn.Visible = false;
            updateBtn.Visible = true;
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            string id = msvInput.Text.Trim();
            string name = nameInput.Text.Trim();
            DateTime dob = dobDtpicker.Value;
            byte gender = 0; // Giới tính mặc định
            if (maleRadio.Checked)
            {
                gender = 1; // Giới tính nam
            }
            else if (femaleRadio.Checked)
            {
                gender = 0; // Giới tính nữ
            }
            string address = addressInput.Text.Trim();
            string lopql = classInput.Text.Trim();

            bool success = _qlhsController.Insert(id, name, dob, gender, address, lopql);
            if (success)
            {
                MessageBox.Show("Thêm sinh viên thành công.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Đã tồn tại mã hoặc sai dữ liệu đầu vào");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = msvInput.Text.Trim();
            if (!string.IsNullOrEmpty(id))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Xóa dữ liệu
                    _qlhsController.Delete(id);
                    ClearForm();
                    LoadData();
                }
            }

        }

        private void ClearForm()
        {
            msvInput.Text = string.Empty;
            msvInput.ReadOnly = false;

            nameInput.Text = string.Empty;
            dobDtpicker.Value = DateTime.Now;

            maleRadio.Checked = false;
            femaleRadio.Checked = false;


            addressInput.Text = string.Empty;
            classInput.Text = string.Empty;
            addBtn.Visible = true;
            updateBtn.Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            ClearForm();
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string id = msvInput.Text.Trim();
            string newName = nameInput.Text.Trim();
            DateTime newDob = dobDtpicker.Value;
            byte newGender = 0; // Giới tính mặc định
            if (maleRadio.Checked)
            {
                newGender = 1; // Giới tính nam
            }
            else if (femaleRadio.Checked)
            {
                newGender = 0; // Giới tính nữ
            }
            string newAddress = addressInput.Text.Trim();
            string newLopql = classInput.Text.Trim();

            bool success = _qlhsController.Update(id, newName, newDob, newGender, newAddress, newLopql);
            if (success)
            {
                MessageBox.Show("Cập nhật sinh viên thành công.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên hoặc đầu vào sai định dạng.");
            }
        }
    }
}