USE [GD2C2015]
GO

/****** Object:  Schema [DATA_G]    Script Date: 10/3/2015 12:50:10 PM ******/

IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'DATA_G')
DROP SCHEMA [DATA_G]
GO

CREATE SCHEMA [DATA_G] AUTHORIZATION [dbo]
GO



/** CREACION DE TABLAS **/

CREATE TABLE DATA_G.ROL(

	Rol_IdRol int PRIMARY KEY,

	Rol_Descripcion varchar(255)

)


CREATE TABLE DATA_G.FUNCIONALIDADES(

	Func_IdFuncionalidad int PRIMARY KEY,
	Rol_IdRol int REFERENCES DATA_G.ROL

)


CREATE TABLE DATA_G.CLIENTE (

	Cli_Dni numeric(18, 0) PRIMARY KEY,
	Rol_IdRol int REFERENCES DATA_G.ROL,
	
	Cli_Nombre nvarchar(255),
	Cli_Apellido nvarchar(255),
	Cli_Dir nvarchar(255),
	Cli_Telefono numeric(18, 0),
	Cli_Mail nvarchar(255),
	Cli_Fecha_Nac datetime

)


CREATE TABLE DATA_G.PRODUCTO(

	Prod_IdProducto int PRIMARY KEY,	

	Prod_CostoEnMillas int,
	Prod_Descripcion varchar(255)

)


CREATE TABLE DATA_G.BENEFICIOS(

	Benef_IdBeneficio int PRIMARY KEY,
	Prod_IdProducto int REFERENCES DATA_G.PRODUCTO,
	Cli_Dni numeric(18, 0) REFERENCES DATA_G.CLIENTE,

	Benef_Milla int
	
)

CREATE TABLE DATA_G.PUNTO_DE_COMPRA(

	PdC_IdPuntoDeCompra int PRIMARY KEY,
	PdC_TipoDePunto varchar(255)

)

CREATE TABLE DATA_G.CIUDAD(
	
	Ciudad_ID int PRIMARY KEY,

	Nombre nvarchar(18)

)

CREATE TABLE DATA_G.AEROPUERTO(

	Aeropuerto_Codigo nvarchar(18) PRIMARY KEY,

	Ciudad_ID int REFERENCES DATA_G.CIUDAD
)
CREATE TABLE DATA_G.RUTA(

	Ruta_Codigo numeric(18, 0) PRIMARY KEY,
	Ruta_Precio_BaseKG numeric(18, 2),
	Ruta_Precio_BasePasaje numeric(18, 2),
	Ruta_Ciudad_Origen nvarchar(255),
	Ruta_Ciudad_Destino nvarchar(255),

	Aeropuerto_Origen nvarchar(18) REFERENCES DATA_G.AEROPUERTO,
	Aeropuerto_Destino nvarchar(18) REFERENCES DATA_G.AEROPUERTO

)

CREATE TABLE DATA_G.AERONAVE(

	Aeronave_Matricula nvarchar(255) PRIMARY KEY,
	Aeronave_Modelo nvarchar(255),
	Aeronave_KG_Disponibles numeric(18, 0),
	Aeronave_Fabricante nvarchar(255),
	Aeronave_CantButacas int /*fijarse la cant max para el numeric*/

)

CREATE TABLE DATA_G.FUERA_DE_SERVICIO(

	FdServ_Id int PRIMARY KEY,

	Aeronave_Matricula nvarchar(255) REFERENCES DATA_G.AERONAVE
)

CREATE TABLE DATA_G.VUELO(

	Vuelo_NroVuelo int PRIMARY KEY,
	Vuelo_FechaEstimadaLlegada datetime,
	Vuelo_FechaLlegada datetime,
	Vuelo_FechaSalida datetime,

	Ruta_Codigo numeric(18, 0) REFERENCES DATA_G.RUTA,
	AeroNave_Matricula nvarchar(255) REFERENCES DATA_G.AERONAVE
	
)


CREATE TABLE DATA_G.BUTACA(

	Butaca_Nro numeric (18, 0) PRIMARY KEY,
	Butaca_Tipo nvarchar(255),
	Butaca_Piso numeric(18, 0),

	Vuelo_NroVuelo int REFERENCES DATA_G.VUELO

)

