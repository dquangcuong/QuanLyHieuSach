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

namespace DA_STOREBOOKS_WIN
{
    public partial class frmNhanVien : Form
    {
        //CÁC HÀM CÓ THỂ DÙNG LẠI, CHỈ CẦN TRUYỀN THAM SÔ
        //Hàm lấy dữ liệu lên DataGridView
        public string connectionString = "Data Source=QUANGCUONG\\SQLEXPRESS;Initial Catalog=DA_QLSACH;User ID=sa;Password=123;Integrated Security=False;";

        public void load_DSSach(string str, DataGridView dtv)
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(str, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh sách nhân viên.\n => Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void load_DSSachDoiTenCotNhanVien(string str, DataGridView dtv)
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(str, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                // Đảm bảo các cột tồn tại trong DataGridView trước khi đổi tên
                if (dtv.Columns.Contains("MaNV"))
                    dtv.Columns["MaNV"].HeaderText = "Mã nhân viên";
                if (dtv.Columns.Contains("TenNV"))
                    dtv.Columns["TenNV"].HeaderText = "Tên nhân viên";
                if (dtv.Columns.Contains("UsernameNV"))
                    dtv.Columns["UsernameNV"].HeaderText = "Tên đăng nhập";
                if (dtv.Columns.Contains("PasswordNV"))
                    dtv.Columns["PasswordNV"].HeaderText = "Mật khẩu";
                if (dtv.Columns.Contains("Quyen"))
                    dtv.Columns["Quyen"].HeaderText = "Quyền";
                if (dtv.Columns.Contains("TrangThaiNV"))
                    dtv.Columns["TrangThaiNV"].HeaderText = "Trạng thái";
                if (dtv.Columns.Contains("NgayTaoNV"))
                    dtv.Columns["NgayTaoNV"].HeaderText = "Ngày tạo";

                // Hiển thị dữ liệu trong DataGridView
                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên grid nhân viên. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Hàm để truy vấn insert into, update, delete
        public void load_TruyVan(string str)
        {
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();

            }

        }
        //Hàm lấy dữ liệu lên ComBoBox
        public void load_ComBoBox(string str, ComboBox cb)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(str, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();

                    // Clear existing items in the ComboBox
                    cb.Items.Clear();

                    // Loop through the result set and add items to the ComboBox
                    while (reader.Read())
                    {
                        cb.Items.Add(reader.GetString(0)); // Change the index if needed
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error load combobox: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public void HienThiLenGirdNhanVien()
        {
            string str = "SELECT * FROM NhanVien";
            load_DSSach(str, grid_NhanVien);
            load_DSSachDoiTenCotNhanVien(str, grid_NhanVien);
            grid_NhanVien.ClearSelection();
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiLenGirdNhanVien();
        }

        //Hàm kiểm tra
        private bool KiemTraUserNameTonTai(string Username)
        {
            bool kq = true; // Giả sử tên khách hàng đã tồn tại

        string scon = "Data Source=QUANGCUONG\\SQLEXPRESS;Initial Catalog=DA_QLSACH;User ID=sa;Password=123;Integrated Security=False;";

            string sSql = "SELECT COUNT(*) FROM NhanVien WHERE UsernameNV = @username";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(scon))
                {
                    using (SqlCommand myCommand = new SqlCommand(sSql, myConnection))
                    {
                        // Thêm tham số vào truy vấn để tránh tấn công SQL injection
                        myCommand.Parameters.AddWithValue("@username", Username);

                        // Mở kết nối và thực thi truy vấn
                        myConnection.Open();
                        int numRows = (int)myCommand.ExecuteScalar();

                        // Nếu số hàng trả về từ truy vấn là 0, tên khách hàng chưa tồn tại
                        if (numRows == 0)
                        {
                            kq = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                kq = false;
                MessageBox.Show("Lỗi kiểm tra username tồn tại.\n Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return kq;
        }
        private bool KiemTraRong()
        {
            bool kq = false; //không rỗng
            if (string.IsNullOrEmpty(txt_TenNV.Text.Trim()) ||
                string.IsNullOrEmpty(txt_User.Text.Trim()) ||
                string.IsNullOrEmpty(txt_Password.Text.Trim()) ||
                string.IsNullOrEmpty(txt_User.Text.Trim()) ||
                string.IsNullOrEmpty(cb_QuyenNV.Text.Trim()) )
            {
                kq = true;
            }
            return kq;
        }
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra rỗng
                bool kiemRong = KiemTraRong();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                // Kiểm tra xem tên khách hàng đã tồn tại trong cơ sở dữ liệu chưa

                string username = txt_User.Text.Trim();

                bool usernameTonTai = KiemTraUserNameTonTai(username);

                if (usernameTonTai)
                {
                    MessageBox.Show("Username đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }
                string maNV = txt_MaNV.Text.Trim();
                string tenNV = txt_TenNV.Text.Trim();
                string password = txt_Password.Text.Trim();
                string quyen = cb_QuyenNV.Text;
                string quyenNV = (quyen == "Quản lý") ? "1" : "0";                
                //string trangThaiNV = cb_TrangThaiNV.Text;
                //string trangThaiNVValue = (trangThaiNV == "Active") ? "1" : "0";
                int trangThaiNV = 0;
                DateTime ngayTaoNV = dt_NgayTaoNV.Value;

                load_TruyVan($"INSERT INTO NhanVien (TenNV, UsernameNV, PasswordNV, Quyen, TrangThaiNV, NgayTaoNV) VALUES (N'{tenNV}', N'{username}', N'{password}', '{quyenNV}', '{trangThaiNV}', '{ngayTaoNV.ToString("yyyy-MM-dd")}')");

                MessageBox.Show("Nhân viên đã được thêm vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiLenGirdNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên vào databse.\n: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_LamMoiNV_Click(object sender, EventArgs e)
        {
            txt_MaNV.Text = "";
            txt_TenNV.Text = "";
            txt_User.Text = "";
            txt_Password.Text = "";
            cb_QuyenNV.SelectedItem = null;
            cb_TrangThaiNV.SelectedItem = null;
            if (DateTime.Now > dt_NgayTaoNV.MaxDate || DateTime.Now < dt_NgayTaoNV.MinDate)
            {
                dt_NgayTaoNV.MinDate = DateTime.Now.AddDays(-365 * 20); // Thiết lập MinDate là một năm trước
                dt_NgayTaoNV.MaxDate = DateTime.Now.AddDays(365); // Thiết lập MaxDate là một năm sau
            }

            dt_NgayTaoNV.Value = DateTime.Now;

            txt_TimNV.Text = "";
            HienThiLenGirdNhanVien();
            grid_NhanVien.ClearSelection();

        }

        private void btn_CapNhatNV_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra rỗng
                bool kiemRong = KiemTraRong();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                string username = txt_User.Text.Trim();
                string maNV = txt_MaNV.Text.Trim();
                string tenNV = txt_TenNV.Text.Trim();
                string password = txt_Password.Text.Trim();
                string quyen = cb_QuyenNV.Text;
                string quyenNV = (quyen == "Quản lý") ? "1" : "0";
                //string trangThaiNV = cb_TrangThaiNV.Text;
                //string trangThaiNVValue = (trangThaiNV == "Active") ? "1" : "0";
                DateTime ngayTaoNV = dt_NgayTaoNV.Value;

                load_TruyVan($"UPDATE NhanVien SET TenNV = N'{tenNV}', UsernameNV = N'{username}', PasswordNV = N'{password}', Quyen = '{quyenNV}', NgayTaoNV = '{ngayTaoNV.ToString("yyyy-MM-dd")}' WHERE MaNV = '{maNV}'");

                MessageBox.Show("Dữ Liệu đã được cập nhật vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiLenGirdNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật thông tin nhân viên vào database: \n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            string maNV = txt_MaNV.Text.Trim();
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Không tìm thấy mã nhân viên để xóa: \n ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string tenNV = txt_TenNV.Text.Trim();
            string username = txt_User.Text.Trim();
            //string password = txt_Password.Text.Trim();
            string quyen = cb_QuyenNV.Text;
            string trangThaiNV = cb_TrangThaiNV.Text;
            DateTime ngayTaoNV = dt_NgayTaoNV.Value;

            string thongTin = "";
            thongTin += $"Bạn có muốn xóa Nhân viên có thông tin: \n";
            thongTin += $"Mã nhân viên: {maNV}\n";
            thongTin += $"Họ tên: {tenNV}\n";
            thongTin += $"Username: {username}\n";
            thongTin += $"Quyên: {quyen}\n";
            thongTin += $"Ngày tạo: {ngayTaoNV}\n";
            thongTin += $"Trạng thái: {trangThaiNV}\n";
            DialogResult dlg = MessageBox.Show(thongTin, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                try
                {
                    load_TruyVan($"DELETE FROM NhanVien WHERE MaNV = '{maNV}'");

                    // Hiển thị thông báo và làm mới danh sách sách
                    MessageBox.Show("Dữ liệu đã được xóa khỏi cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiLenGirdNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên trong databse:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_TimNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimNV.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền thông tin nhân viên cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string timNV = txt_TimNV.Text.Trim();

            string str = $"SELECT * FROM NhanVien WHERE MaNV LIKE N'%{timNV}%' OR UsernameNV LIKE N'%{timNV}%'";
            load_DSSach(str, grid_NhanVien);
            load_DSSachDoiTenCotNhanVien(str, grid_NhanVien);
        }

        private void grid_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = grid_NhanVien.CurrentCell.RowIndex;

            if (rowIndex >= 0 && rowIndex < grid_NhanVien.Rows.Count)
            {
                DataGridViewRow row = grid_NhanVien.Rows[rowIndex];

                if (row.Cells[0].Value != null)
                {
                    txt_MaNV.Text = row.Cells[0].Value.ToString();
                }
                if (row.Cells[1].Value != null)
                {
                    txt_TenNV.Text = row.Cells[1].Value.ToString();
                }
                if (row.Cells[2].Value != null)
                {
                    txt_User.Text = row.Cells[2].Value.ToString();
                }
                if (row.Cells[3].Value != null)
                {
                    txt_Password.Text = row.Cells[3].Value.ToString();
                }
                if (row.Cells[4].Value != null)
                {
                    string quyen = row.Cells[4].Value.ToString();
                    if (quyen == "1")
                    {
                        cb_QuyenNV.SelectedIndex = 0;
                    }
                    else cb_QuyenNV.SelectedIndex = 1;
                }
                if (row.Cells[5].Value != null)
                {
                    string trangThai = row.Cells[5].Value.ToString();
                    if (trangThai == "1")
                    {
                        cb_TrangThaiNV.SelectedIndex = 0;
                    }
                    else cb_TrangThaiNV.SelectedIndex = 1;
                }
                if (row.Cells[6].Value != null)
                {
                    if (DateTime.TryParse(row.Cells[6].Value.ToString(), out DateTime ngayTaoKH))
                    {
                        dt_NgayTaoNV.Value = ngayTaoKH;
                    }
                    else
                    {
                        // Xử lý nếu giá trị không hợp lệ
                        // gán mặc định hoặc hiển thị thông báo lỗi
                    }
                }
              
            }
        }

        //Hàm hiện mật khẩu
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
    }
}
