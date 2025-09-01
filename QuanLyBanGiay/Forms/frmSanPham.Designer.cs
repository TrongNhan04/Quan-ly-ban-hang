namespace QuanLyBanGiay.Forms
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnXuat = new ToolStripButton();
            btnNhap = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnTimKiem = new ToolStripButton();
            txtTuKhoa = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip1 = new ToolStrip();
            btnSapXep = new ToolStripDropDownButton();
            btnLoaiSanPham = new ToolStripMenuItem();
            btnHangSanXuat = new ToolStripMenuItem();
            btnSanPham = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            picHinhAnh = new PictureBox();
            txtTenSanPham = new TextBox();
            label1 = new Label();
            numSoLuong = new NumericUpDown();
            label6 = new Label();
            numSize = new NumericUpDown();
            numDonGia = new NumericUpDown();
            label8 = new Label();
            label2 = new Label();
            label5 = new Label();
            cboHangSanXuat = new ComboBox();
            label4 = new Label();
            cboLoaiSanPham = new ComboBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            SuspendLayout();
            // 
            // btnXuat
            // 
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(129, 44);
            btnXuat.Text = "Xuất...";
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Image = (Image)resources.GetObject("btnNhap.Image");
            btnNhap.ImageTransparentColor = Color.Magenta;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(141, 44);
            btnNhap.Text = "Nhập...";
            btnNhap.Click += btnNhap_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 50);
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(100, 44);
            btnTimKiem.Text = "Tìm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(414, 50);
            txtTuKhoa.KeyDown += txtTuKhoa_KeyDown;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(139, 44);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat, btnSapXep });
            toolStrip1.Location = new Point(4, 43);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1905, 50);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSapXep
            // 
            btnSapXep.DropDownItems.AddRange(new ToolStripItem[] { btnLoaiSanPham, btnHangSanXuat, btnSanPham });
            btnSapXep.Image = Properties.Resources.sort_az_descending;
            btnSapXep.ImageTransparentColor = Color.Magenta;
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(171, 44);
            btnSapXep.Text = "Sắp xếp";
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.Image = Properties.Resources.product2;
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Size = new Size(338, 48);
            btnLoaiSanPham.Text = "Loại sản phẩm";
            btnLoaiSanPham.Click += btnLoaiSanPham_Click;
            // 
            // btnHangSanXuat
            // 
            btnHangSanXuat.Image = Properties.Resources.factory;
            btnHangSanXuat.Name = "btnHangSanXuat";
            btnHangSanXuat.Size = new Size(338, 48);
            btnHangSanXuat.Text = "Hãng sản xuất";
            btnHangSanXuat.Click += btnHangSanXuat_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.Image = Properties.Resources.san_pham;
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(338, 48);
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.Click += btnSanPham_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 93);
            dataGridView.Margin = new Padding(4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1905, 312);
            dataGridView.TabIndex = 3;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.DataError += dataGridView_DataError;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(toolStrip1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 401);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1913, 409);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Image = Properties.Resources.exit;
            btnThoat.Location = new Point(1259, 287);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(208, 64);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Image = Properties.Resources.delete2;
            btnXoa.Location = new Point(611, 287);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(208, 64);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Top;
            btnHuyBo.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuyBo.Image = Properties.Resources.refresh;
            btnHuyBo.Location = new Point(1043, 287);
            btnHuyBo.Margin = new Padding(4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(208, 64);
            btnHuyBo.TabIndex = 9;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Image = Properties.Resources.disk_blue_window;
            btnLuu.Location = new Point(827, 287);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(208, 64);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Image = Properties.Resources.edit;
            btnSua.Location = new Point(395, 287);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(208, 64);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top;
            btnThem.BackColor = SystemColors.ButtonHighlight;
            btnThem.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ControlText;
            btnThem.Image = Properties.Resources.add;
            btnThem.Location = new Point(179, 287);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(208, 64);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numSize);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1913, 401);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.Top;
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(1491, 61);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(243, 290);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 28;
            picHinhAnh.TabStop = false;
            picHinhAnh.Click += picHinhAnh_Click;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Anchor = AnchorStyles.Top;
            txtTenSanPham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenSanPham.Location = new Point(446, 210);
            txtTenSanPham.Margin = new Padding(6);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(519, 50);
            txtTenSanPham.TabIndex = 25;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F);
            label1.Location = new Point(208, 210);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 40);
            label1.TabIndex = 24;
            label1.Text = "Tên Sản Phẩm(*):";
            // 
            // numSoLuong
            // 
            numSoLuong.Anchor = AnchorStyles.Top;
            numSoLuong.Font = new Font("Segoe UI", 10.875F);
            numSoLuong.Location = new Point(1206, 61);
            numSoLuong.Margin = new Padding(5);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(263, 46);
            numSoLuong.TabIndex = 23;
            numSoLuong.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.875F);
            label6.Location = new Point(1025, 63);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(174, 40);
            label6.TabIndex = 22;
            label6.Text = "Số Lượng(*):";
            // 
            // numSize
            // 
            numSize.Anchor = AnchorStyles.Top;
            numSize.Font = new Font("Segoe UI", 10.875F);
            numSize.Location = new Point(1206, 210);
            numSize.Margin = new Padding(5);
            numSize.Maximum = new decimal(new int[] { 42, 0, 0, 0 });
            numSize.Minimum = new decimal(new int[] { 37, 0, 0, 0 });
            numSize.Name = "numSize";
            numSize.Size = new Size(263, 46);
            numSize.TabIndex = 21;
            numSize.ThousandsSeparator = true;
            numSize.Value = new decimal(new int[] { 37, 0, 0, 0 });
            // 
            // numDonGia
            // 
            numDonGia.Anchor = AnchorStyles.Top;
            numDonGia.Font = new Font("Segoe UI", 10.875F);
            numDonGia.Location = new Point(1206, 133);
            numDonGia.Margin = new Padding(5);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(263, 46);
            numDonGia.TabIndex = 21;
            numDonGia.ThousandsSeparator = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.875F);
            label8.Location = new Point(1088, 210);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 40);
            label8.TabIndex = 20;
            label8.Text = "Size (*):";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F);
            label2.Location = new Point(1043, 133);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 40);
            label2.TabIndex = 20;
            label2.Text = "Đơn Giá(*):";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.875F);
            label5.Location = new Point(195, 133);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(243, 40);
            label5.TabIndex = 19;
            label5.Text = "Hãng sản xuất (*):";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.Anchor = AnchorStyles.Top;
            cboHangSanXuat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHangSanXuat.Font = new Font("Segoe UI", 10.875F);
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(446, 135);
            cboHangSanXuat.Margin = new Padding(5);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(519, 48);
            cboHangSanXuat.TabIndex = 18;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.875F);
            label4.Location = new Point(258, 61);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(177, 40);
            label4.TabIndex = 17;
            label4.Text = "Phân Loại(*):";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Anchor = AnchorStyles.Top;
            cboLoaiSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSanPham.Font = new Font("Segoe UI", 10.875F);
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(446, 61);
            cboLoaiSanPham.Margin = new Padding(5);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(519, 48);
            cboLoaiSanPham.TabIndex = 16;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1913, 810);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản Phẩm";
            Load += frmSanPham_Load;
            Shown += frmSanPham_Shown;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripButton btnXuat;
        private ToolStripButton btnNhap;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnTimKiem;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripLabel toolStripLabel1;
        private ToolStrip toolStrip1;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox cboHangSanXuat;
        private Label label4;
        private ComboBox cboLoaiSanPham;
        private TextBox txtTenSanPham;
        private Label label1;
        private NumericUpDown numSoLuong;
        private Label label6;
        private NumericUpDown numDonGia;
        private Label label2;
        private PictureBox picHinhAnh;
        private NumericUpDown numSize;
        private Label label8;
        private ToolStripDropDownButton btnSapXep;
        private ToolStripMenuItem btnLoaiSanPham;
        private ToolStripMenuItem btnHangSanXuat;
        private ToolStripMenuItem btnSanPham;
    }
}