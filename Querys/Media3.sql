select
	Modelo,	
	(SUM(Vendas) / COUNT(Vendas)) as 'Media',
	Year([Data Venda]) as 'Ano'
from Carros
Group By Modelo, Year([Data Venda])
order by Modelo