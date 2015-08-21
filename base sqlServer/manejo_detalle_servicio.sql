
-- Procedimiento insertar detalle de servicio

create proc spinsertar_detalle_servicio
@idorden_trabajo varchar(15),
@idservicio int,
@fecha date,
@cantidad int 
as
insert into detalleServicios (id_ordenTrabajo3,id_servicio1,fecha_serv,cantidad_serv)
values (@idorden_trabajo,@idservicio,@fecha,@cantidad)
go



-- procedimiento editar detalle de servicio

create proc speditar_detalle_servicio
@idorden_trabajo varchar(15),
@idservicio int,
@fecha date,
@cantidad int 

as

update detalleServicios set id_ordenTrabajo3=@idorden_trabajo,
id_servicio1=@idservicio,
fecha_serv=@fecha,
cantidad_serv=@cantidad
where id_ordenTrabajo3=@idorden_trabajo
go




-- procedimiento eliminar detalle de servicio

create procedure speliminar_detalle_servicio
@idorden_trabajo varchar(15)
as
delete from detalleServicios
where id_ordenTrabajo3=@idorden_trabajo
go


--procedimiento buscar detalle de servicio por id

create procedure spbuscar_detalle_servicio_id
@idorden_trabajo varchar(15)
as
select * from detalleServicios
where id_ordenTrabajo3=@idorden_trabajo
go



