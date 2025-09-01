using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    class NguoiDung
    {
        public int ID { get; set; }
        [StringLength(100)]
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public int PhanQuyenID { get; set; }
        public virtual PhanQuyen PhanQuyen { get; set; } = null!;
        public virtual ICollection<NhanVien> NhanVien { get; } = new List<NhanVien>();
    }
}
