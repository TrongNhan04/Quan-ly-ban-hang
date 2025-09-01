namespace QuanLyBanGiay.Forms
{
    partial class frmDonHang_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cboKhachHang = new ComboBox();
            txtNhanVien = new TextBox();
            txtGhiChuDonHang = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnThoat = new Button();
            btnLapHoaDon = new Button();
            btnLuuDonHang = new Button();
            btnXoa = new Button();
            btnXacNhanDat = new Button();
            groupBox2 = new GroupBox();
            numSoLuongDat = new NumericUpDown();
            label6 = new Label();
            numDonGiaDat = new NumericUpDown();
            label5 = new Label();
            label2 = new Label();
            cboSanPham = new ComboBox();
            numSize = new NumericUpDown();
            label8 = new Label();
            dataGridView = new DataGridView();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongDat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaDat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(txtNhanVien);
            groupBox1.Controls.Add(txtGhiChuDonHang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1312, 214);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đơn hàng";
            // 
            // cboKhachHang
            // 
            cboKhachHang.Anchor = AnchorStyles.Top;
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(943, 49);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(333, 48);
            cboKhachHang.TabIndex = 1;
            // 
            // txtNhanVien
            // 
            txtNhanVien.Anchor = AnchorStyles.Top;
            txtNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNhanVien.Location = new Point(309, 42);
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.Size = new Size(347, 50);
            txtNhanVien.TabIndex = 2;
            // 
            // txtGhiChuDonHang
            // 
            txtGhiChuDonHang.Anchor = AnchorStyles.Top;
            txtGhiChuDonHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGhiChuDonHang.Location = new Point(309, 124);
            txtGhiChuDonHang.Name = "txtGhiChuDonHang";
            txtGhiChuDonHang.Size = new Size(967, 50);
            txtGhiChuDonHang.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 124);
            label3.Name = "label3";
            label3.Size = new Size(249, 40);
            label3.TabIndex = 18;
            label3.Text = "Ghi chú đơn hàng:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(727, 49);
            label4.Name = "label4";
            label4.Size = new Size(210, 40);
            label4.TabIndex = 16;
            label4.Text = "Khách hàng (*):";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 41);
            label1.Name = "label1";
            label1.Size = new Size(237, 40);
            label1.TabIndex = 8;
            label1.Text = "Nhân viên lập (*):";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnLapHoaDon);
            panel1.Controls.Add(btnLuuDonHang);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 768);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 115);
            panel1.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.Black;
            btnThoat.Image = Properties.Resources.exit;
            btnThoat.Location = new Point(841, 25);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(208, 64);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.Anchor = AnchorStyles.Top;
            btnLapHoaDon.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            btnLapHoaDon.ForeColor = Color.Blue;
            btnLapHoaDon.Image = Properties.Resources.hoa_don;
            btnLapHoaDon.Location = new Point(540, 25);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(292, 64);
            btnLapHoaDon.TabIndex = 2;
            btnLapHoaDon.Text = "Lập hóa đơn...";
            btnLapHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLapHoaDon.UseVisualStyleBackColor = true;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnLuuDonHang
            // 
            btnLuuDonHang.Anchor = AnchorStyles.Top;
            btnLuuDonHang.BackColor = SystemColors.ButtonHighlight;
            btnLuuDonHang.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuDonHang.ForeColor = SystemColors.ControlText;
            btnLuuDonHang.Image = Properties.Resources.add;
            btnLuuDonHang.Location = new Point(263, 25);
            btnLuuDonHang.Name = "btnLuuDonHang";
            btnLuuDonHang.Size = new Size(271, 64);
            btnLuuDonHang.TabIndex = 0;
            btnLuuDonHang.Text = "Lưu đơn hàng";
            btnLuuDonHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuuDonHang.UseVisualStyleBackColor = false;
            btnLuuDonHang.Click += btnLuuDonHang_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Image = Properties.Resources.delete2;
            btnXoa.Location = new Point(1061, 110);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(215, 64);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanDat
            // 
            btnXacNhanDat.Anchor = AnchorStyles.Top;
            btnXacNhanDat.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhanDat.ForeColor = Color.Blue;
            btnXacNhanDat.Image = Properties.Resources.navigate_check;
            btnXacNhanDat.Location = new Point(1061, 39);
            btnXacNhanDat.Name = "btnXacNhanDat";
            btnXacNhanDat.Size = new Size(215, 64);
            btnXacNhanDat.TabIndex = 5;
            btnXacNhanDat.Text = "Xác nhận";
            btnXacNhanDat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXacNhanDat.UseVisualStyleBackColor = true;
            btnXacNhanDat.Click += btnXacNhanDat_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(numSoLuongDat);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numDonGiaDat);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnXacNhanDat);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cboSanPham);
            groupBox2.Controls.Add(numSize);
            groupBox2.Controls.Add(label8);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1312, 213);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết đơn hàng";
            // 
            // numSoLuongDat
            // 
            numSoLuongDat.Anchor = AnchorStyles.Top;
            numSoLuongDat.Font = new Font("Segoe UI", 10.875F);
            numSoLuongDat.Location = new Point(273, 127);
            numSoLuongDat.Margin = new Padding(5);
            numSoLuongDat.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuongDat.Name = "numSoLuongDat";
            numSoLuongDat.Size = new Size(263, 46);
            numSoLuongDat.TabIndex = 3;
            numSoLuongDat.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.875F);
            label6.Location = new Point(91, 130);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(174, 40);
            label6.TabIndex = 31;
            label6.Text = "Số Lượng(*):";
            // 
            // numDonGiaDat
            // 
            numDonGiaDat.Anchor = AnchorStyles.Top;
            numDonGiaDat.Font = new Font("Segoe UI", 10.875F);
            numDonGiaDat.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            numDonGiaDat.Location = new Point(747, 127);
            numDonGiaDat.Margin = new Padding(5);
            numDonGiaDat.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaDat.Name = "numDonGiaDat";
            numDonGiaDat.Size = new Size(263, 46);
            numDonGiaDat.TabIndex = 4;
            numDonGiaDat.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.875F);
            label5.Location = new Point(580, 130);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(156, 40);
            label5.TabIndex = 29;
            label5.Text = "Đơn Giá(*):";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F);
            label2.Location = new Point(36, 51);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(230, 40);
            label2.TabIndex = 28;
            label2.Text = "Tên Sản Phẩm(*):";
            // 
            // cboSanPham
            // 
            cboSanPham.Anchor = AnchorStyles.Top;
            cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanPham.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(274, 48);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(426, 48);
            cboSanPham.TabIndex = 1;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // numSize
            // 
            numSize.Anchor = AnchorStyles.Top;
            numSize.Font = new Font("Segoe UI", 10.875F);
            numSize.Location = new Point(882, 48);
            numSize.Margin = new Padding(5);
            numSize.Maximum = new decimal(new int[] { 42, 0, 0, 0 });
            numSize.Minimum = new decimal(new int[] { 37, 0, 0, 0 });
            numSize.Name = "numSize";
            numSize.Size = new Size(128, 46);
            numSize.TabIndex = 2;
            numSize.ThousandsSeparator = true;
            numSize.Value = new decimal(new int[] { 37, 0, 0, 0 });
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.875F);
            label8.Location = new Point(760, 51);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 40);
            label8.TabIndex = 26;
            label8.Text = "Size (*):";
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1312, 341);
            dataGridView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 427);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 341);
            panel2.TabIndex = 12;
            // 
            // frmDonHang_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 883);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "frmDonHang_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đơn Hàng Chi Tiết";
            Load += frmDonHang_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongDat).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaDat).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboKhachHang;
        private TextBox txtGhiChuDonHang;
        private Label label3;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLapHoaDon;
        private Button btnXacNhanDat;
        private Button btnLuuDonHang;
        private GroupBox groupBox2;
        private Label label2;
        private NumericUpDown numSize;
        private Label label8;
        private ComboBox cboSanPham;
        private NumericUpDown numSoLuongDat;
        private Label label6;
        private NumericUpDown numDonGiaDat;
        private Label label5;
        private DataGridView dataGridView;
        private Panel panel2;
        private TextBox txtNhanVien;
    }
}