using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienAccess nvAccess = new NhanVienAccess();
        public string CheckDangNhap(NhanVien nhanVien)
        {
           if(nhanVien.UsernameNV == "")
           {
                return "required_nhanvien";
           }
           if (nhanVien.PasswordNV == "")
           {
                return "required_matkhau";
           }
            string info = nvAccess.CheckDangNhap(nhanVien);
            return info;
        }
    }
}
