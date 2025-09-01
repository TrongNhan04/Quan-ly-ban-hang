using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    class DonHang_ChiTiet
    {
        public int ID { get; set; }
        public int DonHangID { get; set; }
        public int SanPhamID { get; set; }
        public int SoLuongDat { get; set; }
        public int DonGiaDat { get; set; }
        public virtual DonHang DonHang { get; set; } = null!;
        public virtual SanPham SanPham { get; set; } = null!;

        [NotMapped]
        public class DanhSachDonHang_ChiTiet
        {
            public int ID { get; set; }
            public int DonHangID { get; set; }
            public int SanPhamID { get; set; }
            public string TenSanPham { get; set; } = null!; // Bổ sung thêm
            public int Size { get; set; }// Bổ sung thêm
            public int SoLuongDat { get; set; }
            public int DonGiaDat { get; set; }
            public double ThanhTien { get; set; } // Bổ sung thêm
        }
    }
}
