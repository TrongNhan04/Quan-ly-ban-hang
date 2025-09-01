using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyBanGiay.Data;
using BC = BCrypt.Net.BCrypt;
using System;
using QuanLyBanGiay.Reports;

namespace QuanLyBanGiay.Forms
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }
        //QLBHDbContext context = new QLBHDbContext();
        int id = 0;
        frmLoaiSanPham? loaiSanPham = null;
        frmHangSanXuat? hangSanXuat = null;
        frmSanPham? sanPham = null;
        frmKhachHang? khachHang = null;
        frmNhanVien? nhanVien = null;
        frmDonHang? donHang = null;
        frmHoaDon? hoaDon = null;
        frmDangNhap? dangNhap = null;
        //frmTaiKhoan? taiKhoan = null;
        frmThongKeDoanhThu? doanhThu = null;
        frmThongKeSanPham? thongKe_SanPham = null;

        string hoVaTenNhanVien = ""; // Lấy tên người dùng hiển thị vào thanh Status
        int maNhanVien = 0;// mã nhân viên cho đơn hàng
        string helpFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Help");
        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaPhanQuyen();
            DangNhap();
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (loaiSanPham == null || loaiSanPham.IsDisposed)
            {
                loaiSanPham = new frmLoaiSanPham();
                loaiSanPham.MdiParent = this;
                loaiSanPham.Show();
            }
            else
                loaiSanPham.Activate();
        }

        private void mnuHangSanXuat_Click(object sender, EventArgs e)
        {
            if (hangSanXuat == null || hangSanXuat.IsDisposed)
            {
                hangSanXuat = new frmHangSanXuat();
                hangSanXuat.MdiParent = this;
                hangSanXuat.Show();
            }
            else
            {
                hangSanXuat.Activate();
            }
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            if (sanPham == null || sanPham.IsDisposed)
            {
                sanPham = new frmSanPham();
                sanPham.MdiParent = this;
                sanPham.Show();
            }
            else
            {
                sanPham.Activate();
            }
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
            {
                khachHang.Activate();
            }
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
            {
                nhanVien.Activate();
            }
        }

        private void mnuDonHang_Click(object sender, EventArgs e)
        {
            if (donHang == null || donHang.IsDisposed)
            {
                donHang = new frmDonHang();
                donHang.MdiParent = this;
                donHang.maNhanVien = this.maNhanVien;
                donHang.Show();
            }
            else
            {
                donHang.Activate();
            }
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;
                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    using (var context = new QLBHDbContext()) 
                    { 
                        var nguoiDung = context.NguoiDung.
                            Where(r => r.TenDangNhap == tenDangNhap).FirstOrDefault();
                        if (nguoiDung == null)
                        {
                            MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtTenDangNhap.Focus();
                            goto LamLai;
                        }
                        else
                        {
                            if (BC.Verify(matKhau, nguoiDung.MatKhau))
                            {
                                var nhanVien = context.NhanVien.Where(r => r.NguoiDungID == nguoiDung.ID).SingleOrDefault();
                                if (nhanVien != null)
                                {
                                    maNhanVien = nhanVien.ID;
                                    hoVaTenNhanVien = nhanVien.HoVaTen;
                                }
                                if (nguoiDung.PhanQuyenID == 1)
                                    QuyenQuanLy();
                                else if (nguoiDung.PhanQuyenID == 2)
                                    QuyenNhanVien();
                                else
                                    ChuaPhanQuyen();
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dangNhap.txtMatKhau.Focus();
                                goto LamLai;
                            }
                        }
                    }
                }
            }
            dangNhap.txtTenDangNhap.Clear();
            dangNhap.txtMatKhau.Clear();
        }
        public void ChuaPhanQuyen()
        {
            // Sáng đăng nhập
            mnuDangNhap.Enabled = true;
            // Mờ tất cả
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;
            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuDonHang.Enabled = false;
            mnuThongKeDoanhThu.Enabled = false;
            mnuThongKeSanPham.Enabled = false;

            btnSanPham.Enabled = false;
            btnKhachHang.Enabled = false;
            btnNhanVien.Enabled = false;
            btnDonHang.Enabled = false;
            btnTaiKhoan.Enabled = false;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Chưa đăng nhập.";
        }
        public void QuyenQuanLy()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            // Mờ các chức năng quản lý không được phép
            // Sáng đăng xuất và các chức năng quản lý được phép
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuLoaiSanPham.Enabled = true;
            mnuHangSanXuat.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuDonHang.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            mnuThongKeSanPham.Enabled = true;

            btnSanPham.Enabled = true;
            btnKhachHang.Enabled = true;
            btnNhanVien.Enabled = true;
            btnDonHang.Enabled = true;
            btnTaiKhoan.Enabled = true;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }
        public void QuyenNhanVien()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            // Mờ các chức năng nhân viên không được phép
            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuNhanVien.Enabled = false;

            btnSanPham.Enabled = false;
            btnNhanVien.Enabled = false;

            // Sáng đăng xuất và các chức năng nhân viên được phép
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuDonHang.Enabled = true;
            mnuThongKeDoanhThu.Enabled = true;
            mnuThongKeSanPham.Enabled = true;

            btnKhachHang.Enabled = true;
            btnDonHang.Enabled = true;
            btnTaiKhoan.Enabled = true;

            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaPhanQuyen();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            
            frmTaiKhoan taiKhoan = new frmTaiKhoan(maNhanVien);
            
            //taiKhoan = new frmTaiKhoan(maNhanVien);
            taiKhoan.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            if (doanhThu == null || doanhThu.IsDisposed)
            {
                doanhThu = new frmThongKeDoanhThu();
                doanhThu.MdiParent = this;
                doanhThu.Show();
            }
            else
            {
                doanhThu.Activate();
            }
        }

        private void mnuThongKeSanPham_Click(object sender, EventArgs e)
        {
            if (thongKe_SanPham == null || thongKe_SanPham.IsDisposed)
            {
                thongKe_SanPham = new frmThongKeSanPham();
                thongKe_SanPham.MdiParent = this;
                thongKe_SanPham.Show();
            }
            else
            {
                thongKe_SanPham.Activate();
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            mnuSanPham_Click(sender, e);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            mnuKhachHang_Click(sender, e);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            mnuNhanVien_Click(sender, e);
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            mnuDonHang_Click(sender, e);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            mnuDoiMatKhau_Click(sender, e);
        }

        private void mnuThongTinPhanMem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpFolder + "\\GioiThieuPhanMem\\GioiThieu.chm");
        }

        private void mnuHuongDanSuDung_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpFolder + "\\HuongDanThaoTac\\QLBGHelp.chm");
        }
    }
}
