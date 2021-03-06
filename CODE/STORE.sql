CREATE DATABASE STORE
GO

USE STORE
GO

CREATE TABLE KHACHHANG
(
	MAKH CHAR(8),
	HO NVARCHAR(7),
	TEN NVARCHAR(7),
	NGSINH DATE,
	SONHA VARCHAR(10),
	DUONG NVARCHAR(30),
	PHUONG NVARCHAR(20),
	QUAN NVARCHAR(15),
	TPHO NVARCHAR(20),
	DIENTHOAI CHAR(10),
	CONSTRAINT PK_HK PRIMARY KEY(MAKH)
)
GO

CREATE TABLE HOADON
(
	MAHD CHAR(8),
	MAKH CHAR(8),
	NGAYLAP DATE,
	TONGTIEN FLOAT,
	CONSTRAINT PK_HD PRIMARY KEY(MAHD)
)
GO

CREATE TABLE CT_HOADON
(
	MAHD CHAR(8),
	MASP CHAR(7),
	SOLUONG INT,
	GIABAN FLOAT,
	GIAGIAM FLOAT,
	THANHTIEN FLOAT,
	CONSTRAINT PK_CTHD PRIMARY KEY (MAHD, MASP)
)
GO

CREATE TABLE SANPHAM
(
	MASP CHAR(7),
	TENSP NVARCHAR(50),
	SOLUONGTON INT,
	MOTA NVARCHAR(100),
	GIA INT,
	CONSTRAINT PK_SP PRIMARY KEY(MASP)
)
GO

ALTER TABLE CT_HOADON
ADD CONSTRAINT FK_CTHD_HD
FOREIGN KEY(MAHD)
REFERENCES HOADON
GO

ALTER TABLE CT_HOADON
ADD CONSTRAINT FK_CTHD_SP
FOREIGN KEY(MASP)
REFERENCES SANPHAM
GO

ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_KH
FOREIGN KEY(MAKH)
REFERENCES KHACHHANG
GO

ALTER TABLE HOADON
ADD CONSTRAINT DF_TONGTIEN
DEFAULT 0 FOR TONGTIEN