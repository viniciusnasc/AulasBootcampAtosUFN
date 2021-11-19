/* Aula 16/11 */

/* Insert */
INSERT INTO TIPO_EVENTO values('MINICURSO')
INSERT INTO EVENTOS values('Carnaval SP', '2022-03-02', '2022-03-06', 'SP', 4)
INSERT INTO EVENTOS values('Grenal', '2022-03-16', '2022-03-16', 'Arena', 2)
insert into PESSOAS values('12345678953', 'karina','karina@gmail.com','11999999997')
insert into PESSOAS values('12345678123', 'ana','ana@gmail.com','11999999998') 
select * from TIPO_EVENTO
select * from EVENTOS
select * from PESSOAS

Insert into PROGRAMACAO values(1, 'Eluveitie', 'show da banda eluveitie','2022-05-9 21:00:00', '2022-05-9 23:00:00', 'palco1', 'chris')
Insert into PROGRAMACAO values(1, 'Angra', 'show da banda angra','2022-05-10 21:00:00', '2022-05-10 23:00:00', 'palco1', 'kiko')
Insert into PROGRAMACAO values(1, 'Avantasia', 'show da banda avantasia','2022-05-11 21:00:00', '2022-05-11 23:00:00', 'palco1', 'tobias')

insert into ingressos values(

drop table contatos
create table Contatos(
id int identity not null primary key,
nome varchar(50) not null,
telefone varchar(20),
email varchar(50))

insert into Contatos(nome, telefone) values ('Pedro', '05597653487')
insert into Contatos values ('Alan', '05184101245', 'alan@gmail.com')
insert into Contatos(nome, email) values ('Joana', 'joana@gmail.com')
insert into Contatos values ('Carlos', '05599105314', 'carlos@gmail.com')

create table Livros(
ISBN int primary key not null identity,
Titulo varchar(50) not null,
AnoLancamento int not null,
FkEditora int not null,
FkAutor int not null,
FkCategoria int not null,

foreign key(FkEditora) references Editora(id),
foreign key(FkAutor) references Autor(id),
foreign key(FkCategoria) references Categoria(id)
)

create table LivroAutor(
id int not null identity primary key,
FkLivro int not null,
FkAutor int not null,

foreign key(FkLivro) references Livros(ISBN),
foreign key(FkAutor) references Autor(id)
)

create table Editora(
id int primary key not null identity,
Nome varchar(20) not null
)

create table Autor(
id int primary key not null identity,
Nome varchar(50) not null,
Nacionalidade varchar(50)
)

create table Categoria(
id int primary key not null identity,
Nome varchar(20) not null,
)