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
    public partial class frmReportPN : Form
    {
        public string connectionString = "Data Source=LAPTOP-G3PJNK5T; Initial Catalog=DA_QLSACH; Integrated Security=True";
        SqlConnection conn = null;
        private int maPhieuNhap;
        public frmReportPN(int maPhieuNhap)
        {
            InitializeComponent();
            this.maPhieuNhap = maPhieuNhap;
        }

        private void frmReportHD_Load(object sender, EventArgs e)
        {
            if(conn == null)
            {
                conn = new SqlConnection(connectionString);
            }

            string str = "";
            str += " SELECT PhieuNhap.MaPN,NhaCungCap.MaNCC, NhaCungCap.TenNCC, NhanVien.MaNV, NhanVien.TenNV, " +
                "PhieuNhap.NgayTao_PN, PhieuNhap.TongTien_PN, Sach.MaSach, Sach.TenSach," +
                " CTPhieuNhap.DonGiaNhap, CTPhieuNhap.SoLuongNhap, CTPhieuNhap.ThanhTien ";

            str += "FROM PhieuNhap INNER JOIN CTPhieuNhap ON PhieuNhap.MaPN = CTPhieuNhap.MaPN ";

            str += "INNER JOIN NhanVien ON PhieuNhap.MaNV = NhanVien.MaNV ";

            str += "INNER JOIN NhaCungCap ON PhieuNhap.MaNCC = NhaCungCap.MaNCC ";

            str += "INNER JOIN Sach ON CTPhieuNhap.MaSach = Sach.MaSach ";

            str += "WHERE PhieuNhap.MaPN = " + maPhieuNhap;

            SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "InPhieuNhap");

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_STOREBOOKS_WIN.ReportPhieuNhap.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["InPhieuNhap"];
            this.reportViewer1.LocalReport.DataSources.Add(rds);


            string str2 = "";
            str2 += " SELECT PhieuNhap.MaPN, NhaCungCap.MaNCC, NhaCungCap.TenNCC, NhanVien.MaNV, NhanVien.TenNV, " +
                "PhieuNhap.NgayTao_PN, PhieuNhap.TongTien_PN ";

            str2 += "FROM PhieuNhap ";

            str2 += "INNER JOIN NhanVien ON PhieuNhap.MaNV = NhanVien.MaNV ";

            str2 += "INNER JOIN NhaCungCap ON PhieuNhap.MaNCC = NhaCungCap.MaNCC ";

            str2 += "WHERE PhieuNhap.MaPN = " +maPhieuNhap;

            SqlDataAdapter adapter2 = new SqlDataAdapter(str2, conn);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "PhieuNhap");

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA_STOREBOOKS_WIN.ReportPhieuNhap.rdlc";
            ReportDataSource rds2 = new ReportDataSource();
            rds2.Name = "DataSet2";
            rds2.Value = ds2.Tables["PhieuNhap"];
            this.reportViewer1.LocalReport.DataSources.Add(rds2);

            this.reportViewer1.RefreshReport();
        }
    }
}
