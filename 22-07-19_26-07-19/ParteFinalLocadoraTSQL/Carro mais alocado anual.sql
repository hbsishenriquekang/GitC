select 
	c.Carro,
	COUNT(c.Carro) as 'Quantidade',
	YEAR(lc.DatInc) as 'Ano'

from Carros c
	inner join Locação lc on c.Id = lc.Carro
	group by c.Carro, YEAR(lc.DatInc)
	order by 'Quantidade' desc 