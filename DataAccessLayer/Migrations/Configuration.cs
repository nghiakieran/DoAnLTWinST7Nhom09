namespace DataAccessLayer.Migrations
{
    using DataAccessLayer.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.DBGroceryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
           // AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DataAccessLayer.DBGroceryContext context)
        {
            context.KhachHangs.AddOrUpdate(
                new KhachHang { MaKH = "KH001", TenKH = "Nguyễn Văn Phát", SoDT = "0123456789" },
                new KhachHang { MaKH = "KH002", TenKH = "Trần Thị Dung", SoDT = "0987654321" },
                new KhachHang { MaKH = "KH003", TenKH = "Lê Văn Nam", SoDT = "0369852147" },
                new KhachHang { MaKH = "KH004", TenKH = "Phạm Thị Nghĩa", SoDT = "0541236987" },
                new KhachHang { MaKH = "KH005", TenKH = "Huỳnh Văn Kiệt", SoDT = "0321456987" }
                );
            context.NhaCungCaps.AddOrUpdate(
                new NhaCungCap { MaNCC = "NCC001", TenNCC = "Công Ty Dầu Thực Vật Tường An", DiaChi = "138 Hai Bà Trưng, Phường Đa Kao, Quận 1, Tp. HCM", SoDT = "0357798888" },
                new NhaCungCap { MaNCC = "NCC002", TenNCC = "Công ty TNHH thực phẩm Orion Vina", DiaChi = "Tầng 22, TTTM Pearl Plaza, Bình Thạnh, TP. HCM", SoDT = "0896541237" },
                new NhaCungCap { MaNCC = "NCC003", TenNCC = "Công ty TNHH Nước giải khát SUNTORY PEPSICO VN", DiaChi = "Lô 206, Đường Amata, Đồng Nai", SoDT = "0613936493" },
                new NhaCungCap { MaNCC = "NCC004", TenNCC = "Công Ty TNHH Abbott Healthcare Việt Nam", DiaChi = "35 Đại Lộ Tự Do, Binh Hoà, Thuận An, Bình Dương", SoDT = "0963255123" },
                new NhaCungCap { MaNCC = "NCC005", TenNCC = "Công ty CP Acecook Việt Nam", DiaChi = "Đường số 11,  KCN Tân Bình, P, Tân Phú, TP. HCM", SoDT = "0838154064" },
                new NhaCungCap { MaNCC = "NCC006", TenNCC = "CÔNG TY TNHH QUỐC TẾ UNILEVER VIỆT NAM", DiaChi = "156 Nguyễn Lương Bằng, P Tân Phú, Quận 7, TP. HCM", SoDT = "0854135686" }
                );
            context.NhanViens.AddOrUpdate(
                new NhanVien { MaNV = "NV001", HoNV = "Nguyễn", TenNV = "Văn Thuận", NgaySinh = new DateTime(1990, 5, 15), GioiTinh = "Nam", SoDT = "0123456789", DiaChi = "123 Đường ABC, Quận 1, TP. Hồ Chí Minh", Luong = 20000000 },
                new NhanVien { MaNV = "NV002", HoNV = "Trần", TenNV = "Quốc Nam", NgaySinh = new DateTime(1995, 8, 20), GioiTinh = "Nam", SoDT = "0987654321", DiaChi = "456 Đường XYZ, Quận 2, TP. Hồ Chí Minh", Luong = 5000000 },
                new NhanVien { MaNV = "NV003", HoNV = "Lê", TenNV = "Phát", NgaySinh = new DateTime(1988, 3, 10), GioiTinh = "Nam", SoDT = "0369852147", DiaChi = "789 Đường DEF, Quận 3, TP. Hồ Chí Minh", Luong = 4000000 },
                new NhanVien { MaNV = "NV004", HoNV = "Phạm", TenNV = "Như Ngọc", NgaySinh = new DateTime(1992, 11, 25), GioiTinh = "Nữ", SoDT = "0541236987", DiaChi = "321 Đường GHI, Quận 4, TP. Hồ Chí Minh", Luong = 4000000 },
                new NhanVien { MaNV = "NV005", HoNV = "Huỳnh", TenNV = "Trúc", NgaySinh = new DateTime(1997, 7, 3), GioiTinh = "Nữ", SoDT = "0321456987", DiaChi = "654 Đường JKL, Quận 5, TP. Hồ Chí Minh", Luong = 4500000 }
                );
            context.TaiKhoans.AddOrUpdate(
                new TaiKhoan { UserName = "user1", Password = "pass1", MaNV = "NV001", Role = "sysadmin" },
                new TaiKhoan { UserName = "user2", Password = "pass2", MaNV = "NV002", Role = "staff" },
                new TaiKhoan { UserName = "user3", Password = "pass3", MaNV = "NV003", Role = "staff" },
                new TaiKhoan { UserName = "user4", Password = "pass4", MaNV = "NV004", Role = "staff" },
                new TaiKhoan { UserName = "user5", Password = "pass5", MaNV = "NV005", Role = "staff" }
                );
            context.SanPhams.AddOrUpdate(
                new SanPham { MaSP = "SP001", TenSP = "Nước ngọt Coca Cola lon 320ml", DonGia = 10000, SoLuong = 72 },
                new SanPham { MaSP = "SP002", TenSP = "Nước ngọt Pepsi không calo vị chanh lon 320ml", DonGia = 10000, SoLuong = 48 },
                new SanPham { MaSP = "SP003", TenSP = "Lốc 4 hộp sữa tiệt trùng socola Dutch Lady 180ml", DonGia = 33000, SoLuong = 72 },
                new SanPham { MaSP = "SP004", TenSP = "Snack vị tảo biển Lays 150g", DonGia = 28000, SoLuong = 20 },
                new SanPham { MaSP = "SP005", TenSP = "Bánh quy sữa Cosy Marie 120g", DonGia = 17000, SoLuong = 20 },
                new SanPham { MaSP = "SP006", TenSP = "Mì Handy Hảo Hảo tôm chua cay ly 67g", DonGia = 9000, SoLuong = 50 },
                new SanPham { MaSP = "SP007", TenSP = "Dầu đậu nành Tường An 1 lít", DonGia = 64000, SoLuong = 40 },
                new SanPham { MaSP = "SP008", TenSP = "Bột giặt OMO sạch bẩn khử mùi 4.3kg", DonGia = 183000, SoLuong = 30 },
                new SanPham { MaSP = "SP009", TenSP = "Nước xả Comfort quyến rũ 3.2 lít", DonGia = 175000, SoLuong = 30 },
                new SanPham { MaSP = "SP010", TenSP = "Sữa tiệt trùng Dutch Lady socola 180ml", DonGia = 7000, SoLuong = 40 },
                new SanPham { MaSP = "SP011", TenSP = "Hộp 6 cái bánh kem trứng Custas", DonGia = 33000, SoLuong = 20 }
                );
            context.HoaDonNhapHangs.AddOrUpdate(
                new HoaDonNhapHang { MaPhieu = "HDNH001", NgayNhap = new DateTime(2024, 4, 15), TongTienDonNhap = 1560000, MaNV = "NV004", MaNCC = "NCC002" },
                new HoaDonNhapHang { MaPhieu = "HDNH002", NgayNhap = new DateTime(2024, 4, 20), TongTienDonNhap = 450000, MaNV = "NV002", MaNCC = "NCC005" },
                new HoaDonNhapHang { MaPhieu = "HDNH003", NgayNhap = new DateTime(2024, 4, 25), TongTienDonNhap = 1200000, MaNV = "NV003", MaNCC = "NCC003" },
                new HoaDonNhapHang { MaPhieu = "HDNH004", NgayNhap = new DateTime(2024, 4, 28), TongTienDonNhap = 2656000, MaNV = "NV005", MaNCC = "NCC004" },
                new HoaDonNhapHang { MaPhieu = "HDNH005", NgayNhap = new DateTime(2024, 5, 1), TongTienDonNhap = 2560000, MaNV = "NV005", MaNCC = "NCC001" },
                new HoaDonNhapHang { MaPhieu = "HDNH006", NgayNhap = new DateTime(2024, 5, 5), TongTienDonNhap = 10740000, MaNV = "NV004", MaNCC = "NCC006" }
                );
            context.ChiTietPhieuNhaps.AddOrUpdate(
                new ChiTietPhieuNhap { MaPhieu = "HDNH001", MaSP = "SP004", SoLuong = 20, DonGia = 28000 },
                new ChiTietPhieuNhap { MaPhieu = "HDNH001", MaSP = "SP005", SoLuong = 20, DonGia = 17000 },
                new ChiTietPhieuNhap { MaPhieu = "HDNH001", MaSP = "SP011", SoLuong = 20, DonGia = 33000 },
                new ChiTietPhieuNhap { MaPhieu = "HDNH002", MaSP = "SP006", SoLuong = 50, DonGia = 9000 },
                new ChiTietPhieuNhap { MaPhieu = "HDNH003", MaSP = "SP001", SoLuong = 72, DonGia = 10000 },
                new ChiTietPhieuNhap { MaPhieu = "HDNH003", MaSP = "SP002", SoLuong = 48, DonGia = 10000 },
                new ChiTietPhieuNhap { MaPhieu = "HDNH004", MaSP = "SP003", SoLuong = 72, DonGia = 33000 },
                new ChiTietPhieuNhap { MaPhieu = "HDNH004", MaSP = "SP010", SoLuong = 40, DonGia = 7000 },
                new ChiTietPhieuNhap { MaPhieu = "HDNH005", MaSP = "SP007", SoLuong = 40, DonGia = 64000 },
                new ChiTietPhieuNhap { MaPhieu = "HDNH006", MaSP = "SP008", SoLuong = 30, DonGia = 183000 },
                new ChiTietPhieuNhap { MaPhieu = "HDNH006", MaSP = "SP009", SoLuong = 30, DonGia = 175000 }
                );
            context.HoaDonBanHangs.AddOrUpdate(
                new HoaDonBanHang { MaHD = "HD001", NgayDatHang = new DateTime(2024, 5, 2), TongSoTien = 50000, MaNV = "NV002", MaKH = "KH001" },
                new HoaDonBanHang { MaHD = "HD002", NgayDatHang = new DateTime(2024, 5, 2), TongSoTien = 66000, MaNV = "NV002", MaKH = "KH003" },
                new HoaDonBanHang { MaHD = "HD003", NgayDatHang = new DateTime(2024, 5, 3), TongSoTien = 45000, MaNV = "NV003", MaKH = "KH004" },
                new HoaDonBanHang { MaHD = "HD004", NgayDatHang = new DateTime(2024, 5, 4), TongSoTien = 45000, MaNV = "NV004", MaKH = "KH002" },
                new HoaDonBanHang { MaHD = "HD005", NgayDatHang = new DateTime(2024, 5, 5), TongSoTien = 256000, MaNV = "NV005", MaKH = "KH005" }
                );
            context.ChiTietHDs.AddOrUpdate(
                new ChiTietHD { MaHD = "HD001", MaSP = "SP001", SoLuongSP = 3, DonGia = 10000 },
                new ChiTietHD { MaHD = "HD001", MaSP = "SP002", SoLuongSP = 2, DonGia = 10000 },
                new ChiTietHD { MaHD = "HD002", MaSP = "SP003", SoLuongSP = 2, DonGia = 33000 },
                new ChiTietHD { MaHD = "HD003", MaSP = "SP004", SoLuongSP = 1, DonGia = 28000 },
                new ChiTietHD { MaHD = "HD003", MaSP = "SP005", SoLuongSP = 1, DonGia = 17000 },
                new ChiTietHD { MaHD = "HD004", MaSP = "SP006", SoLuongSP = 5, DonGia = 9000 },
                new ChiTietHD { MaHD = "HD005", MaSP = "SP007", SoLuongSP = 4, DonGia = 64000 }
                );
            context.SaveChanges();
        }
    }
}
