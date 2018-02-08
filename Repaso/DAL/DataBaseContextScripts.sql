create database NotasDeCredito 
go
Create table NotasCredito
(
NotasID int primary key,
EstudianteID int,
Observaciones varchar(100),
Monto decimal,
Fecha date,
PctBeca float,
MontoAsignatura decimal


);