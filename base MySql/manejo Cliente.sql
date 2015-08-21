# Procedimiento mostrar
delimiter $$
create procedure spmostrar_cliente()
begin
select * from cliente
order by apellido_cli asc limit 100;
end$$

# Buscar Apellidos
delimiter $$
create procedure spbuscar_cliente_apellidos(textobuscar varchar(50))
begin
 
select * from cliente
where apellido_cli like (textobuscar + '%');
end$$

# Buscar Numero documento
delimiter $$
create procedure spbuscar_cliente_num_documento(textobuscar varchar(50))
begin

 
select * from cliente
where numero_documento like (textobuscar + '%');
end$$

# Buscar Nombre Cliente
delimiter $$
create procedure spbuscar_cliente_nombre(textobuscar varchar(50))
begin

 
select * from cliente
where nombre_cli like (textobuscar + '%');
end$$

# procedureedimiento Insertar
delimiter $$
create procedure spinsertar_cliente(out idcliente int,nombre varchar(20),apellido varchar(20),tipo_document varchar(10),numero_document varchar(15), tipo varchar(10),corre varchar(50),telefon varchar(15),direccio varchar(50))
begin
insert into cliente (nombre_cli,apellido_cli,tipo_documento,numero_documento,tipo_cli,correo_cli,telefono_cli,direccion_cli)
values (nombre,apellido,tipo_document,numero_document,tipo,corre,telefon,direccio);
end$$

# Procedimiento Editar
delimiter $$
create procedure speditar_cliente(idcliente int, nombre varchar(20),apellido varchar(20),tipo_document varchar(10),numero_document varchar(15), tipo varchar(10),correo varchar(50),telefono varchar(15),direccion varchar(50))
begin
update cliente set nombre_cli=nombre,
apellido_cli=apellido,
tipo_documento=tipo_document,
numero_documento=numero_document,
tipo_cli=tipo,
correo_cli=correo,
telefono_cli=telefono,
direccion_cli=direccion
where id_cliente=idcliente;
end$$

# Procedimiento Eliminar
delimiter $$
create procedure speliminar_cliente(idcliente int)
begin
delete from cliente
where id_cliente=idcliente;
end$$