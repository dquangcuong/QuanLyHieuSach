using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace DA_STOREBOOKS_WIN.ThuNgan
{

    public partial class frmTNhoadon : Form
    {//CÁC HÀM CÓ THỂ DÙNG LẠI, CHỈ CẦN TRUYỀN THAM SÔ
     //Hàm lấy dữ liệu lên DataGridView
        string connectionString = @"Data Source=QUANGCUONG\SQLEXPRESS;Initial Catalog=DA_QLSACH;User ID=sa;Password=123;Integrated Security=False;";

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
        //MỚI 
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
                MessageBox.Show("Lỗi hiển thị danh sách lên gird. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void load_DSSachDoiTenHoaDon(string str, DataGridView dtv)
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(str, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                // Đảm bảo các cột tồn tại trong DataGridView trước khi đổi tên
                if (dtv.Columns.Contains("MaHD"))
                    dtv.Columns["MaHD"].HeaderText = "Mã hóa đơn";
                if (dtv.Columns.Contains("MaNV"))
                    dtv.Columns["MaNV"].HeaderText = "Mã nhân viên";
                if (dtv.Columns.Contains("MaKH"))
                    dtv.Columns["MaKH"].HeaderText = "Mã khách hàng";
                if (dtv.Columns.Contains("NgayTao_HD"))
                    dtv.Columns["NgayTao_HD"].HeaderText = "Ngày tạo";
                if (dtv.Columns.Contains("TongTien_HD"))
                    dtv.Columns["TongTien_HD"].HeaderText = "Tổng tiền";
                if (dtv.Columns.Contains("TrangThai"))
                    dtv.Columns["TrangThai"].HeaderText = "Trạng thái";
                // Hiển thị dữ liệu trong DataGridView
                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên cột hóa đơn. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void load_DSSachDoiTenChiTiet(string str, DataGridView dtv)
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(str, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                if (dtv.Columns.Contains("MA_CTHD"))
                    dtv.Columns["MA_CTHD"].HeaderText = "Mã chi tiết hóa đơn";
                if (dtv.Columns.Contains("MaHD"))
                    dtv.Columns["MaHD"].HeaderText = "Mã hóa đơn";
                if (dtv.Columns.Contains("MaSach"))
                    dtv.Columns["MaSach"].HeaderText = "Mã sách";
                if (dtv.Columns.Contains("SoLuong"))
                    dtv.Columns["SoLuong"].HeaderText = "Số lượng bán";
                if (dtv.Columns.Contains("DonGia"))
                    dtv.Columns["DonGia"].HeaderText = "Đơn giá bán";
                if (dtv.Columns.Contains("ThanhTienSP"))
                    dtv.Columns["ThanhTienSP"].HeaderText = "Thành tiền sản phẩm";
                // Hiển thị dữ liệu trong DataGridView
                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên cột Chi tiết. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void HienThiGridHoaDon()
        {
            string str = "SELECT * FROM HoaDon WHERE TrangThai != 0";
            load_DSSach(str, grid_HD);
            load_DSSachDoiTenHoaDon(str, grid_HD);
        }
        public void HienThiGridChiTiet()
        {
            string str = "SELECT * FROM CTHoaDon";
            load_DSSach(str, grid_CTHD);
            load_DSSachDoiTenChiTiet(str, grid_CTHD);
        }

        public void HienThiDSNhanVien()
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            String sSql;
            sSql = "SELECT MaNV, TenNV FROM NhanVien";
            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(sSql, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                sqlconn.Close();
                cb_MaNV.DataSource = lt.Tables[0];
                cb_MaNV.DisplayMember = "TenNV";
                cb_MaNV.ValueMember = "MaNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị nhân viên lên combobox.\n => Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void HienThiDSKhachHang()
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            String sSql;
            sSql = "SELECT MaKH, TenKH FROM KhachHang WHERE TrangThaiKH !=0 ";
            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(sSql, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                sqlconn.Close();
                cb_MaKH.DataSource = lt.Tables[0];
                cb_MaKH.DisplayMember = "TenKH";
                cb_MaKH.ValueMember = "MaKH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kh => Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void HienThiDSSach()
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            String sSql;
            sSql = "SELECT MaSach, TenSach FROM Sach WHERE SoLuong > 0  AND TrangThai_Sach != 0";
            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(sSql, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                sqlconn.Close();
                cb_Sach.DataSource = lt.Tables[0];
                cb_Sach.DisplayMember = "TenSach";
                cb_Sach.ValueMember = "MaSach";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị sách lên combobox.\n => Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public frmTNhoadon()
        {
            InitializeComponent();
        }

        private void frmTNhoadon_Load(object sender, EventArgs e)
        {
            HienThiGridHoaDon();
            HienThiGridChiTiet();
            HienThiDSNhanVien();
            HienThiDSKhachHang();
            HienThiDSSach();
            cb_MaKH.SelectedIndex = -1;
            cb_MaNV.SelectedIndex = -1;
            cb_Sach.SelectedIndex =-1;

            grid_HD.ClearSelection();
            grid_CTHD.ClearSelection();
        }

        private int LayMaNhanVienTheoTen(string tenNV)
        {
            int maNV = -1; // Khởi tạo mã nhân viên với giá trị mặc định là -1 (trường hợp không tìm thấy)

            // Tạo câu truy vấn SQL để lấy mã nhân viên dựa trên tên nhân viên đã chọn
            string query = $"SELECT MaNV FROM NhanVien WHERE TenNV = N'{tenNV}'";

            // Mở kết nối tới cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo đối tượng SqlCommand để thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Thực thi truy vấn và trả về kết quả (mã nhân viên)
                    object result = command.ExecuteScalar();

                    // Kiểm tra xem có kết quả trả về hay không
                    if (result != null && result != DBNull.Value)
                    {
                        // Ép kiểu kết quả về kiểu int và gán cho biến maNV
                        maNV = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên có tên này trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Trả về mã nhân viên
            return maNV;
        }
        private int LayMaKhachHangTheoTen(string tenKH)
        {
            int maKH = -1; // Khởi tạo mã nhân viên với giá trị mặc định là -1 (trường hợp không tìm thấy)

            // Tạo câu truy vấn SQL để lấy mã nhân viên dựa trên tên nhân viên đã chọn
            string query = $"SELECT MaKH FROM KhachHang WHERE TenKH = N'{tenKH}'";

            // Mở kết nối tới cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo đối tượng SqlCommand để thực hiện truy vấn
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Thực thi truy vấn và trả về kết quả (mã nhân viên)
                    object result = command.ExecuteScalar();

                    // Kiểm tra xem có kết quả trả về hay không
                    if (result != null && result != DBNull.Value)
                    {
                        // Ép kiểu kết quả về kiểu int và gán cho biến maNV
                        maKH = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng có tên này trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Trả về mã nhân viên
            return maKH;
        }
        private string LayTenNhanVienTheoMa(int maNV)
        {
            string tenNV = "";

            string query = $"SELECT TenNV FROM NhanVien WHERE MaNV = {maNV}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    // Thực hiện truy vấn và trả về kết quả
                    object result = command.ExecuteScalar();
                    // Ép kiểu kết quả về kiểu string và gán cho biến tenNV
                    if (result != null)
                    {
                        tenNV = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return tenNV;
        }
        private string LayTenKhachHangTheoMa(int maKH)
        {
            string tenKH = "";

            string query = $"SELECT TenKH FROM KhachHang WHERE MaKH = {maKH}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    // Thực hiện truy vấn và trả về kết quả
                    object result = command.ExecuteScalar();
                    // Ép kiểu kết quả về kiểu string và gán cho biến tenNV
                    if (result != null)
                    {
                        tenKH = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return tenKH;
        }
        //pHƯƠNG THỨC LOAD DỮ LIỆU CHO BẢNG CHI TIẾT HÓA ĐƠN
        private void LoadChiTietHoaDonTheoMa(int maHD)
        {

            // Thực hiện truy vấn để lấy chi tiết hóa đơn tương ứng với mã hóa đơn vừa thêm
            string query = $"SELECT * FROM CTHoaDon WHERE MaHD = {maHD}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                // Hiển thị dữ liệu trong DataTable vào DataGridView chi tiết hóa đơn
                grid_CTHD.DataSource = dataTable;
            }
        }

        // Phương thức để lấy mã hóa đơn mới nhất
        private int LayMaHoaDonMoiNhat()
        {
            int maHD = 0;

            // Thực hiện truy vấn để lấy mã hóa đơn cuối cùng từ bảng HoaDon
            string query = "SELECT TOP 1 MaHD FROM HoaDon ORDER BY MaHD DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    maHD = Convert.ToInt32(result);
                }
            }

            return maHD;
        }

        //Hàm xử lý thêm xóa sửa HÓA ĐƠN
        private bool KiemTraHoaDonRong()
        {
            bool kq = false; //không rỗng
            if (string.IsNullOrEmpty(cb_MaNV.Text.Trim()) ||
                string.IsNullOrEmpty(cb_MaKH.Text.Trim()))
            {
                kq = true;
            }
            return kq;
        }
        public void LamMoi()
        {
            HienThiDSNhanVien();
            HienThiDSKhachHang();

            txt_MaHD.Text = "";
            cb_MaNV.SelectedItem = null;
            cb_MaKH.SelectedItem = null;
            dt_NgayLapHD.Value = DateTime.Now;
            txt_TongTienHD.Text = "";
            txt_Tim.Text = "";

            HienThiGridHoaDon();
            HienThiGridChiTiet();
            grid_HD.ClearSelection();
        }
        public void XoaChiTietKhiXoaHD(int maHD)
        {
            try
            {
                // Xóa tất cả các chi tiết phiếu nhập có mã phiếu nhập tương ứng
                string queryDeleteChiTiet = $"DELETE FROM CTHoaDon WHERE MaHD = {maHD}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryDeleteChiTiet, connection);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Hiển thị thông báo khi xóa thành công
                        MessageBox.Show("Xóa chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy chi tiết hóa đơn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện xóa chi tiết hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public int LayTrangThaiHoaDon(int ma)
        {
            int trangThai = -1; // Giá trị mặc định nếu không có kết quả truy vấn

            try
            {
                string str = "SELECT TrangThai FROM HoaDon WHERE MaHD = @ma";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(str, connection);
                    command.Parameters.AddWithValue("@ma", ma);
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Chuyển đổi kết quả về kiểu int
                        trangThai = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy trạng thái hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return trangThai;
        }
        public void ThaoTacCapNhatSoLuongBangSach(int maHD)
        {
            try
            {
                string query = "SELECT MaSach, SoLuong FROM CTHoaDon WHERE MaHD = @MaHD";

                // Tạo một DataTable để lưu trữ dữ liệu từ truy vấn
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaHD", maHD);

                        // Tạo một SqlDataAdapter để điền dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Điền dữ liệu từ truy vấn vào DataTable
                            adapter.Fill(dataTable);
                        }
                    }
                }

                // Đóng kết nối sau khi đã nhận dữ liệu
                // Bây giờ không còn cần kết nối nữa
                MessageBox.Show("Đã nhận dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi đóng kết nối, thực hiện cập nhật
                // Chạy vòng lặp trên DataTable để thực hiện cập nhật
                foreach (DataRow row in dataTable.Rows)
                {
                    int maSach = Convert.ToInt32(row["MaSach"]);
                    int soLuongBan = Convert.ToInt32(row["SoLuong"]);

                    string updateQuery = "UPDATE Sach SET SoLuong = SoLuong - @SoLuongBan WHERE MaSach = @MaSach";

                    using (SqlConnection updateConnection = new SqlConnection(connectionString))
                    {
                        updateConnection.Open();

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, updateConnection))
                        {
                            updateCommand.Parameters.AddWithValue("@SoLuongBan", soLuongBan);
                            updateCommand.Parameters.AddWithValue("@MaSach", maSach);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Cập nhật số lượng sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật số lượng sách: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //FROM XỬ LÝ HÓA ĐƠN
        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra rỗng
                bool kiemRong = KiemTraHoaDonRong();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                decimal tongTienHD = 0;


                // Lấy dữ liệu từ các điều khiển trên giao diện
                int nhanVien = Convert.ToInt32(cb_MaNV.SelectedValue);
                int khachHang = Convert.ToInt32(cb_MaKH.SelectedValue);
                string sNgayTaoHoaDon = dt_NgayLapHD.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");

                int trangThai = 2;

                // Thêm hóa đơn mới vào bảng HoaDon
                string queryInsertHoaDon = $"INSERT INTO HoaDon (MaNV, MaKH, NgayTao_HD, TongTien_HD, TrangThai) VALUES ({nhanVien}, {khachHang}, '{sNgayTaoHoaDon}', {tongTienHD}, {trangThai})";

                // Thực thi truy vấn thêm hóa đơn
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryInsertHoaDon, connection);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Hiển thị thông báo khi thêm hóa đơn thành công
                        MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //load lại grid hóa đơn và các combobox
                        LamMoi();

                        //tự động mở chi tiết hóa đơn mới nhât
                        int ma = LayMaHoaDonMoiNhat();
                        LoadChiTietHoaDonTheoMa(ma);
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thêm hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_CapNhatHD_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra rỗng mã hóa đơn khi cập nhật
                if (string.IsNullOrEmpty(txt_MaHD.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int maHD = Convert.ToInt32(txt_MaHD.Text.Trim());
                int kiemTra = LayTrangThaiHoaDon(maHD);
                if (kiemTra == 1)
                {
                    MessageBox.Show("Hóa đơn đã được lưu, vui lòng không chỉnh sửa hoặc xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //Kiểm tra rỗng
                bool kiemRong = KiemTraHoaDonRong();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal tongTienHD = Convert.ToDecimal(txt_TongTienHD.Text);
                if (tongTienHD == 0 || string.IsNullOrEmpty(txt_TongTienHD.Text.Trim()))
                {
                    tongTienHD = 0;
                }

                // Lấy dữ liệu từ các điều khiển trên giao diện
                int nhanVien = Convert.ToInt32(cb_MaNV.SelectedValue);
                int khachHang = Convert.ToInt32(cb_MaKH.SelectedValue);
                string sNgayTaoHoaDon = dt_NgayLapHD.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
                // Sửa hóa đơn trong bảng HoaDon
                string queryUpdateHoaDon = $"UPDATE HoaDon SET MaNV = {nhanVien}, MaKH = {khachHang}, NgayTao_HD = '{sNgayTaoHoaDon}', TongTien_HD = {tongTienHD} WHERE MaHD = {maHD}";
                // Thực thi truy vấn thêm hóa đơn
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryUpdateHoaDon, connection);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Hiển thị thông báo khi thêm hóa đơn thành công
                        MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //load lại grid hóa đơn và các combobox
                        LamMoi();

                        //tự động mở chi tiết hóa đơn mới nhât
                        int ma = LayMaHoaDonMoiNhat();
                        LoadChiTietHoaDonTheoMa(ma);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện cập nhật hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(txt_MaHD.Text.Trim()))
            {
                MessageBox.Show("Không tìm thấy mã hóa đơn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maHD = Convert.ToInt32(txt_MaHD.Text.Trim());

            int kiemTra = LayTrangThaiHoaDon(maHD);
            if (kiemTra == 1)
            {
                MessageBox.Show("Hóa đơn đã được lưu, vui lòng không chỉnh sửa hoặc xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            bool kiemRong = KiemTraHoaDonRong();
            if (kiemRong)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã phiếu nhập
            int trangThai = 0;
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa hóa đơn có mã {maHD} và tất cả chi tiết của nó?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try
                {
                    XoaChiTietKhiXoaHD(maHD);
                    // Cập nhật trạng thái của phiếu nhập thành 0 (đã xóa)
                    string queryDeletePhieuNhap = $"UPDATE HoaDon SET TrangThai = {trangThai} WHERE MaHD = {maHD}";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryDeletePhieuNhap, connection);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi xóa phiếu nhập thành công
                            MessageBox.Show("Xóa HÓA ĐƠN thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Thực hiện các thao tác sau khi xóa thành công
                            // 1. Load lại grid Phiếu nhập

                            // 2. Làm mới các điều khiển
                            LamMoi();
                        }
                        else
                        {
                            MessageBox.Show("Xóa HÓA ĐƠN thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện xóa HÓA ĐƠN: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(txt_MaHD.Text.Trim()))
            {
                MessageBox.Show("Không tìm thấy mã hóa đơn để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Kiểm tra rỗng
            bool kiemRong = KiemTraHoaDonRong();
            if (kiemRong)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã phiếu nhập
            int maHD = Convert.ToInt32(txt_MaHD.Text.Trim());
            int kiemTra = LayTrangThaiHoaDon(maHD);
            if (kiemTra == 1)
            {
                MessageBox.Show("Hóa đơn đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            int trangThai = 1;
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn lưu phiếu nhập có mã {maHD} và tất cả chi tiết của nó?", "Xác nhận lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try
                {
                    // Cập nhật trạng thái của phiếu nhập thành 1 (đã lưu)
                    string queryDeletePhieuNhap = $"UPDATE HoaDon SET TrangThai = {trangThai} WHERE MaHD = {maHD}";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryDeletePhieuNhap, connection);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi xóa phiếu nhập thành công
                            MessageBox.Show("Lưu HÓA ĐƠN thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Thực hiện các thao tác sau khi xóa thành công
                            // 1. Load lại grid Phiếu nhập
                            HienThiGridHoaDon();
                            // 2. Làm mới các điều khiển
                            LamMoi();
                        }
                        else
                        {
                            MessageBox.Show("Lưu HÓA ĐƠN thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện lưu HÓA ĐƠN. " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //thực hiện cập nhật ở bảng sách
            ThaoTacCapNhatSoLuongBangSach(maHD);
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Tim.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền thông hóa đơn tin cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //LẤY DỮ LIỆU
            string tim = txt_Tim.Text.Trim().ToString();

            try
            {
                string query = "SELECT * FROM HoaDon WHERE TrangThai !=0 AND ";
                query += "MaHD = @tim OR ";
                query += "TongTien_HD = @tim OR ";
                query += "MaKH = @tim OR ";
                query += "MaNV  = @tim";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@tim", tim);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Tạo một DataTable để lưu trữ dữ liệu
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Gán DataTable làm nguồn dữ liệu cho grid_PhieuNhap
                    grid_HD.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn tìm kiếm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaHD.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maHD = Convert.ToInt32(txt_MaHD.Text.Trim());
            frmReportHD frm = new frmReportHD(maHD);
            frm.Show();
        }

        private void grid_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = grid_HD.CurrentCell.RowIndex;

            if (rowIndex >= 0 && rowIndex < grid_HD.Rows.Count)
            {
                DataGridViewRow row = grid_HD.Rows[rowIndex];

                if (row.Cells[0].Value != null)
                {
                    txt_MaHD.Text = row.Cells[0].Value.ToString();
                }
                if (row.Cells[1].Value != null)
                {
                    cb_MaNV.SelectedValue = row.Cells[1].Value.ToString();

                }
                if (row.Cells[2].Value != null)
                {
                    cb_MaKH.SelectedValue = row.Cells[2].Value.ToString();

                }
                if (row.Cells[3].Value != null)
                {
                    dt_NgayLapHD.Text = row.Cells[3].Value.ToString();
                }
                if (row.Cells[4].Value != null)
                {
                    txt_TongTienHD.Text = row.Cells[4].Value.ToString();
                }

                //hiện chi tiết hóa đơn
                int maHD = int.Parse(txt_MaHD.Text);

                LoadChiTietHoaDonTheoMa(maHD);
            }
        }



        //FROM XỬ LÝ CHI TIẾT HÓA ĐƠN
        public void Reset()
        {
            cb_Sach.SelectedItem = null;
            num_GiaBan.Value = 0;
            num_SoLuong.Value = 0;

        }
        public class Sach
        {
            public int MaSach { get; set; }
            public string TenSach { get; set; }
            public string TenTacGia { get; set; }
            public string TenTheLoai { get; set; }
            public string HinhAnh { get; set; }
            public int SoLuong { get; set; }
            public decimal GiaBan { get; set; }
            public int TrangThai_Sach { get; set; }
            public string NgayXuatBan { get; set; }
        }
        private Sach LayThongTinSach(int maSach)
        {
            Sach sach = null;

            try
            {
                // Tạo câu truy vấn SQL để lấy thông tin sách từ bảng Sach
                string query = $"SELECT * FROM Sach WHERE MaSach = {maSach}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Đọc dữ liệu từ SqlDataReader
                    if (reader.Read())
                    {
                        // Tạo một đối tượng sách và gán thông tin từ cơ sở dữ liệu
                        sach = new Sach
                        {
                            MaSach = (int)reader["MaSach"],
                            TenSach = reader["TenSach"].ToString(),
                            TenTacGia = reader["TenTacGia"].ToString(),
                            GiaBan = (decimal)reader["GiaBan"],
                            SoLuong = (int)reader["SoLuong"]
                            //Thêm các trường thông tin khác của sách nếu cần
                        };
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return sach;
        }
        private int LaySoLuongTonKho(int maSach)
        {
            int soLuong = 0; // Giá trị mặc định nếu không có kết quả truy vấn

            try
            {
                string str = "SELECT SoLuong FROM Sach WHERE MaSach = @ma";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(str, connection);
                    command.Parameters.AddWithValue("@ma", maSach);
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // Chuyển đổi kết quả về kiểu int
                        soLuong = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy trạng thái hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return soLuong;
        }
        private int KiemTraSoLuongNhap(int soNhap, int maSach)
        {
            int tonKho = LaySoLuongTonKho(maSach);

            if (soNhap > tonKho)
            {
                MessageBox.Show("Số lượng nhập vượt quá số lượng tồn kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private void CapNhatTongTienHoaDon(int maHD)
        {
            try
            {
                // Tính tổng thành tiền từ bảng CTHoaDon
                string queryTongTien = $"SELECT SUM(ThanhTienSP) FROM CTHoaDon WHERE MaHD = {maHD}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryTongTien, connection);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        decimal tongTien = Convert.ToDecimal(result);

                        // Cập nhật tổng tiền vào bảng HoaDon
                        string queryUpdateTongTien = $"UPDATE HoaDon SET TongTien_HD = {tongTien} WHERE MaHD = {maHD}";

                        SqlCommand updateCommand = new SqlCommand(queryUpdateTongTien, connection);
                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi cập nhật tổng tiền thành công
                            string str = "select * from HoaDon";
                            load_DSSach(str, grid_HD);

                            MessageBox.Show("Cập nhật tổng tiền hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật tổng tiền hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật tổng tiền: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool KiemTraCTHoaDonRong()
        {
            bool kq = false; // Không rỗng

            // Kiểm tra nếu cb_MaSach là null hoặc rỗng
            if (string.IsNullOrEmpty(cb_Sach.Text.Trim()))
            {
                kq = true;
            }

            // Kiểm tra nếu num_GiaBan hoặc num_SoLuong bằng 0
            if (num_GiaBan.Value == 0 || num_SoLuong.Value == 0)
            {
                kq = true;
            }

            return kq;
        }
        private bool kiemTraSachTonTaiTrongCTHD(int maSach, int maHD)
        {
            bool kq = true; // Giả sử đã tồn tại


            string sSql = "SELECT COUNT(*) FROM CTHoaDon WHERE MaHD = @maHD AND MaSach = @maSach";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand myCommand = new SqlCommand(sSql, myConnection))
                    {
                        // Thêm tham số vào truy vấn để tránh tấn công SQL injection
                        myCommand.Parameters.AddWithValue("@maHD", maHD);
                        myCommand.Parameters.AddWithValue("@maSach", maSach);

                        // Mở kết nối và thực thi truy vấn
                        myConnection.Open();
                        int numRows = (int)myCommand.ExecuteScalar();

                        //  0, sách chưa có trong chi tiết hóa đơn
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
                MessageBox.Show("Lỗi kiểm tra sách tồn tại trong CTHD. Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return kq;
        }
        public void TaoMoiChiTiet()
        {
            HienThiDSSach();

            cb_Sach.SelectedItem = null;
            num_GiaBan.Value = 0;
            num_SoLuong.Value = 0;

            HienThiGridHoaDon();
            HienThiGridChiTiet();
            grid_CTHD.ClearSelection();
        }

        private void btn_KhachMoi_Click(object sender, EventArgs e)
        {
            frmTNkhachhang frm = new frmTNkhachhang();
            frm.Show();
        }

        private void btn_ThemCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                int maHD = int.Parse(txt_MaHD.Text);
                int kiemTra = LayTrangThaiHoaDon(maHD);
                if (kiemTra == 1)
                {
                    MessageBox.Show("Hóa đơn đã được lưu, vui lòng không thêm mới chi tiết hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //Kiểm tra rỗng
                bool kiemRong = KiemTraCTHoaDonRong();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(cb_Sach.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn để thêm chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maSach = int.Parse(cb_Sach.SelectedValue.ToString());

                int soLuong = (int)num_SoLuong.Value;
                if (!int.TryParse(num_SoLuong.Text, out soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ. Số lượng phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int kiemTraSoLuong = KiemTraSoLuongNhap(soLuong, maSach);
                if (kiemTraSoLuong == 0)
                {
                    MessageBox.Show("Số lượng vượt quá số lượng tồn kho cho phép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal donGia = num_GiaBan.Value;
                decimal thanhTien = soLuong * donGia;

                //kIỂM TRA 
                bool kiemSachTonTai = kiemTraSachTonTaiTrongCTHD(maSach, maHD);
                if (kiemSachTonTai)
                {

                    // Mã sách đã tồn tại trong chi tiết hóa đơn, cập nhật lại số lượng
                    string queryUpdate = $"UPDATE CTHoaDon SET SoLuong = {soLuong}, ThanhTienSP =  {thanhTien} WHERE MaHD = {maHD} AND MaSach = {maSach}";
                    try
                    {
                        load_TruyVan(queryUpdate); //thự thi update
                        CapNhatTongTienHoaDon(maHD); // Cập nhật tổng tiền hóa đơn
                        LoadChiTietHoaDonTheoMa(maHD); // Load lại chi tiết hóa đơn
                        MessageBox.Show("Dữ liệu đã được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Mã sách chưa tồn tại trong chi tiết hóa đơn, thêm mới
                    string queryInsert = $"INSERT INTO CTHoaDon (MaHD, MaSach, SoLuong, DonGia, ThanhTienSP) VALUES ({maHD}, {maSach}, {soLuong}, {donGia}, {thanhTien})";
                    try
                    {
                        load_TruyVan(queryInsert); //thự thi thêm mới
                        CapNhatTongTienHoaDon(maHD); // Cập nhật tổng tiền hóa đơn
                        LoadChiTietHoaDonTheoMa(maHD); // Load lại chi tiết hóa đơn
                        MessageBox.Show("Dữ liệu đã được thêm vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm hóa đơn mới: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi truy vấn thêm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SuaCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                int maHD = int.Parse(txt_MaHD.Text);
                int kiemTra = LayTrangThaiHoaDon(maHD);
                if (kiemTra == 1)
                {
                    MessageBox.Show("Hóa đơn đã được lưu, vui lòng không chỉnh sửa chi tiết hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //Kiểm tra rỗng
                bool kiemRong = KiemTraCTHoaDonRong();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin từ các điều khiển trên giao diện
                if (string.IsNullOrEmpty(cb_Sach.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn để cập nhật chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Lấy thông tin từ các điều khiển trên giao diện
                int maSach = int.Parse(cb_Sach.SelectedValue.ToString());

                int soLuong = (int)num_SoLuong.Value;
                if (!int.TryParse(num_SoLuong.Text, out soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ. Số lượng phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int kiemTraSoLuong = KiemTraSoLuongNhap(soLuong, maSach);
                if (kiemTraSoLuong == 0)
                {
                    MessageBox.Show("Số lượng vượt quá số lượng tồn kho cho phép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal donGia = num_GiaBan.Value;
                decimal thanhTien = soLuong * donGia;

                load_TruyVan($"UPDATE CTHoaDon SET SoLuong = {soLuong}, DonGia = {donGia}, ThanhTienSP = {thanhTien} WHERE MaHD = {maHD} AND MaSach = {maSach}");
                CapNhatTongTienHoaDon(maHD);
                LoadChiTietHoaDonTheoMa(maHD);
                MessageBox.Show("Dữ Liệu đã được cập nhật vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chỉnh sửa chi tiết hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_XoaCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                int maHD = int.Parse(txt_MaHD.Text);
                int kiemTra = LayTrangThaiHoaDon(maHD);
                if (kiemTra == 1)
                {
                    MessageBox.Show("Hóa đơn đã được lưu, vui lòng không xóa chi tiết hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                // Lấy thông tin từ các điều khiển trên giao diện
                if (string.IsNullOrEmpty(cb_Sach.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy mã sách để xóa chi tiết hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Lấy thông tin từ các điều khiển trên giao diện
                int maSach = int.Parse(cb_Sach.SelectedValue.ToString());

                int soLuong = (int)num_SoLuong.Value;

                // Xác nhận việc xóa chi tiết hóa đơn
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết hóa đơn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Nếu người dùng chọn "Yes" trong hộp thoại xác nhận, thực hiện xóa
                    // Xóa chi tiết hóa đơn trong bảng CTHoaDon
                    string queryDeleteCTHoaDon = $"DELETE FROM CTHoaDon WHERE MaHD = {maHD} AND MaSach = {maSach}";
                    load_TruyVan(queryDeleteCTHoaDon);

                    // Thực thi truy vấn thêm chi tiết hóa đơn
                    MessageBox.Show("Xóa chi tiết hoá đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CapNhatTongTienHoaDon(maHD);
                    LoadChiTietHoaDonTheoMa(maHD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện xóa chi tiết hóa đơn: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TaoMoiCTHD_Click(object sender, EventArgs e)
        {
            TaoMoiChiTiet();
        }

        private void cb_Sach_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Sach.SelectedValue != null)
            {
                int maSach;
                if (int.TryParse(cb_Sach.SelectedValue.ToString(), out maSach))
                {
                    Sach chon = LayThongTinSach(maSach);
                    num_GiaBan.Value = chon.GiaBan;
                    string thongBao = "Số lượng tồn kho " + chon.SoLuong.ToString() + "\nVui lòng không nhập giá trị lớn hơn.";
                    lbl_SoLuongMax.Text = thongBao;
                }
            }
            else
            {
                // Nếu giá trị là null, đặt giá trị mặc định cho num_GiaBan
                num_GiaBan.Value = 0;
                lbl_SoLuongMax.Text = "Hãy chọn sách!";
            }
        }

        private void grid_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = grid_CTHD.CurrentCell.RowIndex;

            if (rowIndex >= 0 && rowIndex < grid_CTHD.Rows.Count)
            {
                DataGridViewRow row = grid_CTHD.Rows[rowIndex];

                if (row.Cells[1].Value != null)
                {
                    txt_MaHD.Text = row.Cells[1].Value.ToString();
                }
                if (row.Cells[2].Value != null)
                {
                    cb_Sach.SelectedValue = row.Cells[2].Value.ToString();
                }
                if (row.Cells[3].Value != null)
                {
                    num_SoLuong.Text = row.Cells[3].Value.ToString();
                }
                if (row.Cells[4].Value != null)
                {
                    num_GiaBan.Text = row.Cells[4].Value.ToString();
                }

            }
        }
    }
}
