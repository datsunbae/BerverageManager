using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Berverage_Manager.DataContext
{
    public partial class DBQuanLyBanNuocGiaiKhat : DbContext
    {
        public DBQuanLyBanNuocGiaiKhat()
            : base("name=DBQuanLyBanNuocGiaiKhat")
        {
        }

        public virtual DbSet<CHIETKHAU> CHIETKHAUs { get; set; }
        public virtual DbSet<CT_DONHANG> CT_DONHANG { get; set; }
        public virtual DbSet<CT_PNHAPKHO> CT_PNHAPKHO { get; set; }
        public virtual DbSet<CTKHUYENMAI_CHIETKHAU> CTKHUYENMAI_CHIETKHAU { get; set; }
        public virtual DbSet<CTKHUYENMAI_TANGSP> CTKHUYENMAI_TANGSP { get; set; }
        public virtual DbSet<DOITUONGKHUYENMAI> DOITUONGKHUYENMAIs { get; set; }
        public virtual DbSet<DONHANG> DONHANGs { get; set; }
        public virtual DbSet<DONVI> DONVIs { get; set; }
        public virtual DbSet<HINHTHUCKHUYENMAI> HINHTHUCKHUYENMAIs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHAPKHO> NHAPKHOes { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<TONKHO> TONKHOes { get; set; }
        public virtual DbSet<VAITRO> VAITROes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHIETKHAU>()
                .Property(e => e.MACK)
                .IsUnicode(false);

            modelBuilder.Entity<CHIETKHAU>()
                .HasMany(e => e.CTKHUYENMAI_CHIETKHAU)
                .WithOptional(e => e.CHIETKHAU)
                .HasForeignKey(e => e.LOAICK);

            modelBuilder.Entity<CTKHUYENMAI_CHIETKHAU>()
                .Property(e => e.LOAICK)
                .IsUnicode(false);

            modelBuilder.Entity<DONHANG>()
                .HasMany(e => e.CT_DONHANG)
                .WithOptional(e => e.DONHANG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DONVI>()
                .HasMany(e => e.CT_DONHANG)
                .WithOptional(e => e.DONVI)
                .HasForeignKey(e => e.DVT);

            modelBuilder.Entity<DONVI>()
                .HasMany(e => e.CT_PNHAPKHO)
                .WithOptional(e => e.DONVI)
                .HasForeignKey(e => e.DVT);

            modelBuilder.Entity<DONVI>()
                .HasMany(e => e.SANPHAMs)
                .WithOptional(e => e.DONVI)
                .HasForeignKey(e => e.DVTCHINH);

            modelBuilder.Entity<DONVI>()
                .HasMany(e => e.SANPHAMs1)
                .WithOptional(e => e.DONVI1)
                .HasForeignKey(e => e.DVTPHU);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.DONHANGs)
                .WithOptional(e => e.KHACHHANG)
                .HasForeignKey(e => e.IDKH);

            modelBuilder.Entity<KHUYENMAI>()
                .HasMany(e => e.DONHANGs)
                .WithOptional(e => e.KHUYENMAI)
                .HasForeignKey(e => e.MAKHUYENMAI);

            modelBuilder.Entity<NHACUNGCAP>()
                .HasMany(e => e.NHAPKHOes)
                .WithOptional(e => e.NHACUNGCAP)
                .HasForeignKey(e => e.IDNCC);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MATK)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.DONHANGs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.IDNV);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NHAPKHOes)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.IDNV);

            modelBuilder.Entity<NHAPKHO>()
                .HasMany(e => e.CT_PNHAPKHO)
                .WithOptional(e => e.NHAPKHO)
                .HasForeignKey(e => e.IDPNK);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CT_PNHAPKHO)
                .WithOptional(e => e.SANPHAM)
                .HasForeignKey(e => e.IDSP);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.TONKHOes)
                .WithOptional(e => e.SANPHAM)
                .HasForeignKey(e => e.IDSP)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MADANGNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MVAITRO)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.TAIKHOAN)
                .HasForeignKey(e => e.MATK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VAITRO>()
                .Property(e => e.MAVAITRO)
                .IsUnicode(false);

            modelBuilder.Entity<VAITRO>()
                .HasMany(e => e.TAIKHOANs)
                .WithRequired(e => e.VAITRO)
                .HasForeignKey(e => e.MVAITRO)
                .WillCascadeOnDelete(false);
        }
    }
}
