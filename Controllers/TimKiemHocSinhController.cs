using de1_TranManhThe_0205266.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1_TranManhThe_0205266.Controllers
{
    public class TimKiemHocSinhController
    {
        private readonly TranManhThe_0205266DataContext _dataContext;
        public TimKiemHocSinhController()
        {
            _dataContext= new TranManhThe_0205266DataContext();
        }

        public List<tbl_sinhvien> LoadData()
        {
            var result= _dataContext.tbl_sinhviens.ToList();
            return result;
        }

        public List<tbl_sinhvien> Search(string keyword)
        {
            var result = _dataContext.tbl_sinhviens
                .Where(x => x.svten.Contains(keyword))
                .ToList();

            return result;
        }
    }
}
