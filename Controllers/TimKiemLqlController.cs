using de1_TranManhThe_0205266.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1_TranManhThe_0205266.Controllers
{
    public class TimKiemLqlController
    {
        private readonly TranManhThe_0205266DataContext _dataContext;

        public TimKiemLqlController()
        {
            _dataContext = new TranManhThe_0205266DataContext();
        }

        public List<tbl_lopquanly> LoadData()
        {
            var result = _dataContext.tbl_lopquanlies.ToList();
            return result;
        }

        public List<tbl_lopquanly> Search(string keyword)
        {
            var result = _dataContext.tbl_lopquanlies.Where(x=>x.lqlma.Equals(keyword)).ToList();

            return result;
        }
    }
}
