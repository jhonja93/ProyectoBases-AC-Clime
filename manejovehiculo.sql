--procedimiento mostrar vehiculo
create proc spmostrar_vehiculo
as
select top 100 * from vehiculo
order by placa_veh desc
go

--procedimiento buscar por placa
create proc spbuscar_vehiculo_placa
@textobuscar varchar(7)
as
select * from vehiculo
where placa_veh like @textobuscar +'%'
go

--procedimiento buscar por chasis
create proc spbuscar_vehiculo_chasis
@textobuscar varchar(17)
as
select * from vehiculo
where num_chasis like @textobuscar +'%'
go

--procedimiento buscar marca y modelo vehiculo
create proc spbuscar_vehiculo_marca_modelo
@textobuscar1 varchar(50),
@textobuscar2 varchar(50)
as
select * from vehiculo
where marca_veh like @textobuscar1 + '%' and modelo_veh like @textobuscar2 +'%'
go

--procedimiento insertar vehiculo
create proc spinsertar_vehiculo
@placa_veh varchar(7),
@num_chasis varchar(17),
@marca varchar(10),
@modelo varchar(10),
@idcliente int output
as
insert into vehiculo(placa_veh, num_chasis,marca_veh,modelo_veh)
values(@placa_veh,@num_chasis,@marca,@modelo)
go

-- procedimiento editar vehiculo
create proc speditar_vehiculo
@placa_veh varchar(7),
@num_chasis varchar(17),
@marca varchar(10),
@modelo varchar(10)
as
update vehiculo set placa_veh=@placa_veh, 
num_chasis=@num_chasis,
marca_veh=@marca,
modelo_veh=@modelo
where placa_veh=@placa_veh
go

--procedimiento eliminar vehiculo
create proc speliminar_vehiculo
@placa_veh int
as
delete from vehiculo
where placa_veh=@placa_veh
go


