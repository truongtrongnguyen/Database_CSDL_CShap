IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [DichVu] (
    [MaDV] nvarchar(10) NOT NULL,
    [TenDV] nvarchar(100) NULL,
    [MoTa] nvarchar(100) NULL,
    CONSTRAINT [PK__DichVu__27258657628AD7D6] PRIMARY KEY ([MaDV])
);
GO

CREATE TABLE [KhachHang] (
    [MaKH] nvarchar(6) NOT NULL,
    [TenCTy] nvarchar(100) NULL,
    [DiaChi] nvarchar(150) NULL,
    [Email] nvarchar(30) NULL,
    [DienThoai] nvarchar(11) NULL,
    [Fax] nvarchar(11) NULL,
    [Hoten] nvarchar(50) NULL,
    [MaLoaiKH] nvarchar(10) NULL,
    [DiemTichLuy] int NULL,
    CONSTRAINT [PK__KhachHan__2725CF1E42B12841] PRIMARY KEY ([MaKH])
);
GO

CREATE TABLE [LoaiHang] (
    [MaLoaiHang] nvarchar(6) NOT NULL,
    [TenLoaiHang] nvarchar(150) NULL,
    CONSTRAINT [PK__LoaiHang__5EEA4160C0095824] PRIMARY KEY ([MaLoaiHang])
);
GO

CREATE TABLE [LoaiKhachHang] (
    [MaLoaiKH] nvarchar(10) NOT NULL,
    [TenLoaiKH] nvarchar(50) NULL,
    [DiemTichLuy] int NULL,
    [GhiChu] nvarchar(50) NULL,
    CONSTRAINT [PK__LoaiKhac__12250B7EFA041482] PRIMARY KEY ([MaLoaiKH])
);
GO

CREATE TABLE [NhaCungCap] (
    [MaCTy] nvarchar(6) NOT NULL,
    [TenCTy] nvarchar(150) NULL,
    [TenGDich] varchar(150) NULL,
    [DiaChi] nvarchar(200) NULL,
    [DienThoai] varchar(11) NULL,
    [Fax] nvarchar(11) NULL,
    [Email] nvarchar(30) NULL,
    CONSTRAINT [PK__NhaCungC__3DCB54C2807554EA] PRIMARY KEY ([MaCTy])
);
GO

CREATE TABLE [NhanVien] (
    [MaNV] nvarchar(6) NOT NULL,
    [NgaySinh] date NULL,
    [NgayLamViec] date NULL,
    [DiaChi] nvarchar(200) NULL,
    [DienThoai] nvarchar(11) NULL,
    [LuongCB] float NULL,
    [PhuCap] float NULL,
    [HoTen] nvarchar(50) NULL,
    [PassWordd] nvarchar(6) NULL,
    CONSTRAINT [PK__NhanVien__2725D70A5C35BFB7] PRIMARY KEY ([MaNV])
);
GO

CREATE TABLE [DichVuKhachHang] (
    [MaDV] nvarchar(10) NOT NULL,
    [MaLoaiKH] nvarchar(10) NOT NULL,
    [NgayApDung] date NULL,
    CONSTRAINT [PK_DichVuKhachhang] PRIMARY KEY ([MaDV], [MaLoaiKH]),
    CONSTRAINT [FK__DichVuKha__MaLoa__75A278F5] FOREIGN KEY ([MaLoaiKH]) REFERENCES [LoaiKhachHang] ([MaLoaiKH]),
    CONSTRAINT [FK__DichVuKhac__MaDV__74AE54BC] FOREIGN KEY ([MaDV]) REFERENCES [DichVu] ([MaDV])
);
GO

CREATE TABLE [MatHang] (
    [MaHang] nvarchar(6) NOT NULL,
    [TenHang] nvarchar(150) NULL,
    [MaCty] nvarchar(6) NULL,
    [MaLoaiHang] nvarchar(6) NULL,
    [SoLuong] int NULL,
    [DonViTinh] nvarchar(10) NULL,
    [GiaNhap] float NULL,
    [GiaBan] float NULL,
    CONSTRAINT [PK__MatHang__19C0DB1D46195A28] PRIMARY KEY ([MaHang]),
    CONSTRAINT [FK__MatHang__MaCty__4222D4EF] FOREIGN KEY ([MaCty]) REFERENCES [NhaCungCap] ([MaCTy]),
    CONSTRAINT [FK__MatHang__MaLoaiH__4316F928] FOREIGN KEY ([MaLoaiHang]) REFERENCES [LoaiHang] ([MaLoaiHang])
);
GO

CREATE TABLE [DonDatHang] (
    [SoHD] nvarchar(6) NOT NULL,
    [MaKH] nvarchar(6) NULL,
    [MaNV] nvarchar(6) NULL,
    [NgayDatHang] date NULL,
    [NgayGiaoHang] date NULL,
    [NgayChuyenHang] date NULL,
    [NoiGiaoHang] nvarchar(200) NULL,
    CONSTRAINT [PK__DonDatHa__BC3CAB5787C913B8] PRIMARY KEY ([SoHD]),
    CONSTRAINT [FK__DonDatHang__MaKH__3A81B327] FOREIGN KEY ([MaKH]) REFERENCES [KhachHang] ([MaKH]),
    CONSTRAINT [FK__DonDatHang__MaNV__3B75D760] FOREIGN KEY ([MaNV]) REFERENCES [NhanVien] ([MaNV])
);
GO

CREATE TABLE [ChiTietDathang] (
    [SoHD] nvarchar(6) NOT NULL,
    [MaHang] nvarchar(6) NOT NULL,
    [SoLuong] int NULL,
    [MucGiamGia] float NULL,
    CONSTRAINT [PK_ChiTietDatHang] PRIMARY KEY ([SoHD], [MaHang]),
    CONSTRAINT [FK__ChiTietDa__MaHan__46E78A0C] FOREIGN KEY ([MaHang]) REFERENCES [MatHang] ([MaHang]),
    CONSTRAINT [FK__ChiTietDat__SoHD__45F365D3] FOREIGN KEY ([SoHD]) REFERENCES [DonDatHang] ([SoHD])
);
GO

CREATE INDEX [IX_ChiTietDathang_MaHang] ON [ChiTietDathang] ([MaHang]);
GO

CREATE INDEX [IX_DichVuKhachHang_MaLoaiKH] ON [DichVuKhachHang] ([MaLoaiKH]);
GO

CREATE INDEX [IX_DonDatHang_MaKH] ON [DonDatHang] ([MaKH]);
GO

CREATE INDEX [IX_DonDatHang_MaNV] ON [DonDatHang] ([MaNV]);
GO

CREATE INDEX [IX_MatHang_MaCty] ON [MatHang] ([MaCty]);
GO

CREATE INDEX [IX_MatHang_MaLoaiHang] ON [MatHang] ([MaLoaiHang]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221128102711_V0', N'7.0.0');
GO

COMMIT;
GO

