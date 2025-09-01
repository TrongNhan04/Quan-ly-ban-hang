using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanGiay.Data
{
    class PhanQuyen
    {
        public int ID { get; set; }
        [StringLength(15)]
        public string QuyenHan { get; set; } = null!;
        public virtual ICollection<NguoiDung> NguoiDung { get; } = new List<NguoiDung>();
    }
}
