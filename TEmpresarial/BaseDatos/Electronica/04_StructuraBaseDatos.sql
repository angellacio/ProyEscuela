USE master;
GO
IF (DB_ID('ElectronicaEugenio') IS NOT NULL) DROP DATABASE ElectronicaEugenio;
GO
CREATE DATABASE ElectronicaEugenio;
GO
USE ElectronicaEugenio;
GO
CREATE TABLE elecUsuario(
    IdUsuairo Int NOT NULL IDENTITY PRIMARY KEY,
    Apellido1 nVarChar(150) NOT NULL,
    Apellido2 nVarChar(150) NULL,
    Nombre nVarChar(250) NOT NULL,
    FechaAlta DateTime NOT NULL,
    Usuario nVarChar(8) NOT NULL,
    Contrasenia nVarChar(16) NOT NULL,
    FechaBaja DateTime NULL,
    Estatus Bit NOT NULL)
GO
CREATE TABLE elecCliente(
    IdCliente Int NOT NULL IDENTITY PRIMARY KEY,
    Apellido1 nVarchar(150) NOT NULL,
    Apellido2 nVarchar(150) NULL,
    Nombre nVarchar(250) NOT NULL,
    FechaAlta Datetime NOT NULL,
    CURP nVarchar(20) NULL,
    RFC nVarchar(13) NULL,
    Telefono nVarchar(100) NULL,
    Correo nVarchar(150) NULL,
    Direccion nVarchar(350) NULL,
    FechaBaja Datetime NULL,
    Estatus Int NOT NULL)
GO
CREATE TABLE elecRecoger(
    IdCliente Int NOT NULL,
    IdRecojer Int NOT NULL)
GO
CREATE TABLE elecEquipo(
    IdEquipo Int NOT NULL IDENTITY PRIMARY KEY,
    IdCliente Int NOT NULL,
    IdTipoEquipo Int NOT NULL,
    Marca nVarChar(150) NULL,
    NumeroSerie nVarChar(150) NOT NULL,
    Observaciones nVarChar(350) NOT NULL,
    FechaAlta Datetime NOT NULL,
    FechaBaja Datetime NULL,
    IdEstatus INT NOT NULL)
GO
CREATE TABLE elecEquipoMontos(
    IdEquipoMonto Int NOT NULL IDENTITY PRIMARY KEY,
    IdEquipo Int NOT NULL,
    IdTipoMonto Int NOT NULL,
    Monto Decimal NOT NULL,
    Observaciones nVarChar(350) NULL)
GO
CREATE TABLE elecTabla(
    IdTabla Int NOT NULL IDENTITY PRIMARY KEY,
    Descripcion nVarchar(150) NOT NULL,
    Estatus Bit NOT NULL)
GO
CREATE TABLE elecDescripcion(
    IdDescripcion Int NOT NULL IDENTITY PRIMARY KEY,
    IdTabla Int NOT NULL,
    Descripcion nVarchar(150) NOT NULL,
    Estatus Bit NOT NULL)
GO
CREATE VIEW vw_CososAcomulado
AS
SELECT IdEquipo, SUM(PorCobrar) PorCobrar, SUM(Cobrados) Cobrados, SUM(PorCobrar) - SUM(Cobrados) Neto
FROM (SELECT eEM.IdEquipo, CASE eD.IdTabla WHEN 3 THEN SUM(eEM.Monto) ELSE 0 END 'PorCobrar', CASE eD.IdTabla WHEN 4 THEN SUM(eEM.Monto) ELSE 0 END 'Cobrados', 0 'Neto'
      FROM elecEquipoMontos eEM INNER JOIN
           elecDescripcion eD ON eEM.IdTipoMonto = eD.IdDescripcion
      GROUP BY eEM.IdEquipo, eD.IdTabla) AS A
GROUP BY IdEquipo
GO
INSERT INTO elecUsuario(Apellido1, Apellido2, Nombre, FechaAlta, Usuario, Contrasenia, Estatus) VALUES('RAMIREZ', 'CRUZ', 'EUGENIO', GetDate(), 'eRamirez', '12345678', 1)
INSERT INTO elecUsuario(Apellido1, Apellido2, Nombre, FechaAlta, Usuario, Contrasenia, Estatus) VALUES('RAMIREZ', 'MANCERA', 'ANGEL', GetDate(), 'aRamirez', 'asdf1234', 1)
GO
INSERT INTO elecTabla(Descripcion, Estatus) VALUES('Estados Equipo', 1)
INSERT INTO elecTabla(Descripcion, Estatus) VALUES('Tipo equipo', 1)
INSERT INTO elecTabla(Descripcion, Estatus) VALUES('Monto por cobrar', 1)
INSERT INTO elecTabla(Descripcion, Estatus) VALUES('Monto cobrado', 1)
GO
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(1, 'En taller', 1)
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(1, 'En reparación', 1)
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(1, 'Entregado', 1)
GO
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(2, 'TV', 1)
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(2, 'Radio', 1)
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(2, 'Horno Microondas', 1)
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(2, 'Ventiladores', 1)
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(2, 'Plancha', 1)
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(2, 'Equipo PC', 1)
GO
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(3, 'Evaluación', 1)
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(3, 'Cotización', 1)
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(3, 'Costo', 1)
GO
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(4, 'Abono', 1)
INSERT INTO elecDescripcion(IdTabla, Descripcion, Estatus) VALUES(4, 'Monto descuento', 1)
GO