﻿CREATE DATABASE BANTIVI1
use BANTIVI1

CREATE TABLE NHANVIEN (
MANV CHAR(10) PRIMARY KEY,
HOTEN NCHAR(50) NOT NULL,
NGAYSINH DATE,
SDT INT
)

CREATE TABLE KHACHHANG (
MAKH CHAR(10) PRIMARY KEY,
TENKH NCHAR(50) NOT NULL,
DIACHI NCHAR(30),
SDT INT
)

CREATE TABLE NHASX (
MANSX CHAR(10)PRIMARY KEY,
TENNSX NCHAR(50) UNIQUE,
QUOCGIA NCHAR(30)
)

CREATE TABLE NHACC (
MANCC CHAR(10) PRIMARY KEY,
TENNCC NCHAR(50) UNIQUE,
DIACHI NCHAR(30),
SDT INT 
)

CREATE TABLE SANPHAM (
MASP CHAR(10) PRIMARY KEY,
TENSP NCHAR(20) NOT NULL,
MANSX CHAR(10) REFERENCES NHASX(MANSX),
GIA INT,
MANCC CHAR(10) REFERENCES NHACC(MANCC)
)

create proc xem_sp
as
begin
	select sanpham.masp, tensp, SANPHAM.MANSX, gia, tennsx, tenncc, ngaynhap
	from SANPHAM, NHASX, NHACC, HOADONNHAP
	where SANPHAM.MANSX = NHASX.MANSX and SANPHAM.MANCC = NHACC.MANCC and SANPHAM.MASP = HOADONNHAP.MASP
end

exec xem_sp

CREATE TABLE HOADONNHAP (
MAHDNHAP CHAR(10) PRIMARY KEY,
MANV CHAR(10) REFERENCES NHANVIEN(MANV),
MANCC CHAR(10) REFERENCES NHACC(MANCC),
NGAYNHAP DATE,
MASP CHAR(10) REFERENCES SANPHAM(MASP),
SOLUONG INT,
GTNHAP INT
)

CREATE TABLE HOADONBAN (
MAHDBAN CHAR(10) PRIMARY KEY,
MANV CHAR(10) REFERENCES NHANVIEN(MANV),
MAKH CHAR(10) REFERENCES KHACHHANG(MAKH),
NGAYXUAT DATE,
MASP CHAR(10) REFERENCES SANPHAM(MASP),
SOLUONG INT,
GTBAN INT
)

create proc thong_ke(@date_first date, @date_last date)
as
begin
	select SANPHAM.MASP, TENSP, HOADONBAN.MANV, HOADONBAN.MAKH, SOLUONG,  GTBAN from hoadonban, SANPHAM where HOADONBAN.MASP = SANPHAM.MASP and NGAYXUAT between @date_first and @date_last

end

exec thong_ke @date_first = '20171128', @date_last = '20171219'

select SANPHAM.MASP, TENSP, HOADONBAN.MANV, HOADONBAN.MAKH, SOLUONG,  GTBAN from hoadonban, SANPHAM where HOADONBAN.MASP = SANPHAM.MASP and NGAYXUAT between '20171128' and '20171219'

drop proc thong_ke

INSERT INTO NHANVIEN(MANV,HOTEN,SDT) VALUES ('111',N'Trường ngu','0948358454'),
('2',N'NGUYỄN VĂN HÙNG','19950319','0935939555'),
('3',N'LÊ THỊ HẠNH','19950517','0958396044'),
('4',N'TRẦN VÂN ANH','19970903','0948643960'),
('5',N'NGUYỄN NGỌC ANH','19970415','0938583964'),
('6',N'LÊ ANH HOÀNG','19961204','0933596040'),
('7',N'TRẦN THỊ YẾN','19971208','0939584646'),
('8',N'NGUYỄN THỊ LAN','19980801','0963670892')
select * from nhanvien
INSERT INTO NHASX(MANSX,TENNSX,QUOCGIA)
VALUES ('S1','SAMSUNG',N'HÀN QUỐC'),
('S2','SONY',N'NHẬT BẢN'),
('S3','ASANZO',N'VIỆT NAM'),
('S4','LG',N'HÀN QUỐC'),
('S5','PANASONIC',N'NHẬT BẢN')

