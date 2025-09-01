using Microsoft.EntityFrameworkCore;
using QuanLyBanGiay.Data;
using System.ComponentModel;
using System.Data;
using static QuanLyBanGiay.Data.DonHang_ChiTiet;

namespace QuanLyBanGiay.Forms
{
    public partial class frmDonHang_ChiTiet : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id = 0;// id đơn hàng
        int maDonHang = 0;// lấy mã cho đơn hàng cho hóa đơn
        public int maNhanVien = 0;// lấy mã để hiện thông tin
        BindingList<DanhSachDonHang_ChiTiet> donHangChiTiet = new BindingList<DanhSachDonHang_ChiTiet>();
        public frmDonHang_ChiTiet(int maDonHang = 0)
        {
            InitializeComponent();
            id = maDonHang;
        }
        public void LayKhachHangVaoComboBox()
        {
            var kh = context.KhachHang.Where(r => r.TrangThai).ToList();
            cboKhachHang.DataSource = kh;
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }
        public void LaySanPhamVaoComboBox()
        {
            var sp = context.SanPham.Where(r => r.TrangThai).ToList();
            cboSanPham.DataSource = sp;
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }
        public void BatTat()
        {
            // thêm đơn hàng
            if (id == 0 && dataGridView.Rows.Count == 0)
            {
                cboKhachHang.Text = "";
                txtGhiChuDonHang.Clear();
                cboSanPham.Text = "";
                numDonGiaDat.Value = 0;
                numSoLuongDat.Value = 1;
                numSize.Value = 37;
                txtNhanVien.Enabled = false;
            }
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
            btnLuuDonHang.Enabled = dataGridView.Rows.Count > 0;
            btnLapHoaDon.Enabled = dataGridView.Rows.Count > 0;
        }
        public void TatHet(bool gt)
        {
            btnLuuDonHang.Enabled = false;
            btnLapHoaDon.Enabled = false;
        }
        private void frmDonHang_ChiTiet_Load(object sender, EventArgs e)
        {
            LayKhachHangVaoComboBox();
            LaySanPhamVaoComboBox();

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
            col4.Name = "DonGiaDat";
            col4.DataPropertyName = "DonGiaDat";
            col4.HeaderText = "Đơn giá đặt";
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            style4.Alignment = DataGridViewContentAlignment.MiddleRight;
            style4.Format = "N0";
            col4.DefaultCellStyle = style4;

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "SoLuongDat";
            col5.DataPropertyName = "SoLuongDat";
            col5.HeaderText = "Số lượng đặt";
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

            var nv = context.NhanVien.Find(maNhanVien);
            //đã có chi tiết
            if (id != 0)
            {

                var donHang = context.DonHang.Find(id)!;
                txtNhanVien.Text = nv!.HoVaTen;
                cboKhachHang.SelectedValue = donHang.KhachHangID;
                txtGhiChuDonHang.Text = donHang.GhiChuDonHang;
                btnLuuDonHang.Enabled = false;
                btnLapHoaDon.Enabled = false;

                var ct = context.DonHang_ChiTiet.Where(r => r.DonHangID == id)
                    .Select(r => new DanhSachDonHang_ChiTiet
                    {
                        ID = r.ID,
                        DonHangID = r.DonHangID,
                        SanPhamID = r.SanPhamID,
                        TenSanPham = r.SanPham.TenSanPham,
                        Size = r.SanPham.Size,
                        SoLuongDat = r.SoLuongDat,
                        DonGiaDat = r.DonGiaDat,
                        ThanhTien = r.SoLuongDat * r.DonGiaDat,
                    }).ToList();
                donHangChiTiet = new BindingList<DanhSachDonHang_ChiTiet>(ct);
            }
            else
                txtNhanVien.Text = nv!.HoVaTen;
            dataGridView.DataSource = donHangChiTiet;

            BatTat();
        }
        private void btnXacNhanDat_Click(object sender, EventArgs e)
        {
            // lưu xuống DanhSachDonHang_ChiTiet (NotMapped)
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongDat.Value <= 0)
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGiaDat.Value <= 0)
                MessageBox.Show("Đơn giá bán sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int maSP = Convert.ToInt32(cboSanPham.SelectedValue!.ToString());
                var chiTiet = donHangChiTiet.FirstOrDefault(r => r.SanPhamID == maSP);

                // có chi tiết, cập nhật 
                if (chiTiet != null)
                {
                    chiTiet.Size = Convert.ToInt16(numSize.Value);
                    chiTiet.DonGiaDat = Convert.ToInt32(numDonGiaDat.Value);
                    chiTiet.SoLuongDat = Convert.ToInt32(numSoLuongDat.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numSoLuongDat.Value * numDonGiaDat.Value);
                    dataGridView.Refresh();
                }
                else // chưa có
                {
                    DanhSachDonHang_ChiTiet ds_ct = new DanhSachDonHang_ChiTiet
                    {
                        ID = dataGridView.RowCount + 1,
                        DonHangID = id,
                        SanPhamID = maSP,
                        TenSanPham = cboSanPham.Text,
                        Size = Convert.ToInt32(numSize.Value),
                        SoLuongDat = Convert.ToInt32(numSoLuongDat.Value),
                        DonGiaDat = Convert.ToInt32(numDonGiaDat.Value),
                        ThanhTien = Convert.ToInt32(numSoLuongDat.Value * numDonGiaDat.Value)
                    };
                    donHangChiTiet.Add(ds_ct);
                }
                BatTat();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // xóa khỏi DanhSachDonHang_ChiTiet (NotMapped)
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa sản phẩm " + cboSanPham.Text + "?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int maSP = Convert.ToInt32(dataGridView.CurrentRow.Cells["SanPhamID"].Value.ToString());
                    var chiTiet = donHangChiTiet.FirstOrDefault(r => r.SanPhamID == maSP);

                    if (chiTiet != null)
                    {
                        donHangChiTiet.Remove(chiTiet);
                    }
                    BatTat();
                }
            }
        }
        private void btnLuuDonHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuongDat.Value <= 0)
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGiaDat.Value <= 0)
                MessageBox.Show("Đơn giá bán sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // đã có chi tiết , cập nhật
                if (id != 0)
                {
                    // cập nhật đơn hàng trước
                    DonHang dh = context.DonHang.Find(id)!;
                    var hoaDon = context.HoaDon.Where(r => r.DonHangID == dh.ID).SingleOrDefault();
                    if (hoaDon != null)
                    {
                        var hoaDon_CT = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == hoaDon.ID).FirstOrDefault();
                        context.RemoveRange(hoaDon_CT!);
                        context.SaveChanges();
                        context.Remove(hoaDon);
                        context.SaveChanges();
                    }
                    if (dh != null)
                    {
                        dh.NhanVienID = maNhanVien;
                        dh.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue!.ToString());
                        dh.GhiChuDonHang = txtGhiChuDonHang.Text;
                        context.DonHang.Update(dh);

                        var ct_old = context.DonHang_ChiTiet.Where(r => r.DonHangID == id).ToList();
                        context.RemoveRange(ct_old);


                        // donHangChiTiet (NotMapped)
                        foreach (var item in donHangChiTiet.ToList())
                        {
                            // thêm dữ liệu từ donHangChiTiet (NotMapped) vào bảng DonHang_ChiTiet 
                            DonHang_ChiTiet ct_new = new DonHang_ChiTiet();
                            ct_new.DonHangID = id;
                            ct_new.SanPhamID = item.SanPhamID;
                            ct_new.SoLuongDat = item.SoLuongDat;
                            ct_new.DonGiaDat = item.DonGiaDat;
                            context.DonHang_ChiTiet.Add(ct_new);
                            context.SaveChanges();
                        }
                        int maSP;
                        foreach (DataGridViewRow r in dataGridView.Rows)
                        {
                            maSP = Convert.ToInt32(r.Cells["SanPhamID"].Value.ToString());
                            SanPham sp = context.SanPham.Find(maSP)!;
                            sp.SoLuong -= Convert.ToInt32(r.Cells["SoLuongDat"].Value.ToString());
                            context.SanPham.Update(sp);
                            context.SaveChanges();
                        }
                        maDonHang = dh.ID;
                    }
                }
                else // thêm mới đơn hàng + chi tiết
                {
                    DonHang donHang = new DonHang();
                    donHang.NhanVienID = maNhanVien;
                    donHang.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue!.ToString());
                    donHang.NgayLapDonHang = DateTime.Now;
                    donHang.GhiChuDonHang = txtGhiChuDonHang.Text;
                    donHang.TrangThai = true;
                    context.DonHang.Add(donHang);
                    context.SaveChanges();
                    maDonHang = donHang.ID;// lấy mã để đưa cho hóa đơn

                    foreach (var item in donHangChiTiet.ToList())
                    {
                        // thêm dữ liệu từ donHangChiTiet (NotMapped) vào bảng DonHang_ChiTiet 
                        DonHang_ChiTiet ct_new = new DonHang_ChiTiet();
                        ct_new.DonHangID = donHang.ID;
                        ct_new.SanPhamID = item.SanPhamID;
                        ct_new.SoLuongDat = item.SoLuongDat;
                        ct_new.DonGiaDat = item.DonGiaDat;
                        context.DonHang_ChiTiet.Add(ct_new);
                    }
                    context.SaveChanges();
                    int maSP;
                    foreach (DataGridViewRow r in dataGridView.Rows)
                    {
                        maSP = Convert.ToInt32(r.Cells["SanPhamID"].Value.ToString());
                        SanPham sp = context.SanPham.Find(maSP)!;
                        sp.SoLuong -= Convert.ToInt32(r.Cells["SoLuongDat"].Value.ToString());
                        context.SanPham.Update(sp);
                        context.SaveChanges();
                    }
                }
                MessageBox.Show("Đã lưu thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            // mở hóa đơn kèm id
            if (dataGridView.CurrentRow != null)
            {
                frmHoaDon hoaDon = new frmHoaDon(id);
                hoaDon.ShowDialog();
            }
            else
                MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                int maSP = Convert.ToInt32(cboSanPham.SelectedValue.ToString());
                var sp = context.SanPham.Find(maSP)!;
                numSoLuongDat.Maximum = sp.SoLuong;
                numSoLuongDat.Value = sp.SoLuong;
                numSoLuongDat.Minimum = 1;
                numDonGiaDat.Value = sp.DonGia;
                numSize.Value = sp.Size;
            }
        }
    }
}
