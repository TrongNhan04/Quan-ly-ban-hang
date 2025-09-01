namespace QuanLyBanGiay.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuLoaiSanPham = new ToolStripMenuItem();
            mnuHangSanXuat = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuDonHang = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnSanPham = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btnKhachHang = new ToolStripButton();
            btnNhanVien = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            btnDonHang = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            btnTaiKhoan = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuBaoCaoThongKe, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1185, 44);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator1, mnuThoat });
            mnuHeThong.Image = (Image)resources.GetObject("mnuHeThong.Image");
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(160, 38);
            mnuHeThong.Text = "&Hệ Thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Image = (Image)resources.GetObject("mnuDangNhap.Image");
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(309, 44);
            mnuDangNhap.Text = "Đăng &Nhập...";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Image = (Image)resources.GetObject("mnuDangXuat.Image");
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(309, 44);
            mnuDangXuat.Text = "Đăng &Xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Image = (Image)resources.GetObject("mnuDoiMatKhau.Image");
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(309, 44);
            mnuDoiMatKhau.Text = "Đổi &Mật Khẩu...";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(306, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Image = (Image)resources.GetObject("mnuThoat.Image");
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(309, 44);
            mnuThoat.Text = "&Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiSanPham, mnuHangSanXuat, mnuSanPham, toolStripSeparator2, mnuKhachHang, mnuNhanVien, toolStripSeparator3, mnuDonHang });
            mnuQuanLy.Image = (Image)resources.GetObject("mnuQuanLy.Image");
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(141, 38);
            mnuQuanLy.Text = "&Quản Lý";
            // 
            // mnuLoaiSanPham
            // 
            mnuLoaiSanPham.Image = (Image)resources.GetObject("mnuLoaiSanPham.Image");
            mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            mnuLoaiSanPham.Size = new Size(359, 44);
            mnuLoaiSanPham.Text = "&Loại Sản Phẩm...";
            mnuLoaiSanPham.Click += mnuLoaiSanPham_Click;
            // 
            // mnuHangSanXuat
            // 
            mnuHangSanXuat.Image = (Image)resources.GetObject("mnuHangSanXuat.Image");
            mnuHangSanXuat.Name = "mnuHangSanXuat";
            mnuHangSanXuat.Size = new Size(359, 44);
            mnuHangSanXuat.Text = "&Hãng sản xuất… ";
            mnuHangSanXuat.Click += mnuHangSanXuat_Click;
            // 
            // mnuSanPham
            // 
            mnuSanPham.Image = (Image)resources.GetObject("mnuSanPham.Image");
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(359, 44);
            mnuSanPham.Text = "&Sản Phẩm...";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(356, 6);
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Image = (Image)resources.GetObject("mnuKhachHang.Image");
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(359, 44);
            mnuKhachHang.Text = "&Khách hàng…";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Image = (Image)resources.GetObject("mnuNhanVien.Image");
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(359, 44);
            mnuNhanVien.Text = "&Nhân viên…";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(356, 6);
            // 
            // mnuDonHang
            // 
            mnuDonHang.Image = (Image)resources.GetObject("mnuDonHang.Image");
            mnuDonHang.Name = "mnuDonHang";
            mnuDonHang.Size = new Size(359, 44);
            mnuDonHang.Text = "Đơn &Hàng...";
            mnuDonHang.Click += mnuDonHang_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeSanPham, mnuThongKeDoanhThu });
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(243, 38);
            mnuBaoCaoThongKe.Text = "&Báo cáo - Thống kê";
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.Image = Properties.Resources.thong_ke_san_pham;
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Size = new Size(381, 44);
            mnuThongKeSanPham.Text = "&Thống kê sản phẩm...";
            mnuThongKeSanPham.Click += mnuThongKeSanPham_Click;
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Image = Properties.Resources.thong_ke_doanh_thu;
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(381, 44);
            mnuThongKeDoanhThu.Text = "&Thống kê doanh thu...";
            mnuThongKeDoanhThu.Click += mnuThongKeDoanhThu_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTinPhanMem, mnuHuongDanSuDung });
            mnuTroGiup.Image = (Image)resources.GetObject("mnuTroGiup.Image");
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(142, 38);
            mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Image = (Image)resources.GetObject("mnuThongTinPhanMem.Image");
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(468, 44);
            mnuThongTinPhanMem.Text = "Thông tin &phần mềm...";
            mnuThongTinPhanMem.Click += mnuThongTinPhanMem_Click;
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Image = (Image)resources.GetObject("mnuHuongDanSuDung.Image");
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(468, 44);
            mnuHuongDanSuDung.Text = "&Hướng dẫn sử dụng...";
            mnuHuongDanSuDung.Click += mnuHuongDanSuDung_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel2, lblLienKet });
            statusStrip1.Location = new Point(0, 390);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 23, 0);
            statusStrip1.Size = new Size(1185, 42);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(196, 32);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(713, 32);
            toolStripStatusLabel2.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(251, 32);
            lblLienKet.Text = "© Khoa CNTT - ĐHAG";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSanPham, toolStripSeparator4, btnKhachHang, btnNhanVien, toolStripSeparator5, btnDonHang, toolStripSeparator6, btnTaiKhoan });
            toolStrip1.Location = new Point(0, 44);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1185, 74);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSanPham
            // 
            btnSanPham.Image = Properties.Resources.san_pham;
            btnSanPham.ImageTransparentColor = Color.Magenta;
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(125, 68);
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 74);
            // 
            // btnKhachHang
            // 
            btnKhachHang.Image = Properties.Resources.khach_hang;
            btnKhachHang.ImageTransparentColor = Color.Magenta;
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(144, 68);
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Image = Properties.Resources.nhan_vien;
            btnNhanVien.ImageTransparentColor = Color.Magenta;
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(128, 68);
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 74);
            // 
            // btnDonHang
            // 
            btnDonHang.Image = Properties.Resources.shoppingbasket;
            btnDonHang.ImageTransparentColor = Color.Magenta;
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(124, 68);
            btnDonHang.Text = "Đơn hàng";
            btnDonHang.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 74);
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Image = Properties.Resources.user1;
            btnTaiKhoan.ImageTransparentColor = Color.Magenta;
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(119, 68);
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 432);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Bán Giày";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuLoaiSanPham;
        private ToolStripMenuItem mnuHangSanXuat;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripMenuItem mnuDonHang;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuThongKeSanPham;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSanPham;
        private ToolStripButton btnKhachHang;
        private ToolStripButton btnNhanVien;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnDonHang;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btnTaiKhoan;
    }
}