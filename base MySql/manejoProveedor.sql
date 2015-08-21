#procedimiento mostrar proveedor
delimiter $$
create procedure sqmostrar_proveedor()
begin
select * from proveedor
order by id_proveedor desc limit 100;
end$$

#procedimiento buscar nombre cliente
delimiter $$
create procedure spbuscar_proveedor(textobuscar varchar(50))
begin
select * from proveedor
where nombre_prov like (textobuscar + '%');
end$$

#procedimiento buscar responsable
delimiter $$
create procedure spbuscar_proveedor_responsable(textobuscar varchar(50))

begin
select * from proveedor
where responsable like (textobuscar + '%');
end$$

#procedimineto insertar proveedor
delimiter $$
create procedure spinsertar_proveedor(out idproveedor int, nombreprov varchar(15), responsable varchar(25),telefonoprov varchar(12),direccionprov varchar(50))
begin
insert into proveedor (nombre_prov,responsable,telefono_prov,direccion_prov)
values(nombreprov,responsable,telefonoprov,direccionprov);
end$$

#procedimiento editar proveedor
delimiter $$
create procedure speditar_proveedor(idproveedor int, nombreprov varchar(15), responsable varchar(25),telefonoprov varchar(12),direccionprov varchar(50))
begin
update proveedor set nombre_prov=nombreprov,
responsable=responsable,
telefono_prov=telefonoprov,
direccion_prov=direccionprov
where id_proveedor=idproveedor;
end$$

#procedimiento eliminar proveedor
delimiter $$
create procedure speliminar_proveedor(idproveedor int)
begin
delete from proveedor
where id_proveedor=idproveedor;
end$$
