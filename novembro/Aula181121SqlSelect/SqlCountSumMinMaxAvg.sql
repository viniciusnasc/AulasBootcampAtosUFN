/* Aula 18/11 */

select * from Livro

update Livro set titulo = 'Pior que tá não fica' where titulo like 'Pior Que Tá Não Fica'

select * from LIVRO where ano_publicacao > '2010' and ano_publicacao < '2014'
select * from LIVRO where MONTH(ano_publicacao) = '01'
select * from LIVRO where YEAR(ano_publicacao) = '2015'
select * from LIVRO where YEAR(ano_publicacao) = '2015' and MONTH(ano_publicacao) = '01'
select * from LIVRO where ano_publicacao like '2015-%'
select * from LIVRO where titulo like 'Harry%'
select * from LIVRO where titulo like 'Harry%' or titulo like 'Garota%'
select titulo from LIVRO where ano_publicacao like '2015-%'

/* Exercicios */
select * from eventos where localizacao = 'RS'
select * from eventos where localizacao like 'RS' or localizacao like 'SP'
select * from Ingressos where valor like 50
select * from Ingressos where lugar like 'RJ'
select * from Ingressos where valor >= 50 and valor <= 150
select titulo from Ingressos where valor like 50
select email from Pessoas where fone like '55%'
select * from Ingressos where valor BETWEEN 50 and 150
SELECT email from pessoas where fone

create table CategoriaProdutos(
id int primary key not null identity,
nome varchar(30)
)

create table Produto(
codigo int primary key not null identity,
nome varchar(20),
preco real not null,
estoque int,
idCategoria int,

foreign key(idCategoria) references CategoriaProdutos(id)
)

insert into CategoriaProdutos values('Bebidas')
insert into CategoriaProdutos values('Acougue')
insert into CategoriaProdutos values('Hortifruti')
insert into CategoriaProdutos values('Frios')
insert into CategoriaProdutos values('Limpeza')
insert into CategoriaProdutos values('Bazar')
insert into CategoriaProdutos values('Higiene')
insert into CategoriaProdutos values('Padaria')

select * from CategoriaProdutos
select * from Produto

insert into Produto values('agua com gas', 0.89, 1000, 1)
insert into Produto values('refrigerante 2L', 4.33, 700, 1)
insert into Produto values('ponta de peito', 32.89, 433, 2)
insert into Produto values('sobrecoxa de frango', 13.77, 35, 2)
insert into Produto values('queijo', 30.84, 100, 4)
insert into Produto values('mortadela', 14.84, 100, 4)

select count(*) from Produto
select count(*) as TOTALDEPRODUTOS from Produto
select count(*) from Produto where idCategoria like 2

/* Apresentar quantos produtos tem cadastrados nas categorias 1, 2 e 6 */
select count(*) from Produto where idCategoria like 1 or idCategoria like 2 or idCategoria like 6

select MAX(estoque) from Produto
select MAX(estoque) as Maior_estoque from Produto
update Produto set estoque = 1103 where codigo = 1

/* Apresentar o produto com maior preco da categoria 2*/
select MAX(preco) from Produto where idCATEGORIA like 2

/* Apresentar o produto com menor preco da categoria 1*/
select MIN(preco) from Produto where idCATEGORIA like 1

/* Apresentar a media de preco dos produtos e a media de estoque dos produtos*/
select AVG(preco) from Produto
select AVG(estoque) from produto

/* Apresentar o somatorio do estoque e de preco total e por categoria*/
select SUM(preco) as somatorio_de_preco from Produto
select SUM(Estoque) as somatorio_de_estoque from Produto

select idCategoria, SUM(estoque) as somatorio_estoque from Produto group by idCategoria
select idCategoria, SUM(preco) as somatorio_precos from Produto group by idCategoria

select SUM(preco * estoque) from Produto

create table Venda(
id int not null primary key identity,
fk_produto int not null,
quantidade int not null,
valor real not null,
caixa varchar(50),

foreign key (fk_produto) references produto(codigo)
)
drop table venda
insert into Venda values(1,10,500, 'Astolfo')
insert into Venda values(2,15,500, 'Ricardo')
insert into Venda values(5,20,300, 'Fabricio')

select distinct caixa from venda /* Mostra os caixas que venderam algo */

select caixa, sum(valor) as valor_total_vendas from venda group by caixa order by valor_total_vendas