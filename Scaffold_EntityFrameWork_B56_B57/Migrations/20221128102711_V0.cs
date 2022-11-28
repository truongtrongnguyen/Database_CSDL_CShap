using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScaffoldEntityFrameWorkB56B57.Migrations
{
    /// <inheritdoc />
    public partial class V0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    MaDV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenDV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DichVu__27258657628AD7D6", x => x.MaDV);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenCTy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DienThoai = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Hoten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MaLoaiKH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DiemTichLuy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KhachHan__2725CF1E42B12841", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "LoaiHang",
                columns: table => new
                {
                    MaLoaiHang = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenLoaiHang = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LoaiHang__5EEA4160C0095824", x => x.MaLoaiHang);
                });

            migrationBuilder.CreateTable(
                name: "LoaiKhachHang",
                columns: table => new
                {
                    MaLoaiKH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenLoaiKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiemTichLuy = table.Column<int>(type: "int", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LoaiKhac__12250B7EFA041482", x => x.MaLoaiKH);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaCTy = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenCTy = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TenGDich = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DienThoai = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhaCungC__3DCB54C2807554EA", x => x.MaCTy);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: true),
                    NgayLamViec = table.Column<DateTime>(type: "date", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DienThoai = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    LuongCB = table.Column<double>(type: "float", nullable: true),
                    PhuCap = table.Column<double>(type: "float", nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PassWordd = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhanVien__2725D70A5C35BFB7", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "DichVuKhachHang",
                columns: table => new
                {
                    MaDV = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaLoaiKH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NgayApDung = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVuKhachhang", x => new { x.MaDV, x.MaLoaiKH });
                    table.ForeignKey(
                        name: "FK__DichVuKha__MaLoa__75A278F5",
                        column: x => x.MaLoaiKH,
                        principalTable: "LoaiKhachHang",
                        principalColumn: "MaLoaiKH");
                    table.ForeignKey(
                        name: "FK__DichVuKhac__MaDV__74AE54BC",
                        column: x => x.MaDV,
                        principalTable: "DichVu",
                        principalColumn: "MaDV");
                });

            migrationBuilder.CreateTable(
                name: "MatHang",
                columns: table => new
                {
                    MaHang = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    MaCty = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    MaLoaiHang = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    DonViTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GiaNhap = table.Column<double>(type: "float", nullable: true),
                    GiaBan = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MatHang__19C0DB1D46195A28", x => x.MaHang);
                    table.ForeignKey(
                        name: "FK__MatHang__MaCty__4222D4EF",
                        column: x => x.MaCty,
                        principalTable: "NhaCungCap",
                        principalColumn: "MaCTy");
                    table.ForeignKey(
                        name: "FK__MatHang__MaLoaiH__4316F928",
                        column: x => x.MaLoaiHang,
                        principalTable: "LoaiHang",
                        principalColumn: "MaLoaiHang");
                });

            migrationBuilder.CreateTable(
                name: "DonDatHang",
                columns: table => new
                {
                    SoHD = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    MaNV = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    NgayDatHang = table.Column<DateTime>(type: "date", nullable: true),
                    NgayGiaoHang = table.Column<DateTime>(type: "date", nullable: true),
                    NgayChuyenHang = table.Column<DateTime>(type: "date", nullable: true),
                    NoiGiaoHang = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DonDatHa__BC3CAB5787C913B8", x => x.SoHD);
                    table.ForeignKey(
                        name: "FK__DonDatHang__MaKH__3A81B327",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH");
                    table.ForeignKey(
                        name: "FK__DonDatHang__MaNV__3B75D760",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDathang",
                columns: table => new
                {
                    SoHD = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    MaHang = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    MucGiamGia = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDatHang", x => new { x.SoHD, x.MaHang });
                    table.ForeignKey(
                        name: "FK__ChiTietDa__MaHan__46E78A0C",
                        column: x => x.MaHang,
                        principalTable: "MatHang",
                        principalColumn: "MaHang");
                    table.ForeignKey(
                        name: "FK__ChiTietDat__SoHD__45F365D3",
                        column: x => x.SoHD,
                        principalTable: "DonDatHang",
                        principalColumn: "SoHD");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDathang_MaHang",
                table: "ChiTietDathang",
                column: "MaHang");

            migrationBuilder.CreateIndex(
                name: "IX_DichVuKhachHang_MaLoaiKH",
                table: "DichVuKhachHang",
                column: "MaLoaiKH");

            migrationBuilder.CreateIndex(
                name: "IX_DonDatHang_MaKH",
                table: "DonDatHang",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_DonDatHang_MaNV",
                table: "DonDatHang",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_MatHang_MaCty",
                table: "MatHang",
                column: "MaCty");

            migrationBuilder.CreateIndex(
                name: "IX_MatHang_MaLoaiHang",
                table: "MatHang",
                column: "MaLoaiHang");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietDathang");

            migrationBuilder.DropTable(
                name: "DichVuKhachHang");

            migrationBuilder.DropTable(
                name: "MatHang");

            migrationBuilder.DropTable(
                name: "DonDatHang");

            migrationBuilder.DropTable(
                name: "LoaiKhachHang");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "LoaiHang");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
