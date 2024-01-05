use TOP_FILMS

create procedure SP_USUARIO_ON_LINE 
@user varchar(20),
@pass varchar(20)
as begin
if exists (select * from Usuarios where Usuarios.usuario = @user 
                                  and Convert(varchar(60),DECRYPTBYPASSPHRASE('PASSWORD',Usuarios.password)) = @pass)

	begin
update Usuarios 
set estado = 'CONECTADO'
where Usuarios.usuario = @user and Convert(varchar(60),DECRYPTBYPASSPHRASE('PASSWORD',Usuarios.password) )= @pass 
	end
else begin
raiserror('usuario inexistente',1,1)
	 end 
end




----------------------------------------------------------
select * from Usuarios

insert into Usuarios (usuario,password)
             values (12345,enCRYPTBYPASSPHRASE('PASSWORD','luis'))

			 select * from Usuarios

			

		create table Usuarios (
		id int identity (1,1) primary key,
		usuario varchar(50),
		password varchar(50),
		estado varchar(20)
		)
		drop table Usuarios