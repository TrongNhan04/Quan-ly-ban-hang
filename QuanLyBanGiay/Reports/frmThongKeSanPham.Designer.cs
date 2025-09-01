namespace QuanLyBanGiay.Reports
{
    partial class frmThongKeSanPham
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
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            panel1 = new Panel();
            btnLocKetQua = new Button();
            label2 = new Label();
            label1 = new Label();
            cboLoaiSanPham = new ComboBox();
            cboHangSanXuat = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 110);
            reportViewer1.Margin = new Padding(6);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1182, 426);
            reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboLoaiSanPham);
            panel1.Controls.Add(cboHangSanXuat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 110);
            panel1.TabIndex = 1;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Anchor = AnchorStyles.Top;
            btnLocKetQua.Location = new Point(980, 30);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(183, 51);
            btnLocKetQua.TabIndex = 2;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F);
            label2.Location = new Point(495, 35);
            label2.Name = "label2";
            label2.Size = new Size(195, 37);
            label2.TabIndex = 5;
            label2.Text = "Loại sản phẩm:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F);
            label1.Location = new Point(19, 35);
            label1.Name = "label1";
            label1.Size = new Size(191, 37);
            label1.TabIndex = 6;
            label1.Text = "Hãng sản xuất:";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Anchor = AnchorStyles.Top;
            cboLoaiSanPham.Font = new Font("Segoe UI", 10.125F);
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(696, 32);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(218, 45);
            cboLoaiSanPham.TabIndex = 1;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.Anchor = AnchorStyles.Top;
            cboHangSanXuat.Font = new Font("Segoe UI", 10.125F);
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(216, 32);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(218, 45);
            cboHangSanXuat.TabIndex = 0;
            // 
            // frmThongKeSanPham
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 536);
            Controls.Add(reportViewer1);
            Controls.Add(panel1);
            Margin = new Padding(6);
            Name = "frmThongKeSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê sản phẩm";
            Load += frmThongKeSanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Panel panel1;
        private Button btnLocKetQua;
        private Label label2;
        private Label label1;
        private ComboBox cboLoaiSanPham;
        private ComboBox cboHangSanXuat;
    }
}