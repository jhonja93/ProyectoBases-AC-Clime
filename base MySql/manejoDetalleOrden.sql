
# Procedimiento insertar detalle de orden
delimiter $$
create procedure spinsertar_detalle_orden(
idorden_trabajo varchar(15),
idrepuesto int,
cantid int )
begin
insert into detalle_orden (id_ordenTrabajo1,id_repuesto1,fecha_serv,cantidad)
values (idorden_trabajo,idrepuesto,cantid);
end$$



# procedimiento editar detalle de orden
delimiter $$
create procedure speditar_detalle_orden(idorden_trabajo varchar(15),
idrepuesto int,
cantid int )
begin
update detalle_orden set id_ordenTrabajo1=idorden_trabajo,
id_repuesto1=idrepuesto,
cantidad=cantid
where id_ordenTrabajo1=idorden_trabajo;
end$$




# procedimiento eliminar detalle de orden
delimiter $$
create procedure speliminar_detalle_orden
(idorden_trabajo varchar(15))
begin
delete from detalle_orden
where id_ordenTrabajo1=idorden_trabajo;
end$$


#procedimiento buscar detalle de orden por id
delimiter $$
create procedure spbuscar_detalle_orden_id
(idorden_trabajo varchar(15))
begin
select * from detalle_orden
where id_ordenTrabajo1=idorden_trabajo;
end$$



