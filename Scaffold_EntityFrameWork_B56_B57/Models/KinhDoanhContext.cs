using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Scaffold_EntityFrameWork_B56_B57.Models;

public partial class KinhDoanhContext : DbContext
{
    public KinhDoanhContext()
    {
    }

    public KinhDoanhContext(DbContextOptions<KinhDoanhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietDathang> ChiTietDathangs { get; set; }

    public virtual DbSet<DichVu> DichVus { get; set; }

    public virtual DbSet<DichVuKhachHang> DichVuKhachHangs { get; set; }

    public virtual DbSet<DonDatHang> DonDatHangs { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiHang> LoaiHangs { get; set; }

    public virtual DbSet<LoaiKhachHang> LoaiKhachHangs { get; set; }

    public virtual DbSet<MatHang> MatHangs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-OJA04UG\\SQLEXPRESS; database=KinhDoanh; UID=sa;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDathang>(entity =>
        {
            entity.HasKey(e => new { e.SoHd, e.MaHang }).HasName("PK_ChiTietDatHang");

            entity.ToTable("ChiTietDathang");

            entity.Property(e => e.SoHd)
                .HasMaxLength(6)
                .HasColumnName("SoHD");
            entity.Property(e => e.MaHang).HasMaxLength(6);

            entity.HasOne(d => d.MaHangNavigation).WithMany(p => p.ChiTietDathangs)
                .HasForeignKey(d => d.MaHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietDa__MaHan__46E78A0C");

            entity.HasOne(d => d.SoHdNavigation).WithMany(p => p.ChiTietDathangs)
                .HasForeignKey(d => d.SoHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietDat__SoHD__45F365D3");
        });

        modelBuilder.Entity<DichVu>(entity =>
        {
            entity.HasKey(e => e.MaDv).HasName("PK__DichVu__27258657628AD7D6");

            entity.ToTable("DichVu");

            entity.Property(e => e.MaDv)
                .HasMaxLength(10)
                .HasColumnName("MaDV");
            entity.Property(e => e.MoTa).HasMaxLength(100);
            entity.Property(e => e.TenDv)
                .HasMaxLength(100)
                .HasColumnName("TenDV");
        });

        modelBuilder.Entity<DichVuKhachHang>(entity =>
        {
            entity.HasKey(e => new { e.MaDv, e.MaLoaiKh }).HasName("PK_DichVuKhachhang");

            entity.ToTable("DichVuKhachHang");

            entity.Property(e => e.MaDv)
                .HasMaxLength(10)
                .HasColumnName("MaDV");
            entity.Property(e => e.MaLoaiKh)
                .HasMaxLength(10)
                .HasColumnName("MaLoaiKH");
            entity.Property(e => e.NgayApDung).HasColumnType("date");

            entity.HasOne(d => d.MaDvNavigation).WithMany(p => p.DichVuKhachHangs)
                .HasForeignKey(d => d.MaDv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DichVuKhac__MaDV__74AE54BC");

            entity.HasOne(d => d.MaLoaiKhNavigation).WithMany(p => p.DichVuKhachHangs)
                .HasForeignKey(d => d.MaLoaiKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DichVuKha__MaLoa__75A278F5");
        });

        modelBuilder.Entity<DonDatHang>(entity =>
        {
            entity.HasKey(e => e.SoHd).HasName("PK__DonDatHa__BC3CAB5787C913B8");

            entity.ToTable("DonDatHang");

            entity.Property(e => e.SoHd)
                .HasMaxLength(6)
                .HasColumnName("SoHD");
            entity.Property(e => e.MaKh)
                .HasMaxLength(6)
                .HasColumnName("MaKH");
            entity.Property(e => e.MaNv)
                .HasMaxLength(6)
                .HasColumnName("MaNV");
            entity.Property(e => e.NgayChuyenHang).HasColumnType("date");
            entity.Property(e => e.NgayDatHang).HasColumnType("date");
            entity.Property(e => e.NgayGiaoHang).HasColumnType("date");
            entity.Property(e => e.NoiGiaoHang).HasMaxLength(200);

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.DonDatHangs)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK__DonDatHang__MaKH__3A81B327");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.DonDatHangs)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__DonDatHang__MaNV__3B75D760");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1E42B12841");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKh)
                .HasMaxLength(6)
                .HasColumnName("MaKH");
            entity.Property(e => e.DiaChi).HasMaxLength(150);
            entity.Property(e => e.DienThoai).HasMaxLength(11);
            entity.Property(e => e.Email).HasMaxLength(30);
            entity.Property(e => e.Fax).HasMaxLength(11);
            entity.Property(e => e.HoTenKH).HasMaxLength(50);
            entity.Property(e => e.MaLoaiKh)
                .HasMaxLength(10)
                .HasColumnName("MaLoaiKH");
            entity.Property(e => e.TenCty)
                .HasMaxLength(100)
                .HasColumnName("TenCTy");
        });

        modelBuilder.Entity<LoaiHang>(entity =>
        {
            entity.HasKey(e => e.MaLoaiHang).HasName("PK__LoaiHang__5EEA4160C0095824");

            entity.ToTable("LoaiHang");

            entity.Property(e => e.MaLoaiHang).HasMaxLength(6);
            entity.Property(e => e.TenLoaiHang).HasMaxLength(150);
        });

        modelBuilder.Entity<LoaiKhachHang>(entity =>
        {
            entity.HasKey(e => e.MaLoaiKh).HasName("PK__LoaiKhac__12250B7EFA041482");

            entity.ToTable("LoaiKhachHang");

            entity.Property(e => e.MaLoaiKh)
                .HasMaxLength(10)
                .HasColumnName("MaLoaiKH");
            entity.Property(e => e.GhiChu).HasMaxLength(50);
            entity.Property(e => e.TenLoaiKh)
                .HasMaxLength(50)
                .HasColumnName("TenLoaiKH");
        });

        modelBuilder.Entity<MatHang>(entity =>
        {
            entity.HasKey(e => e.MaHang).HasName("PK__MatHang__19C0DB1D46195A28");

            entity.ToTable("MatHang");

            entity.Property(e => e.MaHang).HasMaxLength(6);
            entity.Property(e => e.DonViTinh).HasMaxLength(10);
            entity.Property(e => e.MaCty).HasMaxLength(6);
            entity.Property(e => e.MaLoaiHang).HasMaxLength(6);
            entity.Property(e => e.TenHang).HasMaxLength(150);

            entity.HasOne(d => d.MaCtyNavigation).WithMany(p => p.MatHangs)
                .HasForeignKey(d => d.MaCty)
                .HasConstraintName("FK__MatHang__MaCty__4222D4EF");

            entity.HasOne(d => d.MaLoaiHangNavigation).WithMany(p => p.MatHangs)
                .HasForeignKey(d => d.MaLoaiHang)
                .HasConstraintName("FK__MatHang__MaLoaiH__4316F928");
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaCty).HasName("PK__NhaCungC__3DCB54C2807554EA");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.MaCty)
                .HasMaxLength(6)
                .HasColumnName("MaCTy");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(30);
            entity.Property(e => e.Fax).HasMaxLength(11);
            entity.Property(e => e.TenCty)
                .HasMaxLength(150)
                .HasColumnName("TenCTy");
            entity.Property(e => e.TenGdich)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TenGDich");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70A5C35BFB7");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(6)
                .HasColumnName("MaNV");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.DienThoai).HasMaxLength(11);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.LuongCb).HasColumnName("LuongCB");
            entity.Property(e => e.NgayLamViec).HasColumnType("date");
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.PassWordd).HasMaxLength(6);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
