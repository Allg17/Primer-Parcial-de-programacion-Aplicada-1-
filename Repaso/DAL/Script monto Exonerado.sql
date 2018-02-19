create database MontoExoneradodbs
go
create table MontoExonerado
(
ID int primary key identity(1,2),
IdEstudiantes int  default 0,
MontoAnterior int default 0,
MontoExonerados int default 0 

);


