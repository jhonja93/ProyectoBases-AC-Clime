-- Procedimiento mostrar
create proc spmostrar_cliente
as
select top 100 * from cliente
order by apellido_cli asc
go

-- Buscar Apellidos
create proc spbuscar_cliente_apellidos
@textobuscar varchar(50)
as 
select * from cliente
where apellido_cli like @textobuscar + '%'
go

-- Buscar Numero documento
create proc spbuscar_cliente_num_documento
@textobuscar varchar(50)
as 
select * from cliente
where numero_documento like @textobuscar + '%'
go

-- Buscar Nombre Cliente
create proc spbuscar_cliente_nombre
@textobuscar varchar(50)
as 
select *from cliente
where nombre_cli like @textobuscar + '%'
go

-- Procedimiento Insertar
create proc spinsertar_cliente
@idcliente int output,
@nombre varchar(20),
@apellido varchar(20),
@tipo_documento varchar(10),
@numero_documento varchar(15),
@tipo varchar(10),
@correo varchar(50),
@telefono varchar(15),
@direccion varchar(50)
as
insert into cliente (nombre_cli,apellido_cli,tipo_documento,numero_documento,tipo_cli,correo_cli,telefono_cli,direccion_cli)
values (@nombre,@apellido,@tipo_documento,@numero_documento,@tipo,@correo,@telefono,@direccion)
go

-- Procedimiento Editar
create proc speditar_cliente
@idcliente int,
@nombre varchar(20),
@apellido varchar(20),
@tipo_documento varchar(10),
@numero_documento varchar(15),
@tipo varchar(10),
@correo varchar(50),
@telefono bigint,
@direccion varchar(50)
as 
update cliente set nombre_cli=@nombre,
apellido_cli=@apellido,
tipo_documento=@tipo_documento,
numero_documento=@numero_documento,
tipo_cli=@tipo,
correo_cli=@correo,
telefono_cli=@telefono,
direccion_cli=@direccion
where id_cliente=@idcliente
go

-- Procedimiento Elimiar
create proc speliminar_cliente
@idcliente int
as
delete from cliente
where id_cliente=@idcliente
go