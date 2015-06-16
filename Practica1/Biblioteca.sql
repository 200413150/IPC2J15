create database Biblioteca

use Biblioteca

create table AUTOR (
	Codigo_autor int not null,
	Nombre varchar(50) not null,
	primary key (Codigo_autor),
)

create table CARNET (
	Codigo_carnet int not null,
	Nombre varchar(50) not null,
	DPI numeric(15,0) not null,
	Direccion varchar(100) not null,
	Telefono numeric(8,0) not null,
	primary key (Codigo_carnet),
)

create table LIBRO (
	Codigo_libro int not null,
	Codigo_autor int not null,
	Existencias numeric(2,0) not null,
	Disponibles numeric(2,0) not null,
	Prestados numeric(2,0) not null,
	Reservados numeric(2,0) not null,
	Paginas numeric(4,0) not null,
	Tema varchar(25) not null,
	primary key (Codigo_libro),
)

create table SERVICIO (
	Codigo_servicio int not null,
	Codigo_carnet int not null,
	Codigo_libro int not null,
	Tipo varchar(15) not null,
	Estado varchar(10) not null,
	primary key (Codigo_servicio),
)

alter table dbo.SERVICIO add constraint fk_Codigo_carnet foreign key (Codigo_carnet) references dbo.CARNET (Codigo_carnet)
alter table dbo.SERVICIO add constraint fk_Codigo_libro foreign key (Codigo_libro) references dbo.LIBRO (Codigo_libro)
alter table dbo.LIBRO add constraint fk_Codigo_autor foreign key (Codigo_autor) references dbo.AUTOR (Codigo_autor)