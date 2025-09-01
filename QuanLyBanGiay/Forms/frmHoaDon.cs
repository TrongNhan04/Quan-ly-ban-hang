using Microsoft.EntityFrameworkCore;
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
using QuanLyBanGiay.Reports;
namespace QuanLyBanGiay.Forms
{
    public partial class frmHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id;
        int maHoaDon;
        public frmHoaDon(int maDonhang = 0)
        {
            InitializeComponent();
            id = maDonhang;
        }
        private void CoHoaDon(bool gt)
        {
            btnLuu.Enabled = !gt;
            btnInHoaDon.Enabled = gt;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "SanPhamID";
            col1.DataPropertyName = "SanPhamID";
            col1.HeaderText = "ID";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col1.Width = 100;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "TenSanPham";
            col2.DataPropertyName = "TenSanPham";
            col2.HeaderText = "Tên sản phẩm";

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "Size";
            col3.DataPropertyName = "Size";
            col3.HeaderText = "Size";
            col3.Width = 100;
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            style3.Alignment = DataGridViewContentAlignment.MiddleRight;
            col3.DefaultCellStyle = style3;

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "DonGia";
            col4.DataPropertyName = "DonGia";
            col4.HeaderText = "Đơn giá";
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            style4.Alignment = DataGridViewContentAlignment.MiddleRight;
            style4.Format = "N0";
            col4.DefaultCellStyle = style4;

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "SoLuong";
            col5.DataPropertyName = "SoLuong";
            col5.HeaderText = "Số lượng";
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            style5.Alignment = DataGridViewContentAlignment.MiddleRight;
            style5.Format = "N0";
            col5.DefaultCellStyle = style5;

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.Name = "ThanhTien";
            col6.DataPropertyName = "ThanhTien";
            col6.HeaderText = "Thành tiền";
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            style6.Alignment = DataGridViewContentAlignment.MiddleRight;
            style6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            style6.ForeColor = Color.Blue;
            style6.Format = "N0";
            col6.DefaultCellStyle = style6;

            dataGridView.Columns.AddRange([col1, col2, col3, col4, col5, col6]);
            
            var hoaDon = context.HoaDon.Include(r => r.DonHang)
                .ThenInclude(r => r.NhanVien)
                .Include( r => r.DonHang)
                .ThenInclude(r => r.KhachHang)
                .Where(r => r.DonHangID == id).SingleOrDefault();
            if (hoaDon != null)// có hóa đơn 
            {
                txtNhanVien.Text = hoaDon.DonHang.NhanVien.HoVaTen;
                txtNhanVien.Enabled = false;
                txtKhachHang.Text = hoaDon.DonHang.KhachHang.HoVaTen;
                txtKhachHang.Enabled = false;
                dptNgayLap.Value = hoaDon.NgayLapHoaDon;
                maHoaDon = hoaDon.ID;

                int sum = 0;
                var donHang_CT = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == hoaDon.ID)
                    .Select(r => new
                    {
                        r.ID,
                        r.SanPhamID,
                        r.SanPham.TenSanPham,
                        r.SanPham.Size,
                        SoLuong = r.SoLuongBan,
                        DonGia = r.DonGiaBan,
                        ThanhTien = r.SoLuongBan * r.DonGiaBan
                    }).ToList();
                dataGridView.DataSource = donHang_CT;
                foreach (DataGridViewRow t in dataGridView.Rows)
                    sum += Convert.ToInt32(t.Cells["ThanhTien"].Value.ToString());
                lblTongCong.Text = sum.ToString("N0");

                CoHoaDon(true);
            }
            else// không có hóa đơn
            {
                var donHang = context.DonHang.Include(r => r.NhanVien)
                    .Include(r => r.KhachHang).Where(r => r.ID == id).SingleOrDefault();
                if (donHang != null)
                {
                    txtNhanVien.Text = donHang.NhanVien.HoVaTen;
                    txtNhanVien.Enabled = false;
                    txtKhachHang.Text = donHang.KhachHang.HoVaTen;
                    txtKhachHang.Enabled = false;
                }
                int sum = 0;
                var donHang_CT = context.DonHang_ChiTiet.Where(r => r.DonHangID == id)
                    .Select(r => new
                    {
                        r.ID,
                        r.SanPhamID,
                        r.SanPham.TenSanPham,
                        r.SanPham.Size,
                        SoLuong = r.SoLuongDat,
                        DonGia = r.DonGiaDat,
                        ThanhTien = r.SoLuongDat * r.DonGiaDat
                    }).ToList();
                dataGridView.DataSource = donHang_CT;
                foreach (DataGridViewRow t in dataGridView.Rows)
                    sum += Convert.ToInt32(t.Cells["ThanhTien"].Value.ToString());
                lblTongCong.Text = sum.ToString("N0");
                CoHoaDon(false);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(dataGridView.Rows.Count>0)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.DonHangID = id;
                hoaDon.NgayLapHoaDon = dptNgayLap.Value;
                context.HoaDon.Add(hoaDon);
                context.SaveChanges();

                foreach(DataGridViewRow i in dataGridView.Rows)
                {
                    HoaDon_ChiTiet hoaDon_CT = new HoaDon_ChiTiet();
                    hoaDon_CT.HoaDonID = hoaDon.ID;
                    hoaDon_CT.SanPhamID = Convert.ToInt32(i.Cells["SanPhamID"].Value.ToString());
                    hoaDon_CT.SoLuongBan = Convert.ToInt32(i.Cells["SoLuong"].Value.ToString());
                    hoaDon_CT.DonGiaBan = Convert.ToInt32(i.Cells["DonGia"].Value.ToString());
                    context.HoaDon_ChiTiet.Add(hoaDon_CT);
                }
                context.SaveChanges();
                frmHoaDon_Load(sender, e);
            }
            else
                MessageBox.Show("Không có sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            frmInHoaDon inHoaDon = new frmInHoaDon(maHoaDon);
            inHoaDon.ShowDialog();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
