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
using OfficeOpenXml;
using System.IO;


namespace DA_STOREBOOKS_WIN
{
    public partial class frmPhieuNhap : Form
    {
        public string connectionString = "Data Source=QUANGCUONG\\SQLEXPRESS;Initial Catalog=DA_QLSACH;User ID=sa;Password=123;Integrated Security=False;";
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
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
        public void load_DSSachDoiTenPhieuNhap(string str, DataGridView dtv)
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(str, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                // Đảm bảo các cột tồn tại trong DataGridView trước khi đổi tên
                if (dtv.Columns.Contains("MaPN"))
                    dtv.Columns["MaPN"].HeaderText = "Mã phiếu";
                if (dtv.Columns.Contains("MaNCC"))
                    dtv.Columns["MaNCC"].HeaderText = "Mã NCC";
                if (dtv.Columns.Contains("MaNV"))
                    dtv.Columns["MaNV"].HeaderText = "Mã Nhân viên";
                if (dtv.Columns.Contains("NgayTao_PN"))
                    dtv.Columns["NgayTao_PN"].HeaderText = "Ngày tạo";
                if (dtv.Columns.Contains("TongTien_PN"))
                    dtv.Columns["TongTien_PN"].HeaderText = "Tổng tiền";
                if (dtv.Columns.Contains("TrangThai"))
                    dtv.Columns["TrangThai"].HeaderText = "Trạng thái";
                // Hiển thị dữ liệu trong DataGridView
                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên cột phiếu nhập. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                if (dtv.Columns.Contains("Ma_CTPN"))
                    dtv.Columns["Ma_CTPN"].HeaderText = "Mã chi tiết phiếu nhập";
                if (dtv.Columns.Contains("MaPN"))
                    dtv.Columns["MaPN"].HeaderText = "Mã phiếu nhập";
                if (dtv.Columns.Contains("MaSach"))
                    dtv.Columns["MaSach"].HeaderText = "Mã sách";
                if (dtv.Columns.Contains("SoLuongNhap"))
                    dtv.Columns["SoLuongNhap"].HeaderText = "Số lượng nhập";
                if (dtv.Columns.Contains("DonGiaNhap"))
                    dtv.Columns["DonGiaNhap"].HeaderText = "Đơn giá nhập";
                if (dtv.Columns.Contains("ThanhTien"))
                    dtv.Columns["ThanhTien"].HeaderText = "Thành tiền";
                // Hiển thị dữ liệu trong DataGridView
                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên cột Chi tiết. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void HienThiGridPhieuNhap()
        {
            string str = "SELECT * FROM PhieuNhap WHERE TrangThai != 0";
            load_DSSach(str, grid_PhieuNhap);
            load_DSSachDoiTenPhieuNhap(str, grid_PhieuNhap);
        }
        public void HienThiGridChiTiet()
        {
            string str = "SELECT * FROM CTPhieuNhap";
            load_DSSach(str, grid_ChiTiet);
            load_DSSachDoiTenChiTiet(str, grid_ChiTiet);
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
        public void HienThiDSNCC()
        {
            
            SqlConnection sqlconn = new SqlConnection(connectionString);

            String sSql;
            sSql = "SELECT MaNCC, TenNCC FROM NhaCungCap";
            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(sSql, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                sqlconn.Close();
                cb_MaNCC.DataSource = lt.Tables[0];
                cb_MaNCC.DisplayMember = "TenNCC";
                cb_MaNCC.ValueMember = "MaNCC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị nhà cung cấp lên combobox.\n => Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void HienThiDSSach()
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            String sSql;
            sSql = "SELECT MaSach, TenSach FROM Sach";
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
                MessageBox.Show("Lỗi hiển thị sách lên combobox.\n => Chi tiết: " + ex.Message);
            }
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            HienThiGridPhieuNhap();
            HienThiGridChiTiet();
            HienThiDSNhanVien();
            HienThiDSNCC();
            HienThiDSSach();
            cb_Sach.SelectedIndex = -1;
            cb_MaNV.SelectedIndex = -1;
            cb_MaNCC.SelectedIndex = -1;

            grid_PhieuNhap.ClearSelection();
            grid_ChiTiet.ClearSelection();

        }

        private void btn_ThemPN_Click(object sender, EventArgs e)
        {
            //kiểm tra rỗng
            if (string.IsNullOrEmpty(cb_MaNV.Text.Trim()) ||
                string.IsNullOrEmpty(cb_MaNCC.Text.Trim()))
            {
                MessageBox.Show("Thông tin phiếu nhập chưa điển đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //lấy dữ liệu
            int maNcc = Convert.ToInt32(cb_MaNCC.SelectedValue);
            int maNv = Convert.ToInt32(cb_MaNV.SelectedValue);
            string sNgayTaoPN = dt_NgayLapPN.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
            int tongTienPN = 0;
            int trangThai = 2; //đã lưu và được chỉnh sửa

            // Thêm dữ liệu vào bảng PhieuNhap
            string queryInsertPhieuNhap = $"INSERT INTO PhieuNhap (MaNCC, MaNV, NgayTao_PN, TongTien_PN, TrangThai) VALUES ({maNcc}, {maNv}, '{sNgayTaoPN}', {tongTienPN},{trangThai})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryInsertPhieuNhap, connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Hiển thị thông báo khi thêm hóa đơn thành công
                    MessageBox.Show("Thêm Phiếu Nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    //Thao tác sau khi thêm xong
                    //1. load lại gird Phiếu nhập
                    HienThiGridPhieuNhap();
                    //.2 Tự động hiển thị chi tiết phiếu nhập mới nhất
                    int ma = LayMaPhieuVuaThem();
                    HienThiGridChiTietVuaThem(ma);
                }
                else
                {
                    MessageBox.Show("Thêm Phiếu Nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        //Lấy ra mã phiếu nhập mới nhất để cập nhập auto
        public int LayMaPhieuVuaThem()
        {
            int ma = 0;

            // Thực hiện truy vấn để lấy mã hóa đơn cuối cùng từ bảng HoaDon
            string query = "SELECT TOP 1 MaPN FROM PhieuNhap ORDER BY NgayTao_PN DESC; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    ma = Convert.ToInt32(result);
                }
            }


            return ma;
        }
        public void HienThiGridChiTietVuaThem(int ma)
        {
            string str = "SELECT * FROM CTPhieuNhap WHERE MaPN = " + ma;
            load_DSSach(str, grid_ChiTiet);
            load_DSSachDoiTenChiTiet(str, grid_ChiTiet);
        }
        public int LayTrangThaiPhieu(int ma)
        {
            int trangThai = -1; // Giá trị mặc định nếu không có kết quả truy vấn

            try
            {
                string str = "SELECT TrangThai FROM PhieuNhap WHERE MaPN = @ma";

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
                MessageBox.Show("Lỗi khi lấy trạng thái phiếu nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return trangThai;
        } 

        private void btn_CapNhatPN_Click(object sender, EventArgs e)
        {
            //kiểm tra rỗng
            if (string.IsNullOrEmpty(txt_MaPN.Text.Trim()))
            {
                MessageBox.Show("Không tìm thấy mã phiếu để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(cb_MaNV.Text.Trim()) ||
                string.IsNullOrEmpty(cb_MaNCC.Text.Trim()))
            {
                MessageBox.Show("Thông tin phiếu nhập chưa điển đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //lấy dữ liệu
            int maPhieu = Convert.ToInt32(txt_MaPN.Text.Trim());

            // kiểm tra trạng thái trước khi cho cập nhật
            int kiemTra = LayTrangThaiPhieu(maPhieu);
            if(kiemTra == 1)
            {
                MessageBox.Show("Phiếu nhập đã được lưu, vui lòng không chỉnh sửa hoặc xóa.","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            int maNcc = Convert.ToInt32(cb_MaNCC.SelectedValue);
            int maNv = Convert.ToInt32(cb_MaNV.SelectedValue);
            string sNgayTaoPN = dt_NgayLapPN.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
            int tongTienPN = 0;

            // Thêm dữ liệu vào bảng PhieuNhap
            // Cập nhật dữ liệu vào bảng PhieuNhap
            string queryUpdatePhieuNhap = $"UPDATE PhieuNhap SET MaNCC = {maNcc}, MaNV = {maNv}, NgayTao_PN = '{sNgayTaoPN}', TongTien_PN = {tongTienPN} WHERE MaPN = {maPhieu}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryUpdatePhieuNhap, connection);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    // Hiển thị thông báo khi cập nhật phiếu nhập thành công
                    MessageBox.Show("Cập nhật Phiếu Nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LamMoi();
                    // Thực hiện các thao tác sau khi cập nhật thành công
                    // 1. Load lại grid Phiếu nhập
                    HienThiGridPhieuNhap();
                    // 2. Hiển thị chi tiết phiếu nhập vừa cập nhật
                    HienThiGridChiTietVuaThem(maPhieu);
                    
                }
                else
                {
                    MessageBox.Show("Cập nhật Phiếu Nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_XoaPN_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(txt_MaPN.Text.Trim()))
            {
                MessageBox.Show("Không tìm thấy mã phiếu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //lấy dữ liệu
            int maPhieu = Convert.ToInt32(txt_MaPN.Text.Trim());

            // kiểm tra trạng thái trước khi cho cập nhật
            int kiemTra = LayTrangThaiPhieu(maPhieu);
            if (kiemTra == 1)
            {
                MessageBox.Show("Phiếu nhập đã được lưu, vui lòng không chỉnh sửa hoặc xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (string.IsNullOrEmpty(cb_MaNV.Text.Trim()) || string.IsNullOrEmpty(cb_MaNCC.Text.Trim()))
            {
                MessageBox.Show("Thông tin phiếu nhập chưa điền đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã phiếu nhập
            int trangThai = 0;
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa phiếu nhập có mã {maPhieu} và tất cả chi tiết của nó?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try
                {
                    XoaChiTietKhiXoaPhieu(maPhieu);
                    // Cập nhật trạng thái của phiếu nhập thành 0 (đã xóa)
                    string queryDeletePhieuNhap = $"UPDATE PhieuNhap SET TrangThai = {trangThai} WHERE MaPN = {maPhieu}";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryDeletePhieuNhap, connection);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi xóa phiếu nhập thành công
                            MessageBox.Show("Xóa Phiếu Nhập thành công!");

                            // Thực hiện các thao tác sau khi xóa thành công
                            // 1. Load lại grid Phiếu nhập
                            HienThiGridPhieuNhap();
                            // 2. Làm mới các điều khiển
                            LamMoi();
                        }
                        else
                        {
                            MessageBox.Show("Xóa Phiếu Nhập thất bại!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện xóa phiếu nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void grid_PhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grid_PhieuNhap.CurrentRow != null)
                {
                    string sMaPhieu, sMaNV, sMaNCC, dngay, sTongTien;
                    sMaPhieu = grid_PhieuNhap.CurrentRow.Cells[0].Value.ToString();
                    sMaNCC = grid_PhieuNhap.CurrentRow.Cells[1].Value.ToString();
                    sMaNV = grid_PhieuNhap.CurrentRow.Cells[2].Value.ToString();
                    dngay = grid_PhieuNhap.CurrentRow.Cells[3].Value.ToString();
                    sTongTien = grid_PhieuNhap.CurrentRow.Cells[4].Value.ToString();

                    txt_MaPN.Text = sMaPhieu;
                    cb_MaNV.SelectedValue = sMaNV;
                    cb_MaNCC.SelectedValue = sMaNCC;
                    dt_NgayLapPN.Text = dngay;
                    txt_TongTien.Text = sTongTien;
                    

                    int iMaPhieu = Convert.ToInt32(sMaPhieu);
                    HienThiGridChiTietVuaThem(iMaPhieu);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây, ví dụ:
                MessageBox.Show("Lỗi khi hiển thông tin từ grid: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LamMoi()
        {
            HienThiDSNhanVien();
            HienThiDSNCC();

            txt_MaPN.Text = "";
            cb_MaNV.SelectedItem = null;
            cb_MaNCC.SelectedItem = null;
            dt_NgayLapPN.Value = DateTime.Now;
            txt_TongTien.Text = "";
            
            txt_TimPN.Text = "";

            HienThiGridPhieuNhap();
            HienThiGridChiTiet();
            grid_PhieuNhap.ClearSelection();
            grid_ChiTiet.ClearSelection();
        }
        private void btn_LamMoiPN_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        public decimal TinhTongTienPhieuNhap(int maPhieu)
        {
            decimal tongTien = 0;

            try
            {
                string str = "";
                str += "SELECT PN.MaPN, SUM(CT.ThanhTien) AS TongTienPhieuNhap ";
                str += "FROM PhieuNhap PN INNER JOIN CTPhieuNhap CT ON PN.MaPN = CT.MaPN ";
                str += "WHERE PN.MaPN = " + maPhieu;
                str += "GROUP BY PN.MaPN ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(str, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Lấy tổng tiền từ cột TongTienPhieuNhap
                        tongTien = Convert.ToDecimal(reader["TongTienPhieuNhap"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng tiền phiếu nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return tongTien;

        }
        public void CapNhatTongTien(int maPhieu)
        {
            try
            {
                // Tính tổng tiền của phiếu nhập
                decimal tongTien = TinhTongTienPhieuNhap(maPhieu);

                // Cập nhật tổng tiền vào cơ sở dữ liệu
                string queryUpdate = $"UPDATE PhieuNhap SET TongTien_PN = {tongTien} WHERE MaPN = {maPhieu}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryUpdate, connection);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật tổng tiền phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật tổng tiền phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật tổng tiền phiếu nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void XoaChiTietKhiXoaPhieu(int maPhieu)
        {
            try
            {
                // Xóa tất cả các chi tiết phiếu nhập có mã phiếu nhập tương ứng
                string queryDeleteChiTiet = $"DELETE FROM CTPhieuNhap WHERE MaPN = {maPhieu}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryDeleteChiTiet, connection);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Hiển thị thông báo khi xóa thành công
                        MessageBox.Show("Xóa chi tiết phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy chi tiết phiếu nhập để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện xóa chi tiết phiếu nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //CHI TIẾT
        private void btn_Plus_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(cb_Sach.Text.Trim()) ||
                string.IsNullOrEmpty(num_GiaNhap.Text.Trim()) ||
                string.IsNullOrEmpty(num_SoLuongNhap.Text.Trim()))
            {
                MessageBox.Show("Thông tin chi tiết chưa điền đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu 
            int maPhieu = Convert.ToInt32(txt_MaPN.Text.Trim());

            // kiểm tra trạng thái trước khi cho cập nhật
            int kiemTra = LayTrangThaiPhieu(maPhieu);
            if (kiemTra == 1)
            {
                MessageBox.Show("Phiếu nhập đã được lưu, vui lòng không chỉnh sửa hoặc xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                int maSach = Convert.ToInt32(cb_Sach.SelectedValue);
                int soLuong = (int)num_SoLuongNhap.Value;

                decimal donGia = num_GiaNhap.Value;
                decimal thanhTien = soLuong * donGia;

                // Kiểm tra nếu đã tồn tại mã phiếu nhập và mã sách trong bảng CTPhieuNhap
                string queryCheckExist = $"SELECT COUNT(*) FROM CTPhieuNhap WHERE MaPN = {maPhieu} AND MaSach = {maSach}";
                int existingRows = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryCheckExist, connection);
                    connection.Open();
                    existingRows = (int)command.ExecuteScalar();
                }

                if (existingRows > 0)
                {
                    // Nếu đã tồn tại, chỉ cập nhật số lượng nhập
                    string queryUpdate = $"UPDATE CTPhieuNhap SET SoLuongNhap = SoLuongNhap + {soLuong}, ThanhTien = ThanhTien + {thanhTien} WHERE MaPN = {maPhieu} AND MaSach = {maSach}";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryUpdate, connection);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi cập nhật thành công
                            MessageBox.Show("Cập nhật số lượng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LamMoiChiTiet();
                            // Thực hiện các thao tác cần thiết sau khi cập nhật
                            // Ví dụ: cập nhật lại grid view, tính lại tổng tiền, v.v.

                            // Gọi phương thức để hiển thị lại grid view chi tiết phiếu nhập
                            HienThiGridChiTietVuaThem(maPhieu);

                            //Cập nhật lại tổng tiền phiểu nhập và hiện lại grid phiếu nhập;
                            CapNhatTongTien(maPhieu);
                            HienThiGridPhieuNhap();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật số lượng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    // Nếu chưa tồn tại, thêm mới dữ liệu vào bảng CTPhieuNhap
                    string queryInsert = $"INSERT INTO CTPhieuNhap (MaPN, MaSach, SoLuongNhap, DonGiaNhap, ThanhTien) VALUES ({maPhieu}, {maSach}, {soLuong}, {donGia}, {thanhTien})";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryInsert, connection);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi thêm thành công
                            MessageBox.Show("Thêm chi tiết phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LamMoiChiTiet();
                            // Thực hiện các thao tác cần thiết sau khi thêm mới
                            // Ví dụ: cập nhật lại grid view, tính lại tổng tiền, v.v.

                            // Gọi phương thức để hiển thị lại grid view chi tiết phiếu nhập
                            HienThiGridChiTietVuaThem(maPhieu);

                            //Cập nhật lại tổng tiền phiểu nhập và hiện lại grid phiếu nhập;
                            CapNhatTongTien(maPhieu);
                            HienThiGridPhieuNhap();
                        }
                        else
                        {
                            MessageBox.Show("Thêm chi tiết phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thêm hoặc cập nhật chi tiết phiếu nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(cb_Sach.Text.Trim()) ||
                string.IsNullOrEmpty(num_GiaNhap.Text.Trim()) ||
                string.IsNullOrEmpty(num_SoLuongNhap.Text.Trim()))
            {
                MessageBox.Show("Thông tin chi tiết chưa điền đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu 
            int maPhieu = Convert.ToInt32(txt_MaPN.Text.Trim());

            // kiểm tra trạng thái trước khi cho cập nhật
            int kiemTra = LayTrangThaiPhieu(maPhieu);
            if (kiemTra == 1)
            {
                MessageBox.Show("Phiếu nhập đã được lưu, vui lòng không chỉnh sửa hoặc xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                // Lấy dữ liệu 
                int maSach = Convert.ToInt32(cb_Sach.SelectedValue);
                int soLuong = (int)num_SoLuongNhap.Value;
                decimal donGia = num_GiaNhap.Value;
                decimal thanhTien = soLuong * donGia;

                // Kiểm tra nếu đã tồn tại mã phiếu nhập và mã sách trong bảng CTPhieuNhap
                string queryCheckExist = $"SELECT COUNT(*) FROM CTPhieuNhap WHERE MaPN = {maPhieu} AND MaSach = {maSach}";
                int existingRows = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryCheckExist, connection);
                    connection.Open();
                    existingRows = (int)command.ExecuteScalar();
                }

                if (existingRows > 0)
                {
                    // Nếu khi sửa thành 1 mã sách khác đã có trong chi tiết
                    string queryUpdate = $"UPDATE CTPhieuNhap SET SoLuongNhap = {soLuong}, DonGiaNhap = {donGia}, ThanhTien = {thanhTien} WHERE MaPN = {maPhieu} AND MaSach = {maSach}";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryUpdate, connection);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi cập nhật thành công
                            MessageBox.Show("Cập nhật chi tiết nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            // Thực hiện các thao tác cần thiết sau khi cập nhật
                            // Ví dụ: cập nhật lại grid view, tính lại tổng tiền, v.v.

                            // Gọi phương thức để hiển thị lại grid view chi tiết phiếu nhập
                            HienThiGridChiTietVuaThem(maPhieu);
                            LamMoiChiTiet();
                            //Cập nhật lại tổng tiền phiểu nhập và hiện lại grid phiếu nhập;
                            CapNhatTongTien(maPhieu);
                            HienThiGridPhieuNhap();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật chi tiết nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    // Nếu sửa thành 1 mã sách mới hoàn toàn, thì thêm
                    string queryInsert = $"INSERT INTO CTPhieuNhap (MaPN, MaSach, SoLuongNhap, DonGiaNhap, ThanhTien) VALUES ({maPhieu}, {maSach}, {soLuong}, {donGia}, {thanhTien})";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryInsert, connection);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi thêm thành công
                            MessageBox.Show("Thêm chi tiết phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LamMoiChiTiet();
                            // Thực hiện các thao tác cần thiết sau khi thêm mới
                            // Ví dụ: cập nhật lại grid view, tính lại tổng tiền, v.v.

                            // Gọi phương thức để hiển thị lại grid view chi tiết phiếu nhập
                            HienThiGridChiTietVuaThem(maPhieu);

                            //Cập nhật lại tổng tiền phiểu nhập và hiện lại grid phiếu nhập;
                            CapNhatTongTien(maPhieu);
                            HienThiGridPhieuNhap();
                        }
                        else
                        {
                            MessageBox.Show("Thêm chi tiết phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện cập nhật chi tiết phiếu nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(cb_Sach.Text.Trim()) ||
                string.IsNullOrEmpty(num_GiaNhap.Text.Trim()) ||
                string.IsNullOrEmpty(num_SoLuongNhap.Text.Trim()))
            {
                MessageBox.Show("Thông tin chi tiết chưa điền đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy dữ liệu 
            int maPhieu = Convert.ToInt32(txt_MaPN.Text.Trim());

            // kiểm tra trạng thái trước khi cho cập nhật
            int kiemTra = LayTrangThaiPhieu(maPhieu);
            if (kiemTra == 1)
            {
                MessageBox.Show("Phiếu nhập đã được lưu, vui lòng không chỉnh sửa hoặc xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                // Lấy dữ liệu 
                int maSach = Convert.ToInt32(cb_Sach.SelectedValue);
                int soLuong = (int)num_SoLuongNhap.Value;
                decimal donGia = num_GiaNhap.Value;
                decimal thanhTien = soLuong * donGia;

                // Kiểm tra nếu đã tồn tại mã phiếu nhập và mã sách trong bảng CTPhieuNhap
                string queryCheckExist = $"SELECT COUNT(*) FROM CTPhieuNhap WHERE MaPN = {maPhieu} AND MaSach = {maSach}";
                int existingRows = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryCheckExist, connection);
                    connection.Open();
                    existingRows = (int)command.ExecuteScalar();
                }

                if (existingRows > 0)
                {
                    // Hiển thị hộp thoại xác nhận trước khi xóa
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết phiếu nhập này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Nếu tồn tại chi tiết phiếu nhập và người dùng đồng ý xóa, thì thực hiện xóa
                        string queryDelete = $"DELETE FROM CTPhieuNhap WHERE MaPN = {maPhieu} AND MaSach = {maSach}";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(queryDelete, connection);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Hiển thị thông báo khi xóa thành công
                                MessageBox.Show("Xóa chi tiết nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LamMoiChiTiet();

                                // Thực hiện các thao tác cần thiết sau khi xóa
                                // Ví dụ: cập nhật lại grid view, tính lại tổng tiền, v.v.

                                // Gọi phương thức để hiển thị lại grid view chi tiết phiếu nhập
                                HienThiGridChiTietVuaThem(maPhieu);

                                //Cập nhật lại tổng tiền phiểu nhập và hiện lại grid phiếu nhập;
                                CapNhatTongTien(maPhieu);
                                HienThiGridPhieuNhap();

                            }
                            else
                            {
                                MessageBox.Show("Xóa chi tiết nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chi tiết nhập không tồn tại trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện xóa chi tiết phiếu nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LamMoiChiTiet()
        {
            HienThiDSSach();

            cb_Sach.SelectedItem = null;
            num_GiaNhap.Value = 0;
            num_SoLuongNhap.Value = 0;
            grid_ChiTiet.ClearSelection();
        }
        private void btn_Update_Click(object sender, EventArgs e) // hàm làm mới chi tiết, đặt lộn tên thui ahihi
        {
            LamMoiChiTiet();
        }

        private void grid_ChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grid_ChiTiet.CurrentRow != null)
                {
                    string sMaChiTiet, sMaPN, sMaSach, sDonGia, sThanhTien;
                    int iSoLuong;

                    // Lấy thông tin từ dòng hiện tại của grid_ChiTiet
                    sMaChiTiet = grid_ChiTiet.CurrentRow.Cells[0].Value.ToString();
                    sMaPN = grid_ChiTiet.CurrentRow.Cells[1].Value.ToString();
                    sMaSach = grid_ChiTiet.CurrentRow.Cells[2].Value.ToString();
                    iSoLuong = Convert.ToInt32(grid_ChiTiet.CurrentRow.Cells[3].Value);
                    sDonGia = grid_ChiTiet.CurrentRow.Cells[4].Value.ToString();
                    sThanhTien = grid_ChiTiet.CurrentRow.Cells[5].Value.ToString();

                    // Hiển thị thông tin lên các điều khiển tương ứng
                    lbl_MaChiTiet.Text = $"Mã chi tiết: {sMaChiTiet}";
                    txt_MaPN.Text = sMaPN;
                    cb_Sach.SelectedValue = sMaSach;
                    num_SoLuongNhap.Value = iSoLuong;
                    num_GiaNhap.Value = Convert.ToDecimal(sDonGia);

                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây, ví dụ:
                MessageBox.Show("Lỗi khi hiển thị thông tin từ grid: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TimPN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimPN.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền thông tin phiếu nhập cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //LẤY DỮ LIỆU
            string tim = txt_TimPN.Text.Trim();

            try
            {
                string query = "SELECT * FROM PhieuNhap WHERE TrangThai !=0 AND ";
                query += "MaPN = @tim OR ";
                query += "TongTien_PN = @tim OR ";
                query += "MaNCC IN (SELECT MaNCC FROM NhaCungCap WHERE TenNCC LIKE N'%' + @tim + '%') OR ";
                query += "MaNV IN (SELECT MaNV FROM NhanVien WHERE TenNV LIKE N'%' + @tim + '%')";

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
                    grid_PhieuNhap.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn tìm kiếm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(txt_MaPN.Text.Trim()))
            {
                MessageBox.Show("Không tìm thấy mã phiếu để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(cb_MaNV.Text.Trim()) || string.IsNullOrEmpty(cb_MaNCC.Text.Trim()))
            {
                MessageBox.Show("Thông tin phiếu nhập chưa điền đủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã phiếu nhập
            int maPhieu = Convert.ToInt32(txt_MaPN.Text.Trim());
            int kiemTra = LayTrangThaiPhieu(maPhieu);
            if (kiemTra == 1)
            {
                MessageBox.Show("Phiếu nhập đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            int trangThai = 1;
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn lưu phiếu nhập có mã {maPhieu} và tất cả chi tiết của nó?", "Xác nhận lưu", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try
                {
                    //thực hiện cập nhật ở bảng sách
                    ThaoTacCapNhatSoLuongBangSach(maPhieu);
                    // Cập nhật trạng thái của phiếu nhập thành 1 (đã lưu)
                    string queryDeletePhieuNhap = $"UPDATE PhieuNhap SET TrangThai = {trangThai} WHERE MaPN = {maPhieu}";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(queryDeletePhieuNhap, connection);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Hiển thị thông báo khi xóa phiếu nhập thành công
                            MessageBox.Show("Lưu Phiếu Nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Thực hiện các thao tác sau khi xóa thành công
                            // 1. Load lại grid Phiếu nhập
                            HienThiGridPhieuNhap();
                            // 2. Làm mới các điều khiển
                            LamMoi();
                        }
                        else
                        {
                            MessageBox.Show("Lưu Phiếu Nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực hiện lưu phiếu nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                return;
            }

            
        }

        //thực hiện thao tác cập nhật số lượng sách trong bảng sách sau khi đã lưu
        public void ThaoTacCapNhatSoLuongBangSach(int maPhieuNhap)
        {
            try
            {
                string query = "SELECT MaSach, SoLuongNhap FROM CTPhieuNhap WHERE MaPN = @MaPN";

                // Tạo một DataTable để lưu trữ dữ liệu từ truy vấn
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaPN", maPhieuNhap);

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
                    int soLuongNhap = Convert.ToInt32(row["SoLuongNhap"]);

                    string updateQuery = "UPDATE Sach SET SoLuong = SoLuong + @SoLuongNhap WHERE MaSach = @MaSach";

                    using (SqlConnection updateConnection = new SqlConnection(connectionString))
                    {
                        updateConnection.Open();

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, updateConnection))
                        {
                            updateCommand.Parameters.AddWithValue("@SoLuongNhap", soLuongNhap);
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

        private void btn_InPN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MaPN.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maPhieu = Convert.ToInt32(txt_MaPN.Text.Trim());
            frmReportPN frm = new frmReportPN(maPhieu);
            frm.Show();
        }
    }
}
