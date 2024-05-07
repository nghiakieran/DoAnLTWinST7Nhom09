using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBGroceryContext : DbContext
    {
        public DBGroceryContext() : base("name=GroceryDBConnection")
        {

        }

        public DBGroceryContext(string userName, string passWord) : base($"name=GroceryDBConnection_User;User Id={userName};Password={passWord}")
        {

        }

        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDonBanHang> HoaDonBanHangs { get; set; }
        public DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<HoaDonNhapHang> HoaDonNhapHangs { get; set; }
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDonBanHang>()
            .HasOptional(hd => hd.KhachHang)
            .WithMany(kh => kh.HoaDonBanHangs)
            .HasForeignKey(hd => hd.MaKH)
            .WillCascadeOnDelete(false);

            // Mối quan hệ một-nhiều: NhanVien - HoaDonBanHang
            modelBuilder.Entity<HoaDonBanHang>()
                .HasOptional(hd => hd.NhanVien)
                .WithMany(nv => nv.HoaDonBanHangs)
                .HasForeignKey(hd => hd.MaNV)
                .WillCascadeOnDelete(false);

            // Mối quan hệ một-nhiều: HoaDonBanHang - ChiTietHD
            modelBuilder.Entity<ChiTietHD>()
                .HasRequired(ct => ct.HoaDonBanHang)
                .WithMany(hd => hd.ChiTietHDs)
                .HasForeignKey(ct => ct.MaHD)
                .WillCascadeOnDelete(false);

            // Mối quan hệ một-nhiều: SanPham - ChiTietHD
            modelBuilder.Entity<ChiTietHD>()
                .HasRequired(ct => ct.SanPham)
                .WithMany(sp => sp.ChiTietHDs)
                .HasForeignKey(ct => ct.MaSP)
                .WillCascadeOnDelete(false);

            // Mối quan hệ một-nhiều: NhanVien - TaiKhoan
            modelBuilder.Entity<TaiKhoan>()
                .HasOptional(tk => tk.NhanVien)
                .WithMany(nv => nv.TaiKhoans)
                .HasForeignKey(tk => tk.MaNV)
                .WillCascadeOnDelete(false);

            // Mối quan hệ một-nhiều: NhanVien - HoaDonNhapHang
            modelBuilder.Entity<HoaDonNhapHang>()
                .HasOptional(hd => hd.NhanVien)
                .WithMany(nv => nv.HoaDonNhapHangs)
                .HasForeignKey(hd => hd.MaNV)
                .WillCascadeOnDelete(false);

            // Mối quan hệ một-nhiều: NhaCungCap - HoaDonNhapHang
            modelBuilder.Entity<HoaDonNhapHang>()
                .HasOptional(hd => hd.NhaCungCap)
                .WithMany(ncc => ncc.HoaDonNhapHangs)
                .HasForeignKey(hd => hd.MaNCC)
                .WillCascadeOnDelete(false);

            // Mối quan hệ một-nhiều: HoaDonNhapHang - ChiTietPhieuNhap
            modelBuilder.Entity<ChiTietPhieuNhap>()
                .HasRequired(ct => ct.HoaDonNhapHang)
                .WithMany(hd => hd.ChiTietPhieuNhaps)
                .HasForeignKey(ct => ct.MaPhieu)
                .WillCascadeOnDelete(false);

            // Mối quan hệ một-nhiều: SanPham - ChiTietPhieuNhap
            modelBuilder.Entity<ChiTietPhieuNhap>()
                .HasRequired(ct => ct.SanPham)
                .WithMany(sp => sp.ChiTietPhieuNhaps)
                .HasForeignKey(ct => ct.MaSP)
                .WillCascadeOnDelete(false);

        }
    }
}
