create table Mesas(
	IdMesa INT NOT NULL,
	Nombre nvarchar(50) NOT NULL
	constraint PK_Mesas primary key(IdMesa)
)

ventas
ventasdetalle
productos

/*  Agregar Mesa
insert into Mesas
values(10, 'Mesa 10'),(11, 'Mesa 11'),(12, 'Mesa 12'),(13, 'Mesa 14'),(15, 'Mesa 15'),(16, 'Mesa 16')
*/

/*  Agregar producto
insert into Productos
values(2, 'Pinta Golden', 120),(3, 'Pinta Scotish', 120),(4, 'Pinta Honey', 120)
*/

/*
*/

alter table ventas
alter column IdVenta int identity not null


select *
from productos

select *
from ventas
