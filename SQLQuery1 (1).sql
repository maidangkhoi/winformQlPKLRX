create database QLxe2
use QLxe2

create table nhacungcap(
	maNCC nvarchar(10),
	tennhacungcap char(10),
	xuatxu char(15)
	constraint pk_ncc primary key(maNCC)
)

insert into nhacungcap values('NCC1','honda','VN'),('NCC2','suzuki','USA')

create table loaiphukien(
	maLPK nvarchar(10),
	tenloai nvarchar(10),
	constraint pk_lpk primary key(maLPK)
)
insert into loaiphukien values('D',N'Đầu xe'),('B',N'Bánh xe'),('DD',N'Đuôi xe'),('M',N'Máy xe'),('T',N'Thân xe'),('DH',N'Đồng hồ xe'),('DC',N'Động cơ xe')
create table phukien(
	maPK nvarchar(10),
	maLPK nvarchar(10),
	maNCC nvarchar(10),
	tenPK nvarchar(20),
	dvt nvarchar (10),
	soluong int,
 constraint pk_pk primary key(maPK)
)
insert into phukien values('PK01','D','NCC1',N'Đầu xe 1','cái',10),('PK02','D','NCC2',N'Đầu xe 2','cái',10),('PK03','B','NCC1',N'Bánh xe 1','cái',10),('PK04','B','NCC2',N'Bánh xe 2','cái',10),('PK05','DD','NCC1',N'Đuôi xe 1','cái',10),('PK06','DD','NCC2',N'Đuôi xe 2','cái',10),('PK07','M','NCC1',N'Máy xe 1','cái',10),('PK08','M','NCC2',N'Máy xe 2','cái',10),('PK09','T','NCC1',N'Thân xe 1','cái',10),('PK010','T','NCC1',N'Thân xe 2','cái',10),('PK011','DH','NCC1',N'Đồng hồ xe 1','cái',10),('PK012','DH','NCC1',N'Đồng hồ xe 2','cái',10),('PK013','DC','NCC1',N'Động cơ xe 1','cái',10),('PK014','DC','NCC1',N'Động cơ xe 2','cái',10)
update phukien set maLPK = ,maNCC = '',tenPK = '',dvt = ,soluong = where maPK = 
select soluong from phukien where maPK = 
drop table phukien
create table xe(
	maXe nvarchar(10),
	tenxe nvarchar(20),
	constraint pk_x primary key(maXe)
)
insert into xe values('X5','Vision'),('X2','Wave'),('X3','SH')
drop table chitietxe
create table chitietxe(
	machitietxe int identity(1,1) primary key,
	maXe nvarchar(10),
	maPK nvarchar(10)
)
insert into chitietxe values ('X1','PK01'),('X1','PK03'),('X1','PK05'),('X1','PK07'),('X1','PK09'),('X1','PK011'),('X1','PK013'),('X2','PK02'),('X2','PK04'),('X2','PK06'),('X2','PK08'),('X2','PK010'),('X2','PK012'),('X2','PK014'),('X3','PK01'),('X3','PK03'),('X3','PK05'),('X3','PK07'),('X3','PK09'),('X3','PK011'),('X3','PK013')

select * from chitietxe
create table tholaprap(
	mataikhoan nvarchar(10),
	maTho nvarchar(10),
	tentho nvarchar(20),
	tinhtrang nvarchar (10)
	constraint pk_tlr primary key(maTho)
)
insert into tholaprap values('T1','T1',N'Thợ 1',N'rảnh'),('T2','T2',N'Thợ 2',N'rảnh'),('T3','T3',N'Thợ 3',N'bận')
create table phancong(
	maPC int IDENTITY(1,1),
	maXe nvarchar(10),
	maTho nvarchar(10),
	tinhtrang nvarchar(20)
	constraint pk_pc primary key(maPC)
)

insert into phancong values((select maXe from xe where tenxe = 'sh'),(select maTho from tholaprap where tentho = N'thợ 3'),N'Chưa hoàn thành')
select * from phancong
delete phancong where maPC = 1

DROP TABLE phancong
create table phanconglaprap(
	maPK nvarchar(10),
	maLPK nvarchar(10),
	maTho nvarchar(10),
	maPC  nvarchar(10),
 constraint pk_pclr primary key(maPC)
 )

create table nhanvien(
	mataikhoan nvarchar(10),
	taikhoan nvarchar(20),	
	matkhau nvarchar(10),
	quyen int,
	constraint pk_nv primary key(mataikhoan)
)

