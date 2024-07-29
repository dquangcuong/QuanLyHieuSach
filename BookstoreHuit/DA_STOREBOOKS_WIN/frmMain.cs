using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_STOREBOOKS_WIN
{
    public partial class frmMain : Form
    {
        // Tạo biến kiểm tra điều kiện đóng form
        public bool CheckExit = true;
        public string connectionString = "Data Source=QUANGCUONG\\SQLEXPRESS;Initial Catalog=DA_QLSACH;User ID=sa;Password=123;Integrated Security=False;";
        private string userName;
        private string passWord;

        public frmMain(string userName ="", string passWord ="")
        {
            InitializeComponent();
            this.userName = userName;
            this.passWord = passWord;
        }

        public void TaiKhoanDangNhap()
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord))
            {
                lblPhienDangNhap.Text = "Tài khoản:" + userName;
            }
            else
            {
                lblPhienDangNhap.Text = "Phiên đăng nhập rỗng.";
            }
        }
        //ĐĂNG XUẤT
        public event EventHandler DangXuatAdmin; // Tạo even ủy thác đăng xuất Admin

        public event EventHandler ThoatFromAdmin; // Tạo even ủy thác thoát ứng dụng Admin
        // Khai báo form hiện tại của admin là rỗng
        private Form formParent; 

        public void openFormChild(Form formChild) // Hàm mở form con của admin
        {
            if (formParent != null) // Nếu form hiện tại khác rỗng thì đóng form hiện tại lại
            {
                formParent.Close();
            }

            formChild.TopLevel = false; // Dùng để tạo biểu mẫu cấp cao nhất
            formChild.FormBorderStyle = FormBorderStyle.None; // dùng để tạo cửa sổ công cụ
            formChild.Dock = DockStyle.Fill; // Điều khiển lấp đầy
            panel_Main.Controls.Add(formChild); // Dùng để form admin tham chiếu đến các form con của mình
            panel_Main.Tag = formChild; // dùng để thay thế form admin thành form con của nó
            formChild.BringToFront(); // Hàm gọi form con để hiển thị
           
            // Thiết lập form ở chế độ full màn hình
            formChild.WindowState = FormWindowState.Maximized;
            // Ngăn người dùng có thể thay đổi kích thước của form
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Show(); // Mở form con lên
        }

        private void btn_ControlSach_Click(object sender, EventArgs e)
        {
            openFormChild(new frmSach());
        }

        private void btn_ControlHoaDon_Click(object sender, EventArgs e)
        {
            openFormChild(new frmHoaDon());
        }

        private void btn_ControlKhach_Click(object sender, EventArgs e)
        {
            openFormChild(new frmKhachHang());
        }

        private void btn_ControlPhieuNhap_Click(object sender, EventArgs e)
        {
            openFormChild(new frmPhieuNhap());
        }

        private void btn_ControlNhanVien_Click(object sender, EventArgs e)
        {
            openFormChild(new frmNhanVien());
        }

        private void btn_ControlThongKe_Click(object sender, EventArgs e)
        {
            openFormChild(new frmThongKe());
        }
        public void CapNhatTinhTrangOFF(string user, string pass)
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
                MessageBox.Show("Lỗi khi cập nhật trạng thái offline: " + ex.Message);
            }
        }
        private bool isLoggingOut = false;

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận đăng xuất
            DialogResult dlg = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dlg == DialogResult.OK)
            {
                // Đặt lại trạng thái trực tuyến của người dùng
                CapNhatTinhTrangOFF(this.userName, this.passWord);
                // Hiển thị thông báo đăng xuất thành công
                MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Thiết lập biến cờ để biết rằng việc đóng form là do đăng xuất
                isLoggingOut = true;

                // Đóng Form hiện tại
                this.Close();
                // Mở Form đăng nhập
                frmLogin frm = new frmLogin();
                frm.Show();
            }
            
        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {
            if (formParent != null)
            {
                formParent.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Thiết lập form ở chế độ full màn hình
            //this.WindowState = FormWindowState.Maximized;
            //// Ngăn người dùng có thể thay đổi kích thước của form
            //this.FormBorderStyle = FormBorderStyle.None;
            // Tính toán kích thước và vị trí của form con
            int width = panel_Main.Width; // Lấy chiều rộng của panel_Main
            int height = panel_Main.Height; // Lấy chiều cao của panel_Main
            int x = 0; // Đặt vị trí x của form con là 0 (phía bên trái)
            int y = 0; // Đặt vị trí y của form con là 0 (phía trên cùng)

            // Thiết lập kích thước và vị trí của form con
            this.Size = new Size(width, height);
            this.Location = new Point(x, y);
            TaiKhoanDangNhap();
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLoggingOut && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dlg = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dlg == DialogResult.Cancel)
                {
                    // Hủy sự kiện đóng Form
                    e.Cancel = true;
                }
                else if (dlg == DialogResult.OK)
                {
                    // Đặt lại trạng thái trực tuyến của người dùng
                    CapNhatTinhTrangOFF(this.userName, this.passWord);
                    // Hiển thị thông báo đăng xuất thành công
                    MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void panel_Container_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
