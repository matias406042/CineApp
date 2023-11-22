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
select s.id_Sala id_Sala, s.id_Tipo id_Tipo, s.descripcion Sala, t.descripcion Tipo 
from Salas s join Tipos_Sala t on s.id_Tipo = t.id_Tipo
end

create procedure SP_GET_PELICULAS
as
begin 
select *
from PELICULAS p join GENEROS_PELICULAS g on g.id_genero = p.id_genero
end

create procedure SP_CREAR_FUNCION

@id_pelicula int,
@id_sala int,
@horario_inicio time,
@horario_fin time,
@fecha datetime
as
begin

insert into FUNCIONES(id_pelicula,id_sala,Horario_Inicio,Horario_Fin,Fecha)
values(@id_pelicula,@id_sala,@horario_inicio,@horario_fin,@fecha)
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
@horario_inicio time,
@horario_fin time,
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

insert into GENEROS_PELICULAS(genero)
values('Comedia')

alter procedure SP_GET_FUNCIONES
@fecha date,
@titulo varchar(20)
as
begin
select f.id_funcion Id_Funcion, Horario_Inicio Inicio, Horario_Fin Fin, 
	f.id_sala Id_Sala, s.descripcion Sala, s.Capacidad Capacidad, Pre_unit Pre_Unit, s.id_Tipo Id_Tipo_Sala, ts.descripcion Tipo_Sala,
	f.id_pelicula Id_Pelicula, titulo Titulo, duracion Duracion, fecha_estreno Fecha_Estreno,
	p.id_genero Id_Genero, genero Genero,
	p.id_clasificacion Id_Clasificacion, c.edad Edad_Clasf,
	p.id_productora Id_Productora, pr.nombre Productora, pr.id_pais Id_Pais_Productora,
	p.id_director Id_Director, di.nombre Nombre_Dir, di.apellido Ape_Dir, di.edad Edad_Dir, di.id_pais Id_Pais_Dir,
	pa.nombre Pais_Productora, pa2.nombre Pais_Director
from FUNCIONES f
	join PELICULAS p on p.id_pelicula = f.id_pelicula
	join Salas s on s.id_Sala = f.id_sala
	join Tipos_Sala ts on ts.id_Tipo = s.id_Tipo
	join GENEROS_PELICULAS g on g.id_genero = p.id_genero
	join CLASIFICACIONES_PELICULAS c on c.id_clasificacion = p.id_clasificacion
	join Productoras pr on pr.id_productora = p.id_productora
	join Paises pa on pa.id_pais = pr.id_pais
	join DIRECTORES di on di.id_director = p.id_director
	join Paises pa2 on pa2.id_pais = di.id_pais
	where	(Fecha = @fecha or @fecha is null) and
			(Titulo LIKE '%' + @Titulo + '%' OR @Titulo IS NULL)
end

create procedure SP_GET_FORMA_PAGO
as
begin
select id_forma_pago ID, descripcion DESCRIPCION
from Formas_pago 
end

create procedure SP_GET_DESCUENTOS
as
begin 
select * from DESCUENTOS
end

alter procedure SP_ADD_TICKET
@id_funcion int,
@id_comprobante int
--@id_butaca int
as
begin
insert into TICKETS(id_funcion,id_comprobante)--,id_butaca)
			values(@id_funcion,@id_comprobante)--,@id_butaca)
end

create procedure SP_ADD_COMPROBANTE
@id_pago int,
@total decimal(10,2),
@id_descuento int,
@id_compr int output
as
begin
insert into COMPROBANTES(id_forma_pago,Total,id_descuento)
			values(@id_pago,@total,@id_descuento)
set @id_compr = SCOPE_IDENTITY()
end

select * from Butacas
select * from FUNCIONES

create procedure SP_GET_BUTACAS_X_FUNCION
@id_Funcion int
as
begin
select id_Butaca ID, fila Fila, columna Columna, estado Estado
from Butacas
where id_funcion = @id_Funcion
end

select * from Butacas

create trigger TR_CrearButacas
on funciones
after insert
as
begin
    declare @fila varchar(1)
    declare @columna int
    declare @total int
    set @fila = 'A'
    set @columna = 1
    set @total = 0
    while @total < 35
    begin
        insert into butacas values ((select id_funcion from inserted), 'Disponible', @fila, @columna)
        set @columna = @columna +1
        if @columna = 8
            begin
            set @fila = CHAR(ASCII(@fila) + 1)
            set @columna = 1
            end
        set @total = @total + 1
    end
end
create trigger TR_EliminarButacas
on funciones
instead of delete
as 
begin
    delete butacas where id_funcion = (select id_funcion from deleted)
    delete funciones where id_funcion = (select id_funcion from deleted)
end

select * from Butacas

alter procedure SP_OCUPAR_BUTACA
@id_funcion int,
@fila varchar(1),
@col int
as
begin
update Butacas
set estado = 'Ocupada'
where id_funcion = @id_funcion and fila = @fila and @col = columna
end

create procedure SP_DESOCUPAR_BUTACA
@id_funcion int,
@fila varchar(1),
@col int
as
begin
update Butacas
set estado = 'Disponible'
where id_funcion = @id_funcion and fila = @fila and @col = columna
end

create procedure SP_GET_BUTACAS_FUNCION
@id_funcion int
as
begin
select fila Fila, columna Col, estado Estado
from Butacas
where id_funcion = @id_funcion
end

exec SP_GET_BUTACAS_FUNCION 11

select * from Butacas where estado = 'Ocupada'

select * 
from FUNCIONES f join PELICULAS p on f.id_pelicula = p.id_pelicula
where id_funcion = 11

update Butacas
set estado = 'Ocupada'
where estado = 'Ocupado'

select * from Butacas where id_funcion = 11

update Butacas
set estado = 'Disponible'
where id_funcion =11

alter procedure SP_REPORTE_COMPROBANTES
@desde datetime,
@hasta datetime
as
begin
select  c.id_comprobante ID, c.fecha Fecha,count(*)'Cantidad_de_tickets', d.descripcion 'Razon_descuento', d.porcentaje 'Valor_del_descuento',sum(Pre_unit)'Total_sin_descuentos aplicados', Total 'Total_real'
from COMPROBANTES c join TICKETS t on c.id_comprobante = t.id_comprobante 
join DESCUENTOS d on d.id_descuento = c.id_descuento
join Butacas b on b.id_Butaca = t.id_butaca
join FUNCIONES f on f.id_funcion = b.id_funcion
join Salas s on s.id_Sala = f.id_sala
where c.fecha between @desde and @hasta
group by c.id_comprobante,c.fecha,d.descripcion,d.porcentaje,Total
end