--procedimiento mostrar repuesto
create proc spmostrar_repuesto
as
select top 100 * from repuesto
order by id_repuesto desc
go

--procedimiento buscar nombre repuesto
create proc spbuscar_repuesto
@textobuscar varchar(50)
as
select * from repuesto
where nombre like @textobuscar + '%'
go

--procedimiento insertar repuesto
create proc spinsertar_repuesto
@idrepuesto int output,
@nombre varchar(20),
@marca varchar(20),
@descripcion varchar(256),
@precio_venta money,
@stock_inicial int,
@stock_actual int
as
insert into repuesto(nombre, marca, descripcion, precio_venta, stock_inicial, stock_actual)
values(@nombre,@marca,@descripcion,@precio_venta,@stock_inicial,@stock_actual)
go

-- procedimiento editar repuesto
create proc speditar_repuesto
@idrepuesto int,
@nombre varchar(25),
@marca varchar(20),
@descripcion varchar(256),
@precio_venta money,
@stock_inicial int,
@stock_actual int
as
update repuesto set nombre=@nombre,
marca=@marca,
descripcion=@descripcion,
precio_venta=@precio_venta,
stock_inicial=@stock_inicial,
stock_actual=@stock_actual
where id_repuesto=@idrepuesto
go

--procedimiento eliminar repuesto
create proc speliminar_repuesto
@idrepuesto int
as
delete from categoria
where id_repuesto=@idrepuesto
go