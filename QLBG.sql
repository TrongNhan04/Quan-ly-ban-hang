USE QLBG;

-- Xóa dữ liệu các bảng cũ (Nếu có)
DELETE FROM LoaiSanPham;
DELETE FROM HangSanXuat;
DELETE FROM SanPham;
DELETE FROM NhanVien;
DELETE FROM KhachHang;
DELETE FROM NguoiDung;
DELETE FROM PhanQuyen;
DELETE FROM DonHang;
DELETE FROM DonHang_ChiTiet;
DELETE FROM HoaDon;
DELETE FROM HoaDon_ChiTiet;

-- Reset identity
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'LoaiSanPham' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('LoaiSanPham', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'HangSanXuat' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('HangSanXuat', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'SanPham' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('SanPham', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'NhanVien' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('NhanVien', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'KhachHang' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('KhachHang', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'NguoiDung' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('NguoiDung', RESEED, 0);
	
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'PhanQuyen' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('PhanQuyen', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'DonHang' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('DonHang', RESEED, 0);
	
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'DonHang_ChiTiet' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('DonHang_ChiTiet', RESEED, 0);

IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'HoaDon' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('HoaDon', RESEED, 0);
	
IF EXISTS (SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(OBJECT_ID) = 'HoaDon_ChiTiet' AND last_value IS NOT NULL)
	DBCC CHECKIDENT('HoaDon', RESEED, 0);

--Loại sản phẩm: ID, TenLoai 
SET IDENTITY_INSERT LoaiSanPham ON
INSERT INTO LoaiSanPham (ID, TenLoai, TrangThai) VALUES
(1, N'Giày leo núi', 1),
(2, N'Giày bóng rổ', 1),
(3, N'Giày chạy bộ', 1),
(4, N'Giày tennis', 1),
(5, N'Giày bóng đá', 1),
(6, N'Sneakers', 1);
SET IDENTITY_INSERT LoaiSanPham OFF

--Hãng sản xuất: ID, TenHangSanXuat 
SET IDENTITY_INSERT HangSanXuat ON
INSERT INTO HangSanXuat (ID, TenHangSanXuat, TrangThai) VALUES
(1, 'Nike', 1),
(2, 'Adidas', 1),
(3, 'Puma', 1),
(4, 'Converse', 1),
(5, 'Vans', 1),
(6, 'New Balance', 1);
SET IDENTITY_INSERT HangSanXuat OFF

--Sản phẩm: ID, LoaiSanPhamID, HangSanXuatID, TenSanPham, DonGia, SoLuong, HinhAnh
SET IDENTITY_INSERT SanPham ON
INSERT INTO SanPham(ID, LoaiSanPhamID, HangSanXuatID, TenSanPham, SoLuong, DonGia, HinhAnh, Size, TrangThai) VALUES
(1, 3, 1, N'Nike Air Zoom Pegasus 39', 50, 2990000, 'image1.jpg', 40, 1),
(2, 2, 2, N'Adidas Harden Vol.6', 30, 3200000, 'image2.jpg', 42, 1),
(3, 5, 3, N'Puma Future Z 1.4', 40, 2800000, 'image3.jpg', 37, 1),
(4, 1, 6, N'New Balance Hierro v7', 25, 3500000, 'image4.jpg', 41, 1),
(5, 6, 5, N'Vans Old Skool Classic', 60, 1700000, 'image5.jpg', 38, 1),
(6, 4, 4, N'Converse Jack Purcell Tennis', 20, 1900000, 'image6.jpg', 39, 1),
(7, 3, 2, N'Adidas Ultraboost 22', 45, 3500000, 'image7.jpg', 41, 1),
(8, 2, 1, N'Nike LeBron Witness 7', 35, 3100000, 'image8.jpg', 37, 1),
(9, 5, 2, N'Adidas Predator Accuracy.3', 38, 2900000, 'image9.jpeg', 39, 1),
(10, 6, 4, N'Converse Chuck Taylor All Star', 70, 1600000, 'image10.jpg', 42, 1),
(11, 1, 3, N'Puma Explore Nitro', 28, 3300000, 'image11.jpg', 40, 1),
(12, 4, 6, N'New Balance 996v4 Tennis', 22, 3000000, 'image12.jpg', 38, 1),
(13, 3, 1, N'Nike Revolution 6', 40, 2100000, 'image13.jpg', 41, 1),
(14, 2, 2, N'Adidas Dame 8', 35, 3300000, 'image14.jpg', 37, 1),
(15, 5, 3, N'Puma Ultra Play', 50, 2700000, 'image15.jpeg', 42, 1);
SET IDENTITY_INSERT SanPham OFF


--Phân quyền: ID, QuyenHan 
SET IDENTITY_INSERT PhanQuyen ON
INSERT INTO PhanQuyen(ID, QuyenHan) VALUES
(1, 'admin'),
(2, 'user');
SET IDENTITY_INSERT PhanQuyen OFF

--Người dùng: ID, TenDangNhap, MatKhau, PhanQuyenID
SET IDENTITY_INSERT NguoiDung ON
INSERT INTO NguoiDung(ID,  TenDangNhap, MatKhau, PhanQuyenID) VALUES
(1, 'admin', '$2a$12$R2QClmPkDZOvHQsDgjVat.R67dfvnkv6Z3hd89J15G3g50xOLSoDu', 1),
(2, 'user1', '$2a$12$8ha1WK9wXe2fuiHhTDxbZuXpCYoTXdftqi8v3VFyu5VF82dIrvv0C', 2),
(3, 'user2', '$2a$12$8ha1WK9wXe2fuiHhTDxbZuXpCYoTXdftqi8v3VFyu5VF82dIrvv0C', 2),
(4, 'user3', '$2a$12$8ha1WK9wXe2fuiHhTDxbZuXpCYoTXdftqi8v3VFyu5VF82dIrvv0C', 2);
SET IDENTITY_INSERT NguoiDung OFF

--Khách hàng: ID, HoVaTen, DienThoai, DiaChi
SET IDENTITY_INSERT KhachHang ON
INSERT INTO KhachHang (ID, HoVaTen, DienThoai, DiaChi, TrangThai) VALUES
(1, N'Ngô Thị Tuyết', '0123456777', N'Chợ Mới', 1),
(2, N'Tạ Thanh Tùng', '0123456555', N'Lấp Vò - Đồng Tháp', 1),
(3, N'Nguyễn Mạnh Hùng', '0123456998', N'Phú Hòa', 1),
(4, N'Lê Văn Phúc', '0123456111', N'Cao Lãnh - Đồng Tháp', 1),
(5, N'Trần Thị Mai', '0123456222', N'Long Xuyên - An Giang', 1),
(6, N'Phạm Quốc Huy', '0123456333', N'Vĩnh Long', 1),
(7, N'Hồ Minh Tuấn', '0123456445', N'Châu Thành - Tiền Giang', 1),
(8, N'Lý Thị Thanh', '0123456556', N'Thanh Bình - Đồng Tháp', 1),
(9, N'Nguyễn Thị Bích', '0123456666', N'Cần Thơ', 1),
(10, N'Võ Minh Khôi', '0123456778', N'Thốt Nốt - Cần Thơ', 1);
SET IDENTITY_INSERT KhachHang OFF

--Nhân viên: ID, HoVaTen, SDT, DiaChi, NguoiDungID
SET IDENTITY_INSERT NhanVien ON
INSERT INTO NhanVien(ID, HoVaTen, DienThoai, DiaChi, NguoiDungID, TrangThai) VALUES
(1, N'Nguyễn Hữu Hoàng', '0123456888', N'Long Xuyên',1, 1),
(2, N'Nguyễn Mai Thu', '0123456999', N'Châu Thành',2, 1),
(3, N'Hà Thành An', '0123456999', N'Thoại Sơn',3, 1),
(4, N'Phạm Thanh Trúc', '0988881234', N'An Phú', 4, 1);
SET IDENTITY_INSERT NhanVien OFF

--Đơn hàng: ID, NgayLapDonHang, KhachHangID, NhanVienID, TrangThai
SET IDENTITY_INSERT DonHang ON
INSERT INTO DonHang(ID, NgayLapDonHang, KhachHangID, NhanVienID, TrangThai) VALUES
(1, '2024-09-29', 3, 1, 1),
(2, '2024-10-04', 2, 1, 1),
(3, '2024-10-13', 1, 2, 1),
(4, '2024-10-19', 4, 3, 1),
(5, '2024-10-26', 5, 1, 1),
(6, '2024-11-02', 6, 2, 1),
(7, '2024-11-07', 7, 3, 1),
(8, '2024-11-13', 8, 1, 1),
(9, '2024-11-21', 9, 2, 1),
(10, '2024-11-28', 10, 3, 1),
(11, '2024-12-05', 1, 1, 1),
(12, '2024-12-10', 2, 2, 1),
(13, '2024-12-16', 3, 3, 1),
(14, '2024-12-23', 4, 1, 1),
(15, '2025-01-01', 5, 2, 1),
(16, '2025-01-08', 6, 3, 1),
(17, '2025-01-14', 7, 1, 1),
(18, '2025-01-19', 8, 2, 1),
(19, '2025-01-26', 9, 3, 1),
(20, '2025-02-01', 10, 1, 1),
(21, '2025-02-09', 1, 2, 1),
(22, '2025-02-16', 2, 3, 1),
(23, '2025-02-23', 3, 1, 1),
(24, '2025-03-02', 1, 2, 1),
(25, '2025-03-09', 2, 3, 1),
(26, '2025-03-16', 3, 1, 1),
(27, '2025-03-24', 4, 2, 1),
(28, '2025-04-01', 5, 3, 1),
(29, '2025-04-10', 6, 1, 1),
(30, '2025-04-22', 7, 2, 1);
SET IDENTITY_INSERT DonHang OFF
	
--Đơn Hàng Chi Tiet: ID, DonHangID, SanPhamID, SoLuongDat, DonGiaDat
SET IDENTITY_INSERT DonHang_ChiTiet ON
INSERT INTO DonHang_ChiTiet(ID, DonHangID, SanPhamID, SoLuongDat, DonGiaDat) VALUES
(1, 1, 15, 2, 5400000),
(2, 2, 3, 1, 2200000),
(3, 3, 1, 3, 2990000),
(4, 4, 2, 2, 1900000),
(5, 5, 4, 1, 1700000),
(6, 6, 6, 1, 1900000),
(7, 7, 8, 2, 3500000),
(8, 8, 10, 1, 3100000),
(9, 9, 2, 3, 2900000),
(10, 10, 11, 2, 1600000),
(11, 11, 13, 1, 3300000),
(12, 12, 6, 1, 3000000),
(13, 13, 9, 2, 2100000),
(14, 14, 10, 1, 3300000),
(15, 15, 1, 1, 2700000),
(16, 16, 14, 2, 3600000),
(17, 17, 10, 2, 1900000),
(18, 18, 11, 1, 2100000),
(19, 19, 7, 1, 3400000),
(20, 20, 6, 2, 3700000),
(21, 21, 1, 2, 3000000),
(22, 22, 4, 1, 1800000),
(23, 23, 3, 2, 3200000),
(24, 24, 6, 1, 2900000),
(25, 25, 5, 2, 2600000),
(26, 26, 7, 3, 3500000),
(27, 27, 9, 1, 3100000),
(28, 28, 5, 1, 1600000),
(29, 29, 6, 2, 3700000),
(30, 30, 3, 1, 3100000);
SET IDENTITY_INSERT DonHang_ChiTiet OFF

--Hóa đơn: ID, NgayLapHoaDon, 
SET IDENTITY_INSERT HoaDon ON
INSERT INTO HoaDon(ID, NgayLapHoaDon, DonHangID) VALUES
(1, '2025-03-11', 1),
(2, '2025-03-18', 2),
(3, '2025-03-26', 3),
(4, '2025-04-03', 4),
(5, '2025-04-12', 5);
SET IDENTITY_INSERT HoaDon OFF

--Hóa đơn chi tiết: ID, HoaDonID, SanPhamID, SoLuongBan, DonGiaBan
SET IDENTITY_INSERT HoaDon_ChiTiet ON
INSERT INTO HoaDon_ChiTiet(ID, HoaDonID, SanPhamID, SoLuongBan, DonGiaBan) VALUES
(1, 1, 15, 1, 5400000),
(2, 2, 3, 2, 2200000),
(3, 3, 1, 3, 2990000),
(4, 4, 2, 1, 1900000),
(5, 5, 4, 1, 1700000);
SET IDENTITY_INSERT HoaDon_ChiTiet OFF

SELECT * FROM LoaiSanPham;
SELECT * FROM HangSanXuat;
SELECT * FROM SanPham;
SELECT * FROM NhanVien;
SELECT * FROM KhachHang;
SELECT * FROM NguoiDung;
SELECT * FROM PhanQuyen;
SELECT * FROM DonHang;
SELECT * FROM DonHang_ChiTiet;
SELECT * FROM HoaDon;
SELECT * FROM HoaDon_ChiTiet;
