# DCU-final

Base de datos y procedimientos almacenados


use DCUfinal;

CREATE TABLE estudiante(
	idEstudiante int primary key identity,
	nombreEst varchar(100),
	correoEst varchar(100),
	telefono varchar(20),
	imagen varchar(500)
	);
	select idEstudiante, nombreEst, correoEst, telefono, imagen from estudiante where nombreEst like 
	

	Create procedure sp_listarEst
	as
	select * from estudiante

	exec sp_listarEst



	--Listatar 1 registro
	Create procedure sp_listarUNEst(@id int, @nom varchar(100))
	as
	select * from estudiante where idEstudiante like'@id%' or nombreEst like'@nom%' 


	--Listatar 1 registro segunda opcion
	Create procedure sp_listarEstJustOne(@id int)
	as
	select * from estudiante where idEstudiante =@id


	exec sp_listarEstJustOne 2

	Create procedure sp_crearEst(
	@nom varchar(100),
	@corr varchar(100),
	@tell varchar(100),
	@imag varchar(500)
	)
	as
	insert into dbo.estudiante values(@nom, @corr,@tell,@imag);

	Create procedure sp_Actualizar(
	@idEst int ,
	@nom varchar(100),
	@corr varchar(100),
	@tell varchar(100),
	@imag varchar(500)
	)
	as
	update dbo.estudiante set nombreEst= @nom, correoEst = @corr, telefono =@tell, imagen= @imag 
		where idEstudiante = @idEst ;


	Create procedure sp_Eliminar(
	@idEst int 
	)
	as
	delete from dbo.estudiante where idEstudiante = @idEst



	exec sp_Eliminar 4
