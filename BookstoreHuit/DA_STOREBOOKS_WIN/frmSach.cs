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
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace DA_STOREBOOKS_WIN
{
    public partial class frmSach : Form
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
                MessageBox.Show("Lỗi => Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void load_DSSachDoiTenCotSach(string str, DataGridView dtv)
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
                    dtv.Columns["MaSach"].HeaderText = "Mã sách";
                if (dtv.Columns.Contains("TenSach"))
                    dtv.Columns["TenSach"].HeaderText = "Tên sách";
                if (dtv.Columns.Contains("TenTacGia"))
                    dtv.Columns["TenTacGia"].HeaderText = "Tên tác giả";
                if (dtv.Columns.Contains("TenTheLoai"))
                    dtv.Columns["TenTheLoai"].HeaderText = "Thể loại";
                if (dtv.Columns.Contains("HinhAnh"))
                    dtv.Columns["HinhAnh"].HeaderText = "Hình ảnh";
                if (dtv.Columns.Contains("SoLuong"))
                    dtv.Columns["SoLuong"].HeaderText = "Số lượng";
                if (dtv.Columns.Contains("GiaBan"))
                    dtv.Columns["GiaBan"].HeaderText = "Giá bán";
                if (dtv.Columns.Contains("TrangThai_Sach"))
                    dtv.Columns["TrangThai_Sach"].HeaderText = "Trạng thái";
                if (dtv.Columns.Contains("NgayXuatBan"))
                    dtv.Columns["NgayXuatBan"].HeaderText = "Ngày xuất bản";

                // Hiển thị dữ liệu trong DataGridView
                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên grid sách. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void load_DSSachDoiTenCotTacGia(string str, DataGridView dtv)
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(str, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                // Đảm bảo các cột tồn tại trong DataGridView trước khi đổi tên
                if (dtv.Columns.Contains("MaTG"))
                    dtv.Columns["MaTG"].HeaderText = "Mã tác giả";
                if (dtv.Columns.Contains("TenTG"))
                    dtv.Columns["TenTG"].HeaderText = "Tên tác giả";
                if (dtv.Columns.Contains("MoTa"))
                    dtv.Columns["MoTa"].HeaderText = "Giới thiệu chung";

                // Hiển thị dữ liệu trong DataGridView
                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên grid tác giả. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void load_DSSachDoiTenCotTheLoai(string str, DataGridView dtv)
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(str, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                // Đảm bảo các cột tồn tại trong DataGridView trước khi đổi tên
                if (dtv.Columns.Contains("MaTL"))
                    dtv.Columns["MaTL"].HeaderText = "Mã thể loại";
                if (dtv.Columns.Contains("TenTL"))
                    dtv.Columns["TenTL"].HeaderText = "Tên thể loại";

                // Hiển thị dữ liệu trong DataGridView
                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên grid thể loại. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void load_DSSachDoiTenCotNCC(string str, DataGridView dtv)
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(str, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                // Đảm bảo các cột tồn tại trong DataGridView trước khi đổi tên
                if (dtv.Columns.Contains("MaNCC"))
                    dtv.Columns["MaNCC"].HeaderText = "Mã nhà cung cấp";
                if (dtv.Columns.Contains("TenNCC"))
                    dtv.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
                if (dtv.Columns.Contains("DiaChiNCC"))
                    dtv.Columns["DiaChiNCC"].HeaderText = "Địa chỉ";
                if (dtv.Columns.Contains("SDT_NCC"))
                    dtv.Columns["SDT_NCC"].HeaderText = "Số điện thoại";
                if (dtv.Columns.Contains("Email_NCC"))
                    dtv.Columns["Email_NCC"].HeaderText = "Email";
                if (dtv.Columns.Contains("NgayTao_NCC"))
                    dtv.Columns["NgayTao_NCC"].HeaderText = "Ngày tạo";
                if (dtv.Columns.Contains("TrangThai_NCC"))
                    dtv.Columns["TrangThai_NCC"].HeaderText = "Trạng thái";

                // Hiển thị dữ liệu trong DataGridView
                dtv.DataSource = lt.Tables[0];

                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi tên grid nhà cung cấp. \n=> Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void LoadDataTheLoai()
        {

            string str = "select TheLoai.TenTL from TheLoai";
            load_ComBoBox(str, cb_TheLoai);
        }
        private void LoadDataTacGia()
        {
            string str = "select TacGia.TenTG from TacGia";
            load_ComBoBox(str, cb_TacGia);
        }

        //load combobox theo thầy
        public void HienThiDSTheLoai()
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            String sSql;
            sSql = "SELECT MaTL, TenTL FROM TheLoai";
            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(sSql, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                sqlconn.Close();
                cb_TheLoai.DataSource = lt.Tables[0];
                cb_TheLoai.DisplayMember = "TenTL";
                cb_TheLoai.ValueMember = "MaTL";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi => Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void HienThiDSTacGia()
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);

            String sSql;
            sSql = "SELECT MaTG, TenTG FROM TacGia";
            try
            {
                sqlconn.Open();

                SqlDataAdapter list = new SqlDataAdapter(sSql, sqlconn);
                DataSet lt = new DataSet();
                list.Fill(lt);

                sqlconn.Close();
                cb_TacGia.DataSource = lt.Tables[0];
                cb_TacGia.DisplayMember = "TenTG";
                cb_TacGia.ValueMember = "MaTG";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi => Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public frmSach()
        {
            InitializeComponent();
            //LoadDataTheLoai();
            //LoadDataTacGia();

            //THEO THẦY 
            HienThiDSTheLoai();
            HienThiDSTacGia();
            btn_TimSach.ImageAlign = ContentAlignment.MiddleCenter;
        }

        //HÀM XỬ LÝ FRM SÁCH
        public void HienThiSachLenGird()
        {
            string str = "select * from Sach";
            load_DSSach(str, grid_Sach);
            load_DSSachDoiTenCotSach(str, grid_Sach);
            grid_Sach.ClearSelection();
        }
        public void HienThiTacGiaLenGird()
        {
            string strTacGia = "select * from TacGia";
            load_DSSach(strTacGia, grid_TacGia);
            load_DSSachDoiTenCotTacGia(strTacGia, grid_TacGia);
            grid_TacGia.ClearSelection();

        }
        public void HienThiTheLoaiLenGird()
        {
            string strTheLoai = "select * from TheLoai";
            load_DSSach(strTheLoai, grid_TheLoai);
            load_DSSachDoiTenCotTheLoai(strTheLoai, grid_TheLoai);
            grid_TheLoai.ClearSelection();

        }
        public void HienThiNCCLenGird()
        {
            string strNCC = "select * from NhaCungCap";
            load_DSSach(strNCC, grid_NCC);
            load_DSSachDoiTenCotNCC(strNCC, grid_NCC);
            grid_NCC.ClearSelection();

        }
        private void frmSach_Load(object sender, EventArgs e)
        {
            HienThiSachLenGird();
            HienThiTacGiaLenGird();
            HienThiTheLoaiLenGird();
            HienThiNCCLenGird();
            HienThiDSTheLoai();
            HienThiDSTacGia();
            cb_TacGia.SelectedIndex = -1;
            cb_TheLoai.SelectedIndex = -1;
        }

        //FORM XỬ LÝ SÁCH
        private void hamTaoMoiSach()
        {
            txt_MaSach.Text = "";
            txt_TenSach.Text = "";
           
            num_GiaBan.Value = 0;
            num_SoLuong.Value = 0;
            cb_TrangThaiSach.SelectedItem = null;
            btn_ChonAnh.Text = "chọn ảnh";
            picAnhSach.Image = null;
            if (DateTime.Now > dtp_NgayXB.MaxDate || DateTime.Now < dtp_NgayXB.MinDate)
            {
                dtp_NgayXB.MinDate = DateTime.Now.AddDays(-365 * 20); // Thiết lập MinDate là một năm trước
                dtp_NgayXB.MaxDate = DateTime.Now.AddDays(365); // Thiết lập MaxDate là một năm sau
            }

            dtp_NgayXB.Value = DateTime.Now;

            txt_TimSach.Text = "";
            HienThiSachLenGird();
            HienThiDSTheLoai();
            HienThiDSTacGia();
            cb_TheLoai.SelectedItem = null;
            cb_TacGia.SelectedItem = null;
        }
        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            hamTaoMoiSach();
        }
        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp, *.webp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp; *.webp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string lpresent = openFileDialog.FileName;

                string lnew = Application.StartupPath + "\\IMG\\" + Path.GetFileName(lpresent);

                if (!File.Exists(lnew))
                {
                    File.Copy(lpresent, lnew);
                    btn_ChonAnh.Text = Path.GetFileName(lpresent);
                    picAnhSach.Image = new Bitmap(Application.StartupPath + "\\IMG\\" + Path.GetFileName(lpresent));
                }
                else
                {
                    btn_ChonAnh.Text = Path.GetFileName(lpresent);
                    picAnhSach.Image = new Bitmap(Application.StartupPath + "\\IMG\\" + Path.GetFileName(lpresent));
                }

            }      

        }

        private bool KiemTraTenSachTonTai(string tenSach)
        {
            bool kq = true; // Giả sử tên khách hàng đã tồn tại
            string sSql = "SELECT COUNT(*) FROM Sach WHERE TenSach = @tenSach";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand myCommand = new SqlCommand(sSql, myConnection))
                    {
                        // Thêm tham số vào truy vấn để tránh tấn công SQL injection
                        myCommand.Parameters.AddWithValue("@tenSach", tenSach);

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
                MessageBox.Show("Lỗi kiểm tra sách tồn tại. Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return kq;
        }
        private bool KiemTraRong()
        {
            bool kq = false; //không rỗng
            if (string.IsNullOrEmpty(txt_TenSach.Text.Trim()) ||
                string.IsNullOrEmpty(cb_TacGia.Text.Trim()) ||
                string.IsNullOrEmpty(cb_TheLoai.Text.Trim()) ||
                string.IsNullOrEmpty(num_GiaBan.Text.Trim()) ||
                string.IsNullOrEmpty(cb_TrangThaiSach.Text.Trim()))
            {
                kq = true;
            }
            return kq;
        }
        private void btn_ThemSach_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra rỗng
                bool kiemRong = KiemTraRong();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }
             
                // Kiểm tra xem sách đã tồn tại trong cơ sở dữ liệu chưa

                string tenSach = txt_TenSach.Text.Trim();

                bool tenSachTonTai = KiemTraTenSachTonTai(tenSach);

                if (tenSachTonTai)
                {
                    MessageBox.Show("Sách đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                // Đọc hình ảnh từ PictureBox
                Image image = picAnhSach.Image;

                //lấy dữ liệu
                string maSach = txt_MaSach.Text.Trim();
                string theLoaiSach = cb_TheLoai.Text;               
                string tacGiaSach = cb_TacGia.Text;
                string soLuongSach = num_SoLuong.Value.ToString();
                string giaBanSach = num_GiaBan.Value.ToString();

                string trangThaiSach = cb_TrangThaiSach.Text;
                string trangThaiSachValue = "1";
                if (trangThaiSach != null)
                {

                    trangThaiSachValue = (trangThaiSach.ToString() == "Còn hàng") ? "1" : "0";
                }

                DateTime ngayXuatBan = dtp_NgayXB.Value;
                string imageData = btn_ChonAnh.Text;

                load_TruyVan("INSERT INTO Sach VALUES(N'" + txt_TenSach.Text + "',N'" + cb_TacGia.Text + "',N'" + cb_TheLoai.Text + "',N'" + btn_ChonAnh.Text + "',N'" + num_SoLuong.Value + "',N'" + num_GiaBan.Value + "',N'" + trangThaiSachValue.ToString() + "',N'" + dtp_NgayXB.Value + "')");

                MessageBox.Show("Sách đã được thêm vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hamTaoMoiSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách mới vào database.\n: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grid_Sach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = grid_Sach.CurrentCell.RowIndex;

            if (rowIndex >= 0 && rowIndex < grid_Sach.Rows.Count)
            {
                DataGridViewRow row = grid_Sach.Rows[rowIndex];

                if (row.Cells[0].Value != null)
                {
                    txt_MaSach.Text = row.Cells[0].Value.ToString();
                }
                if (row.Cells[1].Value != null)
                {
                    txt_TenSach.Text = row.Cells[1].Value.ToString();
                }
                if (row.Cells[2].Value != null)
                {
                    cb_TacGia.Text = row.Cells[2].Value.ToString();
                }
                if (row.Cells[3].Value != null)
                {
                    cb_TheLoai.Text = row.Cells[3].Value.ToString();
                }
                if (row.Cells[4].Value != null)
                {
                    btn_ChonAnh.Text = row.Cells[4].Value.ToString();
                    if (File.Exists(Application.StartupPath + "\\IMG\\" + btn_ChonAnh.Text))
                    {
                        picAnhSach.Image = new Bitmap(Application.StartupPath + "\\IMG\\" + btn_ChonAnh.Text);
                    }
                }
                if (row.Cells[5].Value != null)
                {
                    num_SoLuong.Value = Convert.ToDecimal(row.Cells[5].Value);
                }
                if (row.Cells[6].Value != null)
                {
                    num_GiaBan.Value = Convert.ToDecimal(row.Cells[6].Value);
                }
                if (row.Cells[7].Value != null)
                {   string trangThai = row.Cells[7].Value.ToString();
                    if(trangThai == "1")
                    {
                        cb_TrangThaiSach.SelectedIndex = 0;
                    }
                    else cb_TrangThaiSach.SelectedIndex = 1;
                }
                if (row.Cells[8].Value != null)
                {
                    if (DateTime.TryParse(row.Cells[8].Value.ToString(), out DateTime ngayXB))
                    {
                        dtp_NgayXB.Value = ngayXB;
                    }
                    else
                    {
                        // Xử lý nếu giá trị không hợp lệ
                        // gán mặc định hoặc hiển thị thông báo lỗi
                    }
                }
            }
        }

        private void btn_CapNhatSach_Click(object sender, EventArgs e)
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

                if (string.IsNullOrEmpty(txt_MaSach.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy mã sách để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện nữa
                }

                // Đọc hình ảnh từ PictureBox
                Image image = picAnhSach.Image;

                //lấy dữ liệu
                string maSach = txt_MaSach.Text.Trim();
                string tenSach = txt_TenSach.Text.Trim();
                string theLoaiSach = cb_TheLoai.Text;
                string tacGiaSach = cb_TacGia.Text;
                string soLuongSach = num_SoLuong.Value.ToString();
                string giaBanSach = num_GiaBan.Value.ToString();

                string trangThaiSach = cb_TrangThaiSach.Text;
                string trangThaiSachValue = "1";
                if (trangThaiSach != null)
                {

                    trangThaiSachValue = (trangThaiSach.ToString() == "Còn hàng") ? "1" : "0";
                }

                DateTime ngayXuatBan = dtp_NgayXB.Value;
                string imageData = btn_ChonAnh.Text;

                load_TruyVan($"UPDATE Sach SET [TenSach] = N'{tenSach}', [TenTacGia] = N'{tacGiaSach}', [TenTheLoai] = N'{theLoaiSach}', [HinhAnh] = '{imageData}', [SoLuong] = {soLuongSach}, [GiaBan] = {giaBanSach}, [TrangThai_Sach] = N'{trangThaiSachValue}' , [NgayXuatBan] = '{ngayXuatBan.ToString("yyyy-MM-dd")}' WHERE [MaSach] = {maSach}");
       
                MessageBox.Show("Dữ Liệu đã được cập nhật vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hamTaoMoiSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin sách:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_XoaSach_Click(object sender, EventArgs e)
        {
            //lấy dữ liệu
            string maSach = txt_MaSach.Text.Trim();
            if (string.IsNullOrEmpty(txt_MaSach.Text.Trim()))
            {
                MessageBox.Show("Không tìm thấy mã sách để xóa: \n ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string tenSach = txt_TenSach.Text.Trim();
            string theLoaiSach = cb_TheLoai.Text;
            string tacGiaSach = cb_TacGia.Text;
            string soLuongSach = num_SoLuong.Value.ToString();
            string giaBanSach = num_GiaBan.Value.ToString();
            string trangThaiSach = cb_TrangThaiSach.Text;
            DateTime ngayXuatBan = dtp_NgayXB.Value;

            string thongTin = "";
            thongTin += $"Bạn có muốn xóa Sách có thông tin: \n";
            thongTin += $"Mã sách: {maSach}\n";
            thongTin += $"Tên sách: {tenSach}\n";
            thongTin += $"Tác giả: {tacGiaSach}\n";
            thongTin += $"Thể loại: {theLoaiSach}\n";
            thongTin += $"Giá bán: {giaBanSach}\n";
            thongTin += $"Ngày xuất bản: {ngayXuatBan}\n";
            thongTin += $"Trạng thái: {trangThaiSach}\n";
            DialogResult dlg = MessageBox.Show(thongTin, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                try
                {
                    load_TruyVan($"DELETE FROM Sach WHERE MaSach = '{maSach}'");

                    // Hiển thị thông báo và làm mới danh sách sách
                    MessageBox.Show("Dữ liệu đã được xóa khỏi cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiSachLenGird();
                    hamTaoMoiSach();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sách có trong database:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }
        private byte[] ImageToByteArray(Image image)
        {
            // Kiểm tra hình ảnh đã được cung cấp chưa
            if (image == null)
            {
                // Nếu hình ảnh không hợp lệ, trả về một mảng byte rỗng
                return new byte[0];
            }

            // Nếu hình ảnh hợp lệ, tiến hành chuyển đổi
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btn_TimSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimSach.Text.Trim()))
            {
                MessageBox.Show("Nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string timSach = txt_TimSach.Text.Trim();
            string str = "select * from Sach where Sach.MaSach like N'%" + timSach + "%' OR Sach.TenSach like N'%" + timSach + "%' or Sach.TenTacGia like N'%" + timSach + "%' or Sach.TenTheLoai like N'%" + timSach + "%'";
            load_DSSach(str, grid_Sach);
            load_DSSachDoiTenCotSach(str, grid_Sach);
        }


        //XỬ LÝ FRM THỂ LOẠI
        private bool KiemTraTenTheLoaiTonTai(string ten)
        {
            bool kq = true; // Giả sử tên khách hàng đã tồn tại
            string sSql = "SELECT COUNT(*) FROM TheLoai WHERE TenTL = @ten";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand myCommand = new SqlCommand(sSql, myConnection))
                    {
                        // Thêm tham số vào truy vấn để tránh tấn công SQL injection
                        myCommand.Parameters.AddWithValue("@ten", ten);

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
                MessageBox.Show("Lỗi kiểm tra thể loại tồn tại.\n Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return kq;
        }
        private bool KiemTraRongTheLoai()
        {
            bool kq = false; //không rỗng
            if (string.IsNullOrEmpty(txt_TenTL.Text.Trim()))
            {
                kq = true;
            }
            return kq;
        }
        private void btn_ThemTL_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra rỗng
                bool kiemRong = KiemTraRongTheLoai();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                // Kiểm tra xem sách đã tồn tại trong cơ sở dữ liệu chưa

                string tenTheLoai = txt_TenTL.Text.Trim();

                bool tenTheLoaiSachTonTai = KiemTraTenTheLoaiTonTai(tenTheLoai);

                if (tenTheLoaiSachTonTai)
                {
                    MessageBox.Show("Thể loại đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                load_TruyVan(" INSERT INTO TheLoai VALUES(N'"+ txt_TenTL.Text.Trim() +"')");

                MessageBox.Show("Dữ Liệu đã được thêm vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hamLamMoiTheLoai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thể loại mới và CSDL:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void hamLamMoiTheLoai()
        {
            txt_MaTheLoai.Text = "";
            txt_TenTL.Text = "";
            txt_TimTL.Text = "";

            HienThiTheLoaiLenGird();
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            hamLamMoiTheLoai();
        }

        private void btn_CapNhatTL_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra rỗng
                bool kiemRong = KiemTraRongTheLoai();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }
                if (string.IsNullOrEmpty(txt_MaTheLoai.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy mã thể loại để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện nữa
                }
                string maTheLoai = txt_MaTheLoai.Text.Trim();
                string tenTheLoai = txt_TenTL.Text.Trim();

                load_TruyVan("UPDATE TheLoai SET TenTL = N'" +tenTheLoai + "' where MaTL = N'" + maTheLoai + "'");

                MessageBox.Show("Dữ Liệu đã được cập nhật vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hamLamMoiTheLoai();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin thể loại vào CSDL:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_XoaTL_Click(object sender, EventArgs e)
        {
            string maTheLoai = txt_MaTheLoai.Text.Trim();
            if (string.IsNullOrEmpty(txt_MaTheLoai.Text.Trim()))
            {
                MessageBox.Show("Không tìm thấy mã thể loại để xóa: \n ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string tenTheLoai = txt_TenTL.Text.Trim();

            string thongTin = "";
            thongTin += $"Bạn có muốn xóa Thể loại có thông tin: \n";
            thongTin += $"Mã thể loại: {maTheLoai}";
            thongTin += $"Tên thể loại: {tenTheLoai}";

            DialogResult dlg = MessageBox.Show(thongTin, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                try
                {
                    load_TruyVan($"DELETE FROM TheLoai WHERE MaTL = '{maTheLoai}'");

                    // Hiển thị thông báo và làm mới danh sách sách
                    MessageBox.Show("Dữ liệu đã được xóa khỏi cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    hamLamMoiTheLoai();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa thể loại:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_TimTheLoai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimTL.Text.Trim()))
            {
                MessageBox.Show("Nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string timTheLoai = txt_TimTL.Text.Trim();
            string str = " SELECT * FROM TheLoai WHERE MaTL LIKE N'%" + timTheLoai + "%' OR TenTL LIKE N'%" + timTheLoai + "%'";
            load_DSSach(str, grid_TheLoai);
            load_DSSachDoiTenCotTheLoai(str, grid_TheLoai);
        }

        private void grid_TheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = grid_TheLoai.CurrentCell.RowIndex;

            if (rowIndex >= 0 && rowIndex < grid_TheLoai.Rows.Count)
            {
                DataGridViewRow row = grid_TheLoai.Rows[rowIndex];

                if (row.Cells[0].Value != null)
                {
                    txt_MaTheLoai.Text = row.Cells[0].Value.ToString();
                }
                if (row.Cells[1].Value != null)
                {
                    txt_TenTL.Text = row.Cells[1].Value.ToString();
                }               
            }
        }


        //HÀM XỬ LÝ FROM TÁC GIẢ
        private bool KiemTraTenTacGiaTonTai(string ten)
        {
            bool kq = true; // Giả sử tên khách hàng đã tồn tại
            string sSql = "SELECT COUNT(*) FROM TacGia WHERE TenTG = @ten";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand myCommand = new SqlCommand(sSql, myConnection))
                    {
                        // Thêm tham số vào truy vấn để tránh tấn công SQL injection
                        myCommand.Parameters.AddWithValue("@ten", ten);

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
                MessageBox.Show("Lỗi kiểm tra tác giả tồn tại.\n Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return kq;
        }
        private bool KiemTraRongTacGia()
        {
            bool kq = false; //không rỗng
            if (string.IsNullOrEmpty(txt_TenTacGia_TG.Text.Trim()))
            {
                kq = true;
            }
            return kq;
        }
        private void btn_ThemTG_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra rỗng
                bool kiemRong = KiemTraRongTacGia();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                // Kiểm tra xem sách đã tồn tại trong cơ sở dữ liệu chưa

                string tenTacGia = txt_TenTacGia_TG.Text.Trim();

                bool tenTacGiaTonTai = KiemTraTenTacGiaTonTai(tenTacGia);

                if (tenTacGiaTonTai)
                {
                    MessageBox.Show("Tác giả đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                string maTacGia = txt_MaTacGia_TG.Text.Trim();
                string moTa = txt_MoTa.Text.Trim();

                load_TruyVan($"INSERT INTO TacGia (TenTG, MoTa) VALUES (N'{tenTacGia}', N'{moTa}')");

                MessageBox.Show("Dữ Liệu đã được thêm vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hamLamMoiTacGia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tác giả vào CSDL: \n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void hamLamMoiTacGia()
        {
            txt_MaTacGia_TG.Text = "";
            txt_TenTacGia_TG.Text = "";
            txt_MoTa.Text = "";
            txt_TimTG.Text = "";

            HienThiTacGiaLenGird();
        }
        private void btn_LamMoiTG_Click(object sender, EventArgs e)
        {
            hamLamMoiTacGia();
        }

        private void btn_CapNhatTG_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra rỗng
                bool kiemRong = KiemTraRongTacGia();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện nữa
                }
                if (string.IsNullOrEmpty(txt_MaTacGia_TG.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy mã tác giả để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện nữa
                }
                string maTacGia = txt_MaTacGia_TG.Text.Trim();
                string tenTacGia = txt_TenTacGia_TG.Text.Trim();
                string moTa = txt_MoTa.Text.Trim();

                load_TruyVan($"UPDATE TacGia SET TenTG = N'{tenTacGia}', MoTa = N'{moTa}' WHERE MaTG = {maTacGia}");

                MessageBox.Show("Dữ Liệu đã được cập nhât vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hamLamMoiTacGia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin tác giả vào CSDL:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_XoaTG_Click(object sender, EventArgs e)
        {
            string maTacGia = txt_MaTacGia_TG.Text.Trim();
            if (string.IsNullOrEmpty(txt_MaTacGia_TG.Text.Trim()))
            {
                MessageBox.Show("Không tìm thấy mã nhân viên để xóa: \n ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string tenTacGia = txt_TenTacGia_TG.Text.Trim();
            string moTa = txt_MoTa.Text.Trim();

            string thongTin = "";
            thongTin += $"Bạn có muốn xóa Thể loại có thông tin: \n";
            thongTin += $"Mã tác gải: {maTacGia}";
            thongTin += $"Tên tác giả: {tenTacGia}";
            DialogResult dlg = MessageBox.Show(thongTin, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                try
                {
                    load_TruyVan($"DELETE FROM TacGia WHERE MaTG = '{maTacGia}'");

                    // Hiển thị thông báo và làm mới danh sách sách
                    MessageBox.Show("Dữ liệu đã được xóa khỏi cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    hamLamMoiTacGia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa tác giả:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_TimTacGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimTG.Text.Trim()))
            {
                MessageBox.Show("Nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string timTacGia = txt_TimTG.Text.Trim();
            string str = $"SELECT* FROM TacGia WHERE MaTG LIKE N'%{timTacGia}%' OR TenTG LIKE N'%{timTacGia}%' OR MoTa LIKE N'%{timTacGia}%'";
            load_DSSach(str, grid_TacGia);
            load_DSSachDoiTenCotTacGia(str, grid_TacGia);
        }

        private void grid_TacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = grid_TacGia.CurrentCell.RowIndex;

            if (rowIndex >= 0 && rowIndex < grid_TacGia.Rows.Count)
            {
                DataGridViewRow row = grid_TacGia.Rows[rowIndex];

                if (row.Cells[0].Value != null)
                {
                    txt_MaTacGia_TG.Text = row.Cells[0].Value.ToString();
                }
                if (row.Cells[1].Value != null)
                {
                   txt_TenTacGia_TG.Text = row.Cells[1].Value.ToString();
                }
                if (row.Cells[2].Value != null)
                {
                    txt_MoTa.Text = row.Cells[2].Value.ToString();
                }
            }
        }


        //HÀM XỬ LÝ FROM NHÀ CUNG CẤP
        private bool KiemTraNCCTonTai(string tenNCC)
        {
            bool kq = true; // Giả sử tên khách hàng đã tồn tại
            string sSql = "SELECT COUNT(*) FROM NhaCungCap WHERE TenNCC = @tenNCC";

            try
            {
                using (SqlConnection myConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand myCommand = new SqlCommand(sSql, myConnection))
                    {
                        // Thêm tham số vào truy vấn để tránh tấn công SQL injection
                        myCommand.Parameters.AddWithValue("@tenNCC", tenNCC);

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
                MessageBox.Show("Lỗi kiểm tra nhà cung cấp tồn tại. Chi tiết: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return kq;
        }
        private bool KiemTraRongNCC()
        {
            bool kq = false; //không rỗng
            if (string.IsNullOrEmpty(txt_TenNCC.Text.Trim()) ||
                string.IsNullOrEmpty(txt_DiaChiNCC.Text.Trim()) ||
                string.IsNullOrEmpty(txt_Email.Text.Trim()) ||
                string.IsNullOrEmpty(txt_sdtNCC.Text.Trim()) ||
                string.IsNullOrEmpty(cb_TrangThaiNCC.Text.Trim()))
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
        private bool KiemTraEmail(string sEmail)
        {
            // Sử dụng biểu thức chính quy để kiểm tra chuỗi số điện thoại
            // Biểu thức chính quy này kiểm tra xem chuỗi có chứa 10-11 chữ số và bắt đầu bằng số 0 hoặc 84 không
            // Bạn có thể điều chỉnh biểu thức chính quy này để phù hợp với quy ước về số điện thoại của quốc gia cụ thể
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            // Kiểm tra định dạng email bằng regular expression
            //bool isValidEmail = Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            // Kiểm tra xem chuỗi có khớp với biểu thức chính quy hay không
            return regex.IsMatch(sEmail);
        }
        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra rỗng
                bool kiemRong = KiemTraRongNCC();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }
                //Kiểm tra giá trị ở textbox số điện thoại
                string sdtNCC = txt_sdtNCC.Text.Trim();

                bool kiemSoDienThoai = KiemTraSoDienThoai(sdtNCC);
                if (!kiemSoDienThoai)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                //Kiểm tra giá trị ở textbox email
                string emailNCC = txt_Email.Text.Trim();

                bool kiemEmailNCC = KiemTraEmail(emailNCC);
                if (!kiemEmailNCC)
                {
                    MessageBox.Show("Email không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }

                // Kiểm tra xem tên khách hàng đã tồn tại trong cơ sở dữ liệu chưa

                string tenNCC = txt_TenNCC.Text.Trim();

                bool tenNCCTonTai = KiemTraNCCTonTai(tenNCC);

                if (tenNCCTonTai)
                {
                    MessageBox.Show("Nhà cung cấp đã tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }
                string maNCC = txt_MaNCC.Text.Trim();
                string diaChiNCC = txt_DiaChiNCC.Text.Trim();
                
                DateTime ngayTaoNCC = dt_NgayTaoNCC.Value;

                string trangThaiNCC = cb_TrangThaiNCC.Text;
                string trangThaiNCCValue = (trangThaiNCC == "Hoạt động") ? "1" : "0";

                load_TruyVan($"INSERT INTO NhaCungCap (TenNCC, DiaChiNCC, SDT_NCC, Email_NCC, NgayTao_NCC, TrangThai_NCC) VALUES (N'{tenNCC}', N'{diaChiNCC}', N'{sdtNCC}', N'{emailNCC}', '{ngayTaoNCC.ToString("yyyy-MM-dd")}', '{trangThaiNCCValue}')");
                MessageBox.Show("Dữ Liệu đã được thêm vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                hamTaoMoiNCC();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp mới vào CSDL:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void hamTaoMoiNCC()
        {
            txt_MaNCC.Text = "";
            txt_TenNCC.Text = "";
            txt_DiaChiNCC.Text = "";
            txt_sdtNCC.Text = "";
            txt_Email.Text = "";
            cb_TrangThaiNCC.SelectedItem = null;
            if (DateTime.Now > dt_NgayTaoNCC.MaxDate || DateTime.Now < dt_NgayTaoNCC.MinDate)
            {
                dt_NgayTaoNCC.MinDate = DateTime.Now.AddDays(-365 * 20); // Thiết lập MinDate là một năm trước
                dt_NgayTaoNCC.MaxDate = DateTime.Now.AddDays(365); // Thiết lập MaxDate là một năm sau
            }

            dt_NgayTaoNCC.Value = DateTime.Now;

            txt_TimNCC.Text = "";
            HienThiNCCLenGird();

            lbl_ThongBaoSDTNCC.Visible = false;
            lbl_ThongBaoEmailNCC.Visible = false;
        }
        private void btn_LamMoiNCC_Click(object sender, EventArgs e)
        {
            hamTaoMoiNCC();
        }

        private void btn_SuaNCC_Click(object sender, EventArgs e)
        {

            try
            {
                //Kiểm tra rỗng
                bool kiemRong = KiemTraRongNCC();
                if (kiemRong)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện thêm vào cơ sở dữ liệu nữa
                }
                //Kiểm tra giá trị ở textbox số điện thoại
                string sdtNCC = txt_sdtNCC.Text.Trim();

                bool kiemSoDienThoai = KiemTraSoDienThoai(sdtNCC);
                if (!kiemSoDienThoai)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện nữa
                }

                //kiểm tra email hợp lệ
                string emailNCC = txt_Email.Text.Trim();

                bool kiemEmail = KiemTraEmail(emailNCC);
                if (!kiemEmail)
                {
                    MessageBox.Show("Email không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện nữa
                }
                if(string.IsNullOrEmpty(txt_MaNCC.Text.Trim()))
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng hàm và không thực hiện nữa
                }
                string maNCC = txt_MaNCC.Text.Trim();
                string tenNCC = txt_TenNCC.Text.Trim();
                string diaChiNCC = txt_DiaChiNCC.Text.Trim();
               
                DateTime ngayTaoNCC = dt_NgayTaoNCC.Value;

                string trangThaiNCC = cb_TrangThaiNCC.Text;
                string trangThaiNCCValue = "1";
                if (trangThaiNCC != null)
                {

                    trangThaiNCCValue = (trangThaiNCC.ToString() == "Hoạt động") ? "1" : "0";
                }

                load_TruyVan($"UPDATE NhaCungCap SET TenNCC = N'{tenNCC}', DiaChiNCC = N'{diaChiNCC}', SDT_NCC = N'{sdtNCC}', Email_NCC = N'{emailNCC}', NgayTao_NCC = '{ngayTaoNCC.ToString("yyyy-MM-dd")}', TrangThai_NCC = '{trangThaiNCCValue}' WHERE MaNCC = {maNCC}");
                
                MessageBox.Show("Dữ Liệu đã được thêm vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hamTaoMoiNCC();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin nhà cung cấp:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_XoaNCC_Click(object sender, EventArgs e)
        {
            string maNCC = txt_MaNCC.Text.Trim();
            if (string.IsNullOrEmpty(txt_MaNCC.Text.Trim()))
            {
                MessageBox.Show("Không tìm thấy mã nhà cung cấp để xóa: \n ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string tenNCC = txt_TenNCC.Text.Trim();
            string diaChiNCC = txt_DiaChiNCC.Text.Trim();
            string sdtNCC = txt_sdtNCC.Text.Trim();
            string emailNCC = txt_Email.Text.Trim();

            DateTime ngayTaoNCC = dt_NgayTaoNCC.Value;

            string trangThaiNCC = cb_TrangThaiNCC.Text;
           
            string thongTin = "";
            thongTin += $"Bạn có muốn xóa nhà cung cấp có thông tin: \n";
            thongTin += $"Mã nhà cung cấp: {maNCC}\n";
            thongTin += $"Tên: {tenNCC}\n";
            thongTin += $"Địa chỉ: {diaChiNCC}\n";
            thongTin += $"Số điện thoại: {sdtNCC}\n";
            thongTin += $"Email: {emailNCC}\n";
            thongTin += $"Ngày tạo: {ngayTaoNCC}\n";
            thongTin += $"Trạng thái: {trangThaiNCC}\n";

            DialogResult dlg = MessageBox.Show(thongTin, "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                try
                {
                    load_TruyVan($"DELETE FROM NhaCungCap WHERE MaNCC = '{maNCC}'");

                    // Hiển thị thông báo và làm mới danh sách sách
                    MessageBox.Show("Dữ liệu đã được xóa khỏi cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    string str = "SELECT * FROM NhaCungCap";
                    hamTaoMoiNCC();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhà cung cấp:\n " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_TimNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimNCC.Text.Trim()))
            {
                MessageBox.Show("Nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string timNCC = txt_TimNCC.Text.Trim();
            string str = $"SELECT* FROM NhaCungCap WHERE MaNCC LIKE N'%{timNCC}%' OR TenNCC LIKE N'%{timNCC}%' OR SDT_NCC LIKE N'%{timNCC}%'";
            load_DSSach(str, grid_NCC);
            load_DSSachDoiTenCotNCC(str, grid_NCC);
        }

        private void grid_NCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = grid_NCC.CurrentCell.RowIndex;

            if (rowIndex >= 0 && rowIndex < grid_NCC.Rows.Count)
            {
                DataGridViewRow row = grid_NCC.Rows[rowIndex];

                if (row.Cells[0].Value != null)
                {
                    txt_MaNCC.Text = row.Cells[0].Value.ToString();
                }
                if (row.Cells[1].Value != null)
                {
                    txt_TenNCC.Text = row.Cells[1].Value.ToString();
                }
                if (row.Cells[2].Value != null)
                {
                    txt_DiaChiNCC.Text = row.Cells[2].Value.ToString();
                }
                if (row.Cells[3].Value != null)
                {
                    txt_sdtNCC.Text = row.Cells[3].Value.ToString();
                }
                if (row.Cells[4].Value != null)
                {
                    txt_Email.Text = row.Cells[4].Value.ToString();
                }
                
                if (row.Cells[5].Value != null)
                {
                    if (DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime ngayTaoNCC))
                    {
                        dt_NgayTaoNCC.Value = ngayTaoNCC;
                    }
                    else
                    {
                        // Xử lý nếu giá trị không hợp lệ
                        // gán mặc định hoặc hiển thị thông báo lỗi
                    }
                }
                if (row.Cells[6].Value != null)
                {
                    string trangThai = row.Cells[6].Value.ToString();
                    if (trangThai == "1")
                    {
                        cb_TrangThaiNCC.SelectedIndex = 0;
                    }
                    else cb_TrangThaiNCC.SelectedIndex = 1;
                }
            }
        }

        private void txt_sdtNCC_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra số điện thoại khi người dùng thay đổi nội dung trong textbox
            string soDienThoai = txt_sdtNCC.Text.Trim();
            if (!KiemTraSoDienThoai(soDienThoai))
            {
                // Nếu số điện thoại không hợp lệ, hiển thị label thông báo
                lbl_ThongBaoSDTNCC.Text = "Số điện thoại không hợp lệ.";
                lbl_ThongBaoSDTNCC.Visible = true;
            }
            else
            {
                // Nếu số điện thoại hợp lệ, ẩn label thông báo đi
                lbl_ThongBaoSDTNCC.Visible = false;
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra số điện thoại khi người dùng thay đổi nội dung trong textbox
            string email = txt_Email.Text.Trim();
            if (!KiemTraEmail(email))
            {
                // Nếu số điện thoại không hợp lệ, hiển thị label thông báo
                lbl_ThongBaoEmailNCC.Text = "Email không hợp lệ.";
                lbl_ThongBaoEmailNCC.Visible = true;
            }
            else
            {
                // Nếu số điện thoại hợp lệ, ẩn label thông báo đi
                lbl_ThongBaoEmailNCC.Visible = false;
            }
        }

        private void grid_Sach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là hàng tiêu đề không
            if (e.RowIndex == -1)
            {
                // Thiết lập màu nền của hàng tiêu đề thành màu hồng
                e.CellStyle.BackColor = Color.Pink;
                // (Tuỳ chọn) Thiết lập màu chữ của hàng tiêu đề
                e.CellStyle.ForeColor = Color.Black;
            }
        }

        private void tcSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tcSach.SelectedIndex == 0)
            {
                hamTaoMoiSach();
            }
            if (tcSach.SelectedIndex == 1)
            {
                hamLamMoiTheLoai();
            }
            if (tcSach.SelectedIndex == 2)
            {
                hamLamMoiTacGia();
            }
            if (tcSach.SelectedIndex == 3)
            {
                hamTaoMoiNCC();
            }

        }
    }
}
