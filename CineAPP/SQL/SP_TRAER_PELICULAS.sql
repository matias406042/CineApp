create  procedure SP_BUSCAR_PELICULAS
@Titulo varchar(20)= null,
@AñoEstreno int =null,
@id_Genero int= null


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

    WHERE (Titulo LIKE '%' + @Titulo + '%' OR @Titulo IS NULL)
        AND (p.id_genero = @id_Genero OR @id_Genero IS NULL)
        AND ((year(P.fecha_estreno) = @AñoEstreno) OR (@AñoEstreno IS NULL));
		end



