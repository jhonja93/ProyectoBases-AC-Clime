create database acClimaDB
use acClimaDB

--Table Cliente
create Table cliente(
id_cliente int not null,
nombre_cli varchar(20) not null,
apellido_cli varchar(20) not null,
tipo_documento varchar(10) not null,
numero_documento varchar(15) null,
tipo_cli int not null,
correo_cli varchar(50) null,
telefono_cli bigint null,
direccion_cli varchar(50) null,
constraint PK_Cliente primary key(id_cliente)
)

--Tabla Repuesto
create Table repuesto(
id_repuesto int not null,
marca varchar(15) null,
descripcion varchar(256) null,
precio_venta money not null,
stock_inicial int not null,
stock_actual int not null, -- Cada vez que se venda un articulo se actualiza (resta) este valor
constraint PK_Repuesto primary key(id_repuesto)
)

-- Tabla Proveedor
create Table proveedor(
id_proveedor int not null,
nombre_prov varchar(15) not null,
responsable varchar(15) not null,
telefono_prov varchar(12) null,
direccion_prov varchar(50) null,
constraint PK_Proveedor primary key(id_proveedor)
)

-- Tabla Empleado
create Table empleado(
cedula_empl varchar(10) not null,
nombre_empl varchar(20) not null,
apellido_empl varchar(20) not null,
telefono_empl bigint null,
direccion_empl varchar(50) null,
constraint PK_Empleado primary key(cedula_empl)
)

-- Tabla Vehiculo (con clave foranea)
create Table vehiculo(
placa_veh varchar(8) not null,
num_chasis varchar(17) null,
modelo_veh varchar(10) null,
marca_veh varchar(10) null,
idCliente1 int not null,
constraint PK_Vehiculo primary key(placa_veh),
constraint FK_Cliente1 foreign key(idCliente1) references cliente (id_cliente)
)

-- Tabla Orden Trabajo (con clave foranea)
create Table ordenTrabajo(
id_ordenTrabajo varchar(15) not null,
fecha_in date not null,
fecha_out date not null,
hora_in smalldatetime null,
hora_out smalldatetime null,
costo money not null,
descripcion varchar(256) null,
placa_veh1 varchar(8) not null,
constraint PK_OrdenTrabajo primary key(id_ordenTrabajo),
constraint FK_Vehiculo1 foreign key(placa_veh1) references vehiculo (placa_veh)
)

-- Tabla detalle orden (con clave foranea)
create Table detalle_orden(
id_ordenTrabajo1 varchar(15) not null,
id_repuesto1 int not null,
cantidad int not null,
constraint FK_Respuesto1 foreign key(id_repuesto1) references repuesto (id_repuesto),
constraint FK_OrdenTrabajo1 foreign key(id_ordenTrabajo1) references ordenTrabajo(id_ordenTrabajo)
)

-- Table repuesto-proveedor (con clave foranea)
create Table repuesto_proveedor(
id_repuesto2 int not null,
id_proveedor1 int not null,
precio_compra money not null,
fecha_ingreso date not null,
constraint FK_Repuesto2 foreign key(id_repuesto2) references repuesto(id_repuesto),
constraint FK_Proveedor1 foreign key(id_proveedor1) references proveedor(id_proveedor)
)

-- Table servicios (con clave foranea)
create Table servicio (
id_servicio int not null,
costo_serv money not null,
descripcion_serv varchar(256) null,
cedula_empl1 varchar(10) not null,
constraint PK_Servicio primary key(id_servicio),
constraint FK_Empleado1 foreign key(cedula_empl1) references empleado(cedula_empl)
)

-- Taba equipos (con clave foranea)
create Table herramienta(
id_herramienta varchar(15) not null,
nombre_herr varchar(30) not null,
cedula_empl2 varchar(10) not null,
descripcion_herr varchar(256) null,
constraint PK_Herramienta primary key(id_herramienta),
constraint FK_Empleado2 foreign key(cedula_empl2) references empleado(cedula_empl)
)

-- Tabla factura (con clave foranea)
create Table factura (
codigo varchar(10) not null,
fecha_emision date not null,
iva float not null,
subtotal money not null,
total money not null,
id_ordenTrabajo2 varchar(15) not null,
esCotizacion int not null -- 1. SI 2. NO
constraint PK_Factura primary key(codigo),
constraint FK_OrdenTrabajo2 foreign key(id_ordenTrabajo2) references ordenTrabajo(id_ordenTrabajo)
)

-- Tabla detalleServicios
create Table detalleServicios(
id_ordenTrabajo3 varchar(15) not null,
id_servicio1 int not null,
fecha_serv date not null, -- Cuando se aplico ese servicio
cantidad_serv int not null, --Numero de veces que se aplico ese servicio
constraint FK_OrdenTrabajo3 foreign key(id_ordenTrabajo3) references ordenTrabajo(id_ordenTrabajo),
constraint FK_Servico foreign key(id_servicio1) references servicio(id_servicio)
)



