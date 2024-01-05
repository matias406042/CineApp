use TP_LABORATORIO

create procedure SP_TICKETS_X_COMPROBANTE
@IdComprobante int 

as begin 
select t.id_ticket , t.id_funcion,t.id_butaca,s.Pre_unit
from TICKETS T join FUNCIONES F on t.id_funcion = F.id_funcion
			   join Salas S on S.id_Sala = f.id_sala
where t.id_comprobante = @IdComprobante
end