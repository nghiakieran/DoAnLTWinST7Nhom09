using DataAccessLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class DBChiTietPhieuNhap
    {
        public DBChiTietPhieuNhap() { }
        public bool ThemChiTietPhieuNhap(string MaSP, int SoLuong, decimal? DonGia)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    var lastPN = context.HoaDonNhapHangs.OrderByDescending(nv => nv.MaPhieu).FirstOrDefault();

                    ChiTietPhieuNhap chiTiet = new ChiTietPhieuNhap
                    {
                        MaPhieu = lastPN.MaPhieu,
                        MaSP = MaSP,
                        SoLuong = SoLuong,
                        DonGia = DonGia,
                    };
                    context.ChiTietPhieuNhaps.Add(chiTiet);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
