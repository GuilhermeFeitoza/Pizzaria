CREATE DATABASE Pizzaria
GO 
USE Pizzaria
GO 
CREATE TABLE tbCliente(
	IdCliente int identity primary key,
	Nome varchar(200),
	Cpf varchar(11),
	Email varchar(30),
	Telefone varchar(12),
	DataNascimento datetime,
	Ativo char(1),
);

CREATE TABLE tbFuncionario(
	Id int Identity primary key ,
	Nome varchar(200),
	Usuario varchar(30),
	Senha varchar(200),
	DataAdmissao datetime,
	DataNascimento datetime,
	Ativo char(1),
);

CREATE TABLE tbIngredientes(
	IdIngrediente int identity primary key ,
	Nome varchar(30),
	Descricao varchar(20),
	QtdCal int,
	  );
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
	IdBebida int identity,
	Nome varchar(20),
	Preco decimal,
	Ativo char(1),
	

)