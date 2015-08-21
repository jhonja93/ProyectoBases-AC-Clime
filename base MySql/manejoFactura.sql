#procedimiento buscar factura por codigo factura
delimiter $$
create procedure spbuscar_factura_codigo(textobuscar varchar(10))
begin
select * from factura
where codigo like (textobuscar + '%');
end$$

#procedimiento insertar factura
delimiter $$
create procedure spinsertar_factura(codig varchar(10), fecha_emisio varchar(20),subtota numeric(15,2), iv float,tota float, idOrdenTrabaj int, esCotizacio int)
begin
insert into factura(codigo,fecha_emision,subtotal,iva,total,id_ordenTrabajo2,esCotizacion)
values(codig,fecha_emisio,subtota,iv,tota,idOrdenTrabaj,esCotizacio);
end$$

# procedimiento editar factura
delimiter $$
create procedure speditar_factura(codig varchar(10), fecha_emisio varchar(20),subtota numeric(15,2), iv float,tota float, idOrdenTrabaj int, esCotizacio int)
begin
update factura set codigo=codig,
fecha_emision=fecha_emisio,
subtotal=subtota,
iva=iv,
total=tota,
id_ordenTrabajo2=idOrdenTrabaj,
esCotizacion=esCotizacio
where codigo=codig;
end$$

#procedimiento eliminar factura
delimiter $$
create procedure speliminar_factura(codig varchar(10)))
begin
delete from factura
where codigo=codig;
end$$

