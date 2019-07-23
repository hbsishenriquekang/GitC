select Nome from Marcas where UsuInc = 1

go

select Nome from Marcas where UsuInc = 2

go

select count(Nome) as 'Quantidade' from Marcas where UsuInc = 1 order by 'Quantidade' asc

go

select count(Nome) as 'Quantidade' from Marcas where UsuInc = 2 order by 'Quantidade' asc

go

select count(Nome) from Marcas

go

select Modelo from Carros where UsuInc = 1

go

select Modelo from Carros where UsuInc = 2

go

select count(Modelo) as 'Quantidade' from Carros where UsuInc = 1 order by 'Quantidade' asc

go

select count(Modelo) as 'Quantidade' from Carros where UsuInc = 2 order by 'Quantidade' desc

go

select count(modelo) from Carros

go

Select
	c.Modelo
from Carros c
inner join Marcas m on m.Id = c.Marca
where m.UsuInc = 1

go

Select
	c.Modelo
from Carros c
inner join Marcas m on m.Id = c.Marca
where m.UsuInc = 2

go

Select
	count(c.Modelo) as 'Quantidade'
from Carros c
inner join Marcas m on m.Id = c.Marca
where m.UsuInc = 1
order by 'Quantidade' desc

go

Select
	count(c.Modelo) as 'Quantidade'
from Carros c
inner join Marcas m on m.Id = c.Marca
where m.UsuInc = 2
order by 'Quantidade' asc

go

select sum(Valor * Quantidade) as 'Total de vendas'  from Vendas where YEAR(DatInc) = 2019

go

select sum(Quantidade) as 'Quantidade total de vendas' from Vendas where YEAR(DatInc) = 2019

go

select sum(Valor * Quantidade) as 'Valor', YEAR(DatInc)
from Vendas
group by YEAR(DatInc)
order by 'Valor' desc

go

select sum(Quantidade) as 'Quantidade', YEAR(DatInc)
from Vendas
group by YEAR(DatInc)
order by 'Quantidade' desc

go

select sum(Quantidade) as 'Quantidade', MONTH(DatInc) as 'Mês'
from Vendas
group by MONTH(DatInc)
order by 'Quantidade' desc

go

select sum(Valor * Quantidade) as 'Valor', MONTH(DatInc) as 'Mês'
from Vendas
group by MONTH(DatInc)
order by 'Valor' desc

go

select sum(Valor * Quantidade) from Vendas where UsuInc = 1

go

select sum(Valor * Quantidade) from Vendas where UsuInc = 2

go

select sum(Quantidade) from Vendas where UsuInc = 1

go

select sum(Quantidade) from Vendas where UsuInc = 2

go

select sum(Quantidade) as 'Quantidade' from Vendas where UsuInc = 1 or UsuInc = 2 order by 'Quantidade' desc

go

select sum(Valor * Quantidade) as 'Quantidade' from Vendas where UsuInc = 1 or UsuInc = 2 order by 'Quantidade' desc

go

select 
	m.Nome,
	sum(v.Quantidade) as 'Quantidade'
from Marcas m
inner join Carros c on m.Id = c.Marca
inner join Vendas v on c.Id = v.Carro
group by m.Nome
order by Quantidade desc

go

select 
	m.Nome,
	sum(v.Quantidade * Valor) as 'Valor'
from Marcas m
inner join Carros c on m.Id = c.Marca
inner join Vendas v on c.Id = v.Carro
group by m.Nome
order by Valor desc

go

select sum(Quantidade) as 'Quantidade'
from Vendas
group by Carro
order by 'Quantidade' desc

go

select 
	SUM(Quantidade * valor) as 'Quantidade',
	Carro	
from Vendas
group by Carro
order by 'Quantidade' desc