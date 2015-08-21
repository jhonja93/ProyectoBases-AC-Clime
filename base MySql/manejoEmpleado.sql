#procedimiento mostrar empleado
delimiter $$
create procedure spmostrar_empleado()
begin
select  * from empleado
order by cedula_empl desc limit 100;
end$$


#procedureedimiento buscar nombre empleado
delimiter $$
create procedure spbuscar_empleado_nombre(textobuscar varchar(50))
begin
select * from empleado
where nombre_empl like (textobuscar + '%');
end$$

#procedimiento buscar apellido empleado
delimiter $$
create procedure spbuscar_empleado_apellido(textobuscar varchar(50))

begin
select * from empleado
where apellido_empl like (textobuscar + '%');
end$$

#procedureedimiento buscar cedula empleado
delimiter $$
create procedure spbuscar_empleado_cedula(textobuscar varchar(50))
begin
select * from empleado
where cedula_empl like (textobuscar + '%');
end$$

#procedureedimiento insertar empleado
delimiter $$
create procedure spinsertar_empleado (cedula_empl int,nombre_empl varchar(20),apellido_empl varchar(20),tipo_documento varchar(10),numero_documento varchar(15), telefono_empl varchar(15),direccion_empl varchar(50))
begin
insert into empleado(nombre_empl,apellido_empl,telefono_empl,direccion_empl)
values(nombre_empl,apellido_empl,telefono_empl,direccion_empl);
end$$

#procedureedimiento editar empleado
delimiter $$
create procedure speditar_empleado(cedula_empl int,nombre_empl varchar(20),apellido_empl varchar(20),tipo_documento varchar(10),numero_documento varchar(15), telefono_empl varchar(15),direccion_empl varchar(50))
begin
update empleado set 
nombre_empl=nombre_empl,
apellido_empl=apellido_empl,
telefono_empl=telefono_empl,
direccion_empl=direccion_empl
where cedula_empl=cedula_empl;
end$$

#procedureedimiento eliminar empleado
delimiter $$
create procedure speliminar_empleado(cedula_empl int)

begin
delete from empleado
where cedula_empl=cedula_empl;
end$$