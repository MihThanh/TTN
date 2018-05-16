CREATE DATABASE BANTIVI
use BANTIVI

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



CREATE TABLE NHACC (
MANCC CHAR(10) PRIMARY KEY,
TENNCC NCHAR(50) UNIQUE,
DIACHI NCHAR(30),
SDT INT 
)

CREATE TABLE SANPHAM (
MASP CHAR(10) PRIMARY KEY,
TENSP NCHAR(20) NOT NULL,
GIA INT,
MANCC CHAR(10) REFERENCES NHACC(MANCC)
)



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



INSERT INTO NHANVIEN(MANV,HOTEN,NGAYSINH,SDT)
VALUES ('1',N'LÊ THỊ ÁNH','19960221','0948358454'),
('2',N'NGUYỄN VĂN HÙNG','19950319','0935939555'),
('3',N'LÊ THỊ HẠNH','19950517','0958396044'),
('4',N'TRẦN VÂN ANH','19970903','0948643960'),
('5',N'NGUYỄN NGỌC ANH','19970415','0938583964'),
('6',N'LÊ ANH HOÀNG','19961204','0933596040'),
('7',N'TRẦN THỊ YẾN','19971208','0939584646'),
('8',N'NGUYỄN THỊ LAN','19980801','0963670892')

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

INSERT INTO SANPHAM(MASP,TENSP,GIA,MANCC)
VALUES ('A1','SONY XF32','5000000','C2'),
('A2','SONY XS43','10000000','C2'),
('A3','SONY XZ55','20000000','C2'),
('A4','SAMSUNG QZ60','18000000','C1'),
('A5','SAMSUNG QX65','22000000','C1'),
('A6','LG LX49','14000000','C4'),
('A7','LG LZ32','7000000','C4'),
('A8','ASANZO AX43','7999000','C3'),
('A9','ASANZO AZ32','5000000','C3'),
('A10','PANSONIC PZ32','7000000','C5'),
('A11','PANASONIC PX43','14000000','C5')


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



---proc tìm kiếm 
create proc Timkiem_sp (@ma CHAR(10))
as
begin
select * from SANPHAM
where MASP=@ma
end 

exec Timkiem_SP @ma='A3'

---PROC XÓA SP
CREATE PROC Xoa_sp(@ma CHAR(10))
AS
BEGIN
DELETE FROM SANPHAM
WHERE MASP=@ma
END

EXEC Xoa_sp @ma='A3'

--PROC THÊM SP
create proc Them_sp (@ma CHAR(10),@ten NCHAR(20),@gia INT ,@mancc char(10))
as
begin
INSERT INTO SANPHAM(MASP,TENSP,GIA,MANCC)
values(@ma,@ten,@gia,@mancc)
end

EXEC Them_sp @ma='',@ten='',@gia='',@mancc=''

---PROC SỬA SP
create proc Sua_sp (
                @ma CHAR(10),
				@ten nchar(20),
				@gia int,
				@mancc char(10)


			   )
as
begin
		update SANPHAM
		set	
			TENSP=@ten ,
			GIA=@gia,
			MANCC=@mancc 
		where MASP = @ma
end


EXEC Sua_sp @ma='',@ten='',@gia='',@mancc=''




---proc tìm kiếm nhân viên 

create proc Timkiem_nv(@ma char(10))
as
begin
select * from NHANVIEN
where MANV=@ma
end 

exec Timkiem_nv @ma=''

---PROC XÓA nv
CREATE PROC Xoa_nv (@ma CHAR(10))
AS
BEGIN
DELETE FROM NHANVIEN
WHERE MANV=@ma
END

EXEC Xoa_nv @ma=''

--PROC THÊM nv
create proc Them_nv (@ma CHAR(10),@ten NCHAR(50),@ngaysinh DATE ,@sdt int )
as
begin
INSERT INTO NHANVIEN(MANV,HOTEN,NGAYSINH,SDT)
values(@ma,@ten,@ngaysinh,@sdt)
end

EXEC Them_nv @ma='',@ten='',@ngaysinh='',@sdt=''

---PROC SỬA nv
create proc Sua_nv (
                @ma CHAR(10),
				@ten nchar(50),
				@ngaysinh date,
				@sdt int


			   )
as
begin
		update NHANVIEN
		set	
			HOTEN=@ten ,
			NGAYSINH=@ngaysinh,
			SDT=@sdt 
		where MANV = @ma
end


EXEC Sua_nv @ma='',@ten='',@ngaysinh='',@sdt=''


---proc tìm kiếm nhà cung cấp

create proc Timkiem_ncc(@ma char(10))
as
begin
select * from NHACC
where MANCC=@ma
end 

exec Timkiem_ncc @ma=''

---PROC XÓA SP
CREATE PROC Xoa_ncc (@ma CHAR(10))
AS
BEGIN
DELETE FROM NHACC
WHERE MANCC=@ma
END

EXEC Xoa_ncc @ma=''

--PROC THÊM ncc
create proc Them_ncc (@ma CHAR(10),@ten NCHAR(50),@diachi nchar(30) ,@sdt int )
as
begin
INSERT INTO NHACC(MANCC,TENNCC,DIACHI,SDT)
values(@ma,@ten,@diachi,@sdt)
end

EXEC Them_ncc @ma='',@ten='',@diachi='',@sdt=''

---PROC SỬA ncc
create proc Sua_ncc (
                @ma CHAR(10),
				@ten nchar(50),
				@diachi nchar(30),
				@sdt int


			   )
as
begin
		update NHANCC
		set	
			TENNCC=@ten,
			DIACHI=@diachi,
			SDT=@sdt 
		where MANCC = @ma
end


EXEC Sua_ncc @ma='',@ten='',@diachi='',@sdt=''

