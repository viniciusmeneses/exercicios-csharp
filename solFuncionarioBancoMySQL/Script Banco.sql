create database BDFuncionario;
use BDFuncionario;

create table Funcionario (
	CPF varchar(14) not null primary key,
    nome varchar(50) not null,
    cargo varchar(30) not null,
    salario double(20,2) not null,
    dataAdmissao date not null,
    dataDemissao date null
);