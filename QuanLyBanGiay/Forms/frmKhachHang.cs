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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBanGiay.Forms
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id = 0;

        private void BatTat(bool gt)
        {
            txtHoVaTen.Enabled = gt;
            txtDiaChi.Enabled = gt;
            txtDienThoai.Enabled = gt;
            btnLuu.Enabled = gt;
            btnHuyBo.Enabled = gt;

            btnThem.Enabled = !gt;
            btnSua.Enabled = !gt;
            btnXoa.Enabled = !gt;

        }
        private void LaySTT()
        {
            int i;
            for (i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Cells["STT"].Value = i + 1;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTat(false);
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

            dataGridView.Columns.AddRange(col1, col2, col3, col4, col5);

            var kh = context.KhachHang.Where(r => r.TrangThai).ToList();
            dataGridView.DataSource = kh;

            LaySTT();

            txtHoVaTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", kh, "HoVaTen", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Add("Text", kh, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", kh, "DiaChi", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTat(true);
            txtHoVaTen.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtHoVaTen.Focus();
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

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa khách hàng " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    KhachHang kh = context.KhachHang.Find(id)!;
                    if (kh != null)
                    {
                        kh.TrangThai = false;
                        context.SaveChanges();
                    }
                    frmKhachHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (id == 0)
                {
                    KhachHang kh = new KhachHang();
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.TrangThai = true;
                    context.KhachHang.Add(kh);
                }
                else
                {
                    KhachHang kh = context.KhachHang.Find(id)!;
                    if (kh != null)
                    {
                        kh.HoVaTen = txtHoVaTen.Text;
                        kh.DienThoai = txtDienThoai.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        context.KhachHang.Update(kh);
                    }
                }
                context.SaveChanges();
                frmKhachHang_Load(sender, e);
            }
            ;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTuKhoa.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                frmKhachHang_Load(sender, e);
                return;
            }

            var filteredList = context.KhachHang
                .Where(kh => kh.HoVaTen.ToLower().Contains(keyword) ||
                             (kh.DienThoai != null && kh.DienThoai.ToLower().Contains(keyword)) ||
                             (kh.DiaChi != null && kh.DiaChi.ToLower().Contains(keyword)) && kh.TrangThai)
                .ToList();
            dataGridView.DataSource = filteredList;
            txtHoVaTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", filteredList, "HoVaTen", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Add("Text", filteredList, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", filteredList, "DiaChi", false, DataSourceUpdateMode.Never);
            LaySTT();
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
                                KhachHang kh = new KhachHang();
                                kh.HoVaTen = r["HoVaTen"].ToString()!;
                                kh.DienThoai = r["DienThoai"].ToString()!;
                                kh.DiaChi = r["DiaChi"].ToString()!;
                                kh.TrangThai = true;
                                context.KhachHang.Add(kh);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + dataTable.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmKhachHang_Load(sender, e);
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
            saveFileDialog.FileName = "KhachHang_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //tạo datatable mới, định nghĩa cột
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.AddRange(new DataColumn[4]
                    {
                        new DataColumn("ID",typeof(int)),
                        new DataColumn("HoVaTen",typeof(string)),
                        new DataColumn("DienThoai",typeof(string)),
                        new DataColumn("DiaChi",typeof(string))
                    });

                    //thêm dữ liệu từ khachHang vào datatable
                    var nv = context.KhachHang.Where(r => r.TrangThai).ToList();
                    if (nv != null)
                    {
                        foreach (var i in nv)
                        {
                            dataTable.Rows.Add(i.ID, i.HoVaTen, i.DienThoai, i.DiaChi);
                        }
                    }

                    //khai báo workbook, worksheet mới. Đổ dữ liệu từ datatable vào workbook(sheet) đó
                    using (XLWorkbook workBook = new XLWorkbook())
                    {
                        var sheet = workBook.Worksheets.Add(dataTable, "KhachHang");
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

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void btnSapXepTang_Click(object sender, EventArgs e)
        {
            var kh = context.KhachHang.Where(r => r.TrangThai).OrderBy(r => r.HoVaTen).ToList();
            dataGridView.DataSource = kh;
            LaySTT();
            txtHoVaTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", kh, "HoVaTen", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Add("Text", kh, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", kh, "DiaChi", false, DataSourceUpdateMode.Never);
        }

        private void frmKhachHang_Shown(object sender, EventArgs e)
        {
            LaySTT();
        }
    }
}
