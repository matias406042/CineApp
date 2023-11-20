use TP_LABORATORIO

create procedure SP_TICKET_INSERTAR

@IdFuncion int,
@IdComprobante int,
@IdButaca int
as begin 
insert into TICKETS (id_funcion,id_comprobante,id_butaca)
			values(@IdFuncion,@IdComprobante,@IdButaca)
			end
