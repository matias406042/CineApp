use TP_LABORATORIO

create procedure SP_BUTACA_X_ID
@IdButaca int
as begin
select * from Butacas where id_Butaca = @IdButaca
end