insert into nhanvien values('T0','admin','1234',1),('T3','thoT3','1234',1)
select * from nhanvien where taikhoan = 'admin' and matkhau = '1234'
--ALTER TABLE chitietxe add constraint fk_ctx_x foreign key(maXe) REFERENCES xe(maXe)
--ALTER TABLE chitietxe add constraint fk_ctx_pk foreign key(maPK) REFERENCES phukien(maPK)
--ALTER TABLE loaiphukien add constraint fk_lpk_ncc foreign key(maNCC) REFERENCES nhacungcap(maNCC)
--ALTER TABLE phukien add constraint fk_pk_lpk foreign key(maLPK) REFERENCES loaiphukien(maLPK)
--ALTER TABLE phanconglaprap add constraint fk_pclr_pk foreign key(maPK) REFERENCES phukien(maPK)
--ALTER TABLE phanconglaprap add constraint fk_pclr_pc foreign key(maPC) REFERENCES phancong(maPC)
--ALTER TABLE xe add constraint fk_x_pc foreign key(maPC) REFERENCES phancong(maPC)
--ALTER TABLE phancong add constraint fk_pc_t foreign key(maTho) REFERENCES tholaprap(maTho)
--ALTER TABLE phancong add constraint fk_pc_x foreign key(maXe) REFERENCES xe(maXe)

ALTER TABLE phukien add constraint fk_pk_lpk foreign  key (maLPK) references loaiphukien(maLPK),
constraint fk_pk_ncc foreign  key (maNCC) references nhacungcap(maNCC)
 
ALTER TABLE chitietxe add constraint fk_ctx_x foreign  key (maXe) references xe(maXe),
constraint fk_ctx_pk foreign  key (maPK) references phukien(maPK)

ALTER TABLE phancong add constraint fk_pc_x foreign  key (maXe) references xe(maXe),
constraint fk_pc_t foreign  key (maTho) references tholaprap(maTho)



ALTER TABLE phancong
DROP CONSTRAINT fk_pc_t;

select * from 
update tholaprap set tentho = 'thợ 4',tinhtrang = 'ban' where maTho = 'T4'
delete tholaprap where maTho =

select pc.maPC,pc.maXe,x.tenxe,pc.maTho,tlr.tentho,pc.tinhtrang from phancong pc join tholaprap tlr on pc.maTho = tlr.maTho join xe x on pc.maXe = x.maXe where tlr.maTho = 't3'

SELECT tentho FROM tholaprap where tinhtrang = 'rảnh'

SELECT x.tenxe, pc.maPC,tlr.tentho,pc.tinhtrang from  xe x join phancong pc on pc.maXe=x.maXe join tholaprap tlr on tlr.maTho=pc.maTho

SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= 'airblade' and pk.maLPK = 'D'

update tholaprap set tinhtrang = N'rảnh' where tentho = N'thợ 2'
select soluong from phukien

select pc.maPC,pc.maXe,x.tenxe,pc.maTho,tlr.tentho,pc.tinhtrang from phancong pc join tholaprap tlr on pc.maTho = tlr.maTho join xe x on pc.maXe = x.maXe
select x.tenxe,pk.tenPK from xe x join chitietxe ctx on x.maXe = ctx.maXe join phukien pk on ctx.maPK = pk.maPK where x.maXe = 'x1'
IF (NOT EXISTS(SELECT * FROM chitietxe WHERE maXe = (select maXe from xe where tenxe = 'sh mode')) ) BEGIN INSERT INTO chitietxe VALUES((select maXe from xe where tenxe = 'sh mode'),(select maPK from phukien where tenPK = N'Đầu xe 1')), ((select maXe from xe where tenxe = 'sh mode'),(select maPK from phukien where tenPK = N'Đuôi xe 1')), ((select maXe from xe where tenxe = 'sh mode'),(select maPK from phukien where tenPK = N'Đồng hồ xe 1')), ((select maXe from xe where tenxe = 'sh mode'),(select maPK from phukien where tenPK = N'Động cơ xe 1')), ((select maXe from xe where tenxe = 'sh mode'),(select maPK from phukien where tenPK = N'Bánh xe 1')), ((select maXe from xe where tenxe = 'sh mode'),(select maPK from phukien where tenPK = N'Máy xe 1')), ((select maXe from xe where tenxe = 'sh mode'),(select maPK from phukien where tenPK = N'Thân xe 1')) END ELSE BEGIN UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = N'Đầu xe 2') WHERE maXe = (select maXe from xe where tenxe = 'sh') AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= 'sh' and pk.maLPK = 'D'); UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = N'Đuôi xe 2') WHERE maXe = (select maXe from xe where tenxe = 'sh') AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= 'sh' and pk.maLPK = 'DD') UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = N'Đồng hồ xe 2') WHERE maXe = (select maXe from xe where tenxe = 'sh') AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= 'sh' and pk.maLPK = 'DH') UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = N'Động cơ xe 2') WHERE maXe = (select maXe from xe where tenxe = 'sh') AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= 'sh' and pk.maLPK = 'DC') UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = N'Bánh xe 2') WHERE maXe = (select maXe from xe where tenxe = 'sh') AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= 'sh' and pk.maLPK = 'B') UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = N'Máy xe 2') WHERE maXe = (select maXe from xe where tenxe = 'sh') AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= 'sh' and pk.maLPK = 'M') UPDATE chitietxe SET maPK =  (select maPK from phukien where tenPK = N'Thân xe 2') WHERE maXe = (select maXe from xe where tenxe = 'sh') AND maPK =  (SELECT pk.maPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK where x.tenxe= 'sh' and pk.maLPK = 'T') END 

