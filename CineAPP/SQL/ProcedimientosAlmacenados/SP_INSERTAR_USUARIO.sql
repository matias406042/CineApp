use  TOP_FILMS


alter procedure SP_USUARIO_INSERTAR
@nombre varchar(20),
@pass varchar(20)
as begin 
if exists(select * from Usuarios where @nombre = Usuarios.usuario)
begin 
raiserror('Usuario existente',10,1)
end 
else 
begin 
insert into Usuarios (usuario,password,estado)
			values (@nombre,ENCRYPTBYPASSPHRASE('PASSWORD',@pass),'DESCONECTADO')
end 
end
-----------------------------------------------------
exec SP_USUARIO_INSERTAR '1234','luis'
select * from Usuarios
select u.usuario,u.password ,Convert(varchar(50),DECRYPTBYPASSPHRASE('PASSWORD',u.password))  from Usuarios u