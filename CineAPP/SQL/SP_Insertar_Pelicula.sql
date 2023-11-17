use TP_LABORATORIO

create procedure SP_Insertar_Pelicula
@IdGenero int,
@IdClasificacion int,
@IdProductora int ,
@IdDirector int,
@Titulo varchar (20),
@DuracionMinutos int, 
@Fecha datetime
as 
begin
 insert into PELICULAS values (@IdGenero,@IdClasificacion,@IdProductora,@IdDirector,@Titulo,@DuracionMinutos,@Fecha)
	end;



