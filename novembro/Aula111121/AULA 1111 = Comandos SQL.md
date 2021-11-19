/* AULA 11/11 => Comandos SQL*/
/* Criar e destruit Database */
create database AulaUfn
drop database AulaUfn

/* Comando para ativar a database */
use AulaUfn

/* Criar tabela */
create table Pessoa(
id_pessoa int,
nome varchar(50),
idade int,
dtnasc date
) 

/* Deletar tabela */
drop table Pessoa

/* Selecionar todas dados de uma tabela */
select * from Pessoa

/* Adicionar coluna: */
alter table Pessoa add CPF int

/* Apagar coluna: */
alter table Pessoa drop column CPF

/* Alterar coluna: */
alter table Pessoa alter column nome varchar(35)

/* Indicando uma chave estrangeira */
create table Produto(
id_produto int primary key not null identity,
nome_produto varchar(40),
valor numeric(16,2),
data_compra date,
fabricante int,
CONSTRAINT FK_fabricante FOREIGN KEY(fabricante)
REFERENCES Fabricante (id_fabricante)
)
create table Fabricante(
id_fabricante int primary key not null identity,
nome_fabricante varchar(50)
)

/* Exercicio criar tabela pais, estado e cidade com as devidas chaves estrangeiras */
create table Pais(
id_pais int primary key not null identity,
nome_pais varchar(20)
)

create table Estado(
id_Estado int primary key not null identity,
nome_estado varchar(20),
pais int
CONSTRAINT FK_pais FOREIGN KEY(Pais)
REFERENCES Pais (id_pais)
)

create table Cidade(
id_Cidade int primary key not null identity,
nome_cidade varchar(20),
estado int
CONSTRAINT FK_estado FOREIGN KEY(Estado)
REFERENCES Estado (id_estado)
)