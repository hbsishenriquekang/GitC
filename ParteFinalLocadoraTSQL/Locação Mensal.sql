select 
	c.Carro,
	COUNT(c.Carro) as 'Quantidade',
	CONCAT(MONTH(lc.DatInc),'/',YEAR(lc.DatInc)) as 'Mês'

from Carros c
	inner join Locação lc on c.Id = lc.Carro
	group by c.Carro, MONTH(lc.DatInc), YEAR(lc.DatInc)
	order by 'Mês' desc