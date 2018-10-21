create database SistemaVeiculos;
use SistemaVeiculos;

create table veiculo (
	id int(4) primary key auto_increment not null,
	marca varchar(15) not null,
	nome varchar(25) not null,
	combustivel varchar(8) not null,
	lugares int(1) not null,
	velocidadeMax int(3) not null
);

create table carro (		
	modelo varchar(15) not null,
	arCond varchar(3) not null,
	som varchar(3) not null,
	direcao varchar(15) not null,
    idVeiculo int(4) not null,
    foreign key (idVeiculo) references veiculo(id)
);