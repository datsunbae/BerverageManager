﻿CREATE DATABASE QuanLyBanNuocGiaiKhat_DACS
GO

USE QuanLyBanNuocGiaiKhat_DACS
GO


CREATE TABLE DONVI
(
	MADV NVARCHAR(50) PRIMARY KEY,
	TENDV NVARCHAR(100),
	DVTC BIT
)
GO


CREATE TABLE SANPHAM
(
	MASP INT IDENTITY(1,1) PRIMARY KEY,
	TENSP NVARCHAR(100),
	DVTCHINH NVARCHAR(50),
	GIANHAP_DVTC FLOAT,
	GIABANSI_DVTC FLOAT,
	GIABANLE_DVTC FLOAT,
	DVTPHU NVARCHAR(50),
	GIABANSI_DVTP FLOAT,
	GIABANLE_DVTP FLOAT,
	QUIDOI INT,
	
)
GO

ALTER TABLE SANPHAM 
ADD CONSTRAINT FK_IDDVTC_SANPHAM
FOREIGN KEY (DVTCHINH)
REFERENCES dbo.DONVI(MADV)
GO

ALTER TABLE SANPHAM 
ADD CONSTRAINT FK_IDDVTP_SANPHAM
FOREIGN KEY (DVTPHU)
REFERENCES dbo.DONVI(MADV)
GO

CREATE TABLE VAITRO
(
	MAVAITRO VARCHAR(50) PRIMARY KEY,
	TENVAITRO NVARCHAR(100)
)
GO

CREATE TABLE TAIKHOAN
(
	MADANGNHAP VARCHAR(50) PRIMARY KEY,
	MATKHAU NVARCHAR(50) NOT NULL,
	MVAITRO VARCHAR(50) NOT NULL,

	CONSTRAINT FK_MVAITRO_VAITRO
	FOREIGN KEY (MVAITRO)
	REFERENCES dbo.VAITRO(MAVAITRO)
)
GO



CREATE TABLE NHANVIEN
(
	MANV INT IDENTITY(1,1) PRIMARY KEY,
	TENNV NVARCHAR(100),
	SDTNV NVARCHAR(20),
	EMAILNV NVARCHAR(100),
	DIACHINV NVARCHAR(150),
	MATK VARCHAR(50) NOT NULL,
	HINHANHNV IMAGE,

	CONSTRAINT FK_MATK_TAIKHOAN
	FOREIGN KEY (MATK)
	REFERENCES dbo.TAIKHOAN(MADANGNHAP)
)
GO

CREATE TABLE KHACHHANG
(
	MAKH INT IDENTITY(1,1) PRIMARY KEY,
	TENKH NVARCHAR(100),
	SDTKH NVARCHAR(50),
	EMAILKH NVARCHAR(100),
	DIACHIKH NVARCHAR(100),
	LOAIKH BIT DEFAULT 1
)
GO

CREATE TABLE NHACUNGCAP
(
	MANCC INT IDENTITY(1,1) PRIMARY KEY,
	TENNCC NVARCHAR(100),
	SDTNCC NVARCHAR(20),
	EMAILNCC NVARCHAR(100),
	DIACHINCC NVARCHAR(100)
)
GO



CREATE TABLE NHAPKHO
(
	MAPNK INT IDENTITY(1,1) PRIMARY KEY,
	NGAYNHAP DATE,
	TONGTIEN FLOAT,
	IDNV INT,
	IDNCC INT,

	CONSTRAINT FK_IDNV_NHAPKHO
	FOREIGN KEY (IDNV)
	REFERENCES dbo.NHANVIEN(MANV)
	ON DELETE SET NULL,

	CONSTRAINT FK_IDNCC_NHAPKHO
	FOREIGN KEY (IDNCC)
	REFERENCES dbo.NHACUNGCAP(MANCC)
	ON DELETE SET NULL
)
GO


CREATE TABLE CT_PNHAPKHO
(
	IDCTPNK INT IDENTITY(1,1) PRIMARY KEY,
	IDPNK INT,
	IDSP INT,
	SL INT,
	DVT NVARCHAR(50),
	THANHTIEN FLOAT

	FOREIGN KEY (IDPNK) REFERENCES dbo.NHAPKHO(MAPNK),

	CONSTRAINT FK_IDSP_CTNHAPKHO
	FOREIGN KEY (IDSP)
	REFERENCES dbo.SANPHAM(MASP)
	ON DELETE SET NULL,

	CONSTRAINT FK_IDDVT_CT_PNHAPKHO
	FOREIGN KEY (DVT)
	REFERENCES dbo.DONVI(MADV)
	ON DELETE SET NULL
)
GO

CREATE TABLE TONKHO
(
	ID INT IDENTITY PRIMARY KEY,
	IDSP INT,
	SLTON INT,
	SLTONQUIDOI NVARCHAR(100)

	CONSTRAINT FK_IDSP_TONKHO
	FOREIGN KEY (IDSP)
	REFERENCES dbo.SANPHAM(MASP)
	ON DELETE CASCADE
)
GO

CREATE TABLE DONHANG
(
	MADH INT IDENTITY(1,1) PRIMARY KEY,
	NGAYLAP DATE,
	IDNV INT,
	IDKH INT,
	TONGTIEN FLOAT,

	CONSTRAINT FK_IDNV_DONHANG
	FOREIGN KEY (IDNV)
	REFERENCES dbo.NHANVIEN(MANV) 
	ON DELETE SET NULL,

	CONSTRAINT FK_IDKH_DONHANG
	FOREIGN KEY (IDKH)
	REFERENCES dbo.KHACHHANG(MAKH)
	ON DELETE SET NULL
)
GO

