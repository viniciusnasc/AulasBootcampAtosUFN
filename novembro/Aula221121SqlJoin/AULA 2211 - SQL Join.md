/* Aula 22/11 - Join */

create table Java(
professor varchar(20) null
)

create table Dotnet(
professor varchar(20) null
)

insert into Dotnet values('Ricardo')
insert into Dotnet values('Fabricio')

insert into Java values('Fabricio')
insert into Java values('Silvio')
insert into Java values('Reiner')
update Java set professor = 'Sylvio' where professor like 'Silvio' 

select * from Dotnet
select * from Java

/* Retorna apenas os professores que estiverem em ambas tabelas */
select * from Java inner join dotnet on java.professor = dotnet.professor
select * from Java as J inner join dotnet as D on j.professor = d.professor

/* Retorna todos os professores da primeira tabela, mostrando qual está na segunda */
select * from Java left join Dotnet on java.professor = Dotnet.professor

/* Retorna todos os professores da segunda tabela, mostrando qual está na primeira */
select * from Java right join Dotnet on java.professor = Dotnet.professor

/* Retorna todos os professores, de ambas tabelas, mostrando onde eles existem e nao existem */ 
select * from Java full outer join Dotnet on java.professor = Dotnet.professor

select java.professor as 'java', Dotnet.professor as 'dotnet' 
from Java full outer join Dotnet on java.professor = Dotnet.professor

/* Retorna todos os professores da primeira tabela, exceto os que estao na segunda */
select * from Java left join Dotnet on java.professor = Dotnet.professor 
where Dotnet.professor is null

/* Retorna todos os professores da segunda tabela, exceto os que estão na primeira */
select * from Java right join Dotnet on java.professor = Dotnet.professor where Java.professor is null

/* Retorna todos os professores, de ambas tabelas, exceto os que pertencem a ambas tabelas */ 
select * from Java full outer join Dotnet on java.professor = Dotnet.professor 
where Java.professor is null or Dotnet.professor is null

select LIVRO.isbn, LIVRO.titulo, LIVRO.ano_publicacao, CATEGORIA.tipo_categoria 
from Livro full outer join CATEGORIA on LIVRO.fk_categoria = CATEGORIA.id

select  LIVRO.isbn, LIVRO.titulo, LIVRO.ano_publicacao, EDITORA.Nome as 'Editora', CATEGORIA.tipo_categoria
from LIVRO
inner join EDITORA on EDITORA.id = LIVRO.fk_editora
inner join CATEGORIA on CATEGORIA.id = LIVRO.fk_categoria

/* Nome dos livros na categoria humor */
select Livro.titulo from LIVRO
inner join CATEGORIA on CATEGORIA.id = LIVRO.fk_categoria
where Categoria.id =3 



select * from CATEGORIA

use Mundo
create table Grupo(
id int primary key not null identity,
Nome varchar(20)
)

insert into Grupo values('Anquilossauros')
insert into Grupo values('Ceratopsideos')
insert into Grupo values('Estegossauros')
insert into Grupo values('Terapodes')

DROP TABLE DESCOBRIDOR
create table Descobridor(
id int not null identity primary key,
Nome varchar(50)
)

insert into Descobridor values('Maryanska')
insert into Descobridor values('John Bell Hatcher')
insert into Descobridor values('Cientistas Alemães')
insert into Descobridor values('Museu Americano de Historia Natural')
insert into Descobridor values('Orthniel Charles Marsh')
insert into Descobridor values('Barmum Brown')

create table Era(
id int not null primary key identity,
Nome varchar(30),
AnoInicio int,
AnoFim int
)

insert into Era(NOME) values('Cretaceo')
insert into Era(NOME) values('Jurassico')

create table Dinossauro(
id int not null identity primary key,
Especie varchar(15),
Grupo int,
Toneladas int,
Ano_Descoberto int,
Descobridor int,
Era int,
Pais INT,

foreign key(Grupo) references Grupo(id),
foreign key(Descobridor) references Descobridor(id),
foreign key(Era) references Era(id),
FOREIGN KEY(pAIS) REFERENCES PAIS(IDPAIS)
)

