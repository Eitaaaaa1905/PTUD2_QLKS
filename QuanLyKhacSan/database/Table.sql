CREATE DATABASE QLKS;
go
use QLKS
go
-- Bảng Khách hàng
CREATE TABLE KhachHang (
    MaKhachHang NVARCHAR(50) PRIMARY KEY,
    HoTen NVARCHAR(100),
    SoDienThoai VARCHAR(15),
	DiaChi NVARCHAR(255),
	NgaySinh date,
	GioiTinh nvarchar(255),
	GhiChu nvarchar(255),
	CCCD nvarchar(50)
);
select * from KhachHang

-- Bảng Nhân Viên
CREATE TABLE NhanVien (
    MaNhanVien NVARCHAR(50) PRIMARY KEY,
    AnhNhanVien VARBINARY(max),
    HoTen NVARCHAR(100),
    SoDienThoai VARCHAR(15),
    Email NVARCHAR(100),
    ViTri NVARCHAR(50),
    NgayNhanViec DATETIME,
    LuongCoBan DECIMAL(10,2),
    TenDangNhap NVARCHAR(50),
    MatKhau NVARCHAR(50)
);

-- Bảng Phân Quyền
CREATE TABLE Quyen (
    MaQuyen NVARCHAR(50) PRIMARY KEY,
    TenQuyen NVARCHAR(50)
);

CREATE TABLE PhanQuyenNhanVien (
    MaNhanVien NVARCHAR(50) FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    MaQuyen NVARCHAR(50) FOREIGN KEY REFERENCES Quyen(MaQuyen),
    PRIMARY KEY (MaNhanVien, MaQuyen)
);

-- Bảng Phòng
CREATE TABLE Phong (
    MaPhong NVARCHAR(50) PRIMARY KEY,
    SoPhong VARCHAR(10),
    KieuPhong NVARCHAR(50),
    LoaiPhong NVARCHAR(50),
    GiaMoiDem int,
    TinhTrang NVARCHAR(20) default N'Trống'
);

-- Bảng Đặt Phòng
CREATE TABLE DatPhong (
    MaDatPhong NVARCHAR(50) PRIMARY KEY,
    MaKhachHang NVARCHAR(50) FOREIGN KEY REFERENCES KhachHang(MaKhachHang),
    MaPhong NVARCHAR(50) FOREIGN KEY REFERENCES Phong(MaPhong),
    NgayDatPhong DATETIME,
    NgayNhanPhong DATETIME,
    NgayTraPhong DATETIME,
);

-- Bảng Hóa Đơn
CREATE TABLE HoaDon (
    MaHoaDon NVARCHAR(50) PRIMARY KEY,
    MaDatPhong NVARCHAR(50) FOREIGN KEY REFERENCES DatPhong(MaDatPhong),
    NgayHoaDon DATETIME,
    TongTien DECIMAL(10,2),
    TrangThaiThanhToan NVARCHAR(50)  -- Ví dụ: Đã thanh toán, Chưa thanh toán
);

-- Bảng Thanh Toán
CREATE TABLE ThanhToan (
    MaThanhToan NVARCHAR(50) PRIMARY KEY,
    MaHoaDon NVARCHAR(50) FOREIGN KEY REFERENCES HoaDon(MaHoaDon),
    NgayThanhToan DATETIME,
    PhuongThucThanhToan NVARCHAR(50),  -- Ví dụ: Tiền mặt, Thẻ tín dụng
    SoTienDaThanhToan DECIMAL(10,2)
);

-- Bảng Dịch Vụ
CREATE TABLE DichVu (
    MaDichVu NVARCHAR(50) PRIMARY KEY,
    TenDichVu NVARCHAR(100),
    AnhDichVu VARBINARY(max),
    GiaDichVu DECIMAL(10,2),
    DonViTinh NVARCHAR(50)
);

-- Bảng Sử Dụng Dịch Vụ
CREATE TABLE SuDungDichVu (
    MaSuDungDichVu NVARCHAR(50) PRIMARY KEY,
    MaDatPhong NVARCHAR(50) FOREIGN KEY REFERENCES DatPhong(MaDatPhong),
    MaDichVu NVARCHAR(50) FOREIGN KEY REFERENCES DichVu(MaDichVu),
    SoLuong INT,
    TongTien DECIMAL(10,2)
);

-- Bảng Bảo Trì Phòng
CREATE TABLE BaoTriPhong (
    MaBaoTri NVARCHAR(50) PRIMARY KEY,
    MaPhong NVARCHAR(50) FOREIGN KEY REFERENCES Phong(MaPhong),
    MaNhanVien NVARCHAR(50) FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    NgayBatDau DATETIME,
    NgayKetThuc DATETIME,
    ChiTietBaoTri NVARCHAR(255)
);

-- Bảng Chấm Công
CREATE TABLE ChamCong (
    MaChamCong NVARCHAR(50) PRIMARY KEY,
    MaNhanVien NVARCHAR(50) FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    Ngay DATETIME,
    GioVao DATETIME,
    GioRa DATETIME,
    SoGioLam DECIMAL(5,2)
);

-- Bảng Tính Lương
CREATE TABLE TinhLuong (
    MaTinhLuong NVARCHAR(50) PRIMARY KEY,
    MaNhanVien NVARCHAR(50) FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    ThangTinhLuong DATE,
    TongGioLam DECIMAL(5,2),
    LuongCoBan DECIMAL(10,2),
    TongTienThanhToan DECIMAL(10,2)
);

-- Bảng Khuyến Mãi và Ưu Đãi
CREATE TABLE KhuyenMai (
    MaKhuyenMai NVARCHAR(50) PRIMARY KEY,
    MaPhong NVARCHAR(50) FOREIGN KEY REFERENCES Phong(MaPhong),
    MaDichVu NVARCHAR(50) FOREIGN KEY REFERENCES DichVu(MaDichVu),
    MoTaKhuyenMai NVARCHAR(255),
    NgayBatDau DATETIME,
    NgayKetThuc DATETIME,
    PhanTramGiamGia DECIMAL(5,2)
);

-- Bảng Thống Kê Doanh Thu
CREATE TABLE ThongKeDoanhThu (
    MaThongKe NVARCHAR(50) PRIMARY KEY,
    Thang DATE,
    TongDoanhThu DECIMAL(10,2),
    TongDatPhong INT,
    TongDichVu DECIMAL(10,2),
    TongChiPhi DECIMAL(10,2),
    LoiNhuan DECIMAL(10,2)
);
