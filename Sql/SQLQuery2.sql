USE [GD2C2015]
GO

/****** Object:  Schema [DATA_G]    Script Date: 10/3/2015 12:50:10 PM ******/
DROP SCHEMA [DATA_G]
GO


/****** Object:  Schema [DATA_G]    Script Date: 10/3/2015 12:50:10 PM ******/
CREATE SCHEMA [DATA_G]
GO

CREATE TABLE ROL(

	Rol_IdRol int PRIMARY KEY,

	Rol_Descripcion varchar(255)

)


CREATE TABLE FUNCIONALIDADES(

	Func_IdFuncionalidad int PRIMARY KEY,
	Rol_IdRol int REFERENCES ROL

)


CREATE TABLE CLIENTE (

	Cli_Dni numeric(18, 0) PRIMARY KEY,
	Rol_IdRol int REFERENCES ROL,
	
	Cli_Nombre nvarchar(255),
	Cli_Apellido nvarchar(255),
	Cli_Dir nvarchar(255),
	Cli_Telefono numeric(18, 0),
	Cli_Mail nvarchar(255),
	Cli_Fecha_Nac datetime

)


CREATE TABLE PRODUCTO(

	Prod_IdProducto int PRIMARY KEY,	

	Prod_CostoEnMillas int,
	Prod_Descripcion varchar(255)

)


CREATE TABLE BENEFICIOS(

	Benef_IdBeneficio int PRIMARY KEY,
	Prod_IdProducto int REFERENCES PRODUCTO,
	Cli_Dni numeric(18, 0) REFERENCES CLIENTE,

	Benef_Milla int
	
)

CREATE TABLE PUNTO_DE_COMPRA(

	PdC_IdPuntoDeCompra int PRIMARY KEY,
	PdC_TipoDePunto varchar(255)

)

CREATE TABLE CIUDAD(
	
	Ciudad_ID int PRIMARY KEY,

	Nombre nvarchar(18,0)

)

CREATE TABLE AEROPUERTO(

	Aeropuerto_Codigo nvarchar(18,0) PRIMARY KEY,

	Ciudad_ID int REFERENCES CIUDAD
)
CREATE TABLE RUTA(

	Ruta_Codigo numeric(18, 0) PRIMARY KEY,
	Ruta_Precio_BaseKG numeric(18, 2),
	Ruta_Precio_BasePasaje numeric(18, 2),
	Ruta_Ciudad_Origen nvarchar(255),
	Ruta_Ciudad_Destino nvarchar(255),

	Aeropuerto_Origen nvarchar(18,0) REFERENCES AEROPUERTO,
	Aeropuerto_Destino nvarchar(18,0) REFERENCES AEROPUERTO

)

CREATE TABLE AERONAVE(

	Aeronave_Matricula nvarchar(255) PRIMARY KEY,
	Aeronave_Modelo nvarchar(255),
	Aeronave_KG_Disponibles numeric(18, 0),
	Aeronave_Fabricante nvarchar(255),
	Aeronave_CantButacas int /*fijarse la cant max para el numeric*/

)

CREATE TABLE FUERA_DE_SERVICIO(

	FdServ_Id int PRIMARY KEY,

	Aeronave_Matricula nvarchar(255) REFERENCES AERONAVE
)

CREATE TABLE VUELO(

	Vuelo_NroVuelo int PRIMARY KEY,
	Vuelo_FechaEstimadaLlegada datetime,
	Vuelo_FechaLlegada datetime,
	Vuelo_FechaSalida datetime,

	Ruta_Codigo int REFERENCES RUTA,
	AeroNave_Matricula int REFERENCES AERONAVE
	
)


CREATE TABLE BUTACA(

	Butaca_Nro numeric (18, 0) PRIMARY KEY,
	Butaca_Tipo nvarchar(255),
	Butaca_Piso numeric(18, 0),

	Vuelo_NroVuelo int REFERENCES VUELO

)

CREATE TABLE PASAJE(

	Pasaje_Codigo numeric(18, 0) PRIMARY KEY,
	Pasaje_Precio numeric(18, 2),
	Pasaje_FechaCompra datetime, 
	Pasaje_CantMillas int,
	Pasaje_DniPasajero numeric(18, 0),
	Pasaje_NroVuelo int,
	
	Butaca_Nro numeric(18, 0) REFERENCES BUTACA

)

CREATE TABLE PAQUETE(

	Paquete_Codigo numeric(18,2) PRIMARY KEY,
	
	Paquete_Precio numeric(18,2),
	Paquete_KG numeric(18,0),
	Paquete_FechaCompra datetime,

	Vuelo_NroVuelo int REFERENCES VUELO
)

CREATE TABLE DEVOLUCION(

	Devolucion_Id int PRIMARY KEY,

	Paquete_Codigo numeric(18,2) REFERENCES PAQUETE,
	Pasaje_Codigo numeric(18,0) REFERENCES PASAJE
)

CREATE TABLE COMPRADOR(

	Pasaje_Codigo numeric(18, 0) REFERENCES PASAJE,
	Cli_Dni numeric(18, 0) REFERENCES CLIENTE,
	PdC_IdPuntoDeCompra int REFERENCES PUNTO_DE_COMPRA

)

CREATE TABLE MILLAS(

	Millas_IdMillas int PRIMARY KEY,
	Millas_CantMillas int,
	
	Cli_Dni numeric(18, 0) REFERENCES CLIENTE,
	Vuelo_NroVuelo int REFERENCES VUELO
) 

