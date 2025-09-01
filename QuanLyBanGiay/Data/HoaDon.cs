using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    class HoaDon
    {
        public int ID { get; set; }
        public int DonHangID { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public virtual DonHang DonHang { get; set; } = null!;
        public virtual ICollection<HoaDon_ChiTiet> HoaDon_ChiTiet {get;} = new List<HoaDon_ChiTiet>();
    }
}
