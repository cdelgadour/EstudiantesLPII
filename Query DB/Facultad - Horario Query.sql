USE [NOMBRE DE TU BASE DE DATOS]


CREATE TABLE FACULTAD (
ID_FACULTAD int,
Nombre_Facultad varchar(255),
Director_Facultad varchar(50),
Telefono_Facultad numeric(10),
Correo_Facultad varchar(50),
Localidad_Facultad varchar(100)
);

CREATE TABLE HORARIOS (
ID_HORARIOS int, 
ID_PROFESOR int,
ID_SECCION int
);

INSERT INTO FACULTAD (ID_FACULTAD, Nombre_Facultad, Director_Facultad, Telefono_Facultad, Correo_Facultad, Localidad_Facultad)
VALUES (01, 'Ingeniería en Sistemas Computacionales', 'Ambiorix Liriano', 8095626601, 'info@unphu.edu.do', 'Edificion 2');

INSERT INTO HORARIOS (ID_HORARIOS) VALUES (01);