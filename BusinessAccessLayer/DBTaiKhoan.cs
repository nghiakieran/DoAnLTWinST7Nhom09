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
    public class DBTaiKhoan
    {
        public DBTaiKhoan()
        {

        }
        public bool ThemTaiKhoan(string UserName, string Password, string Role)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    var lastNV = context.NhanViens.OrderByDescending(nv => nv.MaNV).FirstOrDefault();
                    TaiKhoan taiKhoan = new TaiKhoan
                    {
                        UserName = UserName,
                        Password = Password,
                        MaNV = lastNV.MaNV,
                        Role = Role,
                    };
                    context.TaiKhoans.Add(taiKhoan);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool XoaTaiKhoan(string MaNV)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    // Tìm và lấy ra các tài khoản có tham chiếu đến nhân viên cần xóa
                    var taiKhoansToDelete = context.TaiKhoans.Where(tk => tk.MaNV.Contains(MaNV)).ToList();

                    // Xóa các tài khoản có tham chiếu đến nhân viên
                    context.TaiKhoans.RemoveRange(taiKhoansToDelete);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();
                    return true;  
                }
                catch (Exception) 
                { return false; }

            }
        }
        public bool SuaTaiKhoan(string UserName, string Password, string MaNV, string Role)
        {
            using (var context = new DBGroceryContext())
            {
                try
                {
                    var taiKhoan = context.TaiKhoans.FirstOrDefault(tk => tk.MaNV == MaNV);
                    if (taiKhoan != null)
                    {
                        taiKhoan.UserName = UserName;
                        taiKhoan.Password = Password;
                        taiKhoan.Role = Role;
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
