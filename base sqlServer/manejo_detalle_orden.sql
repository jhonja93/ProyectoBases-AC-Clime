
-- Procedimiento insertar detalle de orden

create proc spinsertar_detalle_orden
@idorden_trabajo varchar(15),
@idrepuesto int,
@cantidad int 
as
insert into detalle_orden (id_ordenTrabajo1,id_repuesto1,fecha_serv,cantidad)
values (@idorden_trabajo,@idrepuesto,@cantidad)
go



-- procedimiento editar detalle de orden

create proc speditar_detalle_orden
@idorden_trabajo varchar(15),
@idrepuesto int,
@cantidad int 
as

update detalle_orden set id_ordenTrabajo1=@idorden_trabajo,
id_repuesto1=@idrepuesto,
cantidad=@cantidad
where id_ordenTrabajo1=@idorden_trabajo
go




-- procedimiento eliminar detalle de orden

create procedure speliminar_detalle_orden
@idorden_trabajo varchar(15)
as
delete from detalle_orden
where id_ordenTrabajo1=@idorden_trabajo
go


--procedimiento buscar detalle de orden por id

create procedure spbuscar_detalle_orden_id
@idorden_trabajo varchar(15)
as
select * from detalle_orden
where id_ordenTrabajo1=@idorden_trabajo
go



