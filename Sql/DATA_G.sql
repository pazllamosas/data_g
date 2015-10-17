USE [GD2C2015]
GO

/****** Object:  Schema [DATA_G]    Script Date: 10/3/2015 12:50:10 PM ******/





/** DROP TABLAS **/


IF OBJECT_ID('DATA_G.MILLAS') IS NOT NULL
DROP TABLE DATA_G.MILLAS

IF OBJECT_ID('DATA_G.COMPRADOR') IS NOT NULL
DROP TABLE DATA_G.COMPRADOR

IF OBJECT_ID('DATA_G.DEVOLUCION') IS NOT NULL
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

IF OBJECT_ID('DATA_G.ROL_POR_FUNCIONALIDADES') IS NOT NULL
DROP TABLE DATA_G.ROL_POR_FUNCIONALIDADES

IF OBJECT_ID('DATA_G.FUNCIONALIDADES') IS NOT NULL
DROP TABLE DATA_G.FUNCIONALIDADES

IF OBJECT_ID('DATA_G.ROL') IS NOT NULL
DROP TABLE DATA_G.ROL

IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'DATA_G')
DROP SCHEMA [DATA_G]
GO

/** CREATE TABLAS **/

CREATE SCHEMA [DATA_G] AUTHORIZATION [dbo]
GO

CREATE TABLE DATA_G.ROL(

	IdRol bit PRIMARY KEY,

	Descripcion varchar(255)

)


CREATE TABLE DATA_G.FUNCIONALIDADES(

	IdFuncionalidad int PRIMARY KEY IDENTITY (1,1),

	DescripcionFunc varchar(255)

)


CREATE TABLE DATA_G.ROL_POR_FUNCIONALIDADES(

	IdFuncionalidad int FOREIGN KEY REFERENCES DATA_G.FUNCIONALIDADES,
	IdRol bit FOREIGN KEY REFERENCES DATA_G.ROL

)


CREATE TABLE DATA_G.CLIENTE (

	IdCli int PRIMARY KEY IDENTITY(1,1),

	IdRol bit FOREIGN KEY REFERENCES DATA_G.ROL,
	
	/** PONGO NULL PARA QUE LOS USUARIOS NO TENGAN USERNAME NI PASSWORD**/
	Username nvarchar(255) NULL, /** Validar desd c# que sea unico**/
	Password nvarchar(255) NULL, 

	Dni numeric(18, 0), 
	Nombre nvarchar(255),
	Apellido nvarchar(255),
	Direccion nvarchar(255),
	Telefono numeric(18, 0),
	Mail nvarchar(255),
	Fecha_Nac datetime
	
)


CREATE TABLE DATA_G.PRODUCTO(

	IdProducto int PRIMARY KEY,	

	CostoEnMillas int,
	Descripcion varchar(255)

)


CREATE TABLE DATA_G.BENEFICIOS(

	IdBeneficio int PRIMARY KEY,

	IdProducto int FOREIGN KEY REFERENCES DATA_G.PRODUCTO,
	IdCli int FOREIGN KEY REFERENCES DATA_G.CLIENTE,

	Milla int
	
)


CREATE TABLE DATA_G.PUNTO_DE_COMPRA(

	IdPuntoDeCompra int PRIMARY KEY,

	TipoDePunto varchar(255)

)


CREATE TABLE DATA_G.CIUDAD(
	
	CodigoCiudad nvarchar(255) PRIMARY KEY,

	Nombre nvarchar(255)

)



CREATE TABLE DATA_G.RUTA(

	IdRuta int PRIMARY KEY IDENTITY(1,1),

	Codigo numeric(18, 0),
	Precio_BaseKG numeric(18, 2),
	Precio_BasePasaje numeric(18, 2),
	
	Origen nvarchar(255) FOREIGN KEY REFERENCES DATA_G.CIUDAD,
	Destino nvarchar(255) FOREIGN KEY REFERENCES DATA_G.CIUDAD

)


CREATE TABLE DATA_G.AERONAVE(

	Matricula nvarchar(255) PRIMARY KEY,

	Modelo nvarchar(255),
	KG_Disponibles numeric(18, 0),
	Fabricante nvarchar(255),
	CantButacas int /*fijarse la cant max para el numeric*/,
	Piso int

)

CREATE TABLE DATA_G.FUERA_DE_SERVICIO(

	IdFdS int PRIMARY KEY,

	Matricula nvarchar(255) FOREIGN KEY REFERENCES DATA_G.AERONAVE

)


