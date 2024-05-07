using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Models;
namespace BusinessAccessLayer
{
    public class DBKhachHang
    {
        public DBKhachHang()
        {

        }
        public bool ThemKhachHang(string TenKH, string SoDT)
        {
            using (var context = new DBGroceryContext())
            {

                try
                {
                    string newMaKH = "";
                    var lastKH = context.KhachHangs.OrderByDescending(nv => nv.MaKH).FirstOrDefault();

                    if (lastKH != null)
                    {
                        string lastMaKH = lastKH.MaKH;
                        // Sử dụng mã nhân viên của nhân viên cuối cùng ở đây
                        string last3Chars = lastMaKH.Substring(Math.Max(0, lastMaKH.Length - 3)); // Lấy 3 ký tự cuối
                        int last3CharsAsNumber = int.Parse(last3Chars);
                        last3CharsAsNumber++;
                        // Chuyển đổi số thành chuỗi có 3 ký tự
                        string newNumberString = last3CharsAsNumber.ToString("D3");

                        // Sử dụng PadLeft để thêm số 0 vào trước nếu cần
                        newMaKH = "KH" + newNumberString.PadLeft(3, '0');
                    }
                    else
                    {
                        newMaKH = "KH001";
                    }
                    if (TenKH == null && SoDT == null)
                    {
                        TenKH = "Khach hang moi";
                        SoDT = "0999999999";
                    }

                    KhachHang khach = new KhachHang
                    {
                        MaKH = newMaKH,
                        TenKH = TenKH,
                        SoDT = SoDT
                    };
                    context.KhachHangs.Add(khach);
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
