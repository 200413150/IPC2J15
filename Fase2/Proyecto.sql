create database Proyecto

use Proyecto

create table EMPLEADO(
	Codigo_empleado int not null,
	Codigo_depto int not null,
	Jefe int not null,
	Nombres varchar(50) not null,
	Apellidos varchar(50) not null,
	ID numeric(15,0) not null,
	Telefono numeric(8,0) not null,
	Sueldo numeric(5,2) not null,
	Domicilio varchar(150) not null,
	Puesto varchar(20) not null,
	primary key (Codigo_empleado)
)

create table DEPARTAMENTO(
	Codigo_depto int not null,
	Codigo_sucursal int not null,
	Nombre varchar(50) not null,
	primary key (Codigo_depto)
)

create table CLIENTE(
	Codigo_cliente int not null,
	DPI numeric(15,0) not null,
	Nombres varchar(50) not null,
	Apellidos varchar(50) not null,
	NIT numeric(15,0) not null,
	Telefono numeric(8,0) not null,
	Direccion varchar(100) not null,
	No_tarjeta numeric(15,0) not null,
	Casilla numeric(3,0) null,
	primary key (Codigo_cliente)
)

create table PAQUETE(
	Codigo_paquete int not null,
	Codigo_cliente int not null,
	Codigo_categoria int not null,
	Paquete varchar(100) not null,
	Peso numeric(4,0) not null,
	Valor_paquete numeric(6,2) not null,
	Costo_envio numeric(6,2) not null,
	Total numeric(10,2) not null,
	primary key (Codigo_paquete)
)

create table CATEGORIA(
	Codigo_categoria int not null,
	Impuesto_aduana numeric(3,2) not null,
	primary key (Codigo_categoria)
)

create table PAIS(
	Codigo_pais int not null,
	Nombre varchar(50) not null,
	primary key (Codigo_pais)
)

create table SUCURSAL(
	Codigo_sucursal int not null,
	Codigo_pais int not null,
	Direccion varchar(100) not null,
	Telefono numeric(8,0) not null,
	Capacidad_empleados numeric(3,0) not null,
	primary key (Codigo_sucursal)
)

create table FACTURA(
	Codigo_factura int not null,
	Codigo_sucursal int not null,
	Costo_total numeric(6,2) not null,
	primary key (Codigo_factura)
)

create table DETALLE_FACTURA(
	Codigo_detalle_factura int not null,
	Codigo_factura int not null,
	Codigo_paquete int not null,
	primary key(Codigo_detalle_factura)
)

create table DEVOLUCION(
	Codigo_devolucion int not null,
	Codigo_detalle_factura int not null,
	primary key (Codigo_devolucion)
)

alter table DEVOLUCION add constraint fk_Codigo_detalle_factura foreign key (Codigo_detalle_factura) references DETALLE_FACTURA (Codigo_detalle_factura)