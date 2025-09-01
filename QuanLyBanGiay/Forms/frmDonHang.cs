using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyBanGiay.Data;

namespace QuanLyBanGiay.Forms
{
    public partial class frmDonHang : Form
    {
        public frmDonHang()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id = 0;
        public int maNhanVien = 0;

        public void BatTat()
        {
            // Nút Lập hóa đơn, Sửa và Xóa chỉ sáng khi có đơn hàng
            btnSua.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
            btnLapHoaDon.Enabled = dataGridView.Rows.Count > 0;
        }
        private void LaySTT()
        {
            int i;
            for (i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Cells["STT"].Value = i + 1;

        }
        private void frmDonHang_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.Name = "STT";
            col0.HeaderText = "STT";
            col0.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col0.Width = 100;
            DataGridViewCellStyle style0 = new DataGridViewCellStyle();
            style0.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col0.DefaultCellStyle = style0;

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "ID";
            col1.DataPropertyName = "ID";
            col1.HeaderText = "ID";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col1.Width = 200;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "HoVaTenNhanVien";
            col2.DataPropertyName = "HoVaTenNhanVien";
            col2.HeaderText = "Nhân viên";

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "HoVaTenKhachHang";
            col3.DataPropertyName = "HoVaTenKhachHang";
            col3.HeaderText = "Khách hàng";

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "NgayLapDonHang";
            col4.DataPropertyName = "NgayLapDonHang";
            col4.HeaderText = "Ngày lập";
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            style4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style4.Format = "dd/MM/yyyy";
            col4.DefaultCellStyle = style4;

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "TongTienDonHang";
            col5.DataPropertyName = "TongTienDonHang";
            col5.HeaderText = "Tổng tiền";
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            style5.Alignment = DataGridViewContentAlignment.MiddleRight;
            style5.ForeColor = Color.Blue;
            style5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            style5.Format = "N0";
            col5.DefaultCellStyle = style5;

            DataGridViewLinkColumn col6 = new DataGridViewLinkColumn();
            col6.Name = "XemChiTiet";
            col6.DataPropertyName = "XemChiTiet";
            col6.HeaderText = "Chi tiết";
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            style6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col6.DefaultCellStyle = style6;

            dataGridView.Columns.AddRange(col0, col1, col2, col3, col4, col5, col6);

            var donHang = context.DonHang.Where(r => r.TrangThai).Select(r => new
            {
                r.ID,
                r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                r.NgayLapDonHang,
                r.GhiChuDonHang,
                r.TrangThai,
                TongTienDonHang = r.DonHang_ChiTiet.Sum(r => (r.SoLuongDat) * (r.DonGiaDat)),
                XemChiTiet = "XemChiTiet"
            }).OrderByDescending(r => r.NgayLapDonHang).ToList();
            dataGridView.DataSource = donHang;
            LaySTT();
            BatTat();
        }
        private void btnThemDonHang_Click(object sender, EventArgs e)
        {
            // mở chi tiết
            frmDonHang_ChiTiet donHang_ChiTiet = new frmDonHang_ChiTiet();
            donHang_ChiTiet.maNhanVien = this.maNhanVien;
            donHang_ChiTiet.ShowDialog();
            frmDonHang_Load(sender, e);
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            var nv_ID = context.DonHang.Where(r => r.ID == id).Select(r => r.NhanVienID).SingleOrDefault();
            if (nv_ID == maNhanVien)
            {
                // mở hóa đơn kèm id
                if (dataGridView.CurrentRow != null)
                {

                    frmHoaDon hoaDon = new frmHoaDon(id);
                    hoaDon.ShowDialog();
                }
                else
                    MessageBox.Show("Vui lòng chọn một dòng để lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Vui lòng chọn đơn hàng của mình để lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            var nv_ID = context.DonHang.Where(r => r.ID == id).Select(r => r.NhanVienID).SingleOrDefault();
            if (nv_ID == maNhanVien)
            {
                // mở chi tiết kèm id
                if (dataGridView.CurrentRow != null)
                {

                    frmDonHang_ChiTiet donHang_ChiTiet = new frmDonHang_ChiTiet(id);
                    donHang_ChiTiet.maNhanVien = this.maNhanVien;
                    donHang_ChiTiet.ShowDialog();
                    //frmDonHang_Load(sender, e);
                }
                else
                    MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Vui lòng chọn đơn hàng của mình để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa đơn hàng đang chọn?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    DonHang donHang = context.DonHang.Find(id)!;
                    if (donHang != null)
                    {
                        donHang.TrangThai = false;
                        context.SaveChanges();
                    }
                    frmDonHang_Load(sender, e);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                btnSua_Click(sender, e);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin |*.xls; *.xlsx";
            openFileDialog.Multiselect = false;

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //đọc tiêu đề bảng (dòng đầu tiên)
                    using (XLWorkbook workBook = new XLWorkbook(openFileDialog.FileName))
                    {
                        #region donHang
                        IXLWorksheet sheet1 = workBook.Worksheet(1);
                        bool rowst_donHang = true;
                        string readRange = "1:1";
                        DataTable dataTable_DonHang = new DataTable();
                        var donHangDict = new Dictionary<string, int>();

                        // duyệt qua từng dòng 
                        foreach (IXLRow row in sheet1.RowsUsed())
                        {
                            if (rowst_donHang)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                //duyệt qua từng ô 
                                foreach (IXLCell cell in row.Cells(readRange))
                                    dataTable_DonHang.Columns.Add(cell.Value.ToString());
                                rowst_donHang = false;
                            }
                            else
                            {
                                dataTable_DonHang.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    dataTable_DonHang.Rows[dataTable_DonHang.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (dataTable_DonHang.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {

                                string donHangID_Excel = "";
                                foreach (DataRow r in dataTable_DonHang.Rows)
                                {
                                    DonHang donHang = new DonHang();
                                    donHangID_Excel = r["ID"].ToString()!;
                                    donHang.NhanVienID = Convert.ToInt32(r["NhanVienID"].ToString());
                                    donHang.KhachHangID = Convert.ToInt32(r["KhachHangID"].ToString());
                                    donHang.NgayLapDonHang = Convert.ToDateTime(r["NgayLapDonHang"].ToString());
                                    donHang.GhiChuDonHang = r["GhiChuDonHang"].ToString();
                                    donHang.TrangThai = true;

                                    context.DonHang.Add(donHang);
                                    context.SaveChanges();
                                    donHangDict[donHangID_Excel] = donHang.ID;
                                }
                                transaction.Commit();
                            }
                        }

                        IXLWorksheet sheet2 = workBook.Worksheet(2);
                        bool rowst = true;
                        readRange = "1:1";
                        DataTable dataTable_ChiTiet = new DataTable();

                        // duyệt qua từng dòng 
                        foreach (IXLRow row in sheet2.RowsUsed())
                        {
                            if (rowst)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                //duyệt qua từng ô 
                                foreach (IXLCell cell in row.Cells(readRange))
                                    dataTable_ChiTiet.Columns.Add(cell.Value.ToString());
                                rowst = false;
                            }
                            else
                            {
                                dataTable_ChiTiet.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    dataTable_ChiTiet.Rows[dataTable_ChiTiet.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (dataTable_ChiTiet.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                string donHangID = "";
                                foreach (DataRow r in dataTable_ChiTiet.Rows)
                                {
                                    donHangID = r["DonHangID"].ToString()!;
                                    DonHang_ChiTiet donHang_CT = new DonHang_ChiTiet();
                                    donHang_CT.DonHangID = donHangDict[donHangID];
                                    donHang_CT.SanPhamID = Convert.ToInt32(r["SanPhamID"].ToString());
                                    donHang_CT.SoLuongDat = Convert.ToInt32(r["SoLuongDat"].ToString());
                                    donHang_CT.DonGiaDat = Convert.ToInt32(r["DonGiaDat"].ToString());
                                    context.DonHang_ChiTiet.Add(donHang_CT);
                                }
                                context.SaveChanges();
                                transaction.Commit();

                                MessageBox.Show("Đã nhập thành công " + dataTable_DonHang.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmDonHang_Load(sender, e);
                            }
                        }
                        #endregion

                        if (rowst)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin |*.xls; *.xlsx";
            saveFileDialog.FileName = "DonHang_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //tạo datatable donHang, định nghĩa cột (1)
                    DataTable dataTableDonHang = new DataTable();
                    dataTableDonHang.Columns.AddRange(new DataColumn[5]
                    {
                        new DataColumn("ID",typeof(int)),
                        new DataColumn("NhanVienID",typeof(int)),
                        new DataColumn("KhachHangID",typeof(int)),
                        new DataColumn("NgayLapDonHang",typeof(DateTime)),
                        new DataColumn("GhiChuDonHang",typeof(string))
                    });

                    //thêm dữ liệu từ donhang vào datatable
                    var donHang = context.DonHang.Where(r => r.TrangThai).OrderBy(r => r.NgayLapDonHang).ToList();
                    if (donHang != null)
                    {
                        foreach (var i in donHang)
                            dataTableDonHang.Rows.Add(i.ID, i.NhanVienID, i.KhachHangID, i.NgayLapDonHang, i.GhiChuDonHang);
                    }

                    //tạo datatable donHang_CT, định nghĩa cột (2)
                    DataTable dataTableDonHang_CT = new DataTable();
                    dataTableDonHang_CT.Columns.AddRange(new DataColumn[5]
                    {
                        new DataColumn("ID",typeof(int)),
                        new DataColumn("DonHangID",typeof(int)),
                        new DataColumn("SanPhamID",typeof(int)),
                        new DataColumn("SoLuongDat",typeof(int)),
                        new DataColumn("DonGiaDat",typeof(int))
                    });

                    //thêm dữ liệu từ donHang_CT vào datatable
                    var donHang_CT = context.DonHang_ChiTiet.ToList();
                    if (donHang_CT != null)
                    {
                        foreach (var i in donHang_CT)
                            dataTableDonHang_CT.Rows.Add(i.ID, i.DonHangID, i.SanPhamID, i.SoLuongDat, i.DonGiaDat);
                    }

                    //khai báo workbook, worksheet mới. Đổ dữ liệu từ datatable vào workbook(sheet) đó
                    using (XLWorkbook workBook = new XLWorkbook())
                    {
                        //sheet1 là đơn hàng
                        var sheet1 = workBook.Worksheets.Add(dataTableDonHang, "DonHang");
                        sheet1.Columns().AdjustToContents();

                        //sheet2 là đơn hàng chi tiết
                        var sheet2 = workBook.Worksheets.Add(dataTableDonHang_CT, "DonHang_ChiTiet");
                        sheet2.Columns().AdjustToContents();

                        workBook.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var donHang = context.DonHang
                .Select(r => new
                {
                    r.ID,
                    r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    r.NgayLapDonHang,
                    r.GhiChuDonHang,
                    r.TrangThai,
                    TongTienDonHang = r.DonHang_ChiTiet.Sum(r => (r.SoLuongDat) * (r.DonGiaDat)),
                    XemChiTiet = "XemChiTiet",
                }).Where(a => (a.HoVaTenNhanVien.Contains(txtTuKhoa.Text) ||
                              a.HoVaTenKhachHang.Contains(txtTuKhoa.Text) ||
                              a.NgayLapDonHang.ToString().Contains(txtTuKhoa.Text)) && a.TrangThai)
                .OrderByDescending(r => r.NgayLapDonHang).ToList();
            dataGridView.DataSource = donHang;
            LaySTT();
        }

        private void btnHienCuaToi_Click(object sender, EventArgs e)
        {
            var donHang = context.DonHang.Where(r => r.TrangThai && r.NhanVienID == maNhanVien).Select(r => new
            {
                r.ID,
                r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                r.NgayLapDonHang,
                r.GhiChuDonHang,
                r.TrangThai,
                TongTienDonHang = r.DonHang_ChiTiet.Sum(r => (r.SoLuongDat) * (r.DonGiaDat)),
                XemChiTiet = "XemChiTiet"
            }).OrderByDescending(r => r.NgayLapDonHang).ToList();
            dataGridView.DataSource = donHang;
            LaySTT();
        }

        private void frmDonHang_Shown(object sender, EventArgs e)
        {
            LaySTT();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            frmDonHang_Load(sender, e);
            LaySTT();
        }

        private void btnChuaCoHoaDon_Click(object sender, EventArgs e)
        {
            var donHang = context.DonHang
                .Where(r => r.TrangThai && r.NhanVienID == maNhanVien && !context.HoaDon.Any(h => h.DonHangID == r.ID))
                .Select(r => new
            {
                r.ID,
                r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                r.NgayLapDonHang,
                r.GhiChuDonHang,
                r.TrangThai,
                TongTienDonHang = r.DonHang_ChiTiet.Sum(r => (r.SoLuongDat) * (r.DonGiaDat)),
                XemChiTiet = "XemChiTiet"
            }).OrderByDescending(r => r.NgayLapDonHang).ToList();
            dataGridView.DataSource = donHang;
            LaySTT();
        }
    }
}
