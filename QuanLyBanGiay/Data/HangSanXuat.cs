using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    class HangSanXuat
    {
        public int ID { get; set; }
        [StringLength(100)]
        public string TenHangSanXuat { get; set; } = null!;
        public bool TrangThai { get; set; }
        public virtual ICollection<SanPham> SanPham { get; } = new List<SanPham>();
    }
}
