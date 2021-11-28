/* Aula 17/11 */

create table LIVRO
(
    isbn varchar(50) primary key not null,
    titulo varchar(100) not null,
    ano_publicacao date not null,
    fk_editora integer not null,
    fk_categoria integer not null,
    FOREIGN KEY (fk_editora) REFERENCES EDITORA (id),
    FOREIGN KEY (fk_categoria) REFERENCES CATEGORIA (id)
)

/*insert*/
insert into CATEGORIA values('Literatura Juvenil');
insert into CATEGORIA values('Ficção Científica');
insert into CATEGORIA values('Humor');
select * from CATEGORIA;
insert into AUTOR(nome) values('J.K.Rowling');
insert into AUTOR(nome) values('Clive Staples Lewis');
insert into AUTOR(nome) values('Affonso Solano');
insert into AUTOR(nome) values('Marcos Piangers');
insert into AUTOR(nome) values('Ciro Botelho - Tiririca');
insert into AUTOR(nome) values('Bianca Mól');
select * from AUTOR;
insert into EDITORA(nome) values('Rocco');
insert into EDITORA(nome) values('Wmf Martins Fontes');
insert into EDITORA(nome) values('Casa da Palavra');
insert into EDITORA(nome) values('Belas Letras');
insert into EDITORA(nome) values('Matrix');
select *from EDITORA;
insert into LIVRO values('8532511015','Harry Potter e A Pedra Filosofal','2000',1,1);
insert into LIVRO values('9788578270698','As Crônicas de Nárnia','2009',1,2);
insert into LIVRO values('9788577343348','O Espadachim de Carvão','2013',3,3);
insert into LIVRO values('9788581742458','O Papai É Pop','2015',3,1);
insert into LIVRO values('9788582302026','Pior Que Tá Não Fica','2015',4,2);
insert into LIVRO values('9788577345670','Garota Desdobrável','2015',2,3);
insert into LIVRO values('8532512062','Harry Potter e o Prisioneiro de Azkaban','2000',1,1);
select *from LIVRO;

drop table LIVROAutor
create table LivroAutor(
id int not null identity primary key,
FkLivro varchar(50) not null,
FkAutor int not null,

foreign key(FkLivro) references Livro(ISBN),
foreign key(FkAutor) references Autor(id)
)

insert into LIVROAUTOR values('8532511015',1);
insert into LIVROAUTOR values('9788578270698',2);
insert into LIVROAUTOR values('9788577343348',3);
insert into LIVROAUTOR values('9788581742458',4);
insert into LIVROAUTOR values('9788582302026',5);
insert into LIVROAUTOR values('9788577345670',6);
insert into LIVROAUTOR values('8532512062',1);
select *from LIVROAUTOR;

/* Delete */

delete from LIVROAUTOR where fk_livro = '8532512062'
delete from LIVROAUTOR where fk_livro = '8532512062' and fk_autor = 1
delete from LIVROAUTOR where (fk_livro = '8532512062' and fk_autor = 1) or id=17

/* UPDATE */

update LIVRO set ano_publicacao = '1983' where isbn = '9788578270698'

update LIVRO set ano_publicacao = '1987', titulo = 'As cronicas de narnia, volume unico' where isbn = '9788578270698'

select * from LIVRO
select * from EDITORA
select * from CATEGORIA

update Livro set fk_editora = 1 where ano_publicacao > '2000'
update Livro set fk_categoria = 1 where fk_editora = 1
update Livro set ano_publicacao = '2010' where fk_editora = 5 and fk_categoria = 3