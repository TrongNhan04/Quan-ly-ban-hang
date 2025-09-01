namespace QuanLyBanGiay.Forms
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            panel1 = new Panel();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            picHien = new PictureBox();
            label3 = new Label();
            btnHuyBo = new Button();
            label2 = new Label();
            btnDangNhap = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.vecteezy_shoe_logo_for_sports_24603571_Photoroom;
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(picHien);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(596, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 591);
            panel1.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(68, 347);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(376, 46);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(68, 242);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(434, 46);
            txtTenDangNhap.TabIndex = 0;
            txtTenDangNhap.KeyDown += txtTenDangNhap_KeyDown;
            // 
            // picHien
            // 
            picHien.Image = Properties.Resources.istockphoto_2129502269_1024x1024;
            picHien.Location = new Point(450, 347);
            picHien.Name = "picHien";
            picHien.Size = new Size(52, 46);
            picHien.SizeMode = PictureBoxSizeMode.StretchImage;
            picHien.TabIndex = 26;
            picHien.TabStop = false;
            picHien.Click += picHien_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 242, 215);
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(130, 90);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(320, 65);
            label3.TabIndex = 6;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.ForeColor = Color.Red;
            btnHuyBo.Location = new Point(300, 432);
            btnHuyBo.Margin = new Padding(5);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(202, 68);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 242, 215);
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold);
            label2.Location = new Point(68, 300);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 40);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.Blue;
            btnDangNhap.Location = new Point(68, 432);
            btnDangNhap.Margin = new Padding(5);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(222, 68);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 242, 215);
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold);
            label1.Location = new Point(68, 185);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 40);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập:";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(596, 591);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 591);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += frmDangNhap_Load;
            Shown += frmDangNhap_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHien).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnDangNhap;
        private Button btnHuyBo;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox picHien;
        public TextBox txtMatKhau;
        public TextBox txtTenDangNhap;
    }
}