create database SinhVien
use SinhVien

drop table Student 
drop table MonHoc
drop table CanBo
drop table Lop
drop table ThongTinGiangDay

create table Lop 
( 
	MaLop nvarchar(10) primary key,
	TenLop nvarchar(10) not null
);

create table Student (
	MSSV nvarchar(6) primary key,
	HoSV nvarchar(50) not null,
	TenSV nvarchar(10) not null,
	MaLop nvarchar(10) not null 
);

create table MonHoc (
	MaMon nvarchar(10) primary key,
	TenMon nvarchar(40) not null
);

create table CanBo 
(
	MaCB int primary key,
	TenCB nvarchar(50) not null,
	MatKhau int not null
);

create table ThongTinGiangDay 
(	
	MaCB int not null,
	MaMon nvarchar(10) not null,
	MaLop nvarchar(10) not null,
	constraint FK_maCB foreign key (MaCB) references CanBo(MaCB),
	constraint FK_maMon foreign key (MaMon) references MonHoc(MaMon),
	constraint FK_MaLop foreign key (MaLop) references Lop(MaLop)
);

insert into Lop values 
(N'K44-01', N'CNPM 01'),
(N'K44-02', N'CNPM 02'),
(N'K44-03', N'CNPM 03');

insert into Student values 
(N'B18001', N'Phạm Thị Bảo', N'Nhiên', N'K44-01'),
(N'B18002', N'Nguyễn Văn', N'An', N'K44-01'),
(N'B18003', N'Lê Hoài', N'Anh', N'K44-01'),
(N'B18004', N'Nguyễn Lâm Hoàng', N'Anh', N'K44-01'),
(N'B18005', N'Lê Minh', N'Bằng', N'K44-01'),
(N'B18006', N'Vương Thừa', N'Chấn', N'K44-02'),
(N'B18007', N'Cao Công', N'Danh', N'K44-02'),
(N'B18008', N'Trịnh Lê Long', N'Đức', N'K44-02'),
(N'B18009', N'Dương Lê Minh', N'Hậu', N'K44-02'),
(N'B18010', N'Nguyễn Vũ', N'Hoàng', N'K44-02'),
(N'B18011', N'Nguyễn Hoàng Thái', N'Học', N'K44-03'),
(N'B18012', N'Nguyễn Quốc', N'Huy', N'K44-03'),
(N'B18013', N'Võ Đoàn Gia', N'Huy', N'K44-03'),
(N'B18014', N'Vũ Thị Bích', N'Huyền', N'K44-03'),
(N'B18015', N'Hồ Việt', N'Hưng', N'K44-03');

insert into MonHoc values
(N'CT101', N'Lập trình căn bản'),
(N'CT103', N'Cấu trúc dữ liệu'),
(N'CT251', N'Phát triển ứng dụng trên Windows');

insert into CanBo values 
(001, N'Nguyễn Văn Cường', 123),
(002, N'Huỳnh Minh Phương', 123),
(003, N'Thái Cẩm Nhung', 123);

insert into ThongTinGiangDay values 
(001, N'CT101', N'K44-01'),
(001, N'CT101', N'K44-02'),
(001, N'CT103', N'K44-01'),
(001, N'CT103', N'K44-03'),
(002, N'CT101', N'K44-03'),
(002, N'CT103', N'K44-02'),
(003, N'CT251', N'K44-01'),
(003, N'CT251', N'K44-02'),
(003, N'CT251', N'K44-03');

select * from ThongTinGiangDay
select * from Student
select * from Lop
select * from CanBo







