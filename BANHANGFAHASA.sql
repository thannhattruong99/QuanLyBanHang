CREATE DATABASE BANHANGFAHASA
USE  BANHANGFAHASA

Create table ChucVu
(
	MaCV nchar(6) not null
		Constraint PK_MaCv_ChucVu primary key,
	TenCV nvarchar(100)
)

Insert into  ChucVu
		values ('CV0001',N'Trưởng bộ phận bán hàng'),
				('CV0002',N'Nhân viên bán hàng'),
				('CV0003',N'Nhân viên thu ngân'),
				('CV0004',N'Nhân viên kho')
Create table DonVi
(
	MaDV nchar(6) not null
		Constraint PK_MaDV_DonVi primary key,
	TenDV nvarchar(100)
)
Insert into  DonVi
		values ('CN0001',N'Cuốn'),
				('CA0002',N'Cây'),
				('HO0003',N'Hộp'),
				('CI0004',N'Cái'),
				('DV0005',N'Thùng')
			Insert into  DonVi
		values ('DV0007',N'chai')

create table LoaiHang
(
MaLoaiHang nchar(6) not null
constraint PK_MaLoaiHang_LoaiHang primary key,
TenLoaiHang nvarchar(50)
)

Insert into  LoaiHang
		values ('LH0001',N'Sách nước ngoài'),
				('LH0002',N'Sách giáo khoa'),
				('LH0003',N'Truyện tranh'),
				('LH0004',N'Dụng cụ học tập'),
				('LH0005',N'Văn phòng phẩm'),
				('LH0006',N'SP làm đẹp')

Create table KhachHang
(
	MaKH nchar(6) not null
		Constraint PK_MaKH_KhachHang primary key,
	HoTenKH nvarchar(100),
	DiaChiKH nvarchar(150)
		Constraint DF_DiaChi_KhachHang Default N'Không có thông tin', 
	SDTKH nvarchar(20)
)
Insert into KhachHang
Values	('KH0001', N'Nguyễn Thị Minh Ngọc', N'123/6 bis Lê Thánh Tôn, Q1, Tp.HCM', '098123123'),
		('KH0002', N'Trần Anh Tuấn', N'49/12B Nguyễn Thị Minh Khai, Q1, Tp.HCM', '091321321'),
		('KH0003', N'Lê Nam Anh',  N'Ngõ 6, phố Thanh Xuân, Hà Nội', '090312312'), 
		('KH0004', N'Nguyễn Quốc Khánh',  N'67 bis Nguyễn Thượng Hiền, Q.Bình Thạnh, Tp.HCM','090812812'),
		('KH0005', N'Lâm Thị Thủy',  N'22 Lê Quý Đôn, Bình Thọ, Thủ Đức, Tp.HCM','032223344'),
		('KH0006', N'Nguyễn Hồng Ngọc',  N'8 đường 442, p Tăng Nhơn Phú A, quận 9, Tp.HCM','082358344'),
		('KH0007', N'Trần Huy Hoàng',  N'241 Ni Sư Huỳnh Liên, phường 3,Tân Bình Tp.HCM','0376444534'),
		('KH0008', N'Phạm Thị Thanh Huyền', N'54/2/7 Bàu Cát, p10, Tân Bình, Tp.HCM','0564234111'),
		('KH0009', N'Hoàng THị Thùy TRang', N'542/11 Võ Văn Ngân, p Bình Chiểu, Thủ Đức, Tp.HCM','0987333278'),
		('KH0010', N'Nguyễn Thị Thủy', N'14 Lê Văn Việt, p Tăng Nhơn Phú A, Q9, Tp.HCM ','0947895878'),
		('KH0011', N'Nguyễn Mạnh Hùng',  N'456 Trần Xuân Soạn, p Tân Kiểng, Q7, Tp.HCM','02623586221'),
		('KH0012', N'Tôn Nữ Bảo Nhi', N'227/3/8, P.1, Q3, Tp.HCM','0984166876'),
		('KH0013', N'Phạm Hồng Hương', N'14 Thành Thái , P14, Q10, TP.HCM','0935558175'),
		('KH0014', N'Trần Uy Vũ',  N'215 Điện Biên Phủ, Phường 15, Quận Bình Thạnh,Tp.HCM','0365558175'),
		('KH0015', N'Nguyễn Nam Khá',  N'229/4/8 Tây Thạnh, Phường Tây Thạnh, Quận Tân Phú, Tp.HCM','0982244007'),
		('KH0016', N'Đoàn Huyền Trang',  N'59 Hồ Hảo Hớn, Phường Cô Giang, Quận 1, TP.HCM','0987653333'),
		('KH0017', N'Nguyễn Khánh Linh',  N'40 Phó Đức Chính, Phường Nguyễn Thái Bình, Quận 1, Hồ Chí Minh','0876124657'),
		('KH0018', N'Nguyễn Cao Hoàng Bách',  N'40/19A Đường Ấp Bắc, Phường 13, Tân Bình, Hồ Chí Minh','0876124657'),
		('KH0019', N'Đào Minh Quân',  N'88 Phạm Văn Hai, Phường 3, Tân Bình, Hồ Chí Minh','0876124657'),
		('KH0020', N'Nguyễn Cao Huy Hiệu', N'58b Nguyễn Đình Chiểu, Đa Kao, Hồ Chí Minh, Đa Kao Quận 1 Hồ Chí Minh','0876124657')				
