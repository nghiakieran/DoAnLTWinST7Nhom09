using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ChiTietHD
    {
        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaSP { get; set; }

        public HoaDonBanHang HoaDonBanHang { get; set; }
        public SanPham SanPham { get; set; }

        public int SoLuongSP { get; set; }

        public decimal? DonGia { get; set; }
    }
}