CREATE TABLE DATA_G.VUELO(

	NroVuelo int PRIMARY KEY IDENTITY(1,1),

	FechaEstimadaLlegada datetime,
	FechaLlegada datetime,
	FechaSalida datetime,

	IdRuta int FOREIGN KEY REFERENCES DATA_G.RUTA,
	Matricula nvarchar(255) FOREIGN KEY REFERENCES DATA_G.AERONAVE
	
)


CREATE TABLE DATA_G.BUTACA(

	NroButaca numeric (18, 0) PRIMARY KEY,
	Tipo nvarchar(255),
	Piso numeric(18, 0),
	Estado binary, /** 0:LIBRE  1:OCUPADO**/

	NroVuelo int FOREIGN KEY REFERENCES DATA_G.VUELO

)


CREATE TABLE DATA_G.PASAJE(

	Pasaje_Codigo numeric(18, 0) PRIMARY KEY,

	Precio numeric(18, 2),
	FechaCompra datetime, 
	CantMillas int,
	NroVuelo int,
	Ciudad_Origen nvarchar(255),
	Ciudad_Destino nvarchar(255),

	IdCli int FOREIGN KEY REFERENCES DATA_G.CLIENTE,
	NroButaca numeric(18, 0) FOREIGN KEY REFERENCES DATA_G.BUTACA

)


CREATE TABLE DATA_G.PAQUETE(

	Codigo numeric(18,2) PRIMARY KEY,
	
	Precio numeric(18,2),
	KG numeric(18,0),
	FechaCompra datetime,

	NroVuelo int FOREIGN KEY REFERENCES DATA_G.VUELO

)


CREATE TABLE DATA_G.DEVOLUCION(

	IdDevolucion int PRIMARY KEY,

	Codigo numeric(18,2) FOREIGN KEY REFERENCES DATA_G.PAQUETE,
	Pasaje_Codigo numeric(18,0) FOREIGN KEY REFERENCES DATA_G.PASAJE

)


CREATE TABLE DATA_G.COMPRADOR(

	Pasaje_Codigo numeric(18, 0) FOREIGN KEY REFERENCES DATA_G.PASAJE,
	IdCli int FOREIGN KEY REFERENCES DATA_G.CLIENTE,
	IdPuntoDeCompra int FOREIGN KEY REFERENCES DATA_G.PUNTO_DE_COMPRA

)

CREATE TABLE DATA_G.MILLAS(

	IdMillas int PRIMARY KEY,
	CantMillas int,
	
	IdCli int FOREIGN KEY REFERENCES DATA_G.CLIENTE,
	NroVuelo int FOREIGN KEY REFERENCES DATA_G.VUELO
) 



/** MIGRACION DE DATOS **/

/**ROLES**/

INSERT INTO DATA_G.ROL(IdRol, Descripcion)
VALUES (0,'Administrador')
INSERT INTO DATA_G.ROL(IdRol, Descripcion)
VALUES (1, 'Cliente')


/** FUNCIONALIDADES **/

SET IDENTITY_INSERT DATA_G.FUNCIONALIDADES ON
INSERT INTO DATA_G.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (0,'Crear acceso usuario')
INSERT INTO DATA_G.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (1,'Modificar acceso usuario')
INSERT INTO DATA_G.FUNCIONALIDADES(IdFuncionalidad,DescripcionFunc)
VALUES (2,'Eliminar acceso usuario')

SET IDENTITY_INSERT DATA_G.FUNCIONALIDADES OFF


/** FUNCIONALIDADES POR ROL **/

INSERT INTO DATA_G.ROL_POR_FUNCIONALIDADES
VALUES(0,0)


/** CLIENTE **/ 

INSERT INTO DATA_G.CLIENTE(IdRol,Nombre, Apellido,Dni,Direccion,Telefono,Mail,Fecha_Nac)
SELECT distinct 1,Cli_Nombre,Cli_Apellido, Cli_Dni,Cli_Dir,Cli_Telefono,Cli_Mail,Cli_Fecha_Nac FROM gd_esquema.Maestra 
Order by 4
/**SELECT top 4 ma.Cli_Apellido, ma.Cli_Nombre, ma.Cli_Dni
FROM gd_esquema.Maestra ma
where exists (select 1 
			from gd_esquema.Maestra ma2 where ma2.Cli_Dni = ma.Cli_Dni and  ma.Cli_Apellido <> ma2.Cli_Apellido and ma.Cli_Nombre <> ma2.Cli_Nombre)
**/
INSERT INTO DATA_G.CLIENTE(IdRol,Nombre, Apellido,Dni,Direccion,Telefono,Mail,Fecha_Nac,Username,Password)
VALUES(0,'Maria','Lopez',33652149,'J.C Paz 520',47921563,'mlopez@gmail.com', '1990-05-21','mlopez','w23e')
INSERT INTO DATA_G.CLIENTE(IdRol,Nombre, Apellido,Dni,Direccion,Telefono,Mail,Fecha_Nac,Username,Password)
VALUES(0,'Administrador General',' ',32652149,'J.C Paz 720',47971573,'admin@gmail.com', '1990-05-11','admin','w23e')


