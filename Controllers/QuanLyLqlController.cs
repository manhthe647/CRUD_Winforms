using de1_TranManhThe_0205266.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1_TranManhThe_0205266.Controllers
{
    public class QuanLyLqlController
    {
        private readonly TranManhThe_0205266DataContext _dataContext;
        public QuanLyLqlController()
        {
            _dataContext = new TranManhThe_0205266DataContext();
        }
        public List<tbl_lopquanly> loadData()
        {
            var result = _dataContext.tbl_lopquanlies.ToList();
            return result;
        }
    }
}