INSERT INTO NHACC(MANCC,TENNCC,DIACHI,SDT)
VALUES ('C1','SAMSUNG VIETNAM',N'THÁI NGUYÊN','0947544444'),
('C2','SONY VIETNAM',N'HÀ NỘI','0973859396'),
('C3','ASANZO',N'HÀ NỘI','0944036859'),
('C4','LG VIETNAM',N'HÀ NỘI','0955743555'),
('C5','PANASONIC VIETNAM',N'HÀ NỘI','0948688888')

INSERT INTO KHACHHANG(MAKH,TENKH,DIACHI,SDT)
VALUES ('K1',N'LÊ THỊ HÀ',N'HÀ ĐÔNG, HÀ NỘI','0948586567'),
('K2',N'LÊ VĂN CƯỜNG',N'ĐỐNG ĐA, HÀ NỘI','0958359396'),
('K3',N'NGUYỄN THỊ LAN',N'HÀ ĐÔNG, HÀ NỘI','0938494964'),
('K4',N'TRẦN THỊ YẾN',N'HOÀN KIẾM, HÀ NỘI','0937584869'),
('K5',N'LÊ TRÂM ANH',N'CẦU GIẤY, HÀ NỘI','0948694960'),
('K6',N'NGUYỄN VĂN TIẾN',N'TP.BẮC NINH','0947388867'),
('K7',N'LÊ THỊ HẠNH',N'BA ĐÌNH, HÀ NỘI','0947853969'),
('K8',N'NGUYỄN VĂN HÙNG',N'HOÀN KIẾM, HÀ NỘI','0948583593')

INSERT INTO SANPHAM(MASP,TENSP,MANSX,GIA,MANCC)
VALUES ('A1','SONY XF32','S2','5000000','C2'),
('A2','SONY XS43','S2','10000000','C2'),
('A3','SONY XZ55','S2','20000000','C2'),
('A4','SAMSUNG QZ60','S1','18000000','C1'),
('A5','SAMSUNG QX65','S1','22000000','C1'),
('A6','LG LX49','S4','14000000','C4'),
('A7','LG LZ32','S4','7000000','C4'),
('A8','ASANZO AX43','S3','7999000','C3'),
('A9','ASANZO AZ32','S3','5000000','C3'),
('A10','PANSONIC PZ32','S5','7000000','C5'),
('A11','PANASONIC PX43','S5','14000000','C5')


INSERT INTO HOADONNHAP(MAHDNHAP,MANV,MANCC,NGAYNHAP,MASP,SOLUONG,GTNHAP)
VALUES ('P1','1','C1','20170918','A4','30',''),
('P2','1','C3','20170815','A8','40',''),
('P3','2','C2','20170922','A1','40',''),
('P4','6','C5','20171023','A11','30',''),
('P5','7','C1','20171109','A2','40',''),
('P6','4','C3','20171215','A9','50',''),
('P7','5','C5','20171119','A10','20',''),
('P8','3','C2','20171209','A3','30',''),
('P9','8','C5','20171224','A6','30',''),
('P10','4','C4','20171215','A7','50','')


INSERT INTO HOADONBAN(MAHDBAN,MANV,MAKH,NGAYXUAT,MASP,SOLUONG,GTBAN)
VALUES ('X1','1','K2','20171209','A1','1',''),
('X2','3','K3','20171219','A8','2',''),
('X3','2','K1','20171128','A2','1',''),
('X4','4','K4','20171204','A5','2',''),
('X5','6','K5','20171118','A7','1',''),
('X6','7','K6','20171228','A8','1',''),
('X7','2','K7','20171019','A9','2',''),
('X8','8','K8','20170930','A10','1','')
select * from HOADONNHAP

create proc xoa_sanpham
@ma char(10)
as
begin
	delete SANPHAM where @ma = MASP
end

exec xoa_sanpham @ma = 'A4'

delete SANPHAM where MASP = 'A4'

 

select * from NHANVIEN

create proc xem_nhacc
as
begin	
	select * from nhacc
end

exec xem_nhanvien

create proc xem_nhanvien
as
begin	
	select * from NHANVIEN
end


