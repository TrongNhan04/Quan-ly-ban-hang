using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
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

namespace QuanLyBanGiay.Forms
{
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id = 0;

        private void LaySTT()
        {
            int i;
            for (i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Cells["STT"].Value = i + 1;
        }
        private void BatTat(bool gt)
        {
            txtTenLoai.Enabled = gt;
            btnLuu.Enabled = gt;
            btnHuyBo.Enabled = gt;

            btnThem.Enabled = !gt;
            btnSua.Enabled = !gt;
            btnXoa.Enabled = !gt;
        }
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
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
            col3.Name = "TenLoai";
            col3.DataPropertyName = "TenLoai";
            col3.HeaderText = "Tên loại";
            dataGridView.Columns.AddRange(col1, col2, col3);


            var lsp = context.LoaiSanPham.Where(r => r.TrangThai).ToList();
            dataGridView.DataSource = lsp;
            LaySTT();
            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", lsp, "TenLoai", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTat(true);
            txtTenLoai.Clear();
            txtTenLoai.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                BatTat(true);
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                txtTenLoai.Focus();
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
                if (MessageBox.Show("Xác nhận xóa " + txtTenLoai.Text + "?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    LoaiSanPham lsp = context.LoaiSanPham.Find(id)!;
                    if (lsp != null)
                    {
                        lsp.TrangThai = false;
                        context.SaveChanges();
                    }
                    frmLoaiSanPham_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //thêm
                if (id == 0)
                {
                    LoaiSanPham lsp = new LoaiSanPham();
                    lsp.TenLoai = txtTenLoai.Text;
                    lsp.TrangThai = true;
                    context.LoaiSanPham.Add(lsp);
                }
                else //sửa
                {
                    LoaiSanPham lsp = context.LoaiSanPham.Find(id)!;
                    if (lsp != null)
                    {
                        lsp.TenLoai = txtTenLoai.Text;
                        context.LoaiSanPham.Update(lsp);
                    }
                }
                context.SaveChanges();
                frmLoaiSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel |*.xls; *.xlsx";
            openFileDialog.Multiselect = false;

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //đọc tiêu đề bảng (dòng đầu tiên)
                    using (XLWorkbook workBook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet workSheet = workBook.Worksheet(1);
                        bool rowst = true;
                        string readRange = "1:1";
                        DataTable dataTable = new DataTable();

                        //duyệt qua từng dòng có dữ liệu
                        foreach (IXLRow row in workSheet.RowsUsed())
                        {
                            //nếu là dòng đầu tiên
                            if (rowst)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                //duyệt từng ô trong dòng đầu tiên
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
                        //nếu dataTable có dữ liệu
                        if (dataTable.Rows.Count > 0)
                        {
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                LoaiSanPham lsp = new LoaiSanPham();
                                lsp.TenLoai = dataRow["TenLoai"].ToString() ?? "N/A";
                                lsp.TrangThai = true;
                                context.LoaiSanPham.Add(lsp);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + dataTable.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmLoaiSanPham_Load(sender, e);
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
            saveFileDialog.Filter = "Tập tin Excel |*.xls; *.xlsx";
            saveFileDialog.FileName = "LoaiGiay_" + DateTime.Now.ToShortDateString()
                .Replace("/", "_") + ".xlsx";
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {   //tạo datatable mới, định nghĩa cột
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.AddRange(new DataColumn[2]
                    {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("TenLoai", typeof(string))
                    });

                    //thêm dữ liệu từ loaiSP vào datatable
                    var lsp = context.LoaiSanPham.Where(r => r.TrangThai).ToList();
                    if (lsp != null)
                    {
                        foreach (var item in lsp)
                        {
                            dataTable.Rows.Add(item.ID, item.TenLoai);
                        }
                    }
                    //khai báo workbook, worksheet mới. Đổ dữ liệu từ datatable vào workbook(sheet) đó
                    using (XLWorkbook workBook = new XLWorkbook())
                    {
                        var sheet = workBook.Worksheets.Add(dataTable, "LoaiGiay");
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
            var lsp = context.LoaiSanPham
                             .Where(r => r.TenLoai.Contains(txtTuKhoa.Text) && r.TrangThai)
                             .ToList();
            dataGridView.DataSource = lsp;
            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", lsp, "TenLoai", false, DataSourceUpdateMode.Never);
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
            var lsp = context.LoaiSanPham.Where(r => r.TrangThai).OrderBy(r => r.TenLoai).ToList();
            dataGridView.DataSource = lsp;
            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", lsp, "TenLoai", false, DataSourceUpdateMode.Never);
            LaySTT();
        }

        private void frmLoaiSanPham_Shown(object sender, EventArgs e)
        {
            LaySTT();
        }
    }
}
