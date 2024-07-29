using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BLL;

namespace DA_STOREBOOKS_WIN
{
    public partial class frmDangNhap : Form
    {
        NhanVien nhanvien = new NhanVien();
        NhanVienBLL nvbll = new NhanVienBLL();
        public frmDangNhap()
        {
            InitializeComponent();
            txt_Password.UseSystemPasswordChar = true;

        }
        private void chk_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái của hộp kiểm
            if (chk_HienMatKhau.Checked)
            {
                // Nếu được chọn, hiển thị mật khẩu bằng cách thiết lập UseSystemPasswordChar thành false
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                // Nếu không được chọn, ẩn mật khẩu bằng cách thiết lập UseSystemPasswordChar thành true
                txt_Password.UseSystemPasswordChar = true;
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            nhanvien.UsernameNV = txt_User.Text.Trim().ToString();
            nhanvien.PasswordNV = txt_Password.Text.Trim().ToString();

            string getuser = nvbll.CheckDangNhap(nhanvien);
            switch (getuser)
            {
                case "required_nhanvien":
                   MessageBox.Show("Bạn chưa nhập tên đăng nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "required_matkhau":
                    MessageBox.Show("Bạn chưa nhập mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmMain FAD = new frmMain(); // Khởi tạo đối tượng của frm_Admin để mở form lên
            FAD.Show(); // Mở form Admin lên
            this.Hide(); // Ẩn form đăng nhập đi
        }
    }
}