CREATE TABLE DATA_G.PASAJE(

	Pasaje_Codigo numeric(18, 0) PRIMARY KEY,
	Pasaje_Precio numeric(18, 2),
	Pasaje_FechaCompra datetime, 
	Pasaje_CantMillas int,
	Pasaje_DniPasajero numeric(18, 0),
	Pasaje_NroVuelo int,
	
	Butaca_Nro numeric(18, 0) REFERENCES DATA_G.BUTACA

)

CREATE TABLE DATA_G.PAQUETE(

	Paquete_Codigo numeric(18,2) PRIMARY KEY,
	
	Paquete_Precio numeric(18,2),
	Paquete_KG numeric(18,0),
	Paquete_FechaCompra datetime,

	Vuelo_NroVuelo int REFERENCES DATA_G.VUELO
)

CREATE TABLE DATA_G.DEVOLUCION(

	Devolucion_Id int PRIMARY KEY,

	Paquete_Codigo numeric(18,2) REFERENCES DATA_G.PAQUETE,
	Pasaje_Codigo numeric(18,0) REFERENCES DATA_G.PASAJE
)

CREATE TABLE DATA_G.COMPRADOR(

	Pasaje_Codigo numeric(18, 0) REFERENCES DATA_G.PASAJE,
	Cli_Dni numeric(18, 0) REFERENCES DATA_G.CLIENTE,
	PdC_IdPuntoDeCompra int REFERENCES DATA_G.PUNTO_DE_COMPRA

)

CREATE TABLE DATA_G.MILLAS(

	Millas_IdMillas int PRIMARY KEY,
	Millas_CantMillas int,
	
	Cli_Dni numeric(18, 0) REFERENCES DATA_G.CLIENTE,
	Vuelo_NroVuelo int REFERENCES DATA_G.VUELO
) 



/** DROP TABLAS **/


IF OBJECT_ID('DATA_G.MILLAS') IS NOT NULL
DROP TABLE DATA_G.MILLAS

IF OBJECT_ID('DATA_G.COMPRADOR') IS NOT NULL
DROP TABLE DATA_G.COMPRADOR

IF OBJECT_ID('DATA_G.MILLAS') IS NOT NULL
DROP TABLE DATA_G.DEVOLUCION

IF OBJECT_ID('DATA_G.PAQUETE') IS NOT NULL
DROP TABLE DATA_G.PAQUETE

IF OBJECT_ID('DATA_G.PASAJE') IS NOT NULL
DROP TABLE DATA_G.PASAJE

IF OBJECT_ID('DATA_G.BUTACA') IS NOT NULL
DROP TABLE DATA_G.BUTACA

IF OBJECT_ID('DATA_G.VUELO') IS NOT NULL
DROP TABLE DATA_G.VUELO

IF OBJECT_ID('DATA_G.FUERA_DE_SERVICIO') IS NOT NULL
DROP TABLE DATA_G.FUERA_DE_SERVICIO

IF OBJECT_ID('DATA_G.AERONAVE') IS NOT NULL
DROP TABLE DATA_G.AERONAVE

IF OBJECT_ID('DATA_G.RUTA') IS NOT NULL
DROP TABLE DATA_G.RUTA

IF OBJECT_ID('DATA_G.AEROPUERTO') IS NOT NULL
DROP TABLE DATA_G.AEROPUERTO

IF OBJECT_ID('DATA_G.CIUDAD') IS NOT NULL
DROP TABLE DATA_G.CIUDAD

IF OBJECT_ID('DATA_G.PUNTO_DE_COMPRA') IS NOT NULL
DROP TABLE DATA_G.PUNTO_DE_COMPRA

IF OBJECT_ID('DATA_G.BENEFICIOS') IS NOT NULL
DROP TABLE DATA_G.BENEFICIOS

IF OBJECT_ID('DATA_G.PRODUCTO') IS NOT NULL
DROP TABLE DATA_G.PRODUCTO

IF OBJECT_ID('DATA_G.CLIENTE') IS NOT NULL
DROP TABLE DATA_G.CLIENTE

IF OBJECT_ID('DATA_G.FUNCIONALIDADES') IS NOT NULL
DROP TABLE DATA_G.FUNCIONALIDADES

IF OBJECT_ID('DATA_G.ROL') IS NOT NULL
DROP TABLE DATA_G.ROL