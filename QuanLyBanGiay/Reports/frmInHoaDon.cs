using Microsoft.EntityFrameworkCore;
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
    public partial class frmInHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        QLBHDataSet.DanhSachHoaDon_ChiTietDataTable danhSachHoaDon_ChiTietDataTable = new QLBHDataSet.DanhSachHoaDon_ChiTietDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        int id; // Mã hóa đơn
        public frmInHoaDon(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }
        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon
                .Include(r => r.DonHang).ThenInclude(r => r.KhachHang)
                .Include(r => r.DonHang).ThenInclude(r => r.NhanVien)
                .Include(r => r.HoaDon_ChiTiet)
                .Where(r => r.ID == id).SingleOrDefault();
            if (hoaDon != null)
            {
                var hoaDon_CT = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).Select(r => new
                {
                    r.ID,
                    r.HoaDonID,
                    r.SanPhamID,
                    r.SanPham.TenSanPham,
                    r.SoLuongBan,
                    r.DonGiaBan,
                    ThanhTien = r.SoLuongBan * r.DonGiaBan
                });

                danhSachHoaDon_ChiTietDataTable.Clear();
                foreach (var row in hoaDon_CT)
                {
                    danhSachHoaDon_ChiTietDataTable.AddDanhSachHoaDon_ChiTietRow(
                        row.ID,
                        row.HoaDonID,
                        row.SanPhamID,
                        row.TenSanPham,
                        row.SoLuongBan,
                        row.DonGiaBan,
                        row.ThanhTien);
                };

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsHoaDon_ChiTiet";
                reportDataSource.Value = danhSachHoaDon_ChiTietDataTable;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");

                string day = hoaDon.NgayLapHoaDon.Day < 10 
                    ? day = string.Format("{0}{1}", 0, hoaDon.NgayLapHoaDon.Day) 
                    : hoaDon.NgayLapHoaDon.Day.ToString();
                string month = hoaDon.NgayLapHoaDon.Month < 12 
                    ? month = string.Format("{0}{1}", 0, hoaDon.NgayLapHoaDon.Month) 
                    : hoaDon.NgayLapHoaDon.Month.ToString();

                IList<ReportParameter> param = new List<ReportParameter>
                {

                    new ReportParameter("Shop_DiaChi", "Mỹ Phước, TP. Long Xuyên, An Giang"),
                    new ReportParameter("Shop_SDT", "0123456789"),
                    new ReportParameter("SoHD", hoaDon.ID.ToString()),
                    new ReportParameter("NhanVien", hoaDon.DonHang.NhanVien.HoVaTen),
                    new ReportParameter("NgayLap", string.Format("Ngày {0}, tháng {1}, năm {2}", day, month, hoaDon.NgayLapHoaDon.Year)),
                    new ReportParameter("KhachHang_Ten", hoaDon.DonHang.KhachHang.HoVaTen),
                    new ReportParameter("KhachHang_DiaChi", hoaDon.DonHang.KhachHang.DiaChi),
                    new ReportParameter("KhachHang_SDT", hoaDon.DonHang.KhachHang.DienThoai),
                    new ReportParameter("TongCong", hoaDon.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.DonGiaBan).ToString())
                };

                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
        }
    }
}
