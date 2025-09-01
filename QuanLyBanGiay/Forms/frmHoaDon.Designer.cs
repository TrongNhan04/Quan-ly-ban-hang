namespace QuanLyBanGiay.Forms
{
    partial class frmHoaDon
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
            groupBox1 = new GroupBox();
            dptNgayLap = new DateTimePicker();
            txtKhachHang = new TextBox();
            txtNhanVien = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView = new DataGridView();
            btnThoat = new Button();
            btnInHoaDon = new Button();
            btnLuu = new Button();
            panel1 = new Panel();
            lblTongCong = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dptNgayLap);
            groupBox1.Controls.Add(txtKhachHang);
            groupBox1.Controls.Add(txtNhanVien);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1293, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dptNgayLap
            // 
            dptNgayLap.Anchor = AnchorStyles.Top;
            dptNgayLap.CalendarFont = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dptNgayLap.CustomFormat = "dd/MM/yyyy";
            dptNgayLap.Enabled = false;
            dptNgayLap.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dptNgayLap.Format = DateTimePickerFormat.Custom;
            dptNgayLap.Location = new Point(1048, 40);
            dptNgayLap.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dptNgayLap.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dptNgayLap.Name = "dptNgayLap";
            dptNgayLap.Size = new Size(192, 43);
            dptNgayLap.TabIndex = 2;
            // 
            // txtKhachHang
            // 
            txtKhachHang.Anchor = AnchorStyles.Top;
            txtKhachHang.Font = new Font("Segoe UI", 10.125F);
            txtKhachHang.Location = new Point(640, 39);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(252, 43);
            txtKhachHang.TabIndex = 1;
            // 
            // txtNhanVien
            // 
            txtNhanVien.Anchor = AnchorStyles.Top;
            txtNhanVien.Font = new Font("Segoe UI", 10.125F);
            txtNhanVien.Location = new Point(195, 42);
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.Size = new Size(252, 43);
            txtNhanVien.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F);
            label3.Location = new Point(912, 42);
            label3.Name = "label3";
            label3.Size = new Size(130, 37);
            label3.TabIndex = 0;
            label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F);
            label2.Location = new Point(472, 44);
            label2.Name = "label2";
            label2.Size = new Size(162, 37);
            label2.TabIndex = 0;
            label2.Text = "Khách hàng:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F);
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(142, 37);
            label1.TabIndex = 0;
            label1.Text = "Người lập:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 98);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1293, 467);
            dataGridView.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(609, 18);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(159, 67);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.Top;
            btnInHoaDon.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold);
            btnInHoaDon.ForeColor = Color.Black;
            btnInHoaDon.Image = Properties.Resources.printer_ok;
            btnInHoaDon.Location = new Point(343, 18);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(259, 67);
            btnInHoaDon.TabIndex = 19;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Top;
            btnLuu.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Image = Properties.Resources.disk_blue_window;
            btnLuu.Location = new Point(70, 18);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(267, 67);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu hóa đơn";
            btnLuu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnInHoaDon);
            panel1.Controls.Add(lblTongCong);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 565);
            panel1.Name = "panel1";
            panel1.Size = new Size(1293, 103);
            panel1.TabIndex = 22;
            // 
            // lblTongCong
            // 
            lblTongCong.Anchor = AnchorStyles.Top;
            lblTongCong.AutoSize = true;
            lblTongCong.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongCong.Location = new Point(1035, 35);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Size = new Size(112, 33);
            lblTongCong.TabIndex = 0;
            lblTongCong.Text = "Số tiền";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.875F, FontStyle.Bold);
            label4.Location = new Point(868, 35);
            label4.Name = "label4";
            label4.Size = new Size(170, 33);
            label4.TabIndex = 0;
            label4.Text = "Tổng cộng:";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 668);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn";
            Load += frmHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNhanVien;
        private Label label1;
        private TextBox txtKhachHang;
        private Label label2;
        private DataGridView dataGridView;
        private Button btnThoat;
        private Button btnInHoaDon;
        private Button btnLuu;
        private Panel panel1;
        private Label label3;
        private DateTimePicker dptNgayLap;
        private Label lblTongCong;
        private Label label4;
    }
}