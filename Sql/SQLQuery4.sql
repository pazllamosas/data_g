USE [GD2C2015]
GO

CREATE INDEX IDX_TempViajes ON tempdb.dbo.TEMPVIAJES
(NroVuelo, codigo_ruta, CiudadOrigen, CiudadDestino, fecha_salida, fecha_llegada, matricula_aeronave)
GO

