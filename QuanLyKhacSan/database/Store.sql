--- store l?y danh s�ch kh�ch h�ng
create proc sp_DSKH
as
select MaKhachHang as N'M� Kh�ch H�ng', HoTen as N'T�n kh�ch h�ng', CCCD, SoDienThoai as N'S? ?i?n tho?i', NgaySinh as N'Ng�y sinh',DiaChi as N'??a ch?',GioiTinh as N'Gi?i t�nh', GhiChu as N'Ghi ch�'
from KhachHang
go
--- store them khach hang
GO
CREATE PROCEDURE sp_ThemKH
    @makh NVARCHAR(50),
    @hoten NVARCHAR(100),
    @gioitinh NVARCHAR(255),
    @ngaysinh DATE, 
    @cccd NVARCHAR(50),
    @diachi NVARCHAR(20),
    @sdt VARCHAR(15),
    @ghichu NVARCHAR(255)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM KhachHang WHERE MaKhachHang = @makh)
    BEGIN
        RETURN -1; -- Tra ve -1 de cho biet m� kh�ch h�ng da ton tai
    END

    INSERT INTO KhachHang (MaKhachHang, HoTen, GioiTinh, NgaySinh, CCCD, DiaChi, SoDienThoai, GhiChu)
    VALUES (@makh, @hoten, @gioitinh, @ngaysinh, @cccd, @diachi, @sdt, @ghichu);

    RETURN 1; -- Tr? v? 1 ?? cho bi?t ch�n th�nh c�ng
END
GO
--- store sua khach hang
create proc sp_SuaKH
	@makh NVARCHAR(50),
    @hoten NVARCHAR(100),
    @gioitinh NVARCHAR(255),
    @ngaysinh DATE, 
    @cccd NVARCHAR(50),
    @diachi NVARCHAR(20),
    @sdt VARCHAR(15),
    @ghichu NVARCHAR(255)
as

Update KhachHang
set HoTen = @hoten, GioiTinh = @gioitinh, NgaySinh = @ngaysinh, CCCD = @cccd, DiaChi = @diachi, SoDienThoai = @sdt, GhiChu = @ghichu
where MaKhachHang = @makh
go
--- store xoa khach hang
create proc sp_XoaKH(@makh nvarchar(50))
as
begin
Delete from KhachHang where MaKhachHang = @makh
end
go
--- store t�m ki?m kh�ch h�ng
create proc sp_TimKH(@hoten nvarchar(100))
as
begin
select * from KhachHang where HoTen like '%' + @hoten + '%'
end
go
--- store hi?n th? danh s�ch ph�ng
	create proc sp_DSPhong
	as select MaPhong as N'M� ph�ng', SoPhong as N'S? ph�ng', KieuPhong as N'Ki?u ph�ng', LoaiPhong as N'Lo?i ph�ng', GiaMoiDem as 'Gi� ph�ng'
	from Phong
	go
--- store th�m ph�ng
CREATE PROCEDURE sp_ThemPhong
    @maphong NVARCHAR(50),
    @SoPhong varchar(10),
    @kieuphong nvarchar(50),
    @loaiphong nvarchar(50),
    @giaphong int
AS
BEGIN
	   -- Ki?m tra xem m� ph�ng ?� t?n t?i hay ch?a
    IF EXISTS (SELECT 1 FROM Phong WHERE MaPhong = @maphong)
    BEGIN
        RETURN -1; -- Tra ve -1 khi da co ma phong
    END
	   -- Ki?m tra xem s? ph�ng ?� t?n t?i hay ch?a
    IF EXISTS (SELECT 1 FROM Phong WHERE SoPhong = @SoPhong)
    BEGIN
        RETURN -2; -- Tr? v? -2 khi ?� c� s? ph�ng tr�ng l?p
    END
    INSERT INTO Phong(MaPhong, SoPhong,KieuPhong,LoaiPhong,GiaMoiDem)
    VALUES (@maphong,@SoPhong,@kieuphong,@loaiphong,@giaphong);
    RETURN 1; -- tra ve neu them thanh cong
END
GO
--- store s?a phong
CREATE PROCEDURE sp_SuaPhong
@maphong nvarchar(50),
@sophong varchar(10),
@kieuphong nvarchar(50),
@loaiphong nvarchar(50),
@giaphong int
as
begin
--- kiem tra xem so phong da co chua khi cap nhat
IF EXISTS (SELECT 1 FROM Phong WHERE SoPhong = @sophong and @maphong != MaPhong)
begin
	return -1
