CREATE DATABASE TAIKHOAN
USE TAIKHOAN

CREATE TABLE ACCOUNT(
	TAIKHOAN NVARCHAR(50),
	MATKHAU VARCHAR(20),
	TENHIENTHI NVARCHAR(50),
)

INSERT INTO ACCOUNT(TAIKHOAN, MATKHAU, TENHIENTHI) VALUES(N'test', 'test', N'test')
INSERT INTO ACCOUNT(TAIKHOAN, MATKHAU, TENHIENTHI) VALUES(N'admin', 'admin', N'admin')
select * from ACCOUNT

delete ACCOUNT where MATKHAU = 'test'



select * from ACCOUNT where TAIKHOAN = 'test'

create trigger kiemtra1 on ACCOUNT
for insert
as
declare @taikhoan NVARCHAR(50)
declare @matkhau VARCHAR(20)
declare @tenhienthi NVARCHAR(50)
select @taikhoan = TAIKHOAN, @matkhau = MATKHAU, @tenhienthi = TENHIENTHI FROM INSERTED
if exists (select @taikhoan from ACCOUNT)
ROLLBACK TRAN
else
print 'Đã thêm thành công'

drop trigger kiemtra1