Create Table NhanVien
(
MaNV nchar(6) Not Null
	Constraint PK_MaNV_NhanVien Primary Key,
HoTenNV nvarchar(100) ,
NgaySinhNV DateTime,
GioiTinh nvarchar(20) 
	Constraint Ck_GioiTinh_NhanVien Check( GioiTinh in('Nam', N'Nữ', N'Khác')),
DiaChi nvarchar(200)
	Constraint DF_DiaChi_NhanVien Default N'Chưa nhập thông tin',
SDTNV nvarchar (30),
--NgayBD datetime,
--TaiKhoan nvarchar(50),
--MatKhau nvarchar(30),
--NgayCapTK datetime,
MaCV nchar(6) not null
	constraint FK_MaCV_NhanVien foreign key (MaCV) references ChucVu	
)

Insert Into NhanVien
Values('NV0001',N'Lê Thị Cúc',Convert(datetime,'05/04/1989'),N'Nữ',N'19 Lê Văn Việt, phường Hiệp Phú, quận 9, TP. HCM','092987987','CV0001')
	Insert Into NhanVien
Values('NV0002',N'Hoàng Bảo Nguyên',Convert(datetime,'11/02/1996'),N'Nam',N'330 Nguyễn Trọng Tuyển, Phường 2, Tân Bình, Hồ Chí Minh','0985533321','CV0002')
	Insert Into NhanVien
Values('NV0003',N'Phạm Thị Thanh Hương',Convert(datetime,'05/25/1997'),N'Nữ',N'58b Nguyễn Đình Chiểu, Đa Kao, Hồ Chí Minh, Đa Kao Quận 1 Hồ Chí Minh','092987987','CV0003')
	Insert Into NhanVien
Values('NV0004',N'Bùi Vũ Thu Uyên',Convert(datetime,'03/07/1993'),N'Nữ',N'225/1 Đường Số 8, Phường Bình Hưng Hòa, Quận Bình Tân,Tp. Hồ Chí Minh','0334489093','CV0004')
	Insert Into NhanVien
Values('NV0005',N'Nguyễn Thị Mỹ Duyên',Convert(datetime,'05/03/1992'),N'Nữ',N'433, đường Đỗ Xuân Hợp, phường Phước Long B, quận 9, TP.HCM','0324567111','CV0003')
	Insert Into NhanVien
Values('NV0006',N'Nguyễn Khánh Sơn',Convert(datetime,'06/11/1990'),N'Nữ',N'20 Lã Xuân Oai, phường Tăng Nhơn Phú A, quận 9, TP.HCM','0987555323','CV0002')
	Insert Into NhanVien
Values('NV0007',N'Hoàng Ngọc Thanh Bình',Convert(datetime,'02/06/1994'),N'Nam',N'1256 Võ Văn Kiệt, P.10, Q.5, TP.HCM','0972290000','CV0004')
	Insert Into NhanVien
Values('NV0008',N'Vũ Công Huy Hoàng',Convert(datetime,'08/08/1994'),N'Nam',N'877 Kha Vạn Cân, P.Linh Tây , Q.Thủ Đức, TP.HCM','037222998','CV0002')
	Insert Into NhanVien
