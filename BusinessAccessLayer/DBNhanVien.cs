using DataAccessLayer.Models;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace BusinessAccessLayer
{
    public class DBNhanVien
    {
        public DBNhanVien() { }
        public bool ThemNhanVien(string HoNV, string TenNV, DateTime NgaySinh, string GioiTinh, string SoDT, string DiaChi, decimal? Luong)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    string newMaNV = "";
                    var lastEmployee = context.NhanViens.OrderByDescending(nv => nv.MaNV).FirstOrDefault();

                    if (lastEmployee != null)
                    {
                        string lastEmployeeMaNV = lastEmployee.MaNV;
                        // Sử dụng mã nhân viên của nhân viên cuối cùng ở đây
                        string last3Chars = lastEmployeeMaNV.Substring(Math.Max(0, lastEmployeeMaNV.Length - 3)); // Lấy 3 ký tự cuối
                        int last3CharsAsNumber = int.Parse(last3Chars);
                        last3CharsAsNumber++;
                        // Chuyển đổi số thành chuỗi có 3 ký tự
                        string newNumberString = last3CharsAsNumber.ToString("D3");

                        // Sử dụng PadLeft để thêm số 0 vào trước nếu cần
                        newMaNV = "NV" + newNumberString.PadLeft(3, '0');
                    }
                    else
                    {
                        newMaNV = "NV001";
                    }
                    
                    NhanVien nhanVien = new NhanVien
                    {
                        MaNV = newMaNV,
                        HoNV = HoNV,
                        TenNV = TenNV,
                        NgaySinh = NgaySinh,
                        GioiTinh = GioiTinh,
                        SoDT = SoDT,
                        DiaChi = DiaChi,
                        Luong = Luong,
                    };    
                    context.NhanViens.Add(nhanVien);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool XoaNhanVien(string MaNV)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    // Sau đó, bạn có thể tiếp tục xóa nhân viên từ bảng NhanViens
                    var nhanViensToDelete = context.NhanViens.Where(nv => nv.MaNV.Contains(MaNV)).ToList();
                    context.NhanViens.RemoveRange(nhanViensToDelete);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool SuaNhanVien(string MaNV, string HoNV, string TenNV, DateTime NgaySinh, string GioiTinh, string SoDT, string DiaChi, decimal? Luong)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    // Sau đó, bạn có thể tiếp tục xóa nhân viên từ bảng NhanViens
                    var nhanVien = context.NhanViens.Where(nv => nv.MaNV.Contains(MaNV)).FirstOrDefault();
                    if (nhanVien != null)
                    {
                        nhanVien.HoNV = HoNV;
                        nhanVien.TenNV = TenNV;
                        nhanVien.NgaySinh = NgaySinh;
                        nhanVien.GioiTinh = GioiTinh;
                        nhanVien.SoDT = SoDT;
                        nhanVien.DiaChi = DiaChi;
                        nhanVien.Luong = Luong;
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
