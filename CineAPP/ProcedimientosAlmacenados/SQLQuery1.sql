create  procedure SP_BUSCAR_PELICULAS
@Titulo varchar(20),
@AñoEstreno int,
@id_Genero int



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

create procedure SP_Funciones_Fecha
@fecha datetime
as
begin 
select titulo TITULO, genero GENERO, Horario_Inicio 'HORARIO_INICIO', Horario_Fin 'HORARIO_FIN', descripcion SALA
from FUNCIONES f
join PELICULAS p on f.id_pelicula = p.id_pelicula 
join Salas s on s.id_Sala = f.id_sala
join GENEROS_PELICULAS g on g.id_genero = p.id_genero
where @fecha = Fecha
END
select * from Salas
create procedure SP_GET_GENEROS
as
begin
select * 
from GENEROS_PELICULAS
end
select * from PELICULAS
create procedure SP_GET_SALAS
as
begin
select s.id_Sala id_Sala, s.id_Tipo id_Tipo, Capacidad, s.descripcion Sala, t.descripcion Tipo 
from Salas s join Tipos_Sala t on s.id_Tipo = t.id_Tipo
end

create procedure SP_GET_PELICULAS
as
begin 
select *
from PELICULAS p join GENEROS_PELICULAS g on g.id_genero = p.id_genero
end

create procedure SP_CREAR_FUNCION
@id_funcion int,
@id_pelicula int,
@id_sala int,
@horario_inicio datetime,
@horario_fin datetime,
@fecha datetime
as
begin
insert into FUNCIONES(id_funcion,id_pelicula,id_sala,Horario_Inicio,Horario_Fin,Fecha)
values(@id_funcion,@id_pelicula,@id_sala,@horario_inicio,@horario_fin,@fecha)
end

create procedure SP_BORRAR_FUNCION
@id_funcion int
as
begin
delete FUNCIONES
where id_funcion = @id_funcion
end

create procedure SP_UPDATE_FUNCION
@id_funcion int,
@id_pelicula int,
@id_sala int,
@horario_inicio datetime,
@horario_fin datetime,
@fecha datetime
as
begin
update FUNCIONES
set 
id_pelicula = @id_pelicula,
id_sala = @id_sala,
Horario_Inicio = @horario_inicio,
Horario_Fin = @horario_fin,
Fecha = @fecha
where id_funcion = @id_funcion
end