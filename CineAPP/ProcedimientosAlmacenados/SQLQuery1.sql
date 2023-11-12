create  procedure SP_BUSCAR_PELICULA
@Titulo varchar(20),
@AñoEstreno date,
@Genero int

as 
begin 

if @Titulo is not null AND @AñoEstreno is not null and @Genero is not null

begin
		SELECT
        P.id_pelicula AS IdPelicula,
        G.id_genero AS GeneroId,
        G.descripcion AS GeneroDescripcion,
        P.titulo AS Titulo,
        P.duracion AS Duracion,
        C.id_clasificacion AS ClasificacionId,
        C.descripcion AS ClasificacionDescripcion,
        P.fecha_estreno AS FechaEstreno,
        PR.id_productora AS ProductoraId,
        PR.descripcion AS ProductoraDescripcion
    FROM PELICULAS AS P
    JOIN GENEROS AS G ON P.id_genero = G.id_genero
    JOIN CLASIFICACIONES AS C ON P.id_clasificacion = C.id_clasificacion
    JOIN PRODUCTORAS AS PR ON P.id_productora = PR.id_productora

    WHERE (Titulo LIKE '%' + @Titulo + '%' OR @Titulo IS NULL)
        AND (Genero = @Genero OR @Genero IS NULL)
        AND (FechaEstreno = @FechaEstreno OR @FechaEstreno IS NULL);
		end

