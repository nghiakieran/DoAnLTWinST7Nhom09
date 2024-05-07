using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessAccessLayer
{
    public class DBSanPham
    {
        public bool ThemSanPham(string TenSP, decimal? DonGia, int SoLuong)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string newMaSP = "";
                    var lastSP = context.SanPhams.OrderByDescending(nv => nv.MaSP).FirstOrDefault();

                    if (lastSP != null)
                    {
                        string lastMaSP = lastSP.MaSP;
                        // Sử dụng mã nhân viên của nhân viên cuối cùng ở đây
                        string last3Chars = lastMaSP.Substring(Math.Max(0, lastMaSP.Length - 3)); // Lấy 3 ký tự cuối
                        int last3CharsAsNumber = int.Parse(last3Chars);
                        last3CharsAsNumber++;
                        // Chuyển đổi số thành chuỗi có 3 ký tự
                        string newNumberString = last3CharsAsNumber.ToString("D3");

                        // Sử dụng PadLeft để thêm số 0 vào trước nếu cần
                        newMaSP = "SP" + newNumberString.PadLeft(3, '0');
                    }
                    else
                    {
                        newMaSP = "SP001";
                    }
                    SanPham sanPham = new SanPham
                    {
                        MaSP = newMaSP,
                        TenSP = TenSP.Trim(),
                        DonGia = DonGia,
                        SoLuong = SoLuong
                    };
                    context.SanPhams.Add(sanPham);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool SuaSanPham(string MaSP, string TenSP, decimal? DonGia, int SoLuong)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    var sp = context.SanPhams
                             .FirstOrDefault(s => s.MaSP == MaSP);

                    if (sp != null)
                    {
                        sp.TenSP = TenSP;
                        sp.SoLuong = SoLuong;
                        sp.DonGia = DonGia;

                        context.SaveChanges();
                    }
                    return true; // Trả về true nếu sửa thành công
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool TruThongTinSanPham(string maSP, string tenSP, int soLuong, decimal? donGia)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    var sanPham = context.SanPhams.FirstOrDefault(tk => tk.MaSP == (maSP));
                    if (sanPham != null)
                    {
                        sanPham.MaSP = maSP;
                        sanPham.TenSP = tenSP;
                        sanPham.SoLuong = sanPham.SoLuong - soLuong;
                        sanPham.DonGia = donGia;
                        // Lưu thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool ThemThongTinSanPham(string maSP, string tenSP, int soLuong, decimal? donGia)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    var sanPham = context.SanPhams.FirstOrDefault(tk => tk.MaSP == (maSP));
                    if (sanPham != null)
                    {
                        sanPham.MaSP = maSP;
                        sanPham.TenSP = tenSP;
                        sanPham.SoLuong = sanPham.SoLuong + soLuong;
                        sanPham.DonGia = donGia;
                        // Lưu thay đổi vào cơ sở dữ liệu
                        context.SaveChanges();
                    }
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
