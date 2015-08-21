#procedimiento mostrar vehiculo
delimiter $$
create procedure spmostrar_vehiculo()
begin
select * from vehiculo
order by placa_veh desc limit 100;
end$$

#procedimiento buscar por placa
delimiter $$
create procedure spbuscar_vehiculo_placa(textobuscar varchar(7))

begin
select * from vehiculo
where placa_veh like (textobuscar +'%');
end$$

#procedimiento buscar por chasis
delimiter $$
create procedure spbuscar_vehiculo_chasis(textobuscar varchar(17))
begin
select * from vehiculo
where num_chasis like (textobuscar +'%');
end$$

#procedimiento buscar por cedula
delimiter $$
create procedure spbuscar_vehiculo_cedula(textobuscar int)
begin
select * from vehiculo
where idCliente1 = textobuscar;
end$$


#procedimiento insertar vehiculo
delimiter $$
create procedure spinsertar_vehiculo(placaveh varchar(7), numchasis varchar(17), marca varchar(10), modelo varchar(10), idcliente int)
begin
insert into vehiculo(placa_veh, num_chasis,marca_veh,modelo_veh,idCliente1)
values(placaveh,numchasis,marca,modelo,idcliente);
end$$

# procedimiento editar vehiculo
delimiter $$
create procedure speditar_vehiculo(placaveh varchar(7), numchasis varchar(17), marca varchar(10), modelo varchar(10))#, idcliente int)
begin
update vehiculo set placa_veh=placaveh, 
num_chasis=numchasis,
marca_veh=marca,
modelo_veh=modelo
where placa_veh=placaveh;
end$$

#procedimiento eliminar vehiculo
delimiter $$
create procedure speliminar_vehiculo(placa varchar(7))
begin
delete from vehiculo
where placa_veh=placaveh;
end$$