INSERT INTO Dinossauro values('Saichania',1,4,1977,1,1,12)
INSERT INTO Dinossauro values('Triceratops',2,6,1887,2,1,13)
INSERT INTO Dinossauro values('Kentrossauro',3,2,1909,3,2,14)
INSERT INTO Dinossauro values('Pinacossauro',1,6,1999,4,1,9)
INSERT INTO Dinossauro values('Alossauro',4,3,1877,5,2,3)
INSERT INTO Dinossauro values('Torossauro',2,8,1891,2,1,3)
INSERT INTO Dinossauro values('Anquilossauro',1,8,1906,6,1,3)

select * from Grupo
SELECT * FROM Descobridor
SELECT * FROM ERA
SELECT * FROM PAIS

SELECT * FROM Dinossauro

/* Selecionar todos dados em ordem de dinossauro */
SELECT Dinossauro.Especie,
	   gRUPO.Nome AS 'Grupo',
	   Dinossauro.Toneladas, Dinossauro.Ano_Descoberto,
	   Descobridor.Nome AS 'Descobridor',
	   Era.Nome as 'Era',
	   Pais.Nome as 'Pais'
FROM Dinossauro 
INNER JOIN Descobridor ON Descobridor.id = Dinossauro.Descobridor
inner join Grupo on Grupo.id = Dinossauro.Grupo
inner join Era on Era.id = Dinossauro.Era
inner join Pais on Pais.IdPais = Dinossauro.Pais
ORDER BY Dinossauro.Especie

/* Selecionar todos os dados em ordem de descobridor */ 
SELECT Dinossauro.Especie,
	   gRUPO.Nome AS 'Grupo',
	   Dinossauro.Toneladas, Dinossauro.Ano_Descoberto,
	   Descobridor.Nome AS 'Descobridor',
	   Era.Nome as 'Era',
	   Pais.Nome as 'Pais'
FROM Dinossauro 
INNER JOIN Descobridor ON Descobridor.id = Dinossauro.Descobridor
inner join Grupo on Grupo.id = Dinossauro.Grupo
inner join Era on Era.id = Dinossauro.Era
inner join Pais on Pais.IdPais = Dinossauro.Pais
ORDER BY Descobridor.Nome

/* Anquilossauros ordenados por ano de descoberta */
SELECT Dinossauro.Especie,
	   gRUPO.Nome AS 'Grupo',
	   Dinossauro.Toneladas, Dinossauro.Ano_Descoberto,
	   Descobridor.Nome AS 'Descobridor',
	   Era.Nome as 'Era',
	   Pais.Nome as 'Pais'
FROM Dinossauro 
INNER JOIN Descobridor ON Descobridor.id = Dinossauro.Descobridor
inner join Grupo on Grupo.id = Dinossauro.Grupo
inner join Era on Era.id = Dinossauro.Era
inner join Pais on Pais.IdPais = Dinossauro.Pais
where Dinossauro.Grupo like 1
ORDER BY Dinossauro.Ano_Descoberto

/* Anquilossauros e ceratopsideos cujo ano de descoberta seja entre 1900 e 1999 */
SELECT Dinossauro.Especie,
	   gRUPO.Nome AS 'Grupo',
	   Dinossauro.Toneladas, Dinossauro.Ano_Descoberto,
	   Descobridor.Nome AS 'Descobridor',
	   Era.Nome as 'Era',
	   Pais.Nome as 'Pais'
FROM Dinossauro 
INNER JOIN Descobridor ON Descobridor.id = Dinossauro.Descobridor
inner join Grupo on Grupo.id = Dinossauro.Grupo
inner join Era on Era.id = Dinossauro.Era
inner join Pais on Pais.IdPais = Dinossauro.Pais
where (Dinossauro.Grupo like 2 or Dinossauro.Grupo like 1) 
and Dinossauro.Ano_Descoberto between 1900 And 1999

select * from grupo