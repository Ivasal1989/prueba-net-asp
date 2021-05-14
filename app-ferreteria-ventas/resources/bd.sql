use ferreteria
select * from tb_producto

create table tb_usuario(
codArea varchar(5),
codEpleado varchar(5),
nom varchar(5),
usu varchar(5),
pass varchar(5)
)

insert into tb_usuario values('A0001','E0001','ivan','admin','admin');
insert into tb_usuario values('A0002','E0002','luis','luis','1234');
insert into tb_usuario values('A0003','E0003','eowin','eowin','1234');
go


create proc sp_logueo
@usuario varchar(10),
@password varchar(10)
as
select codArea,nom,usu,pass from tb_usuario
where usu=@usuario and pass=@password
go

create proc sp_listado_producto
as
select * from tb_producto
go

exec sp_listado_producto





