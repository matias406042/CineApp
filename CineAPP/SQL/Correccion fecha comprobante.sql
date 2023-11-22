alter table comprobantes
add fecha datetime

ALTER procedure [dbo].[SP_ADD_COMPROBANTE]
@id_pago int,
@total decimal(10,2),
@id_descuento int,
@id_compr int output
as
begin
insert into COMPROBANTES(id_forma_pago,Total,id_descuento, fecha)
			values(@id_pago,@total,@id_descuento, GETDATE())
set @id_compr = SCOPE_IDENTITY()
end

update COMPROBANTES
set fecha = '2023/11/18'
where fecha is null