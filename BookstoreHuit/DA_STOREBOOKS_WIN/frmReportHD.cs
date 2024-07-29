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
using Microsoft.Reporting.WinForms;

namespace DA_STOREBOOKS_WIN
{
    public partial class frmReportHD : Form
    {
        public string connectionString = "Data Source=LAPTOP-G3PJNK5T; Initial Catalog=DA_QLSACH; Integrated Security=True";
        SqlConnection conn = null;
        private int maHoaDon;

        public frmReportHD(int maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
        }

        private void frmReportHD_Load(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(connectionString);
            }

            string str = "";
            str += " SELECT HoaDon.MaHD, NhanVien.MaNV, NhanVien.TenNV, KhachHang.MaKH, KhachHang.TenKH, HoaDon.NgayTao_HD, HoaDon.TongTien_HD ";

            str += "FROM HoaDon INNER JOIN NhanVien ON HoaDon.MaNV = NhanVien.MaNV ";

            str += "INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH ";

            str += "WHERE HoaDon.MaHD =  " + maHoaDon;

            SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HoaDon");

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_STOREBOOKS_WIN.ReportHoaDon.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["HoaDon"];
            this.reportViewer1.LocalReport.DataSources.Add(rds);


            string str2 = "";
            str2 += " SELECT HoaDon.MaHD, Sach.MaSach, Sach.TenSach, CTHoaDon.SoLuong, CTHoaDon.DonGia, CTHoaDon.ThanhTienSP ";

            str2 += "FROM HoaDon INNER JOIN CTHoaDon ON HoaDon.MaHD = CTHoaDon.MaHD ";

            str2 += "INNER JOIN Sach ON CTHoaDon.MaSach = Sach.MaSach ";

            str2 += "WHERE HoaDon.MaHD =  " + maHoaDon;

            SqlDataAdapter adapter2 = new SqlDataAdapter(str2, conn);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "CTHoaDon");

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_STOREBOOKS_WIN.ReportHoaDon.rdlc";
            ReportDataSource rds2 = new ReportDataSource();
            rds2.Name = "DataSet2";
            rds2.Value = ds2.Tables["CTHoaDon"];
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.RefreshReport();
        }
    }
}
