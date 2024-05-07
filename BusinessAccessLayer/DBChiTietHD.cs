using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class DBChiTietHD
    {
        public DBChiTietHD()
        {

        }
        public bool ThemChiTietHD(string MaSP, int SoLuongSP, decimal? DonGia)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    var lastHD = context.HoaDonBanHangs.OrderByDescending(nv => nv.MaHD).FirstOrDefault();

                    ChiTietHD chiTiet = new ChiTietHD
                    {
                        MaHD = lastHD.MaHD,
                        MaSP = MaSP,
                        SoLuongSP = SoLuongSP,
                        DonGia = DonGia,                 
                    };
                    context.ChiTietHDs.Add(chiTiet);
                    context.SaveChanges();
                    return true;
                } catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
