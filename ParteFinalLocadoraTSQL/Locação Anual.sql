select 
	c.Carro,
	COUNT(lc.Carro) as 'Quantidade',
	YEAR(lc.DatInc) as 'Ano'
	
from Carros c
	inner join Locação lc on c.Id = lc.Carro
	where YEAR(lc.DatInc) = 2019
	group by c.Carro, YEAR(lc.DatInc)
	order by 'Quantidade' desc