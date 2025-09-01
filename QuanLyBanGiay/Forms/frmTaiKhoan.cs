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
    public partial class frmTaiKhoan : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id;// mã nhân viên
        int nguoiDungID;
        public frmTaiKhoan(int maNhanVien = 0)
        {
            InitializeComponent();
            id = maNhanVien;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            NhanVien nv = context.NhanVien.Find(id)!;
            if (nv != null)
            {
                lblNhanVien.Text = nv.HoVaTen;
                lblMaNV.Text = nv.ID.ToString();
                lblDienThoai.Text = nv.DienThoai;
                lblDiaChi.Text = nv.DiaChi;
                nguoiDungID = nv.NguoiDungID;
            }

            NguoiDung user = context.NguoiDung.Find(nguoiDungID)!;
            if (user != null)
                txtTenDangNhap.Text = user.TenDangNhap;
            txtTenDangNhap.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
                MessageBox.Show("Mật khẩu xác nhận không đúng vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var user = context.NguoiDung.Find(nguoiDungID)!;
                if (user != null)
                {
                    user.TenDangNhap = txtTenDangNhap.Text;
                    context.NguoiDung.Update(user);
                    
                    if (string.IsNullOrEmpty(txtMatKhau.Text))
                        context.Entry(user).Property(x => x.MatKhau).IsModified = false; // Giữ nguyên mật khẩu cũ
                    else
                        user.MatKhau = BC.HashPassword(txtMatKhau.Text); // Cập nhật mật khẩu mới
                    
                    context.SaveChanges();
                    var kiemTra = context.NguoiDung.FirstOrDefault(x => x.ID == nguoiDungID);
                    context.Dispose();
                    context = new QLBHDbContext();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmTaiKhoan_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picHien_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '●' || txtXacNhanMatKhau.PasswordChar == '●')
            {
                txtMatKhau.PasswordChar = '\0';
                txtXacNhanMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '●';
                txtXacNhanMatKhau.PasswordChar = '●';
            }
        }
    }
}
