using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class NhanVien
    {
        [Key]
        [StringLength(6)]
        public string MaNV { get; set; }

        [StringLength(10)]
        public string HoNV { get; set; }

        [StringLength(20)]
        public string TenNV { get; set; }

        [Column(TypeName = "Date")]
        public DateTime NgaySinh { get; set; }

        [StringLength(3)]
        public string GioiTinh { get; set; }

        [StringLength(15)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Số điện thoại chỉ được chứa các ký tự số.")]
        public string SoDT { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public decimal? Luong { get; set; }

        public ICollection<TaiKhoan> TaiKhoans { get; set; }

        public ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }

        public ICollection<HoaDonNhapHang> HoaDonNhapHangs { get; set; }
    }
}
