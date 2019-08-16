select
	Nome,
	Materia,
	(SUM(Nota) / COUNT(Nota))
from NotaAlunos
Group By Nome, Materia