Values('NV0009',N'Trần Hoàng Anh Tú',Convert(datetime,'03/10/1990'),N'Nam',N'367A Phan Đình Phùng, P.15, Q. Phú Nhuận, TP.HCM','082332724','CV0003')
	Insert Into NhanVien
Values('NV0010',N'Nguyễn Trần Thanh Sang',Convert(datetime,'12/03/1995'),N'Nam',N'540 Trần Hưng Đạo, P.2, Q.5, TP.HCM','0983344676','CV0002')
	
Create table MatHang
(
MaMH nchar(6) not null
constraint PK_MaMh_MatHang primary key,
TenMH nvarchar(150) not null,
SlTon int,
GiaNhap float,
GiaBan float,
--Mota nvarchar (300),
MaLoaiHang nchar(6) not null
constraint FK_MaLoaiHang_MatHang foreign key (MaLoaiHang) references LoaiHang,
MaDV nchar(6) not null
	constraint FK_MaDV_MatHang foreign key (MaDV) references DonVi
)
	--('LH0001',N'Sách nước ngoài'),
	--			('LH0002',N'Sách giáo khoa'),
	--			('LH0003',N'Truyện tranh'),
	--			('LH0004',N'Dụng cụ học tập'),
	--			('LH0005',N'Văn phòng phẩm'),
	----			('LH0006',N'SP làm đẹp')
	--values ('DV0007',N'chai')
Insert into  MatHang
		values ('MH0101',N'Sách giáo khoa lớp 1','1000','120000','200000', 'LH0002','CN0001'),
				('MH0102',N'Sách giáo khoa lớp 2 ','3000','30000','600000', 'LH0002','CN0001'),
				('MH0103',N'Truyện Conan','500','250000','350000', 'LH0003','CN0001'),
				('MH0104',N'Truyện tranh nhật bản Doraemon','1500','150000','240000', 'LH0003','CN0001'),
				('MH0105',N'Truyện tấm cám','1200','160000','270000', 'LH0006','CN0001'),
				('MH0201',N'Mặt nạ','20000','10000','18000', 'LH0002','CI0004'),
				('MH0202',N'Sữa rửa mặt ','5000','120000','200000', 'LH0006','DV0007'),
				('MH0203',N'Tẩy da chết','500','90000','150000',  'LH0006','HO0003'),
				('MH0204',N'Kem chống nắng','10000','110000','200000',  'LH0006','DV0007'),
				('MH0205',N'Bút bi','4300','130000','190000',  'LH0005','CA0002'),
				('MH0301',N'Bút chì','6000','80000','160000',  'LH0005','CA0002'),
				('MH0302',N'Viết xóa','5000','110000','200000','LH0005','CA0002'),
				('MH0303',N'Kim bấm giấy','500','70000','150000',  'LH0005','CA0002'),
				('MH0402',N'Mực viết','2000','25000','45000', 'LH0005','HO0003'),
				('MH0403',N'Bút tô màu','1800','10000','20000',  'LH0005','HO0003'),
				('MH0501',N'Hồ dán','300','350000','600000',  'LH0005','HO0003'),
				('MH0502',N'Hộp bút','600','350000','600000', 'LH0004','CI0004'),
				('MH0503',N'Gôm tẩy xóa','12000','130000','250000', 'LH0004','CI0004'),
				('MH0601',N'Bảng ','500','80000','140000',  'LH0004','CI0004'),
				('MH0602',N'Tập trắng có ô li','600','75000','130000',  'LH0004','DV0005'),
				('MH0603',N'File đựng tài liệu','600','75000','130000',  'LH0004','DV0005'),
				('MH0604',N'Máy tính điện tử','600','75000','130000',  'LH0004','DV0005')

