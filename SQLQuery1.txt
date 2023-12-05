create table User_1(
userid int identity ,
Username varchar(60),
password_ varchar(60),
Age int,
Gender varchar(80),
phonenum varchar(80)primary key not null,
city varchar(100),
);
insert into User_1(Username,password_,Age,Gender,phonenum,city)
values('Ahmad','Ahmad@123',18,'F','01009234521','Caroi'),
('Mostafa','Mostafa@111',20,'M','01028400669','october'),
('Mohemd','M@1122',25,'M','01554367888','Elsalam'),
('Khaled','Khaled@55',25,'M','01006967234','Elshasayd'),
('Salma','Salma@555',20,'F','01098765432','Elfayom');

create table MMM
(
admin_id int primary Key,
admin_username Varchar(50),
admin_pass Varchar(50),
);

insert into MMM(admin_id,admin_username,admin_pass)
values(1,'Mostafa',123456),
(2,'Ahmad',1234567),
(3,'Salma',12345678),
(4,'Khald',123456789);