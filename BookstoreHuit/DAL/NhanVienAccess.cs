using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
   public  class NhanVienAccess:DatabaseAccess
    {
        public string CheckDangNhap(NhanVien nhanVien)
        {
            string info = CheckDangNhapDTO(nhanVien);
            return info;
        }
    }
}
