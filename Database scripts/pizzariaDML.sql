CREATE DATABASE Pizzaria
GO 
USE Pizzaria
GO 
CREATE TABLE tbCliente(
	IdCliente int identity primary key  NOT NULL,
	Nome varchar(200) NOT NULL,
	Cpf varchar(11) NOT NULL,
	Email varchar(30) NOT NULL,
	Telefone varchar(12) NOT NULL,
	DataNascimento datetime  NOT NULL,
	Ativo char(1)  NOT NULL,
);

CREATE TABLE tbFuncionario(
	Id int Identity primary key  NOT NULL ,
	Nome varchar(200)  NOT NULL,
	Usuario varchar(30)  NOT NULL,
	Senha varchar(200) NOT NULL,
	DataAdmissao datetime  NOT NULL,
	DataNascimento datetime NOT NULL,
	Ativo char(1)  NOT NULL,
);


GO

CREATE TABLE [dbo].[tbIngredientes](
	[IdIngrediente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](30) NULL,
	[Descricao] [varchar](20) NULL,
	[QtdCal] [int] NULL,
	[Preco] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdIngrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE tbPizza(
	IdPizza int identity primary key,
	Nome varchar(20),
	Preco decimal,
	Tamanho int ,

)
CREATE TABLE tbUsuario(
	IdUsuario int identity primary key,
	IdCliente int foreign key (IdCliente) References tbCliente,
	Nome varchar(20),
	Senha varchar(200),
	Ativo char(1)
)

CREATE TABLE tbAvaliacao(
	IdAvaliacao int identity primary key,
	Titulo varchar(30),
	Comentario varchar(50),
	Nota int,
	Ativo char(1)
)
CREATE TABLE tbBebidas(
	IdBebida int primary key identity,
	Nome varchar(50),
	Preco decimal,
	Ativo char(1),

)

CREATE TABLE tbPizza_Ingrediente(
IdPizzaIngrediente INT IDENTITY PRIMARY KEY,
IdPizza int foreign key (IdPizza) References tbPizza,
IdIngrediente int foreign key (IdIngrediente) References tbIngredientes,
)

CREATE TABLE tbPedido(
IdPedido INT IDENTITY PRIMARY KEY ,
StatusPedido CHAR(1),
ValorPedido Decimal,
TipoPedido CHAR(1),
DataPedido DATETIME, 
FormaPagamentoPedido Varchar(20),
Endereco VARCHAR(100),
)




CREATE TABLE tbPedido_Produto(
IdPedidoProduto INT IDENTITY PRIMARY KEY,
IdPizza int foreign key (IdPizza) References tbPizza,
IdBebida int FOREIGN key (IdBebida)REFERENCES tbBebidas
)