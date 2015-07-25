--procedimiento mostrar empleado
create proc spmostrar_empleado
as
select top 100 * from empleado
order by cedula_empl desc
go

--procedimiento buscar nombre empleado
create proc spbuscar_empleado_nombre
@textobuscar varchar(50)
as
select * from empleado
where nombre_empl like @textobuscar + '%'
go

--procedimiento buscar apellido empleado
create proc spbuscar_empleado_apellido
@textobuscar varchar(50)
as
select * from empleado
where apellido_empl like @textobuscar + '%'
go

--procedimiento buscar cedula empleado
create proc spbuscar_empleado_cedula
@textobuscar varchar(50)
as
select * from empleado
where cedula_empl like @textobuscar + '%'
go

--procedimiento insertar empleado
create proc spinsertar_empleado
@cedula_empl int,
@nombre_empl varchar(20),
@apellido_empl varchar(20),
@telefono_empl varchar(15),
@direccion_empl varchar(50)
as
insert into empleado(nombre_empl,apellido_empl,telefono_empl,direccion_empl)
values(@nombre_empl,@apellido_empl,@telefono_empl,@direccion_empl)
go

--procedimiento editar empleado
create proc speditar_empleado
@cedula_empl int,
@nombre_empl varchar(20),
@apellido_empl varchar(20),
@telefono_empl varchar(15),
@direccion_empl varchar(50)
as
update empleado set 
nombre_empl=@nombre_empl,
apellido_empl=@apellido_empl,
telefono_empl=@telefono_empl,
direccion_empl=@direccion_empl
where cedula_empl=@cedula_empl
go

--procedimiento eliminar empleado
create proc speliminar_empleado
@cedula_empl int
as
delete from empleado
where cedula_empl=@cedula_empl
go