
-- tạo tai khoan
create proc TaoTaiKhoan
	@usr nvarchar(50),
	@psw nvarchar(20)
as
	insert into Login values(@usr,@psw)
go

-- doi mat khau
create proc DoiMatKhau
	@usr nvarchar(50),
	@psw nvarchar(20)
as
	update Login set Password=@psw where UserName=@usr
go

-- Xoa tai khoan
create proc XoaTaiKhoan
	@usr nvarchar(50)
as 
	delete from Login where UserName=@usr
go

-- insert du lieu vào bảng nhân viên
create proc Insert_NV
	@manv nchar(10),
	@ht nvarchar(50),
	@ns date,
	@cmnd nchar(15),
	@gt nvarchar(5),
	@dc nvarchar(max),
	@dt nchar(15),
	@email varchar(50)
as
	insert into NhanVien values(@manv,@ht,@ns,@cmnd,@gt,@dc,@dt,@email)
go

-- update du lieu bảng Nhan Vien
create proc Update_NV
	@manv nchar(10),
	@ht nvarchar(50),
	@ns date,
	@cmnd nchar(15),
	@gt nvarchar(5),
	@dc nvarchar(max),
	@dt nchar(15),
	@email varchar(50)
as
	update NhanVien set TenNV=@ht,NgaySinh=@ns,CMND=@cmnd,GT=@gt,DiaChi=@dc,DienThoai=@dt,Email=@email where MaNV=@manv
go

--delete du lieu bang Nhan vien
create proc Delete_NV
	@manv nchar(10)
as
	Delete from NhanVien where MaNV=@manv
go

-- insert du lieu vao bang Loai Hang
create proc Insert_LoaiHang
	@malh nchar(10),
	@tenlh nvarchar(50)
as
	insert into LoaiHang values(@malh,@tenlh)
go

-- update du lieu bang Loai Hang
create proc Update_LoaiHang
	@malh nchar(10),
	@tenlh nvarchar(50)
as
	update LoaiHang set TenLH=@tenlh where MaLH=@malh
go

-- delete du lieu bang Loai Hang
create proc Delete_LoaiHang
	@malh nchar(10)
as
	delete from LoaiHang where MaLH=@malh
go

-- insert du lieu vào bảng NCC
create proc Insert_NCC
	@ma nchar(10),
	@ten nvarchar(50),
	@dc nvarchar(max),
	@dt nchar(15),
	@email varchar(50)
as
	insert into NhaCC values(@ma,@ten,@dc,@dt,@email)
go

-- update du lieu bảng NCC
create proc Update_NCC
	@ma nchar(10),
	@ten nvarchar(50),
	@dc nvarchar(max),
	@dt nchar(15),
	@email varchar(50)
as
	update NhaCC set TenNCC=@ten,DiaChi=@dc,DienThoai=@dt,Email=@email where MaNCC=@ma
go

-- delete du lieu bảng NCC
create proc Delete_NCC
	@ma nchar(10)
as
	delete from NhaCC where MaNCC=@ma
go

-- insert du lieu vào bảng KhachHang
create proc Insert_KhachHang
	@ma nchar(10),
	@ten nvarchar(50),
	@dc nvarchar(max),
	@dt nchar(15),
	@email varchar(50)
as
	insert into KhachHang values(@ma,@ten,@dc,@dt,@email)
go

-- update du lieu bảng Khach Hang
create proc Update_KhachHang
	@ma nchar(10),
	@ten nvarchar(50),
	@dc nvarchar(max),
	@dt nchar(15),
	@email varchar(50)
as
	update KhachHang set TenKH=@ten,DiaChi=@dc,DienThoai=@dt,Email=@email where MaKH=@ma
go

-- delete du lieu bảng Khach Hang
create proc Delete_KhachHang
	@ma nchar(10)
as
	delete from KhachHang where MaKH=@ma
go

-- insert du lieu vào bảng Kho
create proc Insert_Kho
	@ma nchar(10),
	@ten nvarchar(50),
	@dc nvarchar(max),
	@nvql nchar(10),
	@dt nchar(15)
as
	insert into Kho values(@ma,@ten,@dc,@nvql,@dt)
go

-- update du lieu bảng Kho
create proc Update_Kho
	@ma nchar(10),
	@ten nvarchar(50),
	@dc nvarchar(max),
	@nvql nchar(10),
	@dt nchar(15)
