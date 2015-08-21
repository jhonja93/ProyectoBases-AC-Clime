--procedimiento mostrar proveedor
create proc sqmostrar_proveedor
as
select top 100 * from proveedor
order by id_proveedor desc
go

--procedimiento buscar nombre cliente
create proc spbuscar_proveedor
@textobuscar varchar(50)
as
select * from proveedor
where nombre_prov like @textobuscar + '%'
go

--procedimiento buscar responsable
create proc spbuscar_proveedor_responsable
@textobuscar varchar(15)
as
select * from proveedor
where responsable like @textobuscar + '%'
go

--procedimineto insertar proveedor
create proc spinsertar_proveedor
@idproveedor int output,
@nombreprov varchar(15),
@responsable varchar(25),
@telefonoprov varchar(12),
@direccionprov varchar(50)
as
insert into proveedor (nombre_prov,responsable,telefono_prov,direccion_prov)
values(@nombreprov,@responsable,@telefonoprov,@direccionprov)
go

--procedimiento editar proveedor
create proc speditar_proveedor
@idproveedor int,
@nombreprov varchar(15),
@responsable varchar(25),
@telefonoprov varchar(12),
@direccionprov varchar(50)
as
update proveedor set nombre_prov=@nombreprov,
responsable=@responsable,
telefono_prov=@telefonoprov,
direccion_prov=@direccionprov
where id_proveedor=@idproveedor
go

--procedimiento eliminar proveedor
create proc speliminar_proveedor
@idproveedor int
as
delete from proveedor
where id_proveedor=@idproveedor
go
