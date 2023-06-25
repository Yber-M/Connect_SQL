-- CREAMOS LA BASE DE DATOS VEHICULOS
CREATE DATABASE GLOBTECX_CARS;

-- USAMOS EL DB VEHICULOS
USE GLOBTECX_CARS;

-- CREAMOS LA TABLA
CREATE TABLE vehiculo (
	IdVehiculo INT IDENTITY (1, 1) PRIMARY KEY,
	Placa VARCHAR(6),
	Marca VARCHAR(20),
	Modelo VARCHAR(20),
	Color VARCHAR(20)
);
GO

SELECT * FROM vehiculo;

-- INSERTAMOS DATOS INICIALES EN LA TABLA
INSERT INTO vehiculo (Placa, Marca, Modelo, Color) VALUES ('ABC123', 'Toyota', 'Corolla', 'Rojo');
INSERT INTO vehiculo (Placa, Marca, Modelo, Color) VALUES ('DEF456', 'Honda', 'Civic', 'Azul');
INSERT INTO vehiculo (Placa, Marca, Modelo, Color) VALUES ('GHI789', 'Ford', 'Mustang', 'Negro');
INSERT INTO vehiculo (Placa, Marca, Modelo, Color) VALUES ('JKL012', 'Chevrolet', 'Camaro', 'Blanco');
INSERT INTO vehiculo (Placa, Marca, Modelo, Color) VALUES ('MNO345', 'Volkswagen', 'Golf', 'Gris');
INSERT INTO vehiculo (Placa, Marca, Modelo, Color) VALUES ('PQR678', 'BMW', 'Serie 3', 'Plateado');
INSERT INTO vehiculo (Placa, Marca, Modelo, Color) VALUES ('STU901', 'Mercedes-Benz', 'Clase C', 'Negro');
INSERT INTO vehiculo (Placa, Marca, Modelo, Color) VALUES ('VWX234', 'Audi', 'A4', 'Azul');
INSERT INTO vehiculo (Placa, Marca, Modelo, Color) VALUES ('YZA567', 'Nissan', 'Sentra', 'Rojo');
INSERT INTO vehiculo (Placa, Marca, Modelo, Color) VALUES ('BCD890', 'Hyundai', 'Elantra', 'Blanco');


SELECT Placa, Marca, Modelo, Color FROM vehiculo WHERE IdVehiculo = 4

SELECT * FROM vehiculo;