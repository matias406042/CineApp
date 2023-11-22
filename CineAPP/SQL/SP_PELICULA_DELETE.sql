create procedure SP_PELICULA_DELETE
@id int 

as begin



	if exists(select id_ticket  from TICKETS t	
							join FUNCIONES f on  t.id_funcion=f.id_funcion 
							join PELICULAS p on p.id_pelicula = f.id_pelicula						
							where p.id_pelicula = @id)
	begin

	raiserror('Hay tickets emitidos , violando integridad referencial',16,2)
	end
	else
	begin
			delete FUNCIONES  where id_pelicula =@id
			delete PELICULAS where id_pelicula =@id
	end
end