create database NotaCreditodb
go

Create table NotasCredito
(
NotasID int primary key identity(1,1),
EstudianteID int,
Observaciones varchar(100),
Monto decimal,
Fecha date,
PctBeca decimal,
MontoAsignatura decimal


);


