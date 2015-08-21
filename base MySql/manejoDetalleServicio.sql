
# Procedimiento insertar detalle de servicio
delimiter $$
create procedure spinsertar_detalle_servicio
(idorden_trabajo varchar(15),
idservicio int,
fecha date,
cantidad int )
begin
insert into detalleServicios (id_ordenTrabajo3,id_servicio1,fecha_serv,cantidad_serv)
values (idorden_trabajo,idservicio,fecha,cantidad);
end$$



# procedimiento editar detalle de servicio
delimiter $$
create procedure speditar_detalle_servicio
(idorden_trabajo varchar(15),
idservicio int,
fecha date,
cantidad int )

begin

update detalleServicios set id_ordenTrabajo3=idorden_trabajo,
id_servicio1=idservicio,
fecha_serv=fecha,
cantidad_serv=cantidad
where id_ordenTrabajo3=idorden_trabajo;
end$$




# procedimiento eliminar detalle de servicio
delimiter $$
create procedure speliminar_detalle_servicio
(idorden_trabajo varchar(15))
begin
delete from detalleServicios
where id_ordenTrabajo3=idorden_trabajo;
end$$


#procedimiento buscar detalle de servicio por id
delimiter $$
create procedure spbuscar_detalle_servicio_id
(idorden_trabajo varchar(15))
begin
select * from detalleServicios
where id_ordenTrabajo3=idorden_trabajo;
end$$



