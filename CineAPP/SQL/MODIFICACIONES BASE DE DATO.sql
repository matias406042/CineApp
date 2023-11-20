use TP_LABORATORIO22

alter table Funciones
drop column horario

alter table Funciones 
add Horario_Inicio date 

alter table Funciones 
add Horario_Fin date

alter table Funciones 
add Fecha date


alter table Salas 
add Capacidad int

alter table tickets
drop column Pre_unit

alter table salas
add Pre_unit money