as
	update Kho set TenKho=@ten,DiaChi=@dc,NVQL=@nvql,DienThoai=@dt where MaKho=@ma
go

-- delete du lieu bảng Kho
create proc Delete_Kho
	@ma nchar(10)
as
	delete from Kho where MaKho=@ma
go

-- insert du lieu vào bảng Mat Hang
create proc Insert_MatHang
	@ma nchar(10),
	@ten nvarchar(50),
	@malh nchar(10),
	@dvt nvarchar(10)
as
	insert into MatHang values(@ma,@ten,@malh,@dvt)
go

-- update du lieu bảng Mat Hang
create proc Update_MatHang
	@ma nchar(10),
	@ten nvarchar(50),
	@malh nchar(10),
	@dvt nvarchar(10)
as
	update MatHang set TenHang=@ten,MaLH=@malh,DVT=@dvt where MaHang=@ma
go

-- delete du lieu bảng Mat Hang
create proc Delete_MatHang
	@ma nchar(10)
as
	delete from MatHang where MaHang=@ma
go

-- insert du lieu vào bảng Phieu Nhap
create proc Insert_PhieuNhap
	@ma nchar(10),
	@nv nchar(10),
	@ngay date,
	@ncc nchar(10),
	@kho nchar(10)
as
	insert into PhieuNhap values(@ma,@nv,@ngay,@ncc,@kho)
go

-- update du lieu bảng Phieu Nhap
alter proc Update_PhieuNhap
	@ma nchar(10),
	@nv nchar(10),
	@ngay date,
	@ncc nchar(10),
	@kho nchar(10)
as
	update PhieuNhap set MaNV=@nv,NgayNhap=@ngay,MaNCC=@ncc,MaKho=@kho where MaPN=@ma
go


-- delete du lieu bảng Phieu Nhap
create proc Delete_PhieuNhap
	@ma nchar(10)
as
	delete from PhieuNhap where MaPN=@ma
go

-- insert du lieu vào bảng Phieu Xuat
create proc Insert_PhieuXuat
	@ma nchar(10),
	@nv nchar(10),
	@ngay date,
	@kh nchar(10),
	@kho nchar(10)
as
	insert into PhieuXuat values(@ma,@nv,@ngay,@kh,@kho)
go

-- update du lieu bảng Phieu Xuat
alter proc Update_PhieuXuat
	@ma nchar(10),
	@nv nchar(10),
	@ngay date,
	@kh nchar(10),
	@kho nchar(10)
as
	update PhieuXuat set MaNV=@nv,NgayXuat=@ngay,MaKH=@kh,MaKho=@kho where MaPX=@ma
go

-- delete du lieu bảng Phieu Xuat
create proc Delete_PhieuXuat
	@ma nchar(10)
as
	delete from PhieuXuat where MaPX=@ma
go

-- insert du lieu vào bảng CTPN
alter proc Insert_CTPN
	@ma nchar(10),
	@mh nchar(10),
	@sl int,
	@dg float
as
begin
	declare @kho nchar(10)
	select @kho=MaKho from PhieuNhap where MaPN=@ma
	if exists(select * from CTMH where MaKho=@kho and MaHang=@mh)
		begin
		declare @slg int = 0 
		select @slg=SoLuong from CTMH where MaKho=@kho and MaHang=@mh
		declare @slc int =0
		set @slc=(@slg+@sl)
		insert into CTPN values(@ma,@mh,@sl,@dg)
		update CTMH set SoLuong=@slc where MaHang=@mh and MaKho=@kho
		end
	else
		Insert into CTMH values(@mh,@kho,@sl)
end
go

-- update du lieu bảng CTPN
alter proc Update_CTPN
	@ma nchar(10),
	@mh nchar(10),
	@sl int,
	@dg float
as
begin
	declare @kho nchar(10), @slg_kho int, @slbd int
	select @kho=MaKho from PhieuNhap where MaPN=@ma
	select @slg_kho=SoLuong from CTMH where MaKho=@kho and MaHang=@mh
	select @slbd=SoLuong from CTPN where MaPN=@ma and MaHang=@mh
	declare @slc int = (@slg_kho-@slbd+@sl)
	update CTPN set SoLuong=@sl,DonGia=@dg where MaPN=@ma and MaHang=@mh
	update CTMH set SoLuong=@slc where MaKho=@kho and MaHang=@mh
