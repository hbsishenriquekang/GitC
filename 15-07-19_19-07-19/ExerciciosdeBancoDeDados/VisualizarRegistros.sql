select 
		AL.Nome,
		
		SUM(NT.Notas) / COUNT(NT.Notas) as 'Nota Media',
		IIF(SUM(NT.Notas) / COUNT(NT.Notas) >= 7,'Aprovado','Reprovado') as 'Média',
		IIF((SUM(CONVERT(MONEY, NT.Presenca)) / CONVERT(MONEY,COUNT(NT.Presenca)) * 100) >= 75,'Aprovado', 'Reprovado') as 'Frquencia'
	
from Alunos AL

inner join Notas NT on AL.Id = NT.Nome


group by AL.Nome



