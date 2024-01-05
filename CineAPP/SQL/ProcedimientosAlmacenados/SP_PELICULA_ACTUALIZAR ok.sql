use TP_LABORATORIO_FINAL

create procedure SP_PELICULA_ACTUALIZAR

@Id int,
@IdGenero int,
@IdClasificacion int,
@IdProductora int,
@Titulo varchar (20),
@DuracionMinutos int, 
@Fecha datetime
as
begin

update PELICULAS 
       set
	     id_genero = @IdGenero,
		 id_clasificacion=@IdClasificacion,
		 id_productora= @IdProductora,
		 titulo =@Titulo,
		 duracion=@DuracionMinutos,
		 fecha_estreno=@Fecha
		 where id_pelicula =@Id
		 end