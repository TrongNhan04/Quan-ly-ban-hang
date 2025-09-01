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
using Microsoft.Reporting.WinForms;
using Microsoft.EntityFrameworkCore;
namespace QuanLyBanGiay.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        QLBHDataSet.DanhSachHoaDonDataTable danhSachHoaDonDataTable = new QLBHDataSet.DanhSachHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon.Include(r => r.DonHang).
                ThenInclude(r => r.KhachHang).Include(r => r.DonHang).ThenInclude(r => r.NhanVien)
                .Select(r => new
                {
                    r.ID,
                    NhanVienID = r.DonHang.NhanVienID,
                    HoVaTenNhanVien = r.DonHang.NhanVien.HoVaTen,
                    KhachHangID = r.DonHang.KhachHangID,
                    HoVaTenKhachHang = r.DonHang.KhachHang.HoVaTen,
                    r.NgayLapHoaDon,
                    TongTien = r.HoaDon_ChiTiet.Sum(r => r.DonGiaBan * r.SoLuongBan)
                }).ToList();

            danhSachHoaDonDataTable.Clear();
            foreach (var row in hoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(
                    row.ID,
                    row.NhanVienID,
                    row.HoVaTenNhanVien,
                    row.KhachHangID,
                    row.HoVaTenKhachHang,
                    row.NgayLapHoaDon,
                    row.TongTien);
            }
            ;
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon.Include(r => r.DonHang)
               .ThenInclude(r => r.KhachHang).Include(r => r.DonHang)
               .ThenInclude(r => r.NhanVien)
               .Select(r => new
               {
                   r.ID,
                   NhanVienID = r.DonHang.NhanVienID,
                   HoVaTenNhanVien = r.DonHang.NhanVien.HoVaTen,
                   KhachHangID = r.DonHang.KhachHangID,
                   HoVaTenKhachHang = r.DonHang.KhachHang.HoVaTen,
                   r.NgayLapHoaDon,
                   TongTien = r.HoaDon_ChiTiet.Sum(r => r.DonGiaBan * r.SoLuongBan)
               });
            hoaDon = hoaDon.Where(r => r.NgayLapHoaDon >= dtpTuNgay.Value && r.NgayLapHoaDon <= dtpDenNgay.Value);

            danhSachHoaDonDataTable.Clear();
            foreach (var row in hoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(row.ID,
                row.NhanVienID,
                row.HoVaTenNhanVien,
                row.KhachHangID,
                row.HoVaTenKhachHang,
                row.NgayLapHoaDon,
                row.TongTien);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTa", "(Từ ngày " + dtpTuNgay.Text + " - Đến ngày: " + dtpDenNgay.Text+")");
            reportViewer1.LocalReport.SetParameters(reportParameter);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu_Load(sender, e);
        }
    }

}
    
