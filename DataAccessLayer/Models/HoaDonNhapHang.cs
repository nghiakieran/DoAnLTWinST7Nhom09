using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class HoaDonNhapHang
    {
        [Key]
        [StringLength(10)]
        public string MaPhieu { get; set; }

        [Column(TypeName = "Date")]
        public DateTime NgayNhap { get; set; }

        public decimal TongTienDonNhap { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }
        public NhanVien NhanVien { get; set; }

        [StringLength(10)]
        public string MaNCC { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
    }
}
