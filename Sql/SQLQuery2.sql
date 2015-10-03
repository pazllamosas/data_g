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

	Func_IdFuncionalidad

)

CREATE TABLE CLIENTE (

	Cli_Dni numeric(18, 0) PRIMARY KEY,
	Cli_IdRol int REFERENCES ROL,
	
	Cli_Nombre nvarchar(255),
	Cli_Apellido nvarchar(255),
	Cli_Dir nvarchar(255),
	Cli_Telefono numeric(18, 0),
	Cli_Mail nvarchar(255),
	Cli_Fecha_Nac datetime

)
