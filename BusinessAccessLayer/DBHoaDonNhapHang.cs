using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class DBHoaDonNhapHang
    {
        public DBHoaDonNhapHang()
        {

        }
        public bool ThemPhieuNhap(string TenNCC, decimal TongTienDonNhap)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string newPN = "";
                    var lastPN = context.HoaDonNhapHangs.OrderByDescending(nv => nv.MaPhieu).FirstOrDefault();

                    if (lastPN != null)
                    {
                        string lastMaPN = lastPN.MaPhieu;
                        string last3Chars = lastMaPN.Substring(Math.Max(0, lastMaPN.Length - 3));
                        int last3CharsAsNumber = int.Parse(last3Chars) + 1;
                        string newNumberString = last3CharsAsNumber.ToString("D3");
                        newPN = "HDNH" + newNumberString.PadLeft(3, '0');
                    }
                    else
                    {
                        newPN = "HDNH001";
                    }

                    // Tìm Nhà cung cấp bằng TenNCC để lấy MaNCC

                    var nhacc = context.NhaCungCaps.FirstOrDefault(ncc => ncc.TenNCC == TenNCC);    
                    var hoaDonNhapHang = new HoaDonNhapHang
                    {
                        MaPhieu = newPN,
                        NgayNhap = DateTime.Now,
                        TongTienDonNhap = TongTienDonNhap,
                        MaNV = DBCurrentLogin.GetCurrentLoginInfo().MaNV,
                        MaNCC = nhacc.MaNCC,
                    };

                    context.HoaDonNhapHangs.Add(hoaDonNhapHang);
                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi thêm phiếu nhập: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
