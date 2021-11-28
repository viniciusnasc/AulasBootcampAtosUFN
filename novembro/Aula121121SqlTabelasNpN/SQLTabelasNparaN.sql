/* AULA 12/11 => Comandos SQL*/

/* Criacao de tabelas n para n */
create table professor(
idProfessor int primary key not null identity,
nome varchar(20),
)

create table disciplina(
idDisciplina int primary key not null identity,
nome varchar(20),
)

create table Aluno(
idAluno int primary key not null identity,
nome varchar(20),
professor int,
Constraint  FK_Professor Foreign Key(professor)
references professor(idProfessor)
)

create table disciplinaAluno(
idDisciplinaAluno int primary key not null identity,
Aluno int,
Disciplina int
Constraint FK_Aluno Foreign Key(Aluno)
references Aluno(idAluno),
Constraint FK_Disciplina Foreign Key(disciplina)
references disciplina(idDisciplina)
)

/* Atividade Pilotos - Equipes - Patrocinadores */

create table equipe(
equipeId int primary key not null identity,
nomeEquipe varchar(50)
)

create table piloto(
pilotoMatricula int primary key not null identity,
nome varchar(50),
equipe int,
Constraint FK_equipe Foreign key(equipe)
references equipe(equipeId)
)

create table patrocinador(
patrocinadorId int primary key not null identity,
equipe int,
Constraint FK_patrocinadorEquipe Foreign Key(equipe)
references equipe(equipeId)
)

create table contratoEquipePiloto(
contratoId int primary key not null identity,
equipe int,
piloto int,
dataInicial date,
dataFinal date,
salario numeric(10,2),
Constraint FK_contratoPilEq Foreign Key(piloto)
references piloto(pilotoMatricula),
Constraint FK_contratoEqPil Foreign Key(equipe)
references equipe(equipeId)
)

create table contratoEquipePatrocinador(
contratoId int primary key not null identity,
equipe int,
patrocinador int,
valorContrato numeric(10,2),
dataInicial date,
dataFinal date,
Constraint FK_contratoEqPat Foreign key(equipe)
references equipe(equipeId),
Constraint FK_contratoPatEq Foreign Key(patrocinador)
references patrocinador(patrocinadorId)
)

/* Exercicio Eventos */
CREATE TABLE TIPO_EVENTO
(
    id integer primary key identity not null,
    tipo varchar(50)
);
CREATE TABLE EVENTOS
(
    id integer primary key not null identity,
    nome varchar(50) not null,
    data_ini date not null,
    data_fim date not null,
    localizacao varchar(100) not null,
    fk_tipo integer not null,
    foreign key (fk_tipo) references TIPO_EVENTO(id)
);
CREATE TABLE PROGRAMACAO/*atrações*/(
    id integer primary key not null identity,
    fk_evento integer not null,
    nome varchar(50) not null,
    descricao varchar(500) not null,
    data_ini datetime not null,
    data_fim datetime not null,
    lugar varchar(100) not null,
    responsavel varchar(100) not null, /*ministrante, cantor, grupo...*/    
	foreign key (fk_evento) references EVENTOS(id)
);
CREATE TABLE INGRESSOS
(
    id integer primary key not null identity,
    titulo varchar(50) not null,
    lugar varchar(100) not null,
    valor real not null,
    quantidade integer not null,
    fk_evento integer not null,
    foreign key (fk_evento) references EVENTOS(id)
);
CREATE TABLE PESSOAS
(
    cpf varchar(11) not null primary key,
    nome varchar(70) not null,
    email varchar(50) not null,
    fone varchar(15)
);
CREATE TABLE COMPRA /*inscricao*/(
    id integer primary key not null identity,
    fk_pessoa varchar(11) not null,
    fk_ingresso integer not null,
    quantidade integer not null    foreign key (fk_ingresso) references INGRESSOS (id),
    foreign key(fk_pessoa) references PESSOAS(cpf)
);