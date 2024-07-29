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
using System.Text.RegularExpressions;

namespace DA_STOREBOOKS_WIN
{
    public partial class frmKhachHang : Form
    {
        //CÁC HÀM CÓ THỂ DÙNG LẠI, CHỈ CẦN TRUYỀN THAM SÔ
        //Hàm lấy dữ liệu lên DataGridView
        public string connectionString = "Data Source=QUANGCUONG\\SQLEXPRESS;Initial Catalog=DA_QLSACH;User ID=sa;Password=123;Integrated Security=False;";

        //Load ds từ csdl lên gridview
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
                MessageBox.Show("Lỗi kết nối Database. \n => Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void load_DSSachDoiTenKhachHang(string str, DataGridView dtv)
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(str, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                // Đảm bảo các cột tồn tại trong DataGridView trước khi đổi tên
                if (dtv.Columns.Contains("MaKH"))
                    dtv.Columns["MaKH"].HeaderText = "Mã khách hàng";
                if (dtv.Columns.Contains("TenKH"))
                    dtv.Columns["TenKH"].HeaderText = "Tên khách hàng";
                if (dtv.Columns.Contains("SDT_KH"))
                    dtv.Columns["SDT_KH"].HeaderText = "Số điện thoại";
                if (dtv.Columns.Contains("NgayTaoKH"))
                    dtv.Columns["NgayTaoKH"].HeaderText = "Ngày tạo";
                if (dtv.Columns.Contains("TrangThaiKH"))
                    dtv.Columns["TrangThaiKH"].HeaderText = "Trạng thái";

                // Hiển thị dữ liệu trong DataGridView
                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên grid Khách Hàng. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Lỗi hàm load_Combobox: \n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void HienThiLenGrid()
        {
            string str = "SELECT * FROM KhachHang";

            load_DSSach(str, grid_KhachHang);
            load_DSSachDoiTenKhachHang(str, grid_KhachHang);
            grid_KhachHang.ClearSelection();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiLenGrid();
            if (DateTime.Now > dt_NgayTaoKH.MaxDate || DateTime.Now < dt_NgayTaoKH.MinDate)
            {
                dt_NgayTaoKH.MinDate = DateTime.Now.AddDays(-365 * 20); // Thiết lập MinDate là một năm trước
                dt_NgayTaoKH.MaxDate = DateTime.Now.AddDays(365); // Thiết lập MaxDate là một năm sau
            }

            dt_NgayTaoKH.Value = DateTime.Now;
            dt_NgayTaoKH.MaxDate = DateTime.Now;
        }

        private bool KiemTraTenKHTonTai(string tenKH)
        {
            bool kq = true; // Giả sử tên khách hàng đã tồn tại
            string sSql = "SELECT COUNT(*) FROM KhachHang WHERE TenKH = @tenKH";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand myCommand = new SqlCommand(sSql, myConnection))
                    {
                        // Thêm tham số vào truy vấn để tránh tấn công SQL injection
                        myCommand.Parameters.AddWithValue("@tenKH", tenKH);

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
                MessageBox.Show("Lỗi kiểm tra khách hàng tồn tại. \n Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return kq;
        }
        private bool KiemTraRong()
        {
            bool kq = false; //không rỗng
            if(string.IsNullOrEmpty(txt_TenKH.Text.Trim()) ||
                string.IsNullOrEmpty(txt_sdtKH.Text.Trim()) ||
                string.IsNullOrEmpty(cb_TrangThaiKH.Text.Trim()) )
            {
                kq = true;
            }
            return kq;
        }
        private bool KiemTraSoDienThoai(string soDienThoai)
        {
            // Sử dụng biểu thức chính quy để kiểm tra chuỗi số điện thoại
            // Biểu thức chính quy này kiểm tra xem chuỗi có chứa 10-11 chữ số và bắt đầu bằng số 0 hoặc 84 không
            // Bạn có thể điều chỉnh biểu thức chính quy này để phù hợp với quy ước về số điện thoại của quốc gia cụ thể
            Regex regex = new Regex(@"^(0|\+84)?[0-9]{9,10}$");

            // Kiểm tra xem chuỗi có khớp với biểu thức chính quy hay không
            return regex.IsMatch(soDienThoai);
        }


        private void btn_ThemKH_Click(object sender, EventArgs e)
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
                //Kiểm tra giá trị ở textbox số điện thoại
                string sdtKH = txt_sdtKH.Text.Trim();

                bool kiemSoDienThoai = KiemTraSoDienThoai(sdtKH);
                if (!kiemSoDienThoai)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                // Kiểm tra xem tên khách hàng đã tồn tại trong cơ sở dữ liệu chưa

                string tenKH = txt_TenKH.Text.Trim();

                bool tenKHTonTai = KiemTraTenKHTonTai(tenKH);

                if (tenKHTonTai)
                {
                    MessageBox.Show("Tên khách hàng đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                string maKH = txt_MaKH.Text.Trim();
                DateTime ngayTaoKH = dt_NgayTaoKH.Value;
                string trangThaiKH = cb_TrangThaiKH.Text;
                string trangThaiKHValue = (trangThaiKH == "Active") ? "1" : "0";

                string sSql ="";
                sSql += $"INSERT INTO KhachHang (TenKH, SDT_KH, NgayTaoKH, TrangThaiKH) ";
                sSql += $"VALUES (N'{tenKH}', N'{sdtKH}', '{ngayTaoKH.ToString("yyyy - MM - dd")}', '{trangThaiKHValue}')";
                //load_TruyVan($"INSERT INTO KhachHang (TenKH, SDT_KH, NgayTaoKH, TrangThaiKH) VALUES (N'{tenKH}', N'{sdtKH}', '{ngayTaoKH.ToString("yyyy-MM-dd")}', '{trangThaiKHValue}')");
                load_TruyVan(sSql);

                MessageBox.Show("Đã thêm khách hàng vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hamLamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void hamLamMoi()
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_sdtKH.Text = "";
            // Kiểm tra và cập nhật giá trị MinDate và MaxDate của DateTimePicker
            if (DateTime.Now > dt_NgayTaoKH.MaxDate || DateTime.Now < dt_NgayTaoKH.MinDate)
            {
                dt_NgayTaoKH.MinDate = DateTime.Now.AddDays(-365 * 20); // Thiết lập MinDate là một năm trước
                dt_NgayTaoKH.MaxDate = DateTime.Now.AddDays(365); // Thiết lập MaxDate là một năm sau
            }

            dt_NgayTaoKH.Value = DateTime.Now;
            cb_TrangThaiKH.SelectedItem = null;

            txt_TimKH.Text = "";
            HienThiLenGrid();
            grid_KhachHang.ClearSelection();

            // Nếu số điện thoại hợp lệ, ẩn label thông báo đi
            lbl_ThongBao.Visible = false;
        }
        private void btn_LamMoiKH_Click(object sender, EventArgs e)
        {
            hamLamMoi();
        }

        private void btn_CapNhatKH_Click(object sender, EventArgs e)
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
                //Kiểm tra giá trị ở textbox số điện thoại
                string sdtKH = txt_sdtKH.Text.Trim();

                bool kiemSoDienThoai = KiemTraSoDienThoai(sdtKH);
                if (!kiemSoDienThoai)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                string maKH = txt_MaKH.Text.Trim();
                string tenKH = txt_TenKH.Text.Trim();
                DateTime ngayTaoKH = dt_NgayTaoKH.Value;
                string trangThaiKH = cb_TrangThaiKH.Text;
                string trangThaiKHValue = (trangThaiKH == "Active") ? "1" : "0";

                string sSql = "";
                sSql += $"UPDATE KhachHang SET ";
                sSql += $"TenKH = N'{tenKH}', ";
                sSql += $"SDT_KH = N'{sdtKH}', ";
                sSql += $"NgayTaoKH = '{ngayTaoKH.ToString("yyyy-MM-dd")}', ";
                sSql += $"TrangThaiKH = '{trangThaiKHValue}' ";
                sSql += $" WHERE MaKH = '{maKH}'";

                load_TruyVan(sSql);
                MessageBox.Show("Đã cập nhật khách hàng vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hamLamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật khách hàng:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            string maKH = txt_MaKH.Text.Trim();
            if (string.IsNullOrEmpty(txt_MaKH.Text.Trim()))
            {
                MessageBox.Show("Không tìm thấy mã khách hàng để xóa: \n ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string tenKH = txt_TenKH.Text.Trim();
            string sdtKH = txt_sdtKH.Text.Trim();
            DateTime ngayTaoKH = dt_NgayTaoKH.Value;
            string trangThaiKH = cb_TrangThaiKH.Text;
            string trangThaiKHValue = (trangThaiKH == "Active") ? "1" : "0";

            string thongTin = "";
            thongTin += $"Bạn có muốn xóa Khách Hàng có thông tin: \n";
            thongTin += $"Mã khách hàng: {maKH}\n";
            thongTin += $"Họ tên: {tenKH}\n";
            thongTin += $"Số điện thoại: {sdtKH}\n";
            thongTin += $"Ngày tạo: {ngayTaoKH}\n";
            thongTin += $"Trạng thái: {trangThaiKH}\n";
            DialogResult dlg = MessageBox.Show(thongTin, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                try
                {
                    load_TruyVan($"DELETE FROM KhachHang WHERE MaKH = '{maKH}'");

                    // Hiển thị thông báo và làm mới danh sách sách
                    MessageBox.Show("Đã xóa khách hàng khỏi cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hamLamMoi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa khách hàng:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_TimKhachHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimKH.Text.Trim()))
            {
                MessageBox.Show("Thông tin tìm kiếm đang trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string timKhacHang = txt_TimKH.Text.Trim();
            string str = $"SELECT* FROM KhachHang WHERE MaKH LIKE N'%{timKhacHang}%' OR TenKH LIKE N'%{timKhacHang}%' OR SDT_KH LIKE N'%{timKhacHang}%'";
            load_DSSach(str, grid_KhachHang);
            load_DSSachDoiTenKhachHang(str, grid_KhachHang);

        }

        private void grid_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = grid_KhachHang.CurrentCell.RowIndex;

            if (rowIndex >= 0 && rowIndex < grid_KhachHang.Rows.Count)
            {
                DataGridViewRow row = grid_KhachHang.Rows[rowIndex];

                if (row.Cells[0].Value != null)
                {
                    txt_MaKH.Text = row.Cells[0].Value.ToString();
                }
                if (row.Cells[1].Value != null)
                {
                    txt_TenKH.Text = row.Cells[1].Value.ToString();
                }
                if (row.Cells[2].Value != null)
                {
                    txt_sdtKH.Text = row.Cells[2].Value.ToString();
                }
                if (row.Cells[3].Value != null)
                {
                    if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime ngayTaoKH))
                    {
                        dt_NgayTaoKH.Value = ngayTaoKH;
                    }
                    else
                    {
                        // Xử lý nếu giá trị không hợp lệ
                        // gán mặc định hoặc hiển thị thông báo lỗi
                    }
                }
                if (row.Cells[4].Value != null)
                {
                    string trangThai = row.Cells[4].Value.ToString();
                    if (trangThai == "1")
                    {
                        cb_TrangThaiKH.SelectedIndex = 0;
                    }
                    else cb_TrangThaiKH.SelectedIndex = 1;
                }
            }
        }

        //hiện thông báo khi nhập số điện thoại không đúng
        private void txt_sdtKH_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra số điện thoại khi người dùng thay đổi nội dung trong textbox
            string soDienThoai = txt_sdtKH.Text.Trim();
            if (!KiemTraSoDienThoai(soDienThoai))
            {
                // Nếu số điện thoại không hợp lệ, hiển thị label thông báo
                lbl_ThongBao.Text = "Số điện thoại không hợp lệ.";
                lbl_ThongBao.Visible = true;
            }
            else
            {
                // Nếu số điện thoại hợp lệ, ẩn label thông báo đi
                lbl_ThongBao.Visible = false;
            }
        }
    }
}