Create table HoaDon
(
	MaHD nchar(6) not null
		constraint PK_MaHD_HoaDon Primary Key,
	MaKH nchar(6) not null
	constraint FK_MaKH_Hoadon foreign key (MaKH) references KhachHang,	
	MaNV nchar(6) not null
	constraint FK_MaNV_HOaDon foreign key (MaNV) references NhanVien,
	NgayLHD datetime,
	PTTT nvarchar(100)
)
Insert into  HoaDon
		values ('HD0001','KH0001','NV0002',Convert(datetime,'12/01/2020'),N'Tiền mặt'),
				('HD0002','KH0002','NV0006',Convert(datetime,'12/01/2020'),N'Tiền mặt'),
				('HD0003','KH0003','NV0008',Convert(datetime,'12/01/2020'),N'Thẻ'),
				('HD0004','KH0004','NV0010',Convert(datetime,'12/01/2020'),N'Tiền mặt'),
				('HD0005','KH0005','NV0002',Convert(datetime,'12/02/2020'),N'Thẻ'),
				('HD0006','KH0006','NV0006',Convert(datetime,'12/02/2020'),N'Tiền mặt'),
				('HD0007','KH0007','NV0008',Convert(datetime,'12/02/2020'),N'Tiền mặt'),
				('HD0008','KH0008','NV0010',Convert(datetime,'12/02/2020'),N'Tiền mặt'),
				('HD0009','KH0009','NV0002',Convert(datetime,'12/03/2020'),N'Thẻ'),
				('HD0010','KH0010','NV0006',Convert(datetime,'12/03/2020'),N'Tiền mặt'),
				('HD0011','KH0011','NV0008',Convert(datetime,'12/04/2020'),N'Tiền mặt'),
				('HD0012','KH0012','NV0010',Convert(datetime,'12/04/2020'),N'Thẻ'),
				('HD0013','KH0013','NV0002',Convert(datetime,'12/05/2020'),N'Tiền mặt'),
				('HD0015','KH0014','NV0006',Convert(datetime,'12/05/2020'),N'Thẻ'),
				('HD0016','KH0015','NV0008',Convert(datetime,'12/06/2020'),N'Tiền mặt'),
				('HD0017','KH0016','NV0010',Convert(datetime,'12/07/2020'),N'Tiền mặt'),
				('HD0018','KH0001','NV0010',Convert(datetime,'12/08/2020'),N'Tiền mặt'),
				('HD0019','KH0002','NV0002',Convert(datetime,'12/08/2020'),N'Tiền mặt'),
				('HD0020','KH0003','NV0006',Convert(datetime,'12/09/2020'),N'Thẻ')
					
Create table ChiTietDonHang
(
	MaHD nchar(6) not null
		constraint FK_MaHD_ChiTietHoaDon Foreign Key (MaHD) references HoaDon,
	MaMH nchar(6) not null
		constraint FK_MaMH_ChiTietHoaDon Foreign Key (MaMH) references MatHang,
	SLDat int ,
	GiaBan float,
		constraint PK_MaHD_MaMH_ChiTietDonHang Primary Key (MaHD, MaMH)
)
Insert into  ChiTietDonHang
		values ('HD0001','MH0101','1','200000')	
Insert into  ChiTietDonHang
		values('HD0001','MH0201','1','18000')	
Insert into  ChiTietDonHang
		values('HD0002','MH0202','2','200000')
Insert into  ChiTietDonHang
		values('HD0002','MH0101','2','200000')
Insert into  ChiTietDonHang
		values('HD0003','MH0102','1','60000')
Insert into  ChiTietDonHang
		values('HD0003','MH0105','1','270000')
Insert into  ChiTietDonHang
		values('HD0003','MH0101','1','200000')
Insert into  ChiTietDonHang
		values('HD0004','MH0601','1','130000')
Insert into  ChiTietDonHang
		values('HD0005','MH0201','15','18000')
