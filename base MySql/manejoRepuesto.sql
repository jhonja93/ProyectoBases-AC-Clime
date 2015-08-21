#procedimiento mostrar repuesto
delimiter $$
create procedure spmostrar_repuesto()
begin
select * from repuesto
order by id_repuesto desc limit 100;
end$$

#procedimiento buscar nombre repuesto
delimiter $$
create procedure spbuscar_repuesto_nombre(textobuscar varchar(50))
begin
select * from repuesto
where nombre like (textobuscar + '%');
end$$

#procedimiento buscar marca repuesto
delimiter $$
create procedure spbuscar_repuesto_marca(textobuscar varchar(50))
begin
select * from repuesto
where marca like (textobuscar + '%');
end$$

#procedimiento insertar repuesto
delimiter $$
create procedure spinsertar_repuesto(out idrepuesto int,
nombr varchar(20),
marc varchar(20),
descripcio varchar(256),
precioventa numeric(12,2),
stockinicial int,
stockactual int)
begin
insert into repuesto(nombre, marca, descripcion, precio_venta, stock_inicial, stock_actual)
values(nombr,marc,descripcio,precioventa,stockinicial,stockactual);
end$$

# procedimiento editar repuesto
delimiter $$
create procedure speditar_repuesto(idrepuesto int,
nombr varchar(25),
marc varchar(20),
descripcio varchar(256),
precioventa numeric(12,2),
stockinicial int,
stockactual int)
begin
update repuesto set nombre=nombr,
marca=marc,
descripcion=descripcio,
precio_venta=precioventa,
stock_inicial=stockinicial,
stock_actual=stockactual
where id_repuesto=idrepuesto;
end$$

#procedimiento eliminar repuesto
delimiter $$
create procedure speliminar_repuesto(idrepuesto int)
begin
delete from repuesto
where id_repuesto=idrepuesto;
end$$