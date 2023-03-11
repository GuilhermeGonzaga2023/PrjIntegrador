create table Cliente
(
idCliente int identity(1,1),
nomeCliente varchar(100) not null,
loginCliente varchar(50)not null,
senhaCliente varchar(50)not null
constraint pk_Cliente primary key (idCliente)
)

create table Funcionario
(
idFuncionario int identity(1,1),
nomeFuncionario varchar(100)not null,
cpfFuncionario char(11)not null,
loginFuncionario varchar(50)not null,
senhaFuncionario varchar(50)not null
constraint pk_funcioario primary key (idFuncionario)
)

create table Vagas
(
idVaga int identity(1,1),
numeroVaga int
)