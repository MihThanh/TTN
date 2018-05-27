CREATE DATABASE QUANLYNHANSU
USE QUANLYNHANSU

CREATE TABLE PHONGBAN
(
	MAPB VARCHAR(10) PRIMARY KEY,
	TENPB NCHAR(20),
	MATP CHAR(10),
	DIADIEM NCHAR(30),
	NGAYNC DATE
)

CREATE TABLE DUAN(
	MADA CHAR(10) PRIMARY KEY,
	TENDA NCHAR(10),
	DIADIEM NCHAR(20),
	MAPB VARCHAR(10) REFERENCES PHONGBAN(MAPB)
)

CREATE TABLE NHANVIEN(
	MANV CHAR(10) PRIMARY KEY,
	HOTEN NCHAR(50) NOT NULL,
	MANGS CHAR(10),
	NS DATE,
	GT NCHAR(5) CHECK (GT IN ('NAM','NỮ')),
	LUONG NUMERIC,
	MAPB VARCHAR(10) REFERENCES PHONGBAN(MAPB)
)

CREATE TABLE PHANCONG(
	MANV CHAR(10) REFERENCES NHANVIEN(MANV),
	MADA CHAR(10) REFERENCES DUAN(MADA),
	SOGIO CHAR(10),
	PRIMARY KEY (MANV,MADA)
)

SELECT * FROM NHANVIEN

INSERT INTO dbo.PHONGBAN(MAPB,TENPB,MATP,DIADIEM) VALUES('PB01',N'HÀNH CHÍNH','1',N'HÀ NỘI')
 
INSERT INTO dbo.PHONGBAN(MAPB,TENPB,MATP,DIADIEM)
VALUES('PB02',N'NHÂN SỰ','2',N'HÀ NỘI')

INSERT INTO dbo.PHONGBAN(MAPB,TENPB,MATP,DIADIEM)
VALUES('PB03',N'CHÍNH TRỊ','3',N'ĐÀ NẴNG')

INSERT INTO dbo.PHONGBAN(MAPB,TENPB,MATP,DIADIEM)
VALUES('PB04',N'KINH TẾ','4',N'HÀ NỘI')


INSERT INTO dbo.PHONGBAN(MAPB,TENPB,MATP,DIADIEM)
VALUES('PB05',N'KHO','5',N'HỒ CHÍ MINH')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'NGUYỄN HẢI NAM','1',N'NAM','PB01','19971227')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'NGUYỄN MINH ĐỨC','2',N'NAM','PB01','19970723')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'ĐÀO THỊ DUNG','3',N'NU','PB02','19970612')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'NGUYỄN ANH CƯỜNG','4',N'NAM','PB03','19970507')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'NGUYỄN THỊ TRƯỜNG','111','NU','PB01','19960315')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'TRẦN QUANG DUY','5',N'NAM','PB03','19971206')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'LÊ QUANG DŨNG','6',N'NAM','PB04','19970918')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'PHẠM CÔNG HIẾU','7',N'NAM','PB04','19970425')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'NGUYỄN THÙY LINH','8',N'NU','PB04','19970316')


INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'NGUYỄN ĐỨC MINH','11',N'NAM','PB03','19971125')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'NGUYỄN ĐỨC MẠNH','12',N'NAM','PB02','19970607')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'TRẦN GIA LINH','13',N'U','PB04','19970108')

INSERT INTO dbo.NHANVIEN (HOTEN, MANV,GT,MAPB,NS) 
VALUES (N'NGUYỄN TUẤN HIỆP','14',N'NAM','PB01','19971224')


INSERT INTO dbo.DUAN(MADA,TENDA,MAPB)
VALUES ('DA 2',N'BÁN HÀNG','PB04')

INSERT INTO dbo.DUAN(MADA,TENDA,MAPB)
VALUES ('DA 3',N'CUNG ỨNG','PB02')

INSERT INTO dbo.DUAN(MADA,TENDA,MAPB)
VALUES ('DA 4',N'CÔNG CHỨNG','PB01')

INSERT INTO dbo.DUAN(MADA,TENDA,MAPB)
VALUES ('DA 5',N'VĂN HÓA','PB03')

INSERT INTO dbo.PHANCONG(MANV,MADA,SOGIO)
VALUES('1','DA 4','100')

INSERT INTO dbo.PHANCONG(MANV,MADA,SOGIO)
VALUES('15','DA 2','100')

INSERT INTO dbo.PHANCONG(MANV,MADA,SOGIO)
VALUES('3','DA 3','100')

UPDATE NHANVIEN
SET GT = N'NỮ'
WHERE MAPB = ""