using de1_TranManhThe_0205266.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de1_TranManhThe_0205266.Controllers
{
    public class QuanLyHocSinhController
    {
        private readonly TranManhThe_0205266DataContext _dataContext;
        public QuanLyHocSinhController()
        {
            _dataContext= new TranManhThe_0205266DataContext();
        }

        public List<tbl_sinhvien> loadData()
        {
            var result= _dataContext.tbl_sinhviens.ToList();
            return result;
        }

        public List<tbl_lopquanly> getListLql()
        {
            var result = _dataContext.tbl_lopquanlies.ToList();
            return result;
        }

        public bool Insert(string id, string name, DateTime dob, byte gender, string address, string lopql )
        {
            var checkId= _dataContext.tbl_sinhviens.FirstOrDefault(x=>x.svma.Equals(id));
            if (checkId != null)
            {
                return false;
            }
            var checkLql = _dataContext.tbl_lopquanlies.FirstOrDefault(x => x.lqlma.Equals(lopql));
            if (checkLql != null)
            {
            var newSinhvien = new tbl_sinhvien()
            {
                svma = id,
                svten = name,
                svngaysinh = dob,
                svgioitinh = gender,
                svquequan= address,
                lqlma= lopql
                 
            };
            _dataContext.tbl_sinhviens.InsertOnSubmit(newSinhvien);
            _dataContext.SubmitChanges();
            return true;

            }
            
            return false;
        }

        public bool Update(string id, string newName, DateTime newDob, byte newGender, string newAddress, string newLopql)
        {
            var sinhVien = _dataContext.tbl_sinhviens.FirstOrDefault(x => x.svma.Equals(id));
            if (sinhVien != null)
            {
                var checkLql = _dataContext.tbl_lopquanlies.FirstOrDefault(x => x.lqlma.Equals(newLopql));
                if (checkLql != null)
                {
                    sinhVien.svten = newName;
                    sinhVien.svngaysinh = newDob;
                    sinhVien.svgioitinh = newGender;
                    sinhVien.svquequan = newAddress;
                    sinhVien.lqlma = newLopql;

                    _dataContext.SubmitChanges();
                    return true;
                }
            }

            return false;
        }


        public bool Delete(string id)
        {
            var sinhVien = _dataContext.tbl_sinhviens.FirstOrDefault(sv => sv.svma == id);
            if (sinhVien != null)
            {
                _dataContext.tbl_sinhviens.DeleteOnSubmit(sinhVien);
                _dataContext.SubmitChanges();
                return true;
            }
            else
            {
                return false; // Không tìm thấy sinh viên cần xóa
            }
        }
    }
}
