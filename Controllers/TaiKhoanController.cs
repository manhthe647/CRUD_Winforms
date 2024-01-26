using de1_TranManhThe_0205266.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1_TranManhThe_0205266.Controllers
{
    public class TaiKhoanController
    {
        private readonly TranManhThe_0205266DataContext _dataContext;
        public TaiKhoanController()
        {
            _dataContext= new TranManhThe_0205266DataContext();
        }

        public bool Login(string taikhoan, string matkhau)
        {
            var isValid = _dataContext.tbl_taikhoans.SingleOrDefault(x=>x.tktaikhoan.Equals(taikhoan) && x.tkmatkhau.Equals(matkhau));
            if (isValid == null)
            {
                return false;
            }
            return true;
        }

    }
}
