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
    public partial class frmThongKe : Form
    {
        public string connectionString = "Data Source=QUANGCUONG\\SQLEXPRESS;Initial Catalog=DA_QLSACH;User ID=sa;Password=123;Integrated Security=False;";

        public frmThongKe()
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
        public void load_DSSachDoiTenThongKe(string str, DataGridView dtv)
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(str, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                // Đảm bảo các cột tồn tại trong DataGridView trước khi đổi tên
                if (dtv.Columns.Contains("MaSach"))
                    dtv.Columns["MaSach"].HeaderText = "Mã";
                if (dtv.Columns.Contains("TenSach"))
                    dtv.Columns["TenSach"].HeaderText = "Tên sách";
                if (dtv.Columns.Contains("TongSLNhap"))
                    dtv.Columns["TongSLNhap"].HeaderText = "Số lượng nhập";
                if (dtv.Columns.Contains("TongTienNhap"))
                    dtv.Columns["TongTienNhap"].HeaderText = "Tổng tiền nhập";
                if (dtv.Columns.Contains("TongSLBan"))
                    dtv.Columns["TongSLBan"].HeaderText = "Số lượng bán";
                if (dtv.Columns.Contains("TongTienBan"))
                    dtv.Columns["TongTienBan"].HeaderText = "Doanh Thu";
                if (dtv.Columns.Contains("TonKho"))
                    dtv.Columns["TonKho"].HeaderText = "Số lượng tồn kho";
                // Hiển thị dữ liệu trong DataGridView
                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên cột phiếu nhập. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void HienDanhSachLenGrid()
        {
            string str = "";
            str += "SELECT ";
            str += "Sach.MaSach, Sach.TenSach, ";
            str += "ISNULL(SUM(pn.SoLuongNhap), 0) AS TongSLNhap, ";
            str += "ISNULL(SUM(pn.TongTien_PN), 0) AS TongTienNhap, ";
            str += "ISNULL(SUM(hd.SoLuong), 0) AS TongSLBan, ";
            str += "ISNULL(SUM(hd.TongTien_HD), 0) AS TongTienBan, ";
            str += "Sach.SoLuong AS TonKho ";
            str += "FROM Sach ";
            str += "LEFT JOIN ";
            str += "(SELECT CTPhieuNhap.MaSach, CTPhieuNhap.SoLuongNhap, PhieuNhap.TongTien_PN ";
            str += "FROM PhieuNhap ";
            str += "INNER JOIN CTPhieuNhap ON CTPhieuNhap.MaPN = PhieuNhap.MaPN ";
            str += "WHERE PhieuNhap.TrangThai = 1) AS pn ";
            str += "ON Sach.MaSach = pn.MaSach ";
            str += "LEFT JOIN ";
            str += "(SELECT CTHoaDon.MaSach, CTHoaDon.SoLuong, HoaDon.TongTien_HD ";
            str += "FROM HoaDon ";
            str += "INNER JOIN CTHoaDon ON HoaDon.MaHD = CTHoaDon.MaHD ";
            str += "WHERE HoaDon.TrangThai = 1) AS hd ";
            str += "ON Sach.MaSach = hd.MaSach ";
            str += "GROUP BY Sach.MaSach, Sach.TenSach, Sach.SoLuong ";

            DataSet dataSet = new DataSet();
            load_DSSach(str, grid_ThongKe);
            load_DSSachDoiTenThongKe(str, grid_ThongKe);
        }
        public void HienDanhSachLenHeader()
        {
            string strTongSLNhap = "";
            strTongSLNhap += "SELECT SUM(pn.SoLuongNhap) AS TongSLNhap ";
            strTongSLNhap += "FROM ";
            strTongSLNhap += "(SELECT CTPhieuNhap.MaSach, CTPhieuNhap.SoLuongNhap, PhieuNhap.TongTien_PN ";
            strTongSLNhap += "FROM PhieuNhap ";
            strTongSLNhap += "INNER JOIN CTPhieuNhap ON CTPhieuNhap.MaPN = PhieuNhap.MaPN ";
            strTongSLNhap += "WHERE PhieuNhap.TrangThai = 1) AS pn ";
            HienThiTongSoLuongNhap(strTongSLNhap, txtSoLuongNhap);


            string strTongTienNhap = "";
            strTongTienNhap += "SELECT SUM(PhieuNhap.TongTien_PN) AS TongTienNhap ";
            strTongTienNhap += "FROM PhieuNhap ";
            strTongTienNhap += "WHERE PhieuNhap.TrangThai = 1";
            HienThiTongTienNhap(strTongTienNhap, txtTongTienNhap);

            string strTongSLBan = "";
            strTongSLBan += "SELECT SUM(hd.SoLuong) AS TongSLBan ";
            strTongSLBan += "FROM ";
            strTongSLBan += "(SELECT CTHoaDon.MaSach, CTHoaDon.SoLuong, HoaDon.TongTien_HD ";
            strTongSLBan += "FROM HoaDon ";
            strTongSLBan += "INNER JOIN CTHoaDon ON HoaDon.MaHD = CTHoaDon.MaHD ";
            strTongSLBan += "WHERE HoaDon.TrangThai = 1) AS hd ";
            HienThiTongSoLuongBan(strTongSLBan, txtSoLuongBan);

            string strTongTienBan = "";
            strTongTienBan += "SELECT SUM(HoaDon.TongTien_HD) AS TongTienBan ";
            strTongTienBan += "FROM HoaDon ";
            strTongTienBan += "WHERE HoaDon.TrangThai = 1";
            HienThiTongTienBan(strTongTienBan, txtTongTienBan);

            string strTonKho = "";
            strTonKho += "SELECT SUM(Sach.SoLuong) AS TonKho ";
            strTonKho += "FROM Sach ";
            strTonKho += "WHERE Sach.TrangThai_Sach = 1";
            HienThiTonKho(strTonKho, txtTonKho);

            decimal tongTienLai = TinhTienLai();
            if(tongTienLai <= 0)
            {
                txtLai.Text = "0";
            }
            else
            {
                txtLai.Text = tongTienLai.ToString();
            }
        }


        private void frmThongKe_Load(object sender, EventArgs e)
        {
            HienDanhSachLenGrid();
            HienDanhSachLenHeader();
        }
        public void HienThiTongSoLuongNhap(string str, TextBox txtSoLuongNhap)
        {
            // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                try
                {
                    sqlconn.Open();

                    // Thực hiện truy vấn và lấy dữ liệu từ cơ sở dữ liệu
                    SqlCommand cmd = new SqlCommand(str, sqlconn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Kiểm tra dữ liệu trả về từ truy vấn
                    if (reader.HasRows)
                    {
                        // Khai báo biến tổng số lượng nhập và tổng tiền nhập
                        int tongSoLuongNhap = 0;

                        // Đọc dữ liệu từ mỗi dòng kết quả
                        while (reader.Read())
                        {
                            tongSoLuongNhap += Convert.ToInt32(reader["TongSLNhap"]);
                        }

                        // Hiển thị kết quả trong TextBox tương ứng
                        txtSoLuongNhap.Text = tongSoLuongNhap.ToString();
                    }
                    else
                    {
                        // Nếu không có dữ liệu, hiển thị giá trị mặc định hoặc rỗng trong TextBox
                        txtSoLuongNhap.Text = "0";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị tổng số lượng nhập. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void HienThiTongTienNhap(string str, TextBox txtTongTienNhap)
        {
            // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                try
                {
                    sqlconn.Open();

                    // Thực hiện truy vấn và lấy dữ liệu từ cơ sở dữ liệu
                    SqlCommand cmd = new SqlCommand(str, sqlconn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Kiểm tra dữ liệu trả về từ truy vấn
                    if (reader.HasRows)
                    {
                        // Khai báo biến tổng số lượng nhập và tổng tiền nhập
                        decimal tongTienNhap = 0;

                        // Đọc dữ liệu từ mỗi dòng kết quả
                        while (reader.Read())
                        {
                            tongTienNhap += Convert.ToDecimal(reader["TongTienNhap"]);
                        }

                        // Hiển thị kết quả trong TextBox tương ứng
                        txtTongTienNhap.Text = tongTienNhap.ToString();
                    }
                    else
                    {
                        // Nếu không có dữ liệu, hiển thị giá trị mặc định hoặc rỗng trong TextBox
                        txtTongTienNhap.Text = "0";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị tổng tiền nhập. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void HienThiTongSoLuongBan(string str, TextBox txtSoLuongBan)
        {
            // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                try
                {
                    sqlconn.Open();

                    // Thực hiện truy vấn và lấy dữ liệu từ cơ sở dữ liệu
                    SqlCommand cmd = new SqlCommand(str, sqlconn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Kiểm tra dữ liệu trả về từ truy vấn
                    if (reader.HasRows)
                    {
                        // Khai báo biến tổng số lượng nhập và tổng tiền nhập
                        int tongSoLuongBan = 0;

                        // Đọc dữ liệu từ mỗi dòng kết quả
                        while (reader.Read())
                        {
                            tongSoLuongBan += Convert.ToInt32(reader["TongSLBan"]);
                        }

                        // Hiển thị kết quả trong TextBox tương ứng
                        txtSoLuongBan.Text = tongSoLuongBan.ToString();
                    }
                    else
                    {
                        // Nếu không có dữ liệu, hiển thị giá trị mặc định hoặc rỗng trong TextBox
                        txtSoLuongBan.Text = "0";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị tổng số lượng bán. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void HienThiTongTienBan(string str, TextBox txtTongTienBan)
        {
            // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                try
                {
                    sqlconn.Open();

                    // Thực hiện truy vấn và lấy dữ liệu từ cơ sở dữ liệu
                    SqlCommand cmd = new SqlCommand(str, sqlconn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Kiểm tra dữ liệu trả về từ truy vấn
                    if (reader.HasRows)
                    {
                        // Khai báo biến tổng số lượng nhập và tổng tiền nhập
                        decimal tongTienBan = 0;

                        // Đọc dữ liệu từ mỗi dòng kết quả
                        while (reader.Read())
                        {
                            tongTienBan += Convert.ToDecimal(reader["TongTienBan"]);
                        }

                        // Hiển thị kết quả trong TextBox tương ứng
                        txtTongTienBan.Text = tongTienBan.ToString();
                    }
                    else
                    {
                        // Nếu không có dữ liệu, hiển thị giá trị mặc định hoặc rỗng trong TextBox
                        txtTongTienBan.Text = "0";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị tổng tiền bán. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void HienThiTonKho(string str, TextBox txtTonKho)
        {
            // Kết nối đến cơ sở dữ liệu và thực hiện truy vấn
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                try
                {
                    sqlconn.Open();

                    // Thực hiện truy vấn và lấy dữ liệu từ cơ sở dữ liệu
                    SqlCommand cmd = new SqlCommand(str, sqlconn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Kiểm tra dữ liệu trả về từ truy vấn
                    if (reader.HasRows)
                    {
                        // Khai báo biến tổng số lượng nhập và tổng tiền nhập
                        int tonKho = 0;

                        // Đọc dữ liệu từ mỗi dòng kết quả
                        while (reader.Read())
                        {
                            tonKho += Convert.ToInt32(reader["TonKho"]);
                        }

                        // Hiển thị kết quả trong TextBox tương ứng
                        txtTonKho.Text = tonKho.ToString();
                    }
                    else
                    {
                        // Nếu không có dữ liệu, hiển thị giá trị mặc định hoặc rỗng trong TextBox
                        txtTonKho.Text = "0";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi hiển thị tổng tồn kho. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public decimal TinhTienLai()
        {
            decimal tongTienNhap = 0;
            decimal tongTienBan = 0;

            // Truy vấn tổng tiền nhập
            string queryTongTienNhap = "SELECT SUM(PhieuNhap.TongTien_PN) AS TongTienNhap FROM PhieuNhap WHERE PhieuNhap.TrangThai = 1";

            // Truy vấn tổng tiền bán
            string queryTongTienBan = "SELECT SUM(HoaDon.TongTien_HD) AS TongTienBan FROM HoaDon WHERE HoaDon.TrangThai = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Truy vấn tổng tiền nhập
                    SqlCommand cmdTongTienNhap = new SqlCommand(queryTongTienNhap, connection);
                    object resultTongTienNhap = cmdTongTienNhap.ExecuteScalar();
                    if (resultTongTienNhap != DBNull.Value)
                    {
                        tongTienNhap = Convert.ToDecimal(resultTongTienNhap);
                    }

                    // Truy vấn tổng tiền bán
                    SqlCommand cmdTongTienBan = new SqlCommand(queryTongTienBan, connection);
                    object resultTongTienBan = cmdTongTienBan.ExecuteScalar();
                    if (resultTongTienBan != DBNull.Value)
                    {
                        tongTienBan = Convert.ToDecimal(resultTongTienBan);
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tính tiền lãi. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Tính tiền lãi
            decimal tienLai = 0;
            tienLai = tongTienBan - tongTienNhap;
            return tienLai;
        }

        public void HienDanhSachTheoNgay(string ngayBatDau, string ngayKetThuc)
        {
            string str = "";
            str += "SELECT ";
            str += "Sach.MaSach, Sach.TenSach, ";
            str += "ISNULL(SUM(pn.SoLuongNhap), 0) AS TongSLNhap, ";
            str += "ISNULL(SUM(pn.TongTien_PN), 0) AS TongTienNhap, ";
            str += "ISNULL(SUM(hd.SoLuong), 0) AS TongSLBan, ";
            str += "ISNULL(SUM(hd.TongTien_HD), 0) AS TongTienBan, ";
            str += "Sach.SoLuong AS TonKho ";
            str += "FROM Sach ";
            str += "LEFT JOIN ";
            str += "(SELECT CTPhieuNhap.MaSach, CTPhieuNhap.SoLuongNhap, PhieuNhap.TongTien_PN ";
            str += "FROM PhieuNhap ";
            str += "INNER JOIN CTPhieuNhap ON CTPhieuNhap.MaPN = PhieuNhap.MaPN ";
            str += "WHERE PhieuNhap.TrangThai = 1 AND ";
            str += $"PhieuNhap.NgayTao_PN BETWEEN '{ngayBatDau}' AND '{ngayKetThuc}') AS pn ";
            str += "ON Sach.MaSach = pn.MaSach ";
            str += "LEFT JOIN ";
            str += "(SELECT CTHoaDon.MaSach, CTHoaDon.SoLuong, HoaDon.TongTien_HD ";
            str += "FROM HoaDon ";
            str += "INNER JOIN CTHoaDon ON HoaDon.MaHD = CTHoaDon.MaHD ";
            str += "WHERE HoaDon.TrangThai = 1 AND ";
            str += $"HoaDon.NgayTao_HD BETWEEN '{ngayBatDau}' AND '{ngayKetThuc}') AS hd ";
            str += "ON Sach.MaSach = hd.MaSach ";
            str += "GROUP BY Sach.MaSach, Sach.TenSach, Sach.SoLuong ";

            DataSet dataSet = new DataSet();
            load_DSSach(str, grid_ThongKe);
            load_DSSachDoiTenThongKe(str, grid_ThongKe);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ngayBatDau = dp_NgayBatDau.Value.ToString("yyyy-MM-dd");
            string ngayKetThuc = dp_NgayKetThuc.Value.ToString("yyyy-MM-dd");
            HienDanhSachTheoNgay(ngayBatDau, ngayKetThuc);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            dp_NgayBatDau.Value = DateTime.Now;
            dp_NgayKetThuc.Value = DateTime.Now;
            HienDanhSachLenGrid();
        }
    }
}
