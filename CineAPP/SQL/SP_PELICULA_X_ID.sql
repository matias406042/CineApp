

create procedure SP_PELICULIA_X_ID
@ID int 
as 

begin 

SELECT    
			P.id_pelicula as PeliculasID,
			P.titulo  as PeliculaTitulo,
			P.duracion as PeliculaDuracion,
	   		P.fecha_estreno as PeliculaEstreno,

			G.id_genero as GeneroID,
			G.genero as GeneroDescripcion,
       
			C.id_clasificacion as CalificacionID,
			C.edad as CalificacionEdad,

			PR.id_productora as ProductoraID,
			PR.nombre as ProductoraNombre

      
        

    FROM PELICULAS AS P
    JOIN GENEROS_PELICULAS AS G ON P.id_genero = G.id_genero
    JOIN CLASIFICACIONES_PELICULAS AS C ON P.id_clasificacion = C.id_clasificacion
    JOIN PRODUCTORAS AS PR ON P.id_productora = PR.id_productora

    WHERE p.id_pelicula = @ID
	end;



