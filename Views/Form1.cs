
using de1_TranManhThe_0205266.Controllers;
using de1_TranManhThe_0205266.Views.QuanLy;
using de1_TranManhThe_0205266.Views.Tìm_kiếm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de1_TranManhThe_0205266.Views
{
    public partial class Form1 : Form
    {
        private readonly TaiKhoanController _taikhoanController;
        public Form1()
        {
            InitializeComponent();
            _taikhoanController = new TaiKhoanController();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string taikhoan= taikhoanInput.Text.Trim();
            string matkhau= matkhauInput.Text.Trim();
            if(taikhoan == "" || matkhau == "")
            {
                MessageBox.Show("Vui lòng điền thông tin");
            }
            var result = _taikhoanController.Login(taikhoan, matkhau);
            if (!result)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu ");
            }
            else {
                loginPanel.Visible = false;
                menuToolStripMenuItem.Visible = true;
                mainPanel.Visible = true;

              
            }
        }

        private void qlhsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySv f = new QuanLySv();
            f.TopLevel= false;

            f.Width = mainPanel.Width;
            f.Height= mainPanel.Height;
            f.Dock = DockStyle.Fill;
            f.Show();

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(f);
        }

        private void tkhsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemSinhVien f = new TimKiemSinhVien();
            f.TopLevel = false;

            f.Width = mainPanel.Width;
            f.Height = mainPanel.Height;
            f.Dock = DockStyle.Fill;
            f.Show();

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(f);
        }

        private void tklqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemLopQuanLy f = new TimKiemLopQuanLy();
            f.TopLevel = false;

            f.Width = mainPanel.Width;
            f.Height = mainPanel.Height;
            f.Dock = DockStyle.Fill;
            f.Show();

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(f);
        }

        private void qllqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLql f = new QuanLyLql();
            f.TopLevel = false;

            f.Width = mainPanel.Width;
            f.Height = mainPanel.Height;
            f.Dock = DockStyle.Fill;
            f.Show();

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(f);
        }
    }
}
