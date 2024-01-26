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
    public partial class TimKiemLopQuanLy : Form
    {
        private TimKiemLqlController _tklqlController;

        public TimKiemLopQuanLy()
        {
            InitializeComponent();
            _tklqlController = new TimKiemLqlController();
            LoadData();
        }

        private void LoadData()
        {
            tklql_dataGridView.DataSource= _tklqlController.LoadData();
        }

    

        private void searchLqlBtn_Click(object sender, EventArgs e)
        {
            var keyword = tklqlSearchInput.Text.Trim();
            tklql_dataGridView.DataSource=_tklqlController.Search(keyword);
        }
    }
}
