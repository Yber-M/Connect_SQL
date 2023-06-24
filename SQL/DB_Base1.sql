/* INICIO DB */
-- Eliminando la BD por si existe
IF DB_ID('BASE1') is not null
   DROP DATABASE BASE1
GO

-- Creamos el DB
CREATE DATABASE BASE1;

-- Usamo el DB
USE BASE1;

-- CREAMOS TABLA PRODUCTO
CREATE TABLE PRODUCTO (
	codigo INT IDENTITY (1 ,1) PRIMARY KEY not null,
	descripcion VARCHAR(50) null,
	precio FLOAT
);
GO

SELECT * FROM PRODUCTO;