﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scaffold_EntityFrameWork_B56_B57.Models;

#nullable disable

namespace ScaffoldEntityFrameWorkB56B57.Migrations
{
    [DbContext(typeof(KinhDoanhContext))]
    partial class KinhDoanhContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.ChiTietDathang", b =>
                {
                    b.Property<string>("SoHd")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)")
                        .HasColumnName("SoHD");

                    b.Property<string>("MaHang")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<double?>("MucGiamGia")
                        .HasColumnType("float");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("SoHd", "MaHang")
                        .HasName("PK_ChiTietDatHang");

                    b.HasIndex("MaHang");

                    b.ToTable("ChiTietDathang", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.DichVu", b =>
                {
                    b.Property<string>("MaDv")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaDV");

                    b.Property<string>("MoTa")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenDv")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenDV");

                    b.HasKey("MaDv")
                        .HasName("PK__DichVu__27258657628AD7D6");

                    b.ToTable("DichVu", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.DichVuKhachHang", b =>
                {
                    b.Property<string>("MaDv")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaDV");

                    b.Property<string>("MaLoaiKh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaLoaiKH");

                    b.Property<DateTime?>("NgayApDung")
                        .HasColumnType("date");

                    b.HasKey("MaDv", "MaLoaiKh")
                        .HasName("PK_DichVuKhachhang");

                    b.HasIndex("MaLoaiKh");

                    b.ToTable("DichVuKhachHang", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.DonDatHang", b =>
                {
                    b.Property<string>("SoHd")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)")
                        .HasColumnName("SoHD");

                    b.Property<string>("MaKh")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)")
                        .HasColumnName("MaKH");

                    b.Property<string>("MaNv")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)")
                        .HasColumnName("MaNV");

                    b.Property<DateTime?>("NgayChuyenHang")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayDatHang")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayGiaoHang")
                        .HasColumnType("date");

                    b.Property<string>("NoiGiaoHang")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("SoHd")
                        .HasName("PK__DonDatHa__BC3CAB5787C913B8");

                    b.HasIndex("MaKh");

                    b.HasIndex("MaNv");

                    b.ToTable("DonDatHang", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.KhachHang", b =>
                {
                    b.Property<string>("MaKh")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)")
                        .HasColumnName("MaKH");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("DiemTichLuy")
                        .HasColumnType("int");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Fax")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("HoTenKH")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MaLoaiKh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaLoaiKH");

                    b.Property<string>("TenCty")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenCTy");

                    b.HasKey("MaKh")
                        .HasName("PK__KhachHan__2725CF1E42B12841");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.LoaiHang", b =>
                {
                    b.Property<string>("MaLoaiHang")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("TenLoaiHang")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("MaLoaiHang")
                        .HasName("PK__LoaiHang__5EEA4160C0095824");

                    b.ToTable("LoaiHang", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.LoaiKhachHang", b =>
                {
                    b.Property<string>("MaLoaiKh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaLoaiKH");

                    b.Property<int?>("DiemTichLuy")
                        .HasColumnType("int");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenLoaiKh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenLoaiKH");

                    b.HasKey("MaLoaiKh")
                        .HasName("PK__LoaiKhac__12250B7EFA041482");

                    b.ToTable("LoaiKhachHang", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.MatHang", b =>
                {
                    b.Property<string>("MaHang")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("DonViTinh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double?>("GiaBan")
                        .HasColumnType("float");

                    b.Property<double?>("GiaNhap")
                        .HasColumnType("float");

                    b.Property<string>("MaCty")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("MaLoaiHang")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenHang")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("MaHang")
                        .HasName("PK__MatHang__19C0DB1D46195A28");

                    b.HasIndex("MaCty");

                    b.HasIndex("MaLoaiHang");

                    b.ToTable("MatHang", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.NhaCungCap", b =>
                {
                    b.Property<string>("MaCty")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)")
                        .HasColumnName("MaCTy");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Fax")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("TenCty")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("TenCTy");

                    b.Property<string>("TenGdich")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("TenGDich");

                    b.HasKey("MaCty")
                        .HasName("PK__NhaCungC__3DCB54C2807554EA");

                    b.ToTable("NhaCungCap", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.NhanVien", b =>
                {
                    b.Property<string>("MaNv")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)")
                        .HasColumnName("MaNV");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DienThoai")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("HoTen")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("LuongCb")
                        .HasColumnType("float")
                        .HasColumnName("LuongCB");

                    b.Property<DateTime?>("NgayLamViec")
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("PassWordd")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<double?>("PhuCap")
                        .HasColumnType("float");

                    b.HasKey("MaNv")
                        .HasName("PK__NhanVien__2725D70A5C35BFB7");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.ChiTietDathang", b =>
                {
                    b.HasOne("Scaffold_EntityFrameWork_B56_B57.Models.MatHang", "MaHangNavigation")
                        .WithMany("ChiTietDathangs")
                        .HasForeignKey("MaHang")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietDa__MaHan__46E78A0C");

                    b.HasOne("Scaffold_EntityFrameWork_B56_B57.Models.DonDatHang", "SoHdNavigation")
                        .WithMany("ChiTietDathangs")
                        .HasForeignKey("SoHd")
                        .IsRequired()
                        .HasConstraintName("FK__ChiTietDat__SoHD__45F365D3");

                    b.Navigation("MaHangNavigation");

                    b.Navigation("SoHdNavigation");
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.DichVuKhachHang", b =>
                {
                    b.HasOne("Scaffold_EntityFrameWork_B56_B57.Models.DichVu", "MaDvNavigation")
                        .WithMany("DichVuKhachHangs")
                        .HasForeignKey("MaDv")
                        .IsRequired()
                        .HasConstraintName("FK__DichVuKhac__MaDV__74AE54BC");

                    b.HasOne("Scaffold_EntityFrameWork_B56_B57.Models.LoaiKhachHang", "MaLoaiKhNavigation")
                        .WithMany("DichVuKhachHangs")
                        .HasForeignKey("MaLoaiKh")
                        .IsRequired()
                        .HasConstraintName("FK__DichVuKha__MaLoa__75A278F5");

                    b.Navigation("MaDvNavigation");

                    b.Navigation("MaLoaiKhNavigation");
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.DonDatHang", b =>
                {
                    b.HasOne("Scaffold_EntityFrameWork_B56_B57.Models.KhachHang", "MaKhNavigation")
                        .WithMany("DonDatHangs")
                        .HasForeignKey("MaKh")
                        .HasConstraintName("FK__DonDatHang__MaKH__3A81B327");

                    b.HasOne("Scaffold_EntityFrameWork_B56_B57.Models.NhanVien", "MaNvNavigation")
                        .WithMany("DonDatHangs")
                        .HasForeignKey("MaNv")
                        .HasConstraintName("FK__DonDatHang__MaNV__3B75D760");

                    b.Navigation("MaKhNavigation");

                    b.Navigation("MaNvNavigation");
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.MatHang", b =>
                {
                    b.HasOne("Scaffold_EntityFrameWork_B56_B57.Models.NhaCungCap", "MaCtyNavigation")
                        .WithMany("MatHangs")
                        .HasForeignKey("MaCty")
                        .HasConstraintName("FK__MatHang__MaCty__4222D4EF");

                    b.HasOne("Scaffold_EntityFrameWork_B56_B57.Models.LoaiHang", "MaLoaiHangNavigation")
                        .WithMany("MatHangs")
                        .HasForeignKey("MaLoaiHang")
                        .HasConstraintName("FK__MatHang__MaLoaiH__4316F928");

                    b.Navigation("MaCtyNavigation");

                    b.Navigation("MaLoaiHangNavigation");
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.DichVu", b =>
                {
                    b.Navigation("DichVuKhachHangs");
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.DonDatHang", b =>
                {
                    b.Navigation("ChiTietDathangs");
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.KhachHang", b =>
                {
                    b.Navigation("DonDatHangs");
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.LoaiHang", b =>
                {
                    b.Navigation("MatHangs");
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.LoaiKhachHang", b =>
                {
                    b.Navigation("DichVuKhachHangs");
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.MatHang", b =>
                {
                    b.Navigation("ChiTietDathangs");
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.NhaCungCap", b =>
                {
                    b.Navigation("MatHangs");
                });

            modelBuilder.Entity("Scaffold_EntityFrameWork_B56_B57.Models.NhanVien", b =>
                {
                    b.Navigation("DonDatHangs");
                });
#pragma warning restore 612, 618
        }
    }
}