end
go

-- delete du lieu bảng CTPN
alter proc Delete_CTPN
	@ma nchar(10),
	@mh nchar(10)
as
begin
	declare @kho nchar(10), @slg_kho int = 0, @slbd int = 0, @slc int=0 
	select @kho=MaKho from PhieuNhap where MaPN=@ma
	select @slg_kho=SoLuong from CTMH where MaKho=@kho and MaHang=@mh
	select @slbd=SoLuong from CTPN where MaPN=@ma and MaHang=@mh
	set @slc = (@slg_kho-@slbd)
	delete from CTPN where MaPN=@ma and MaHang=@mh
	if (@slc=0) Delete from CTMH where MaHang = @mh and MaKho = @kho
	else 
		update CTMH set SoLuong=@slc where MaHang=@mh and MaKho=@kho
end
go


-- insert du lieu vào bảng CTPX
alter proc Insert_CTPX
	@ma nchar(10),
	@mh nchar(10),
	@sl int,
	@dg float
as
begin
	declare @kho nchar(10), @slg int = 0
	select @kho=MaKho from PhieuXuat where MaPX=@ma
	select @slg=SoLuong from CTMH where MaKho=@kho and MaHang=@mh
	declare @slc int =(@slg-@sl)
	insert into CTPX values(@ma,@mh,@sl,@dg)
	if (@slc=0) Delete from CTMH where MaHang = @mh and MaKho = @kho
	else update CTMH set SoLuong=@slc where MaHang=@mh and MaKho=@kho
end
go

-- update du lieu bảng CTPX
alter proc Update_CTPX
	@ma nchar(10),
	@mh nchar(10),
	@sl int,
	@dg float
as
begin
	declare @kho nchar(10), @slKho int = 0, @slbd int = 0
	select @kho=MaKho from PhieuXuat where MaPX=@ma
	if not exists(select * from CTMH where MaKho=@kho and MaHang=@mh)
		set @slKho=0
	else 
		select @slKho=SoLuong from CTMH where MaKho=@kho and MaHang=@mh
	select @slbd=SoLuong from CTPX where MaHang=@mh and MaPX=@ma
	declare @slc int = 0
	set @slc=(@slkho+@slbd-@sl)
	update CTPX set SoLuong=@sl,DonGia=@dg where MaPX=@ma and MaHang=@mh
	if (@slc=0) Delete from CTMH where MaHang = @mh and MaKho = @kho
	else update CTMH set SoLuong=@slc where MaHang=@mh and MaKho=@kho
end
go

-- delete du lieu bảng CTPX
alter proc Delete_CTPX
	@ma nchar(10),
	@mh nchar(10)
as
begin
	declare @kho nchar(10), @slbd int = 0
	select @kho=MaKho from PhieuXuat where MaPX=@ma
	select @slbd=SoLuong from CTPX where MaPX=@ma and MaHang=@mh
	if exists(select * from CTMH where MaKho=@kho and MaHang=@mh)
		begin 
		declare @slg_kho int = 0
		select @slg_kho=SoLuong from CTMH where MaKho=@kho and MaHang=@mh
		declare @slc int =(@slg_kho+@slbd)
		Delete from CTPX where MaPX=@ma and MaHang=@mh
		update CTMH set SoLuong=@slc where MaHang=@mh and MaKho=@kho 
		end
	else 
		begin
		Delete from CTPX where MaPX=@ma and MaHang=@mh
		Insert into CTMH values(@mh,@kho,@slbd)
		end
end
go

-- insert du lieu vào bảng CTMH
alter proc Insert_CTMH
	@ma nchar(10),
	@kho nchar(10),
	@sl int
as
	insert into CTMH values(@ma,@kho,@sl)
go

-- update du lieu bảng CTMH
alter proc Update_CTMH
	@ma nchar(10),
	@kho nchar(10),
	@sl int
as
	update CTMH set SoLuong=@sl where MaHang=@ma and MaKho=@kho
go

-- delete du lieu bảng CTMH
alter proc Delete_CTMH
	@ma nchar(10),
	@kho nchar(10)
as
	delete from CTMH where MaHang=@ma and MaKho=@kho
go
