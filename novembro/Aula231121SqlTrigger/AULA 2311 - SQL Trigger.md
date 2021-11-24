/* Aula 23/11 - trigger*/
select * from Java
select * from dotnet

create table log(
id int not null primary key identity,
acao varchar(10) not null,
descricao varchar(100),
quando datetime not null
)

create trigger PrimeiraTrigger
on Java
after delete
as
begin
insert into log values('delete', 'foi excluido um registro da tabela java', GETDATE());
end

insert into Java values('ricardo')
delete Java where professor = 'ricardo'

select * from java
select * from log

create trigger SegundaTrigger
on java 
after insert
as
begin
	insert into log values('insersão', 'foi incluido um registro da tabela java', GETDATE());
	PRINT('Dados inseridos!');
end

insert into java values('ricardo')

DROP TRIGGER TERCEIRATRIGGER
create trigger TerceiraTrigger
on dotnet
after insert
as 
begin
	declare @contagem int
	select @contagem = (select count(professor) from dotnet)
	print('Quantidade de registros: ' + convert(varchar(10),@contagem))
	if @contagem <=3
		begin
			insert into log VALUES('INSERCAO', 'NOVO PROFESSOR NA ACADEMIA .NET', GETDATE());
			PRINT('dADOS INSERIDOS COM SUCESSO!');
		end
	else
		begin
			insert into log VALUES('INSERCAO', 'TENTATIVA DE INSERCAO DE NOVO PROFESSOR NA ACADEMIA .NET', GETDATE());
			ROLLBACK;
			RAISERROR('INVALIDO', 1,1);
			RETURN;
		end
end

select * from log
SELECT * FROM DOTNET
INSERT INTO DOTNET VALUES('TESTE')

drop trigger quartatrigger
create trigger QuartaTrigger
on dotnet
after update
as 
BEGIN
	declare @old varchar(10)
	declare @new varchar(10)

	select @old = (select deleted.Professor from deleted)
	select @new = (select inserted.Professor from inserted)
	
	if(ROWCOUNT_BIG() = 0)--Boa pratica para interromper uma trigger caso nenhum registro tenha sido afetado
		return;
	
	if @old = @new
		begin
			raiserror('Sem alterações! Valores são iguais', 14,1 );
			rollback transaction;
			insert into log values('Alteraçao', 'tentativa de alteração do nome de um professor na academia dotnet, pelo mesmo nome', getdate())
		end
	else
	begin
		insert into log values('Alteraçao', 'alteração do nome de um professor ' + @old + ' na academia dotnet, para o nome ' + @new, getdate())
	end
END

create trigger QuintaTrigger
on dotnet
after delete
as
BEGIN
	declare @nome varchar(10)
	select @nome = (select deleted.Professor from deleted)
	insert into log values('exclusão', @nome + ' foi excluido dos professores da academia .net', getdate());
END

delete from dotnet where professor = 'teste'
insert into dotnet values('teste')

select * from log

create trigger SextaTrigger
on dotnet
instead of insert
as
begin
	insert into log values('inclusao', 'novo professor na academia .net', getdate());
	insert into dotnet values(UPPER((select inserted.professor from inserted)));
end

select * from dotnet
select * from log

insert into dotnet values('vinicius');

/* exercicios */
update era set anoinicio = 145 where Nome='cretaceo'
update era set anofim = 65 where Nome='cretaceo'
update era set anoinicio = 154 where Nome='jurassico'
update era set anofim = 199 where Nome='jurassico'
select * from era

alter table dinossauro add Inicio int
alter table dinossauro add Fim int

select * from dinossauro
select * from era

drop trigger DinossauroEraTrigger

create trigger DinossauroEraTrigger
on dinossauro
after insert
as
begin
		declare @Inicio int
		declare @Fim int
		select @Inicio = (select inserted.Inicio from inserted)
		select @Fim = (select inserted.Fim from inserted)

		declare @InicioEra int
		declare @FimEra int
		select @InicioEra = (select Era.AnoInicio from inserted join Era on Era.Id = inserted.Era)
		select @FimEra = (select Era.AnoFim from inserted join Era on Era.Id = inserted.Era)
	
		if @Inicio > @InicioEra 
		begin
			raiserror('O inicio do aparecimento do dinossauro não condiz com a era', 14,1 );
			rollback transaction;
		end
	
		if @Fim < @FimEra
		begin
			raiserror('A data de extinção do dinossauro não condiz com a era', 14,1 );
			rollback transaction;
		end
end

insert into dinossauro values('dinossauron', 1,5,1900,2,1,2,144,3)