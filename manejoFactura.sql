--procedimiento buscar factura por codigo factura
create proc spbuscar_factura_codigo
@textobuscar varchar(10)
as
select * from factura
where codigo like @textobuscar +'%'
go

--procedimiento insertar vehiculo
create proc spinsertar_factura
@codigo varchar(10),
@fecha_emision smalldatetime,
@subtotal money,
@iva float,
@total float,
@idOrdenTrabajo varchar(15) output,
@esCotizacion int
as
insert into factura(codigo,fecha_emision,subtotal,iva,total,id_ordenTrabajo2,esCotizacion)
values(@codigo,@fecha_emision,@subtotal,@iva,@total,@idOrdenTrabajo,@esCotizacion)
go

-- procedimiento editar factura
create proc speditar_factura
@codigo varchar(10),
@fecha_emision smalldatetime,
@subtotal money,
@iva float,
@total float,
--@idOrdenTrabajo varchar(15) output,
@esCotizacion int
as
update factura set codigo=@codigo,
fecha_emision=@fecha_emision,
subtotal=@subtotal,
iva=@iva,
total=@total,
--id_ordenTrabajo2=@idOrdenTrabajo,
esCotizacion=@esCotizacion
where codigo=@codigo
go

--procedimiento eliminar factura
create proc speliminar_factura
@codigo int
as
delete from factura
where codigo=@codigo
go

