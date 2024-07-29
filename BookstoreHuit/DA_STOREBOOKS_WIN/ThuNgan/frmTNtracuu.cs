using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_STOREBOOKS_WIN.ThuNgan
{
    public partial class frmTNtracuu : Form
    {
        //CÁC HÀM CÓ THỂ DÙNG LẠI, CHỈ CẦN TRUYỀN THAM SÔ
        //Hàm lấy dữ liệu lên DataGridView
        string connectionString = @"Data Source=QUANGCUONG\SQLEXPRESS;Initial Catalog=DA_QLSACH;User ID=sa;Password=123;Integrated Security=False;";

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
            //string connectionString = "Data Source=LAPTOP-G3PJNK5T; Initial Catalog=DA_QLSACH; Integrated Security=True";

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

        public frmTNtracuu()
        {
            InitializeComponent();
            //THEO THẦY 
            HienThiDSTheLoai();
            HienThiDSTacGia();
            cb_TheLoai.SelectedIndex = -1;
            cb_TacGia.SelectedIndex = -1;

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

        private void frmTNtracuu_Load(object sender, EventArgs e)
        {
            HienThiSachLenGird();
            HienThiTacGiaLenGird();
            HienThiTheLoaiLenGird();
            HienThiNCCLenGird();
            cb_TheLoai.SelectedIndex = -1;
            cb_TacGia.SelectedIndex = -1;
        }
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
                //string fileName = Path.GetFileName(lpresent);
                //string destinationPath = Path.Combine(Application.StartupPath, "IMG", fileName);

                //if (!File.Exists(destinationPath))
                //{
                //    File.Copy(lpresent, destinationPath);
                //}
                //btn_ChonAnh.Text = destinationPath; // Hiển thị đường dẫn đầy đủ
                //picAnhSach.Image = new Bitmap(destinationPath);

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

        private void grid_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
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
                {
                    string trangThai = row.Cells[7].Value.ToString();
                    if (trangThai == "1")
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




        //FROM XỬ LÝ TÁC GIẢ 
        private void hamLamMoiTacGia()
        {
            txt_MaTacGia_TG.Text = "";
            txt_TenTacGia_TG.Text = "";
            txt_MoTa.Text = "";
            txt_TimTG.Text = "";

            HienThiTacGiaLenGird();
        }
        private void btn_TimTacGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimTG.Text.Trim()))
            {
                MessageBox.Show("Nhập thông tin tìm kiếm.");
                return;
            }
            string timTacGia = txt_TimTG.Text.Trim();
            string str = $"SELECT* FROM TacGia WHERE MaTG LIKE N'%{timTacGia}%' OR TenTG LIKE N'%{timTacGia}%' OR MoTa LIKE N'%{timTacGia}%'";
            load_DSSach(str, grid_TacGia);
            load_DSSachDoiTenCotTacGia(str, grid_TacGia);
        }

        private void btn_LamMoiTG_Click(object sender, EventArgs e)
        {
            hamLamMoiTacGia();
        }

        private void grid_TacGia_CellClick(object sender, DataGridViewCellEventArgs e)
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




        //FROM XỬ LÝ THỂ LOẠI
        private void hamLamMoiTheLoai()
        {
            txt_MaTheLoai.Text = "";
            txt_TenTL.Text = "";
            txt_TimTL.Text = "";

            HienThiTheLoaiLenGird();
        }
        private void btn_TimTheLoai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_TimTL.Text.Trim()))
            {
                MessageBox.Show("Nhập thông tin tìm kiếm.");
                return;
            }
            string timTheLoai = txt_TimTL.Text.Trim();
            string str = " SELECT * FROM TheLoai WHERE MaTL LIKE N'%" + timTheLoai + "%' OR TenTL LIKE N'%" + timTheLoai + "%'";
            load_DSSach(str, grid_TheLoai);
            load_DSSachDoiTenCotTheLoai(str, grid_TheLoai);
        }

        private void btn_LamMoiTL_Click(object sender, EventArgs e)
        {
            hamLamMoiTheLoai();
        }

        private void grid_TheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
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



        //FROM XỬ LÝ NHÀ CUNG CẤP
        private void hamTaoMoiNCC()
        {
            txt_MaNCC.Text = "";
            txt_TenNCC.Text = "";
            txt_DiaChiNCC.Text = "";
            txt_sdtNCC.Text = "";
            txt_Email.Text = "";
            cb_TrangThaiNCC.SelectedItem = null;
            // Kiểm tra và cập nhật giá trị MinDate và MaxDate của DateTimePicker
            if (DateTime.Now > dt_NgayTaoNCC.MaxDate || DateTime.Now < dt_NgayTaoNCC.MinDate)
            {
                dt_NgayTaoNCC.MinDate = DateTime.Now.AddDays(-365*20); // Thiết lập MinDate là một năm trước
                dt_NgayTaoNCC.MaxDate = DateTime.Now.AddDays(365); // Thiết lập MaxDate là một năm sau
            }

            dt_NgayTaoNCC.Value = DateTime.Now;

            txt_TimNCC.Text = "";
            HienThiNCCLenGird();
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

        private void btn_LamMoiNCC_Click(object sender, EventArgs e)
        {
            hamTaoMoiNCC();
        }

        private void grid_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void tcSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcSach.SelectedIndex == 0)
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
