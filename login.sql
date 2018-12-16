create database tbl_login
use tbl_login

create table  tbl_usersignup
(
u_id int identity primary key,
u_name nvarchar(50) not null,
u_Eamil nvarchar(50) not null,
u_Password nvarchar(50) not null

)

alter table tbl_usersignup
add u_Contact nvarchar(50) 
alter table tbl_usersignup
add Image nvarchar(max)

select * from tbl_usersignup

insert into tbl_usersignup
values('salman','sl@gmail.com','test')

insert into tbl_usersignup
values('slkd','sl@yahoo.com','55123')