/** PASAJE  **/

INSERT INTO DATA_G.PASAJE(Pasaje_Codigo,Precio,FechaCompra, CantMillas, NroVuelo, IdCli, NroButaca, Ciudad_Origen, Ciudad_Destino)
 
SELECT 	M.Pasaje_Codigo,
		M.Pasaje_Precio,
		M.Pasaje_FechaCompra,
		CAST(ROUND(M.Pasaje_Precio/10,1) AS decimal(10,0)) AS 'CantMillas',
		v.NroVuelo,
		c.idCli,
		b.NroButaca,
		r.Origen,
		r.Destino 
	 
 
FROM gd_esquema.Maestra M, DATA_G.BUTACA b, DATA_G.VUELO v, DATA_G.AERONAVE a, DATA_G.CLIENTE c, DATA_G.RUTA r
	/**WHERE M.Pasaje_Codigo <> 0
	AND v.FechaSalida = M.FechaSalida
	AND v.FechaLlegada = M.FechaLLegada
	AND v.Matricula = M.Aeronave_Matricula
	AND c.Dni = M.Cli_Dni
	AND b.NroVuelo = v.NroVuelo
	AND b.Piso = a.Piso**/


/** PAQUETE **/



INSERT INTO DATA_G.PAQUETE(Codigo, FechaCompra, Precio, NroVuelo, KG)

SELECT M.Paquete_Codigo,
	   M.Paquete_FechaCompra,
	   M.Paquete_Precio,
	   V.NroVuelo,
	   M.Paquete_KG

FROM gd_esquema.Maestra M, DATA_G.VUELO V 
	WHERE M.Paquete_Codigo <> 0


INSERT INTO DATA_G.VUELO(FechaEstimadaLlegada, FechaLlegada, FechaSalida, IdRuta, Matricula)

SELECT M.Fecha_Llegada_Estimada,
	   M.FechaLlegada,
	   M.FechaSalida,
	   R.IdRuta,
	   M.Aeronave_Matricula

FROM gd_esquema.Maestra M, DATA_G.RUTA R


INSERT INTO DATA_G.RUTA(Codigo, Precio_BaseKG, Precio_BasePasaje, Origen, Destino)

SELECT DISTINCT M.Ruta_Codigo,
	   M.Ruta_Precio_BaseKG,
	   M.Ruta_Precio_BasePasaje,
	   M.Ruta_Ciudad_Origen,
	   M.Ruta_Ciudad_Destino


FROM gd_esquema.Maestra M Order by 1


INSERT INTO DATA_G.BUTACA(NroButaca, Tipo, Piso, Estado)

SELECT DISTINCT M.Butaca_Nro,
				M.Butaca_Tipo,
				M.Butaca_Piso,
				0 AS 'Estado'


FROM gd_esquema.Maestra M 
WHERE M.Butaca_Tipo <> '0'
ORDER BY 1

/**INSERT INTO DATA_G.AERONAVE(Matricula, Modelo, KG_Disponibles, Fabricante, CantButacas, Piso)
SELECT M.Aeronave_Matricula, M.Aeronave_Modelo, M.Aeronave_KG_Disponibles, M.Aeronave_Fabricante, ,
FROM gd_esquema.Maestra M**/

  

 
 /**CREATE FUNCTION DATA_G.GetMillas( @Pasaje_Precio numeric(18,2))
	RETURNS int
	AS BEGIN 
	DECLARE @RETORNO int
	BEGIN TRY 	
		SELECT @RETORNO=Pasaje_Precio/10 FROM DATA_G.PASAJE WHERE Pasaje_Precio=@Pasaje_Precio
		RETURN @RETORNO
	END TRY
	BEGIN CATCH
		RETURN NULL
	END CATCH
	END **/

	 







