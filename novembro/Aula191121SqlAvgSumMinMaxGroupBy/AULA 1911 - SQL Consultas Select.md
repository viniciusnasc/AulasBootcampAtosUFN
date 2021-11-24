/* Aula 19/11 - consultas select */

/* Mostra infos das tabelas*/
exec sp_columns Produto

select CategoriaProdutos.nome, sum(Produto.estoque) 
as Total_estoque_categoria
from CategoriaProdutos, Produto 
where Produto.idCategoria = CategoriaProdutos.id
group by CategoriaProdutos.nome
order by CategoriaProdutos.nome

select nome from CategoriaProdutos where nome like 'Bebidas'
select nome from Produto where nome like 'p_' /* seleciona produtos q comecam com p e tenha 2 letras */

/* Exercicio */

create database Mundo
use Mundo

drop table Continente
drop table Cidade
drop table Rio
drop table Pais

create table Continente(
IdContinente int not null primary key identity,
Nome varchar(35)
)

create table Pais(
IdPais int not null primary key identity,
Nome varchar(35) not null,
Continente int not null,
Pop real,
PIB real,
Expec_vida real,

foreign key(Continente) references Continente(IdContinente)
)

create table Cidade(
IdCidade int not null primary key identity,
Nome varchar(35) not null,
fk_pais int not null,
Pop real,
Capital varchar(1),

foreign key(fk_pais) references Pais(IdPais)
)

create table Rio(
IdRio int not null primary key identity,
Nome varchar(35) not null,
Nascente int not null,
Pais int not null,
Comprimento real,

foreign key(Nascente) references Pais(IdPais),
foreign key(Pais) references Pais(IdPais)
)

insert into Continente values ('America do Sul')
insert into Continente values ('America do Norte')
insert into Continente values ('America do Central')
insert into Continente values ('Africa')
insert into Continente values ('Europa')
insert into Continente values ('Asia')

insert into Pais values('Brasil', 1, 100000, 1.445, 90)
insert into Pais values('Alemanha', 5, 200000, 15.445, 100)
insert into Pais values('Estados Unidos', 2, 300000, 20.445, 85)
insert into Pais values('Japão', 6, 60000, 16.545, 95)
insert into Pais values('Egito', 4, 80000, 1.0, 80)
insert into Pais values('Mexico', 3, 50000, 1.545, 82)
insert into Pais values('Inglaterra', 5, 50000, 15.445, 97)
insert into Pais values('Russia', 6, 800000, 18.445, 99)
insert into Pais values('China', 6, 900000, 17.445, 60)
insert into Pais values('Chile', 1, 50000, 1.245, 80)
insert into Pais values('Portugal', 5, 60000, 8.445, 90)

insert into Cidade values('Sao Paulo', 1, 12.33, 'S')
insert into Cidade values('Franca', 1, 1.33, 'N')
insert into Cidade values('Lisboa', 11, 3.33, 'S')
insert into Cidade values('Sao Petersburgo', 8, 4.991, 'N')
insert into Cidade values('Nova york', 3, 8.419, 'N')
insert into Cidade values('Cairo', 5, 9.54, 'S')
insert into Cidade values('Nagasaki', 4, 0.429, 'N')
insert into Cidade values('South Park', 3, 1.812, 'N')
insert into Cidade values('Adamantina', 1, 0.035, 'N')
insert into Cidade values('Porto Alegre', 1, 12.33, 'S')

insert into Rio values('Amazonas', 1, 2, 100000)
insert into Rio values('Rio2', 3, 3, 10000)
insert into Rio values('Rio3', 1, 5, 20000)
insert into Rio values('Rio4', 1, 3, 20000)
insert into Rio values('Rio5', 4, 4, 20000)
insert into Rio values('Rio6', 5, 2, 20000)
insert into Rio values('Rio7', 6, 2, 20000)
insert into Rio values('Rio8', 6, 2, 20000)
insert into Rio values('Rio9', 6, 2, 1000)

/* Liste todas as cidades que são capitais. */
select * from Cidade where Capital = 'S'

/* Apresente todos os rios que a nascente é no Brasil */
select * from Rio where Nascente = 1

/* Apresente o nome dos países onde a expectativa de vida é menor que 70 anos. */
select * from Pais where Expec_vida < 70

/* Liste todas as capitais, os nomes dos países e as populações dos países cujos PIB é maior que 1 trilhão de dólares. */ 
select Cidade.Nome, Pais.Nome, Pais.Pop
from Cidade, Pais
where Pais.IdPais = Cidade.fk_pais and Pais.PIB > 1 and Cidade.Capital = 'S'
group by Pais.IdPais, Cidade.Nome, Pais.Nome, Pais.Pop
order by Pais.IdPais

/* Qual é a média da população das cidades que não são capitais. */
select AVG(Pop) from Cidade where Capital = 's'

/* Para cada continente retorne o PIB médio de seus países. */
select Continente.Nome, AVG(PIB) 
from Continente, Pais
where Pais.Continente = Continente.IdContinente
group by Continente.Nome

/* Apresente o menor comprimento de rio */
select MIN(Comprimento) from Rio

/* Apredente a média de comprimento dos rios nos EUA */
select AVG(Comprimento) from Rio where Pais = 3

/* Apresente o somatório de comprimento de rios do Brasil */
select SUM(Comprimento) from Rio where Pais = 1

/* Apresente todos os rios que a nascente e a foz são no Brasil */
select * from rio where Nascente = 1 and Pais = 1

/* Liste todas as cidades e os países aos quais pertencem. */
select Cidade.Nome, Pais.Nome 
from Cidade, Pais
where Cidade.fk_pais = Pais.IdPais

/* Apresente a quantidade de rios por continente. */
Select Continente.Nome, count(Rio.IdRio) 
from Continente, Rio, Pais
where Rio.Pais = Pais.IdPais and Pais.Continente = Continente.IdContinente 
group by Continente.Nome

/* Apresentar os nomes dos continentes e o somatorio de comprimento dos rios */
Select Continente.Nome, Sum(Rio.Comprimento)
from Continente, Rio, Pais
where Rio.Pais = Pais.IdPais and Pais.Continente = Continente.IdContinente
group by Continente.Nome

/* Apresentar a média de expectativa de vida mundial */
select AVG(Expec_vida) from Pais

/* Apresentar os nomes dos continentes e sua media da expectativa de vida */
select Continente.Nome, AVG(Pais.Expec_vida)
from Continente, Pais
where Pais.Continente = Continente.IdContinente
group by Continente.Nome

select * from Cidade
select * from Continente
select * from RIO

select CategoriaProdutos.nome, sum(Produto.estoque) 
as Total_estoque_categoria
from CategoriaProdutos, Produto 
where Produto.idCategoria = CategoriaProdutos.id
group by CategoriaProdutos.nome
order by CategoriaProdutos.nome