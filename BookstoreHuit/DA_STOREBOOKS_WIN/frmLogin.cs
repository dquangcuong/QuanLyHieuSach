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
using DA_STOREBOOKS_WIN.ThuNgan;

namespace DA_STOREBOOKS_WIN
{
    public partial class frmLogin : Form
    {
        NhanVien nhanvien = new NhanVien();
        NhanVienBLL nvbll = new NhanVienBLL();
        public string connectionString = "Data Source=QUANGCUONG\\SQLEXPRESS;Initial Catalog=DA_QLSACH;User ID=sa;Password=123;Integrated Security=False;";
        List<Online> listTKOnline;

        public frmLogin()
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
        public int KiemTraQuyen(string user, string pass)
        {
            int quyen = -1; // Giá trị mặc định nếu không có kết quả truy vấn

            try
            {
                string str = "SELECT Quyen FROM NhanVien WHERE UsernameNV = @UsernameNV AND PasswordNV = @PasswordNV";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(str, connection);
                    command.Parameters.AddWithValue("@UsernameNV", user);
                    command.Parameters.AddWithValue("@PasswordNV", pass);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Chuyển đổi kết quả về kiểu int
                        quyen = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy xuất quyền nhân viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return quyen;
        }
        public int KiemTraOnline(string user, string pass)
        {
            int onl = -1; // Giá trị mặc định nếu không có kết quả truy vấn

            try
            {
                string str = "SELECT  TrangThaiNV FROM NhanVien WHERE UsernameNV = @UsernameNV AND PasswordNV = @PasswordNV";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(str, connection);
                    command.Parameters.AddWithValue("@UsernameNV", user);
                    command.Parameters.AddWithValue("@PasswordNV", pass);
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Chuyển đổi kết quả về kiểu int
                        onl = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy xuất quyền nhân viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return onl;
        }
        public void CapNhatTinhTrangOnl(string user, string pass)
        {
            try
            {
                string updateQuery = "UPDATE NhanVien SET TrangThaiNV = 1 WHERE UsernameNV = @UsernameNV AND PasswordNV = @PasswordNV";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@UsernameNV", user);
                    command.Parameters.AddWithValue("@PasswordNV", pass);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        //MessageBox.Show("Cập nhật trạng thái trực tuyến thành công!");
                    }
                    else
                    {
                        //MessageBox.Show("Cập nhật trạng thái trực tuyến không thành công. Tên đăng nhập hoặc mật khẩu không đúng.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái trực tuyến: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void CapNhatTinhTrangOff(string user, string pass)
        {
            try
            {
                string updateQuery = "UPDATE NhanVien SET TrangThaiNV = 0 WHERE UsernameNV = @UsernameNV AND PasswordNV = @PasswordNV";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@UsernameNV", user);
                    command.Parameters.AddWithValue("@PasswordNV", pass);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        //MessageBox.Show("Cập nhật trạng thái offline thành công!");
                    }
                    else
                    {
                        //MessageBox.Show("Cập nhật trạng thái offline không thành công. Tên đăng nhập hoặc mật khẩu không đúng.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái offline: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            //kiểm tra Admin
            int quyen = KiemTraQuyen(nhanvien.UsernameNV, nhanvien.PasswordNV);
            int onl = KiemTraOnline(nhanvien.UsernameNV, nhanvien.PasswordNV);
            string tt = quyen.ToString() + "--" + onl.ToString();

            if (quyen == 1 && onl !=1)
            {
                listTKOnline = new List<Online>(); // Khởi tạo list
                listTKOnline.Add(new Online(nhanvien.UsernameNV, nhanvien.UsernameNV));
                MessageBox.Show("Admin đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhatTinhTrangOnl(nhanvien.UsernameNV, nhanvien.PasswordNV);
                frmMain FAD = new frmMain(nhanvien.UsernameNV, nhanvien.PasswordNV); // Khởi tạo đối tượng của frm_Admin để mở form lên
                FAD.DangXuatAdmin += FAD_DangXuatAdmin;
                FAD.Show(); // Mở form Admin lên
                this.Hide(); // Ẩn form đăng nhập đi
            }
            if(quyen == 1 && onl == 1)
            {
                MessageBox.Show("Tài khoản Admin đang được đăng nhập ở thiết bị khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if(quyen != 1 && onl != 1)
            {
                listTKOnline = new List<Online>(); // Khởi tạo list
                listTKOnline.Add(new Online(nhanvien.UsernameNV, nhanvien.UsernameNV));
                MessageBox.Show("Tài khoản nhân viên đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhatTinhTrangOnl(nhanvien.UsernameNV, nhanvien.PasswordNV);
                frmMainThuNgan FAD = new frmMainThuNgan(nhanvien.UsernameNV, nhanvien.PasswordNV); // Khởi tạo đối tượng của frm_Admin để mở form lên
                FAD.Show(); // Mở form Admin lên
                this.Hide(); // Ẩn form đăng nhập đi
            }
            if (quyen != 1 && onl == 1)
            {

                MessageBox.Show("Tài khoản nhân viên đang được đăng nhập ở thiết bị khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

        }
        private void FAD_DangXuatAdmin(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // Hiện hộp thoại xác nhận đăng xuất
            if (tb == DialogResult.Yes)
            {
                (sender as frmMain).CheckExit = false; // Tham chiếu đến biến CheckExit ở Admin
                (sender as frmMain).Close(); // Đóng form Admin
                this.Show(); // Mở lại form đăng nhập
                txt_User.Focus(); // Con trỏ chuột nháy ở textbox tên tài khoản
                nhanvien.UsernameNV = txt_User.Text.Trim().ToString();
                nhanvien.PasswordNV = txt_Password.Text.Trim().ToString();
                UDlogoutTK(nhanvien.UsernameNV, nhanvien.PasswordNV); // Chuyển trạng thái tài khoản về Offline
            }
            else
            {
                return;
            }
        }
        public void UDlogoutTK(string user, string pass) // Hàm xử lý cập nhật trang thái Offline của tài khoản
        {
            for (int i = 0; i < listTKOnline.Count; i++)
            {
                if (listTKOnline[i].Username == user && listTKOnline[i].Password == pass)
                {
                    CapNhatTinhTrangOff(user, pass);
                }
            }
        }

        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true; // Ngăn chặn xử lý mặc định của Enter hoặc phím mũi tên đi xuống
                txt_Password.Focus(); // Chuyển focus sang TextBox2
            }
        }

        private void txt_Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true; // Ngăn chặn xử lý mặc định của Enter hoặc phím mũi tên đi xuống
                txt_User.Focus(); // Chuyển focus sang TextBox2
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
