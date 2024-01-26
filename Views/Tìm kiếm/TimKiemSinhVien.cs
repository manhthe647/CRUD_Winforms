using de1_TranManhThe_0205266.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de1_TranManhThe_0205266.Views.Tìm_kiếm
{
    public partial class TimKiemSinhVien : Form
    {
        private TimKiemHocSinhController _tkhsController;
        public TimKiemSinhVien()
        {
            InitializeComponent();
            _tkhsController= new TimKiemHocSinhController();
            LoadData();

        }

        private void TimKiemHocSinh_Load(object sender, EventArgs e)
        {

        }
        
        private void LoadData()
        {
            tknv_dataGridView.DataSource = _tkhsController.LoadData();
        }
       
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword= searchInput.Text.Trim();
             tknv_dataGridView.DataSource= _tkhsController.Search(keyword);
        }
    }
}
