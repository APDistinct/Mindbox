USE [Test]

select p.name, c.name
from [Wrk].[Product] p
left join [Wrk].[Relation] r on(p.id = r.[ProductId])
left join [Wrk].[Category] c on(c.id = r.[CategoryId])