Insert into  ChiTietDonHang
		values('HD0006','MH0301','1','160000')
				Insert into  ChiTietDonHang
		values('HD0006','MH0302','1','200000')
				Insert into  ChiTietDonHang
		values('HD0007','MH0502','1','600000')
				Insert into  ChiTietDonHang
		values('HD0008','MH0101','1','200000')
				Insert into  ChiTietDonHang
		values('HD0008','MH0102','1','60000')
				Insert into  ChiTietDonHang
		values('HD0008','MH0103','1','350000')
				Insert into  ChiTietDonHang
		values('HD0008','MH0104','1','240000')
				Insert into  ChiTietDonHang
		values('HD0008','MH0105','1','270000')
				Insert into  ChiTietDonHang
		values('HD0009','MH0402','5','45000')
				Insert into  ChiTietDonHang
		values('HD0009','MH0403','1','20000')
				Insert into  ChiTietDonHang
		values('HD0010','MH0602','1','130000')
				Insert into  ChiTietDonHang
		values('HD0010','MH0105','1','270000')
				Insert into  ChiTietDonHang
		values('HD0010','MH0302','1','200000')
				Insert into  ChiTietDonHang
		values('HD0011','MH0203','2','150000')
				Insert into  ChiTietDonHang
		values('HD0012','MH0502','1','600000')
				Insert into  ChiTietDonHang
		values('HD0013','MH0101','2','200000')
				Insert into  ChiTietDonHang
		values('HD0013','MH0204','1','200000')
				Insert into  ChiTietDonHang
		values('HD0013','MH0205','1','190000')
				Insert into  ChiTietDonHang
		values('HD0014','MH0503','1','250000')
				Insert into  ChiTietDonHang
		values('HD0014','MH0601','2','140000')
				Insert into  ChiTietDonHang
		values('HD0015','MH0502','1','600000')
				Insert into  ChiTietDonHang
		values('HD0016','MH0303','1','150000')
				Insert into  ChiTietDonHang
		values('HD0016','MH0301','1','160000')
				Insert into  ChiTietDonHang
		values('HD0017','MH0602','2','130000')
				Insert into  ChiTietDonHang
		values('HD0018','MH0503','1','250000')
				Insert into  ChiTietDonHang
		values('HD0019','MH0205','1','190000')
				Insert into  ChiTietDonHang
		values('HD0020','MH0105','1','270000')
				Insert into  ChiTietDonHang
		values('HD0020','MH0201','10','18000')
				Insert into  ChiTietDonHang
		values('HD0020','MH0202','1','200000')
				Insert into  ChiTietDonHang
		values('HD0020','MH0203','1','150000')
				Insert into  ChiTietDonHang
		values('HD0020','MH0204','1','200000')

Create table CTKhuyenMai
(
	MaKM nchar(6) not null
		Constraint PK_MaKM_CTKM primary key,
	TenKM nvarchar(100),
	NgayBD datetime,
	NgayKT datetime
)

Insert into  CTKhuyenMai
		values ('KM0001',N'Sale Black Friday',Convert(datetime,'11/20/2020'),Convert(datetime,'11/27/2020')),
				('KM0002',N'Sale 12.12',Convert(datetime,'12/10/2020'),Convert(datetime,'12/12/2020')),
				('KM0003',N'Sinh nhật FAHASA',Convert(datetime,'05/05/2020'),Convert(datetime,'05/12/2020')),
				('KM0004',N'Siêu sale cuối năm',Convert(datetime,'12/24/2020'),Convert(datetime,'12/30/2020')),
				('KM0005',N'Sale 69%',Convert(datetime,'11/01/2020'),Convert(datetime,'11/03/2020')),
				('KM0006',N'Tri ân khách hàng',Convert(datetime,'10/01/2020'),Convert(datetime,'11/01/2020'))
	
Create table ChiTietCTKM
(
	MaKM nchar(6) not null
		constraint FK_MaKM_ChiTietCTKM Foreign Key (MaKM) references CTKHuyenMai,
	MaMH nchar(6) not null
		constraint FK_MaMH_ChiTietCTKM Foreign Key (MaMH) references MatHang,
	Giatri float,
	Hientrang nvarchar(50),
	constraint PK_MaKM_MaMHChiTietCTKM Primary Key (MaKM, MaMH)
)
Insert into  ChiTietCTKM
		values ('KM0001','MH0101','20','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0001','MH0202','11','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0001','MH0104','9','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0001','MH0403','30','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0001','MH0502','20','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0002','MH0602','21','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0002','MH0203','41','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0002','MH0202','30','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0002','MH0402','79','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0002','MH0101','19','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0002','MH0503','20','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0002','MH0502','12','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0002','MH0601','50','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0401','89','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0502','50','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0303','50','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0302','38','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0301','35','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0205','33','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0204','31','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0203','29','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0202','25','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0201','22','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0105','19','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0104','15','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0103','12','Kết thúc')
				Insert into  ChiTietCTKM
		values('KM0004','MH0102','10','Kết thúc')
