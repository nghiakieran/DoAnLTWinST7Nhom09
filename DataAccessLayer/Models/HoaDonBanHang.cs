using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class HoaDonBanHang
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Column(TypeName = "Date")]
        public DateTime NgayDatHang { get; set; }

        public decimal? TongSoTien { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }
        public NhanVien NhanVien { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }
        public KhachHang KhachHang { get; set; }

        public ICollection<ChiTietHD> ChiTietHDs { get; set; }
    }
}
