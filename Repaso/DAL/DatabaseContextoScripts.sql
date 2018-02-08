Create DataBase InscripcionExamen 
go 

CREATE TABLE Estudiantes (
    EstudianteID  INT primary key IDENTITY (1, 1) NOT NULL,
    Nombre        VARCHAR (30)  NULL,
    Monto         DECIMAL (18)  NULL,
    Observaciones VARCHAR (100) NULL,
    Fecha  DATE          NULL,
    
);
