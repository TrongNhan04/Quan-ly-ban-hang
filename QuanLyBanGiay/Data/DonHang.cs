using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    class DonHang
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayLapDonHang { get; set; }
        public string? GhiChuDonHang { get; set; }
        public bool TrangThai { get; set; }
        public virtual ICollection<DonHang_ChiTiet> DonHang_ChiTiet { get; } = new List<DonHang_ChiTiet>();
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
