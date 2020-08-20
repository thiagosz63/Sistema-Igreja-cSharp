/* Sistema Igreja Assembleia de Deus Shekinah */

create database IGREJA_SHEKINAH;
use IGREJA_SHEKINAH;

create table PESSOAS(
	idpessoa int primary key auto_increment,
	nome varchar(50) not null,
	sexo enum ('M','F') not null,
	estado_civil varchar(20) not null,
	email varchar (30),
	rg varchar(15) unique,
	cpf varchar(15) not null unique,
	cargo varchar (30) not null,
	situacao varchar (30) not null,
	id_igrejas int not null 
);

create table IGREJAS(
	idigrejas int primary key auto_increment,
	congregacao varchar (50) not null,
	dirigente varchar(30) not null
);

create table ENDERECO(
	idendereco int primary key auto_increment,
	rua varchar (30) not null,
	numero varchar (10),
	bairro varchar (30) not null,
	cidade varchar (30) not null,
	estado char (2) not null,
	id_pessoas int not null unique,
	id_igrejas int not null unique
); 

create table TELEFONE(
	idtelefone int primary key auto_increment,
	tipo enum ('res','cel','com') not null,
	numero varchar (10) not null,
	id_pessoas int not null unique,
	id_igrejas int not null unique
);

create table ADMINISTRACAO(
	idadministracao int primary key auto_increment,
	login varchar(30) not null,
	senha varchar(20) not null
);

create table USUARIO(
	idusuario int primary key auto_increment,
	login varchar(30) not null,
	senha varchar(20) not null
);

alter table PESSOAS 
add constraint FK_PESSOAS_IGREJAS
foreign key(id_igrejas)
references IGREJAS(idigrejas);

alter table TELEFONE 
add constraint FK_TELEFONE_PESSOAS
foreign key(id_pessoas)
references PESSOAS(idpessoa);

alter table TELEFONE 
add constraint FK_TELEFONE_IGREJAS
foreign key(id_igrejas)
references IGREJAS(idigrejas);

alter table ENDERECO 
add constraint FK_ENDERECO_PESSOAS
foreign key(id_pessoas)
references PESSOAS(idpessoa);

alter table ENDERECO 
add constraint FK_ENDERECO_IGREJAS
foreign key(id_igrejas)
references IGREJAS(idigrejas);