update phukien set soluong = (select soluong from phukien where tenPK = N'Đầu xe 1' ) - 1 where tenPK = N'Đầu xe 1'
select tenloai from loaiphukien where maLPK = 

--INSERT INTO phancong(maPK,maXe,maTho,maLPK,maNCC,maPC)
--VALUES ('', 'banhxeAB1','CongtyA1','Bánh xe AB','chiếc','20');
--INSERT INTO phukien (maPK,maLPK,maNCC,tenPK,dvt,soluong)
--VALUES ('banhxe1', 'banhxeAB1','CongtyA1','Bánh xe AB','chiếc','20');
--INSERT INTO phukien (maPK,maLPK,maNCC,tenPK,dvt,soluong)
--VALUES ('dauxe1', 'dauxeAB1','CongtyA1','đầu xe AB','cái','10');
--INSERT INTO phukien (maPK,maLPK,maNCC,tenPK,dvt,soluong)
--VALUES ('duoixe1', 'duoixeAB1','CongtyA1','Đuôi xe AB','cái','10');
--INSERT INTO phukien (maPK,maLPK,maNCC,tenPK,dvt,soluong)
--VALUES ('mayxe1', 'mayxeAB1','CongtyA1','Máy xe AB','cái','10');
--INSERT INTO phukien (maPK,maLPK,maNCC,tenPK,dvt,soluong)
--VALUES ('thanxe1', 'thanxeAB1','CongtyA1','Thân xe AB','cái','10');
--INSERT INTO phukien (maPK,maLPK,maNCC,tenPK,dvt,soluong)
--VALUES ('donghoxe1', 'donghoxeAB1','CongtyA1','Đồng hồ xe AB','bộ','10');
--INSERT INTO phukien (maPK,maLPK,maNCC,tenPK,dvt,soluong)
--VALUES ('dongco1', 'dongcoAB1','CongtyA1','Động cơ 150cc','cái','10');

--INSERT INTO loaiphukien(maLPK,tenloai,maNCC)
--VALUES ('banhxe','banhxeAB2','CT2');
--INSERT INTO loaiphukien(maLPK,tenloai,maNCC)
--VALUES ('thanxe','thanxeAB2','CT2');
--INSERT INTO loaiphukien(maLPK,tenloai,maNCC)
--VALUES ('dauxe','dauxeAB3','CT2');
--INSERT INTO loaiphukien(maLPK,tenloai,maNCC)
--VALUES ('dongco','dongcoAB3','CT2');
--INSERT INTO loaiphukien(maLPK,tenloai,maNCC)
--VALUES ('donghoxe','donghoxe2','CT2');
--INSERT INTO loaiphukien(maLPK,tenloai,maNCC)
--VALUES ('duoixe','duoixeAB2','CT2');
--INSERT INTO loaiphukien(maLPK,tenloai,maNCC)
--VALUES ('mayxe','mayxeAB3','CT2');

SELECT pk.tenPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK join phancong pc on pc.maTho=x.maTho join tholaprap tlr on tlr.maTho=pc.maTho where x.tenxe='Airblade' 
SELECT x.tenxe, pc.maPC,tlr.tentho from  xe x join phancong pc on pc.maPC=x.maPC join tholaprap tlr on tlr.maTho=pc.maTho where x.tenxe='Airblade'
SELECT*FROM phukien WHERE maLPK= 'dauxe01'
SELECT tenPK FROM phukien 
SELECT pk.tenPK FROM xe x join phancong pc on pc.maPC=x.maPC join phanconglaprap pclr on pclr.maPC = pc.maPC join phukien pk on pk.maPK = pclr.maPK where x.tenxe='Airblade'
SELECT pk.tenPK  FROM phukien pk join loaiphukien lpk on lpk.maLPK = pk.maLPK where lpk.maLPK = 'dauxe'
SELECT pk.tenPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK join phancong pc on pc.maTho=x.maTho join tholaprap tlr on tlr.maTho=pc.maTho where x.tenxe='Airblade' 
SELECT pk.tenPK from chitietxe ctx join xe x on ctx.maXe=x.maXe join phukien pk on pk.maPK= ctx.maPK join phancong pc on pc.maTho=x.maTho join tholaprap tlr on tlr.maTho=pc.maTho where x.tenxe='Airblade2021' 

select * from phancong pc join phanconglaprap plcr on pc.maPC  = plcr.maPC where plcr.maPC = 'PC1'



