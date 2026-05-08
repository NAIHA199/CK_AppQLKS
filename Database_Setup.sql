-- =============================================
-- Tạo Database QuanLyKhachSan
-- =============================================

-- 1. Tạo Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = N'QuanLyKhachSan')
BEGIN
    CREATE DATABASE QuanLyKhachSan;
END
GO

USE QuanLyKhachSan;
GO

-- =============================================
-- 2. Tạo Bảng Phong
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'Phong')
BEGIN
    CREATE TABLE dbo.Phong
    (
        MaPhong NVARCHAR(10) PRIMARY KEY NOT NULL,
        TenPhong NVARCHAR(50) NOT NULL,
        LoaiPhong NVARCHAR(20) NOT NULL, -- 'Phòng Đơn', 'Phòng Đôi', 'Phòng Vip'
        DonGia BIGINT NOT NULL DEFAULT 0,
        TrangThai NVARCHAR(20) NOT NULL DEFAULT 'Trống', -- 'Trống', 'Đã Đặt', 'Đang Sử Dụng'
        NgayTao DATETIME DEFAULT GETDATE(),
        NgaySua DATETIME DEFAULT GETDATE()
    );

    -- Thêm dữ liệu mẫu
    INSERT INTO dbo.Phong (MaPhong, TenPhong, LoaiPhong, DonGia, TrangThai)
    VALUES 
        (N'101', N'Phòng 101', N'Phòng Đơn', 300000, N'Trống'),
        (N'102', N'Phòng 102', N'Phòng Đơn', 300000, N'Đã Đặt'),
        (N'103', N'Phòng 103', N'Phòng Đôi', 500000, N'Trống'),
        (N'104', N'Phòng 104', N'Phòng Đôi', 500000, N'Trống'),
        (N'105', N'Phòng 105', N'Phòng Vip', 800000, N'Đã Đặt'),
        (N'201', N'Phòng 201', N'Phòng Đơn', 300000, N'Trống'),
        (N'202', N'Phòng 202', N'Phòng Đôi', 500000, N'Trống'),
        (N'203', N'Phòng 203', N'Phòng Vip', 800000, N'Trống'),
        (N'204', N'Phòng 204', N'Phòng Đơn', 300000, N'Đã Đặt'),
        (N'205', N'Phòng 205', N'Phòng Đôi', 500000, N'Trống');

    PRINT N'Bảng Phong đã được tạo và có dữ liệu mẫu.';
END
GO

-- =============================================
-- 3. Tạo Bảng KhachHang
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'KhachHang')
BEGIN
    CREATE TABLE dbo.KhachHang
    (
        MaKhachHang INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
        HoTen NVARCHAR(100) NOT NULL,
        SoDienThoai NVARCHAR(20) NULL,
        SoCCCD NVARCHAR(20) NULL,
        LoaiKhach NVARCHAR(50) NULL, -- 'Nội Địa', 'Nước Ngoài'
        QuocTich NVARCHAR(50) NULL,
        GioiTinh NVARCHAR(10) NULL, -- 'Nam', 'Nữ'
        NgayNhan DATETIME NOT NULL,
        NgayTra DATETIME NOT NULL,
        SoKhach INT NOT NULL DEFAULT 1,
        MaPhong NVARCHAR(10) NOT NULL,
        NgayTao DATETIME DEFAULT GETDATE(),
        NgaySua DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
    );

    PRINT N'Bảng KhachHang đã được tạo.';
END
GO

-- =============================================
-- 4. Tạo Bảng LoaiPhong (Quản lý loại phòng)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'LoaiPhong')
BEGIN
    CREATE TABLE dbo.LoaiPhong
    (
        MaLoaiPhong INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
        TenLoaiPhong NVARCHAR(50) NOT NULL, -- 'Phòng Đơn', 'Phòng Đôi', 'Phòng Vip'
        MoTa NVARCHAR(255) NULL,
        NgayTao DATETIME DEFAULT GETDATE()
    );

    -- Thêm dữ liệu mẫu
    INSERT INTO dbo.LoaiPhong (TenLoaiPhong, MoTa)
    VALUES 
        (N'Phòng Đơn', N'Phòng cho 1 khách'),
        (N'Phòng Đôi', N'Phòng cho 2 khách'),
        (N'Phòng Vip', N'Phòng cao cấp cho 2-3 khách');

    PRINT N'Bảng LoaiPhong đã được tạo và có dữ liệu mẫu.';
END
GO

-- =============================================
-- 5. Kiểm tra dữ liệu
-- =============================================
PRINT N'--- Dữ liệu bảng Phong ---';
SELECT * FROM dbo.Phong;

PRINT N'--- Dữ liệu bảng LoaiPhong ---';
SELECT * FROM dbo.LoaiPhong;

PRINT N'Database QuanLyKhachSan và các bảng đã sẵn sàng!';
GO
