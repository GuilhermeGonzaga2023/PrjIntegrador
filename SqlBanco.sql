create table Cliente
(
idCliente int identity(1,1),
nomeCliente varchar(100) not null,
placaCarro varchar(8)not null,
loginCliente varchar(50) unique not null,
senhaCliente varchar(50)not null
constraint pk_Cliente primary key (idCliente)
)

go
create procedure pi_Cliente
@nomeCliente varchar(100),

@loginCLiente varchar(50),
@senhaCliente varchar(50)
as
insert into Cliente
(nomeCliente, loginCliente, senhaCliente)
values (@nomeCliente, @LoginCliente, @senhaCLiente)


create table Funcionario
(
idFuncionario int identity(1,1),
nomeFuncionario varchar(100)not null,
cpfFuncionario char(11)not null,
loginFuncionario varchar(50) unique not null,
senhaFuncionario varchar(50)not null
constraint pk_funcioario primary key (idFuncionario)
)

go
create procedure pi_Funcionario
@nomeFuncionario varchar(100),
@cpfFuncionario char(11),
@loginFuncionario varchar(50),
@senhaFuncionario varchar(50)
as
insert into Funcionario
(nomeFuncionario,  cpfFuncionario, loginFuncionario, senhaFuncionario)
values (@nomeFuncionario, @cpfFuncionario, @loginFuncioario, @senhaFuncionario)

--create table Vaga
--(
--idVaga int identity(1,1),
--idCliente int not null,
--numeroVaga int not null,
--localVaga varchar(100)not null
--constraint pk_Vagas primary key (idVaga)
--constraint fk_Vagas_Cliente foreign key
--(idCliente) references Cliente (idCliente)
--)