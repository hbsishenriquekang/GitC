select
	Dog,	
	(SUM(Total) / COUNT(Total)) as 'TotalVendasMês',
	Month(DataVenda) as 'Mês'
from DOG
Group By Dog, Month(DataVenda)
order by TotalVendasMês desc