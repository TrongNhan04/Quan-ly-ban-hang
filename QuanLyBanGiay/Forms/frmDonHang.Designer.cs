namespace QuanLyBanGiay.Forms
{
    partial class frmDonHang
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonHang));
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnLocTheoToi = new ToolStripButton();
            btnHienTatCa = new ToolStripButton();
            panel1 = new Panel();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLapHoaDon = new Button();
            btnSua = new Button();
            btnThemDonHang = new Button();
            btnChuaCoHoaDon = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(toolStrip1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1625, 569);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách đơn hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 93);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1617, 472);
            dataGridView.TabIndex = 1;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat, toolStripSeparator2, btnLocTheoToi, btnHienTatCa, toolStripSeparator3, btnChuaCoHoaDon });
            toolStrip1.Location = new Point(4, 43);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1617, 50);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(139, 44);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(414, 50);
            txtTuKhoa.KeyDown += txtTuKhoa_KeyDown;
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 50);
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
            // btnXuat
            // 
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(129, 44);
            btnXuat.Text = "Xuất...";
            btnXuat.Click += btnXuat_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 50);
            // 
            // btnLocTheoToi
            // 
            btnLocTheoToi.Image = Properties.Resources.funnel;
            btnLocTheoToi.ImageTransparentColor = Color.Magenta;
            btnLocTheoToi.Name = "btnLocTheoToi";
            btnLocTheoToi.Size = new Size(205, 44);
            btnLocTheoToi.Text = "Lọc theo tôi";
            btnLocTheoToi.Click += btnHienCuaToi_Click;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Image = Properties.Resources.table_sql_view;
            btnHienTatCa.ImageTransparentColor = Color.Magenta;
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(129, 44);
            btnHienTatCa.Text = "Tất cả";
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnLapHoaDon);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThemDonHang);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 569);
            panel1.Name = "panel1";
            panel1.Size = new Size(1625, 124);
            panel1.TabIndex = 9;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Image = Properties.Resources.exit;
            btnThoat.Location = new Point(1163, 30);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(165, 64);
            btnThoat.TabIndex = 16;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Image = Properties.Resources.delete2;
            btnXoa.Location = new Point(1001, 30);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(154, 64);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Anchor = AnchorStyles.Top;
            btnLapHoaDon.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            btnLapHoaDon.ForeColor = Color.Blue;
            btnLapHoaDon.Image = Properties.Resources.hoa_don;
            btnLapHoaDon.Location = new Point(570, 30);
            btnLapHoaDon.Margin = new Padding(4);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(260, 64);
            btnLapHoaDon.TabIndex = 14;
            btnLapHoaDon.Text = "Lập hóa đơn...";
            btnLapHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top;
            btnSua.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Image = Properties.Resources.edit;
            btnSua.Location = new Point(838, 30);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(155, 64);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThemDonHang
            // 
            btnThemDonHang.Anchor = AnchorStyles.Top;
            btnThemDonHang.BackColor = SystemColors.ButtonHighlight;
            btnThemDonHang.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemDonHang.ForeColor = SystemColors.ControlText;
            btnThemDonHang.Image = Properties.Resources.add;
            btnThemDonHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemDonHang.Location = new Point(297, 30);
            btnThemDonHang.Margin = new Padding(4);
            btnThemDonHang.Name = "btnThemDonHang";
            btnThemDonHang.Size = new Size(265, 64);
            btnThemDonHang.TabIndex = 11;
            btnThemDonHang.Text = "Thêm mới...";
            btnThemDonHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemDonHang.UseVisualStyleBackColor = false;
            btnThemDonHang.Click += btnThemDonHang_Click;
            // 
            // btnChuaCoHoaDon
            // 
            btnChuaCoHoaDon.Image = Properties.Resources.document_error;
            btnChuaCoHoaDon.ImageTransparentColor = Color.Magenta;
            btnChuaCoHoaDon.Name = "btnChuaCoHoaDon";
            btnChuaCoHoaDon.Size = new Size(271, 44);
            btnChuaCoHoaDon.Text = "Chưa có hóa đơn";
            btnChuaCoHoaDon.Click += btnChuaCoHoaDon_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 50);
            // 
            // frmDonHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1625, 693);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "frmDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đơn Hàng";
            Load += frmDonHang_Load;
            Shown += frmDonHang_Shown;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private Panel panel1;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLapHoaDon;
        private Button btnSua;
        private Button btnThemDonHang;
        private DataGridView dataGridView;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnLocTheoToi;
        private ToolStripButton btnHienTatCa;
        private ToolStripButton btnChuaCoHoaDon;
        private ToolStripSeparator toolStripSeparator3;
    }
}