using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class DBHoaDonBanHang
    {
        public DBHoaDonBanHang() { }
        public bool ThemHoaDon(decimal TongSoTien)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string newMaHD = "";
                    var lastHD = context.HoaDonBanHangs.OrderByDescending(nv => nv.MaHD).FirstOrDefault();
                    var lastKH = context.KhachHangs.OrderByDescending(nv => nv.MaKH).FirstOrDefault();
                    if (lastHD != null)
                    {
                        string lastMaHD = lastHD.MaHD;
                        // Sử dụng mã nhân viên của nhân viên cuối cùng ở đây
                        string last3Chars = lastMaHD.Substring(Math.Max(0, lastMaHD.Length - 3)); // Lấy 3 ký tự cuối
                        int last3CharsAsNumberHD = int.Parse(last3Chars);
                        last3CharsAsNumberHD++;
                        // Chuyển đổi số thành chuỗi có 3 ký tự
                        string newNumberStringHD = last3CharsAsNumberHD.ToString("D3");

                        // Sử dụng PadLeft để thêm số 0 vào trước nếu cần
                        newMaHD = "HD" + newNumberStringHD.PadLeft(3, '0');
                    }
                    else
                    {
                        newMaHD = "HD001";
                    }
                    HoaDonBanHang hoaDon = new HoaDonBanHang
                    {
                        MaHD = newMaHD,
                        NgayDatHang = DateTime.Now,
                        TongSoTien = TongSoTien,
                        MaNV = DBCurrentLogin.GetCurrentLoginInfo().MaNV,
                        MaKH = lastKH.MaKH
                    };
                    context.HoaDonBanHangs.Add(hoaDon);
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
