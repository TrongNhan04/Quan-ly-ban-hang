using ClosedXML.Excel;
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
using BC = BCrypt.Net.BCrypt;

namespace QuanLyBanGiay.Forms
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id = 0;
        private void BatTat(bool gt)
        {
            txtHoVaTen.Enabled = gt;
            txtDienThoai.Enabled = gt;
            txtDiaChi.Enabled = gt;
            cboQuyenHan.Enabled = gt;
            txtTenDangNhap.Enabled = gt;
            btnLuu.Enabled = gt;
            btnHuyBo.Enabled = gt;

            btnThem.Enabled = !gt;
            btnSua.Enabled = !gt;
            btnXoa.Enabled = !gt;

        }
        public void LayQuyenHanVaoComboBox()
        {
            var pq = context.PhanQuyen.ToList();
            cboQuyenHan.DataSource = pq;
            cboQuyenHan.ValueMember = "ID";
            cboQuyenHan.DisplayMember = "QuyenHan";
        }
        private void LaySTT()
        {
            int i;
            for (i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Cells["STT"].Value = i + 1;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTat(false);
            LayQuyenHanVaoComboBox();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.Name = "STT";
            col1.HeaderText = "STT";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col1.Width = 100;
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            style1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col1.DefaultCellStyle = style1;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.Name = "ID";
            col2.DataPropertyName = "ID";
            col2.HeaderText = "ID";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            col2.Width = 200;

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "HoVaTen";
            col3.DataPropertyName = "HoVaTen";
            col3.HeaderText = "Họ và tên";

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "DienThoai";
            col4.DataPropertyName = "DienThoai";
            col4.HeaderText = "Điện thoại";

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "DiaChi";
            col5.DataPropertyName = "DiaChi";
            col5.HeaderText = "Địa chỉ";

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.Name = "TenDangNhap";
            col6.DataPropertyName = "TenDangNhap";
            col6.HeaderText = "Tên đăng nhập";

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.Name = "QuyenHan";
            col7.DataPropertyName = "QuyenHan";
            col7.HeaderText = "Quyền hạn";

            dataGridView.Columns.AddRange(col1, col2, col3, col4, col5, col6, col7);

            var nv = context.NhanVien.Include(r => r.NguoiDung).ThenInclude(r => r.PhanQuyen)
                .Where(r => r.TrangThai).Select(r => new
                {
                    r.ID,
                    r.HoVaTen,
                    r.DienThoai,
                    r.DiaChi,
                    r.NguoiDungID,
                    r.NguoiDung.TenDangNhap,
                    QuyenHanID = r.NguoiDung.PhanQuyen.ID,
                    QuyenHan = r.NguoiDung.PhanQuyen.QuyenHan
                }).ToList();
            dataGridView.DataSource = nv;

            LaySTT();

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", nv, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", nv, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", nv, "DiaChi", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", nv, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedValue", nv, "QuyenHanID", false, DataSourceUpdateMode.Never);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTat(true);
            id = 0;
            txtHoVaTen.Clear();
            txtHoVaTen.Focus();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            cboQuyenHan.SelectedValue = "";
            txtTenDangNhap.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                BatTat(true);
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                txtHoVaTen.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa nhân viên " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    NhanVien nv = context.NhanVien.Find(id)!;
                    if (nv != null)
                    {
                        nv.TrangThai = false;
                        context.SaveChanges();
                    }
                    frmNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
            {
                MessageBox.Show("Vui lòng chọn quyền hạn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (id == 0)// thêm
                {
                    // tạo user 
                    NguoiDung user = new NguoiDung();
                    user.TenDangNhap = txtTenDangNhap.Text;
                    user.MatKhau = BC.HashPassword("000");
                    user.PhanQuyenID = Convert.ToInt32(cboQuyenHan.SelectedValue!.ToString());
                    context.NguoiDung.Add(user);
                    context.SaveChanges();

                    // tạo nhân viên
                    NhanVien nv = new NhanVien();
                    nv.HoVaTen = txtHoVaTen.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.NguoiDungID = user.ID;
                    nv.TrangThai = true;
                    context.NhanVien.Add(nv);
                    context.SaveChanges();
                }
                else// sửa
                {
                    var nv = context.NhanVien.Include(r => r.NguoiDung).Where(r => r.ID == id).SingleOrDefault();
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.NguoiDung.TenDangNhap = txtTenDangNhap.Text;
                        nv.NguoiDung.PhanQuyenID = Convert.ToInt32(cboQuyenHan.SelectedValue!.ToString());
                        context.NhanVien.Update(nv);
                        context.SaveChanges();
                    }
                }
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        IXLWorksheet sheet = workBook.Worksheet(1);
                        bool rowst = true;
                        string readRange = "1:1";
                        DataTable dataTable = new DataTable();

                        // duyệt qua từng dòng 
                        foreach (IXLRow row in sheet.RowsUsed())
                        {
                            if (rowst)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                //duyệt qua từng ô 
                                foreach (IXLCell cell in row.Cells(readRange))
                                    dataTable.Columns.Add(cell.Value.ToString());
                                rowst = false;
                            }
                            else
                            {
                                dataTable.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    dataTable.Rows[dataTable.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        if (dataTable.Rows.Count > 0)
                        {
                            foreach (DataRow r in dataTable.Rows)
                            {
                                NguoiDung user = new NguoiDung();
                                user.TenDangNhap = r["TenDangNhap"].ToString()!;
                                user.PhanQuyenID = r["QuyenHan"].ToString() == "admin" ? 1 : 2;
                                user.MatKhau = "000";
                                context.NguoiDung.Add(user);
                                context.SaveChanges();

                                NhanVien nv = new NhanVien();
                                nv.HoVaTen = r["HoVaTen"].ToString()!;
                                nv.DienThoai = r["DienThoai"].ToString()!;
                                nv.DiaChi = r["DiaChi"].ToString()!;
                                nv.NguoiDungID = user.ID;
                                nv.TrangThai = true;
                                context.NhanVien.Add(nv);

                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + dataTable.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhanVien_Load(sender, e);
                        }

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
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //tạo datatable mới, định nghĩa cột
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.AddRange(new DataColumn[6]
                    {
                        new DataColumn("ID",typeof(int)),
                        new DataColumn("HoVaTen",typeof(string)),
                        new DataColumn("DienThoai",typeof(string)),
                        new DataColumn("DiaChi",typeof(string)),
                        new DataColumn("TenDangNhap",typeof(string)),
                        new DataColumn("QuyenHan",typeof(string)),
                    });

                    //thêm dữ liệu từ nhanVien vào datatable
                    var nv = context.NhanVien.Include(r => r.NguoiDung)
                        .ThenInclude(r => r.PhanQuyen).Where(r => r.TrangThai).ToList();
                    if (nv != null)
                    {
                        foreach (var i in nv)
                        {
                            dataTable.Rows.Add(i.ID, i.HoVaTen, i.DienThoai, i.DiaChi, i.NguoiDung.TenDangNhap, i.NguoiDung.PhanQuyen.QuyenHan);
                        }
                    }

                    //khai báo workbook, worksheet mới. Đổ dữ liệu từ datatable vào workbook(sheet) đó
                    using (XLWorkbook workBook = new XLWorkbook())
                    {
                        var sheet = workBook.Worksheets.Add(dataTable, "NhanVien");
                        sheet.Columns().AdjustToContents();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var nv = context.NhanVien.Include(r => r.NguoiDung).ThenInclude(r => r.PhanQuyen)
             .Where(r => (r.HoVaTen.Contains(txtTuKhoa.Text) ||
                                 r.DienThoai!.Contains(txtTuKhoa.Text) ||
                                 r.DiaChi!.Contains(txtTuKhoa.Text)) && r.TrangThai)
                     .Select(r => new
                     {
                         r.ID,
                         r.HoVaTen,
                         r.DienThoai,
                         r.DiaChi,
                         r.NguoiDungID,
                         r.NguoiDung.TenDangNhap,
                         QuyenHanID = r.NguoiDung.PhanQuyen.ID,
                         QuyenHan = r.NguoiDung.PhanQuyen.QuyenHan
                     })
                     .ToList();
            dataGridView.DataSource = nv;
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", nv, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", nv, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", nv, "DiaChi", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", nv, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedValue", nv, "QuyenHanID", false, DataSourceUpdateMode.Never);
            LaySTT();
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void btnSapXepTang_Click(object sender, EventArgs e)
        {
            var nv = context.NhanVien.Include(r => r.NguoiDung).ThenInclude(r => r.PhanQuyen)
                .Where(r => r.TrangThai).Select(r => new
                {
                    r.ID,
                    r.HoVaTen,
                    r.DienThoai,
                    r.DiaChi,
                    r.NguoiDungID,
                    r.NguoiDung.TenDangNhap,
                    QuyenHanID = r.NguoiDung.PhanQuyen.ID,
                    QuyenHan = r.NguoiDung.PhanQuyen.QuyenHan
                }).OrderBy(r => r.HoVaTen).ToList();
            dataGridView.DataSource = nv;
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", nv, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", nv, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", nv, "DiaChi", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", nv, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedValue", nv, "QuyenHanID", false, DataSourceUpdateMode.Never);
            LaySTT();
        }

        private void frmNhanVien_Shown(object sender, EventArgs e)
        {
            LaySTT();
        }
    }
}