end
Update Phong
set SoPhong = @sophong, KieuPhong = @kieuphong, LoaiPhong = @loaiphong, GiaMoiDem = @giaphong
where MaPhong = @maphong
return 1;
End
--- store xoa phong
create proc sp_XoaPhong
@maphong nvarchar(50)
as
begin
Delete from Phong where MaPhong = @maphong
end
--- store t�m kiem phong
--CREATE PROCEDURE sp_TimPhong(@sophong INT = Null)
--AS
--BEGIN
--        IF @sophong IS NULL
--    BEGIN
--        SELECT * FROM Phong; -- Tr? v? t?t c? c�c ph�ng n?u kh�ng c� ?i?u ki?n t�m ki?m
--    END
--    ELSE
--    BEGIN
--        SELECT * FROM Phong 
--        WHERE CAST(SoPhong AS NVARCHAR(10)) LIKE '%' + CAST(@sophong AS NVARCHAR(10)) + '%';
--    END
--END
--GO
CREATE PROCEDURE sp_TimPhong(@sophong nvarchar(100))
AS
BEGIN   
  select * from Phong where SoPhong like '%' + @sophong + '%'
END
GO
--- store tra ve danh sach phong
create proc sp_DanhSachPhong
as
begin
select SoPhong, KieuPhong,LoaiPhong
from Phong
end
--- store l?y danh s�ch ??t ph�ng
CREATE PROCEDURE sp_DanhSachDatPhong
AS
BEGIN
    SELECT 
        dp.MaDatPhong AS N'M� ??t ph�ng', 
        kh.HoTen AS N'T�n kh�ch h�ng', 
        p.SoPhong AS N'S? ph�ng', 
        dp.NgayDatPhong AS N'Ng�y ??t ph�ng', 
        dp.NgayNhanPhong AS N'Ng�y nh?n ph�ng', 
        dp.NgayTraPhong AS N'Ng�y tr? ph�ng',
        DATEDIFF(DAY, dp.NgayNhanPhong, dp.NgayTraPhong) AS N'T?ng ng�y ?'
    FROM 
        DatPhong dp
    JOIN 
        Phong p ON dp.MaPhong = p.MaPhong
    JOIN 
        KhachHang kh ON dp.MaKhachHang = kh.MaKhachHang
    GROUP BY 
        dp.MaDatPhong, 
        kh.HoTen, 
        p.SoPhong, 
        dp.NgayDatPhong, 
        dp.NgayNhanPhong, 
        dp.NgayTraPhong
END
GO
--- store th�m ??t ph�ng
CREATE PROCEDURE SP_ThemDatPhong
@madatphong nvarchar(50),
@makh nvarchar(50),
@maphong nvarchar(50),
@ngaydatphong datetime,
@ngaynhanphong datetime,
@ngaytraphong datetime
as
begin
end
go
--- store thay ??i t�nh tr?ng ph�ng
--CREATE PROCEDURE SP_ThayDoiTinhTrangPhong
--@maphong nvarchar(50),
--@ngaydatphong datetime,
--@ngaynhanphong datetime,
--@ngaytraphong datetime
--as
--begin
--select *
--from DatPhong dp
--Where ( dp.NgayNhanPhong <= @ngaynhanphong and @ngaytraphong <= dp.NgayTraPhong) or (dp.NgayNhanPhong <= @ngaytraphong and @ngaytraphong <= dp.NgayTraPhong) and dp.MaPhong = @maphong
--end
CREATE PROCEDURE SP_ThayDoiTinhTrangPhong
    @maphong NVARCHAR(50),
    @ngaydatphong DATETIME,
    @ngaynhanphong DATETIME,
    @ngaytraphong DATETIME
AS
BEGIN
    DECLARE @Count INT;
    DECLARE @Count2 INT;

    -- ??m s? b?n ghi th?a m�n ?i?u ki?n ??u ti�n
    SELECT @Count = COUNT(*)
    FROM DatPhong dp
    WHERE 
        (
            (dp.NgayNhanPhong <= @ngaynhanphong AND @ngaytraphong <= dp.NgayTraPhong) OR 
            (dp.NgayNhanPhong <= @ngaytraphong AND @ngaynhanphong <= dp.NgayTraPhong) OR
			(dp.NgayNhanPhong <= @ngaydatphong and @ngaydatphong <= dp.NgayTraPhong)
        )
        AND dp.MaPhong = @maphong;

    -- ??m s? b?n ghi th?a m�n ?i?u ki?n th? hai
    SELECT @Count2 = COUNT(*)
    FROM DatPhong dp
    WHERE 
        (
            (dp.NgayDatPhong <= @ngaydatphong AND @ngaynhanphong <= dp.NgayNhanPhong) OR 
            (dp.NgayDatPhong <= @ngaynhanphong AND @ngaydatphong <= dp.NgayNhanPhong) OR
			(dp.NgayDatPhong <= @ngaytraphong and @ngaytraphong <= dp.NgayNhanPhong)
        )
        AND dp.MaPhong = @maphong;

    -- Ki?m tra v� tr? v? gi� tr?
    IF @Count > 0
    BEGIN
        RETURN 1;  -- C� �t nh?t m?t b?n ghi th?a m�n ?i?u ki?n ??u ti�n
    END
    ELSE IF @Count2 > 0
    BEGIN
        RETURN 2;  -- @ngaydatphong v� @ngaynhanphong n?m trong kho?ng NgayDatPhong v� NgayNhanPhong
    END
    ELSE
    BEGIN
        RETURN 0;  -- Kh�ng c� b?n ghi n�o th?a m�n
    END
END
