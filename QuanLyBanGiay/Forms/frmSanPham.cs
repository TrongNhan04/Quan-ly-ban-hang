using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.ReportingServices.Diagnostics.Internal;
using QuanLyBanGiay.Data;
using SlugGenerator;
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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        int id; // Lấy mã sản phẩm (dùng cho Sửa và Xóa)
        string imageName = "no-image.jpg"; // Hình ảnh mặc định
        //string imageFolder = @"C:\Users\Admin\Desktop\LTQL\HinhAnh";
        string imageFolder = @"D:\LapTrinh_QuanLy\Do_An\QuanLyBanGiay\Images";
        private void BatTat(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSize.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void LaySTT()
        {
            int i;
            for (i = 0; i < dataGridView.Rows.Count; i++)
                dataGridView.Rows[i].Cells["STT"].Value = i + 1;
        }
        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.Where(r => r.TrangThai).ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }

        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.Where(r => r.TrangThai).ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTat(false);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();

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
            col2.Name = "TenLoai";
            col2.DataPropertyName = "TenLoai";
            col2.HeaderText = "Phân loại";

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.Name = "TenHangSanXuat";
            col3.DataPropertyName = "TenHangSanXuat";
            col3.HeaderText = "Hãng sản xuất";

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.Name = "TenSanPham";
            col4.DataPropertyName = "TenSanPham";
            col4.HeaderText = "Tên sản phẩm";

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.Name = "Size";
            col5.DataPropertyName = "Size";
            col5.HeaderText = "Size";
            DataGridViewCellStyle style5 = new DataGridViewCellStyle();
            style5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col5.DefaultCellStyle = style5;

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.Name = "SoLuong";
            col6.DataPropertyName = "SoLuong";
            col6.HeaderText = "Số lượng";
            DataGridViewCellStyle style6 = new DataGridViewCellStyle();
            style6.Alignment = DataGridViewContentAlignment.MiddleRight;
            style6.Format = "N0";
            col6.DefaultCellStyle = style6;

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.Name = "DonGia";
            col7.DataPropertyName = "DonGia";
            col7.HeaderText = "Đơn giá";
            DataGridViewCellStyle style7 = new DataGridViewCellStyle();
            style7.Alignment = DataGridViewContentAlignment.MiddleRight;
            style7.Format = "N0";
            col7.DefaultCellStyle = style7;

            DataGridViewImageColumn col8 = new DataGridViewImageColumn();
            col8.Name = "HinhAnh";
            col8.DataPropertyName = "HinhAnh";
            col8.HeaderText = "Hình ảnh";

            dataGridView.Columns.AddRange(col0, col1, col2, col3, col4, col5, col6, col7, col8);

            var sp = context.SanPham.Where(r => r.TrangThai).Select(r => new
            {
                r.ID,
                r.LoaiSanPhamID,
                r.LoaiSanPham.TenLoai,
                r.HangSanXuatID,
                r.HangSanXuat.TenHangSanXuat,
                r.TenSanPham,
                r.Size,
                r.SoLuong,
                r.DonGia,
                r.HinhAnh,
            }).ToList();
            dataGridView.DataSource = sp;

            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", sp, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", sp, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", sp, "TenSanPham", false, DataSourceUpdateMode.Never);

            numSize.DataBindings.Clear();
            numSize.DataBindings.Add("Value", sp, "Size", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", sp, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", sp, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", sp, "HinhAnh", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
            LaySTT();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                string imagePath = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
                if (File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    image = new Bitmap(image, 24, 24);
                    e.Value = image;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTat(true);
            id = 0;
            cboLoaiSanPham.Text = "";
            cboHangSanXuat.Text = "";
            txtTenSanPham.Clear();
            numSoLuong.Value = 1;
            numDonGia.Value = 0;
            numSize.Value = 37;
            picHinhAnh.Image = null;
            cboLoaiSanPham.Focus();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                BatTat(true);
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                cboLoaiSanPham.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboLoaiSanPham.Text))
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    SanPham sp = new SanPham();
                    sp.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue?.ToString());
                    sp.LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue?.ToString());
                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.Size = Convert.ToInt32(numSize.Value);
                    sp.DonGia = Convert.ToInt32(numDonGia.Value);
                    sp.SoLuong = Convert.ToInt32(numSoLuong.Value);
                    sp.HinhAnh = imageName;
                    sp.TrangThai = true;
                    context.SanPham.Add(sp);
                    context.SaveChanges();
                }
                else
                {
                    SanPham sp = context.SanPham.Find(id)!;
                    if (sp != null)
                    {
                        sp.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue?.ToString());
                        sp.LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue?.ToString());
                        sp.TenSanPham = txtTenSanPham.Text;
                        sp.Size = Convert.ToInt32(numSize.Value);
                        sp.DonGia = Convert.ToInt32(numDonGia.Value);
                        sp.SoLuong = Convert.ToInt32(numSoLuong.Value);
                        sp.HinhAnh = imageName;
                        context.SanPham.Update(sp);
                        context.SaveChanges();
                    }
                }
                frmSanPham_Load(sender, e);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa " + txtTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    SanPham sp = context.SanPham.Find(id)!;
                    if (sp != null)
                    {
                        // Xóa hình ảnh (nếu có)
                        if (!string.IsNullOrEmpty(sp.HinhAnh))
                        {
                            string imagePath = Path.Combine(imageFolder, sp.HinhAnh);
                            if (File.Exists(imagePath))
                            {
                                System.GC.Collect();
                                System.GC.WaitForPendingFinalizers();
                                File.Delete(imagePath);
                            }
                        }
                        sp.TrangThai = false;
                        context.SaveChanges();
                    }
                    frmSanPham_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                
                // Lưu tên file hình vào biến toàn cục
                imageName = fileName.GenerateSlug() + ext;
                
                // Sao chép file hình vào thư mục Images
                string fileSavePath = Path.Combine(imageFolder, imageName);
                
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                // Hiện hình ảnh đã chọn lên PictureBox
                picHinhAnh.Image = Image.FromFile(fileSavePath);
            }
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
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
                                string tenHSX = r["HangSanXuat"].ToString()!;
                                var hsxID = context.HangSanXuat.Where(r => r.TenHangSanXuat == tenHSX).Select(r => r.ID).FirstOrDefault();

                                string tenLSP = r["LoaiSanPham"].ToString()!;
                                var lspID = context.HangSanXuat.Where(r => r.TenHangSanXuat == tenHSX).Select(r => r.ID).FirstOrDefault();

                                if (hsxID != 0 && lspID != 0)
                                {
                                    SanPham sp = new SanPham();
                                    sp.HangSanXuatID = Convert.ToInt32(hsxID);
                                    sp.LoaiSanPhamID = Convert.ToInt32(lspID);
                                    sp.TenSanPham = r["TenSanPham"].ToString()!;
                                    sp.Size = Convert.ToInt32(r["Size"].ToString());
                                    sp.DonGia = Convert.ToInt32(r["DonGia"].ToString());
                                    sp.SoLuong = Convert.ToInt32(r["SoLuong"].ToString());
                                    sp.HinhAnh = r["HinhAnh"].ToString()!;
                                    sp.TrangThai = true;
                                    context.SanPham.Add(sp);
                                }
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + dataTable.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmSanPham_Load(sender, e);
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
            saveFileDialog.FileName = "SanPham_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //tạo datatable mới, định nghĩa cột
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.AddRange(new DataColumn[8]
                    {
                        new DataColumn("ID",typeof(int)),
                        new DataColumn("HangSanXuat",typeof(string)),
                        new DataColumn("LoaiSanPham",typeof(string)),
                        new DataColumn("TenSanPham",typeof(string)),
                        new DataColumn("Size",typeof(int)),
                        new DataColumn("DonGia",typeof(int)),
                        new DataColumn("SoLuong",typeof(int)),
                        new DataColumn("HinhAnh",typeof(string))
                    });

                    //thêm dữ liệu từ sanpham vào datatable
                    var sanPham = context.SanPham.Include(r => r.LoaiSanPham)
                             .Include(r => r.HangSanXuat).Where(r => r.TrangThai).ToList();

                    if (sanPham != null)
                    {
                        foreach (var i in sanPham)
                        {
                            dataTable.Rows.Add(i.ID, i.HangSanXuat.TenHangSanXuat, i.LoaiSanPham.TenLoai, i.TenSanPham, i.Size, i.DonGia, i.SoLuong, i.HinhAnh);
                        }
                    }

                    //khai báo workbook, worksheet mới. Đổ dữ liệu từ datatable vào workbook(sheet) đó
                    using (XLWorkbook workBook = new XLWorkbook())
                    {
                        var sheet = workBook.Worksheets.Add(dataTable, "SanPham");
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

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            var sp = context.SanPham.Where(r => r.TrangThai).Select(r => new
            {
                r.ID,
                r.LoaiSanPhamID,
                r.LoaiSanPham.TenLoai,
                r.HangSanXuatID,
                r.HangSanXuat.TenHangSanXuat,
                r.TenSanPham,
                r.Size,
                r.SoLuong,
                r.DonGia,
                r.HinhAnh,
            }).OrderBy(r => r.TenLoai).ToList();
            dataGridView.DataSource = sp;
            LaySTT();
            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", sp, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", sp, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", sp, "TenSanPham", false, DataSourceUpdateMode.Never);

            numSize.DataBindings.Clear();
            numSize.DataBindings.Add("Value", sp, "Size", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", sp, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", sp, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", sp, "HinhAnh", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
        }

        private void btnHangSanXuat_Click(object sender, EventArgs e)
        {
            var sp = context.SanPham.Where(r => r.TrangThai).Select(r => new
            {
                r.ID,
                r.LoaiSanPhamID,
                r.LoaiSanPham.TenLoai,
                r.HangSanXuatID,
                r.HangSanXuat.TenHangSanXuat,
                r.TenSanPham,
                r.Size,
                r.SoLuong,
                r.DonGia,
                r.HinhAnh,
            }).OrderBy(r => r.TenHangSanXuat).ToList();
            dataGridView.DataSource = sp; LaySTT();
            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", sp, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", sp, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", sp, "TenSanPham", false, DataSourceUpdateMode.Never);

            numSize.DataBindings.Clear();
            numSize.DataBindings.Add("Value", sp, "Size", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", sp, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", sp, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", sp, "HinhAnh", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            var sp = context.SanPham.Where(r => r.TrangThai).Select(r => new
            {
                r.ID,
                r.LoaiSanPhamID,
                r.LoaiSanPham.TenLoai,
                r.HangSanXuatID,
                r.HangSanXuat.TenHangSanXuat,
                r.TenSanPham,
                r.Size,
                r.SoLuong,
                r.DonGia,
                r.HinhAnh,
            }).OrderBy(r => r.TenSanPham).ToList();
            dataGridView.DataSource = sp; LaySTT();
            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", sp, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", sp, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", sp, "TenSanPham", false, DataSourceUpdateMode.Never);

            numSize.DataBindings.Clear();
            numSize.DataBindings.Add("Value", sp, "Size", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", sp, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", sp, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", sp, "HinhAnh", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
        }

        private void frmSanPham_Shown(object sender, EventArgs e)
        {
            LaySTT();
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
            var sp = context.SanPham
                .Select(r => new
                {
                    r.ID,
                    r.LoaiSanPhamID,
                    r.LoaiSanPham.TenLoai,
                    r.HangSanXuatID,
                    r.HangSanXuat.TenHangSanXuat,
                    r.TenSanPham,
                    r.Size,
                    r.SoLuong,
                    r.DonGia,
                    r.HinhAnh,
                    r.TrangThai,
                })
                .Where(r => (r.TenLoai.Contains(txtTuKhoa.Text) ||
                            r.TenHangSanXuat.Contains(txtTuKhoa.Text) ||
                            r.TenSanPham.Contains(txtTuKhoa.Text)) && r.TrangThai)
                .ToList();
            dataGridView.DataSource = sp;
            LaySTT();
            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", sp, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", sp, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", sp, "TenSanPham", false, DataSourceUpdateMode.Never);

            numSize.DataBindings.Clear();
            numSize.DataBindings.Add("Value", sp, "Size", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", sp, "SoLuong", false, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", sp, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", sp, "HinhAnh", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
        }
    }
}

