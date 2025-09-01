using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    class NhanVien
    {
        public int ID { get; set; }
        [StringLength(100)]
        public string HoVaTen { get; set; } = null!;
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public int NguoiDungID { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<DonHang> DonHang { get; } = new List<DonHang>();
        public virtual NguoiDung NguoiDung { get; set; } = null!;
    }
}
