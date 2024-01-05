use TP_LABORATORIO
alter procedure SP_TICKET_X_ID
@IdTicket int

as begin
select t.id_ticket , t.id_butaca,s.Pre_unit
from TICKETS T join butacas b on b.id_Butaca = t.id_butaca
join funciones f on f.id_funcion = b.id_funcion
			   join Salas S on S.id_Sala = f.id_sala
			   where t.id_ticket = @IdTicket
end

exec SP_TICKET_X_ID @IdTicket = 2