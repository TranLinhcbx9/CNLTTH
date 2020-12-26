using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LK_API.Data.EF
{
    public partial class LKDbContext : DbContext
    {
        public LKDbContext()
            : base("name=LKDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Anh> Anhs { get; set; }
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<LinhKien> LinhKiens { get; set; }
        public virtual DbSet<LoaiLinhKien> LoaiLinhKiens { get; set; }
        public virtual DbSet<LoaiMay> LoaiMays { get; set; }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinhKien>()
                .HasMany(e => e.Anhs)
                .WithRequired(e => e.LinhKien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinhKien>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.LinhKien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinhKien>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.LinhKien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LinhKien>()
                .HasMany(e => e.ChiTietPhieuXuats)
                .WithRequired(e => e.LinhKien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.PhieuNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuXuat>()
                .HasMany(e => e.ChiTietPhieuXuats)
                .WithRequired(e => e.PhieuXuat)
                .WillCascadeOnDelete(false);
        }
    }
}
