using Microsoft.Reporting.WinForms;
using QuanLyBanGiay.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QuanLyBanGiay.Reports
{
    public partial class frmThongKeSanPham : Form
    {

        QLBHDbContext context = new QLBHDbContext();
        QLBHDataSet.DanhSachSanPhamDataTable danhSachSanPhamDataTable = new QLBHDataSet.DanhSachSanPhamDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");

        public frmThongKeSanPham()
        {
            InitializeComponent();
        }
        public void LayLoaiSanPhamVaoComboBox()
        {
            var lsp = context.LoaiSanPham.Where(r => r.TrangThai).ToList();
            cboLoaiSanPham.DataSource = lsp;
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }
        public void LayHangSanXuatVaoComboBox()
        {
            var hsx = context.HangSanXuat.Where(r => r.TrangThai).ToList();
            cboHangSanXuat.DataSource = hsx;
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            LayHangSanXuatVaoComboBox();
            LayLoaiSanPhamVaoComboBox();

            var danhSachSanPham = context.SanPham.Select(r => new
            {
                r.ID,
                r.HangSanXuatID,
                r.HangSanXuat.TenHangSanXuat,
                r.LoaiSanPhamID,
                r.LoaiSanPham.TenLoai,
                r.TenSanPham,
                r.DonGia,
                r.SoLuong,
                r.HinhAnh,
            }).ToList();

            danhSachSanPhamDataTable.Clear();
            foreach (var row in danhSachSanPham)
            {
                danhSachSanPhamDataTable.AddDanhSachSanPhamRow(row.ID,
                row.HangSanXuatID,
               row.TenHangSanXuat,
               row.LoaiSanPhamID,
               row.TenLoai,
               row.TenSanPham,
               row.DonGia,
               row.SoLuong,
               row.HinhAnh);
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsSanPham";
            reportDataSource.Value = danhSachSanPhamDataTable;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeSanPham.rdlc");
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            if (cboHangSanXuat.Text == "" && cboLoaiSanPham.Text == "")
            {
                // Nếu cả 2 ComboBox đều bỏ trống thì hiển thị tất cả
                frmThongKeSanPham_Load(sender, e);
            }
            else
            {
                var danhSachSanPham = context.SanPham.Select(r => new
                {
                    r.ID,
                    r.HangSanXuatID,
                    r.HangSanXuat.TenHangSanXuat,
                    r.LoaiSanPhamID,
                    r.LoaiSanPham.TenLoai,
                    r.TenSanPham,
                    r.DonGia,
                    r.SoLuong,
                    r.HinhAnh,
                });
                string hangSanXuat = "";
                string loaiSanPham = "";
                if (cboHangSanXuat.Text != "")
                {
                    int hangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue!.ToString());
                    hangSanXuat = "Hãng sản xuất: " + cboHangSanXuat.Text;
                    danhSachSanPham = danhSachSanPham.Where(r => r.HangSanXuatID == hangSanXuatID);
                }
                if (cboLoaiSanPham.Text != "")
                {
                    int loaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue!.ToString());
                    loaiSanPham += "Phân loại: " + cboLoaiSanPham.Text;
                    danhSachSanPham = danhSachSanPham.Where(r => r.LoaiSanPhamID == loaiSanPhamID);
                }
                danhSachSanPhamDataTable.Clear();
                foreach (var row in danhSachSanPham)
                {
                    danhSachSanPhamDataTable.AddDanhSachSanPhamRow(row.ID,
                    row.HangSanXuatID,
                    row.TenHangSanXuat,
                    row.LoaiSanPhamID,
                    row.TenLoai,
                    row.TenSanPham,
                    row.DonGia,
                    row.SoLuong,
                    row.HinhAnh);
                }
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsSanPham";
                reportDataSource.Value = danhSachSanPhamDataTable;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeSanPham.rdlc");


                string locKetQua = hangSanXuat != "" && loaiSanPham != "" ? hangSanXuat + " - " + loaiSanPham : hangSanXuat + loaiSanPham;
                ReportParameter reportParameter = new ReportParameter("MoTa", "(" + locKetQua + ")");
                reportViewer1.LocalReport.SetParameters(reportParameter);

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
        }
    }
}


