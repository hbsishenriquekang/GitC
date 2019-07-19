insert into Notas
		(Nome, Turma, Notas, Presenca, UsuInc, UsuAlt, DatInc, DatAlt)
		values
		(6, 2, 7, 'true', 2, 2, GETDATE(), GETDATE() )
go
select * from Notas 