CREATE TABLE CT_DONHANG
(
	IDCTDH INT IDENTITY(1,1) PRIMARY KEY,
	MADH INT,
	MASP INT,
	SL INT,
	DVT NVARCHAR(50),
	THANHTIEN FLOAT
	

	CONSTRAINT FK_MADH_CTDONHANG
	FOREIGN KEY (MADH)
	REFERENCES dbo.DONHANG(MADH)
	ON DELETE CASCADE,

	CONSTRAINT FK_MASP_CTDONHANG
	FOREIGN KEY (MASP)
	REFERENCES dbo.SANPHAM(MASP)
	ON DELETE SET NULL,

	CONSTRAINT FK_IDDVT_CT_DONHANG
	FOREIGN KEY (DVT)
	REFERENCES dbo.DONVI(MADV)
	ON DELETE SET NULL
)
GO



-- THÊM DONVI
INSERT INTO DONVI(MADV,TENDV, DVTC) VALUES ('DV1', N'Thùng', 1); 
INSERT INTO DONVI(MADV,TENDV, DVTC) VALUES ('DV2', N'Kết', 1); 
INSERT INTO DONVI(MADV,TENDV, DVTC) VALUES ('DV3', N'Lon', 0);
INSERT INTO DONVI(MADV,TENDV, DVTC) VALUES ('DV4', N'Chai', 0);


-- THÊM SANPHAM
INSERT INTO SANPHAM(TENSP, DVTCHINH, GIANHAP_DVTC, GIABANSI_DVTC, GIABANLE_DVTC, DVTPHU, GIABANSI_DVTP, GIABANLE_DVTP, QUIDOI) VALUES (N'Sting', 'DV1', 100000, 120000, 150000, 'DV4', 5000, 7000, 24); 


--THÊM VAITRO
INSERT INTO VAITRO(MAVAITRO,TENVAITRO) VALUES ('VT1', N'Admin');
INSERT INTO VAITRO(MAVAITRO,TENVAITRO) VALUES ('VT2', N'Nhân viên bán hàng');
INSERT INTO VAITRO(MAVAITRO,TENVAITRO) VALUES ('VT3', N'Nhân viên kho'); 

-- THÊM TAIKHOAN
INSERT INTO TAIKHOAN(MADANGNHAP,MATKHAU,MVAITRO) VALUES ('datsunbae', '0802', 'VT1'); 
INSERT INTO TAIKHOAN(MADANGNHAP,MATKHAU,MVAITRO) VALUES ('caodai', '1651', 'VT2'); 
INSERT INTO TAIKHOAN(MADANGNHAP,MATKHAU,MVAITRO) VALUES ('quocduy', '123', 'VT3'); 

-- THÊM NHANVIEN
INSERT INTO NHANVIEN(TENNV, SDTNV, EMAILNV, DIACHINV, MATK, HINHANHNV) SELECT N'Nguyễn Văn Đạt', '0386411857', 'datsunbae@gmail.com', N'Quảng Ngãi', 'datsunbae', BULKCOLUMN 
FROM OPENROWSET (BULK 'D:\DoAnCoSo\user.jpg', Single_Blob) as Image;
INSERT INTO NHANVIEN(TENNV, SDTNV, EMAILNV, DIACHINV, MATK, HINHANHNV) SELECT N'Trần Cao Đại', '0398698810', 'caodai@gmail.com', N'Phú Yên', 'caodai', BULKCOLUMN 
FROM OPENROWSET (BULK 'D:\DoAnCoSo\user.jpg', Single_Blob) as Image;

-- THÊM KHACHHANG
INSERT INTO KHACHHANG(TENKH, SDTKH, EMAILKH, DIACHIKH, LOAIKH) VALUES (N'Khách lẻ', null, null, null, 0); 
INSERT INTO KHACHHANG(TENKH, SDTKH, EMAILKH, DIACHIKH) VALUES (N'Minh Thuận', '0965886410', 'minhthuan@gmail.com', N'Hồ Chí Minh'); 
INSERT INTO KHACHHANG(TENKH, SDTKH, EMAILKH, DIACHIKH) VALUES (N'Cẩm Tiên', '0865118649', 'camtien@gmail.com', N'Hồ Chí Minh'); 
INSERT INTO KHACHHANG(TENKH, SDTKH, EMAILKH, DIACHIKH) VALUES (N'Trâm Trần', '098671356', 'tramtran@gmail.com', N'Hà Nội'); 

--THÊM NHACCUNGCAP
INSERT INTO NHACUNGCAP(TENNCC, SDTNCC, EMAILNCC, DIACHINCC) VALUES (N'Anh Minh', '0965118649', 'anhminh@gmail.com', N'Hồ Chí Minh'); 
INSERT INTO NHACUNGCAP(TENNCC, SDTNCC, EMAILNCC, DIACHINCC) VALUES (N'Minh Thành', '0967449619', 'minhthanh@gmail.com', N'Hồ Chí Minh'); 
INSERT INTO NHACUNGCAP(TENNCC, SDTNCC, EMAILNCC, DIACHINCC) VALUES (N'Thành Công', '0956771452', 'thanhcong@gmail.com', N'Bình Dương'); 



