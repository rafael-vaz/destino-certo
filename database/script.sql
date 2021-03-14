/*CRIAÇÃO DO BANCO DE DADOS*/
create database destinocerto;

/*CRIAÇÃO DAS TABELAS*/

create table usuarios(
id_usuarios int auto_increment not null primary key,    
nome varchar(200) not null,
login varchar(100) not null,
data_nascimento varchar(50) not null,
senha varchar(50) not null,
conta varchar(50) not null    
);

create table pacotes(
id_pacotes int auto_increment not null primary key,    
nome varchar(200) not null,
origem varchar(200) not null,
destino varchar(200) not null,
saida varchar(50) not null,
retorno varchar(50) not null,
preco double(9,2) not null,
id_usuarios int  
);

create table atendimento(
    id_atendimento int auto_increment not null primary key,
    nome varchar(200) not null,
    email varchar(200) not null,
    duvida varchar(500) not null
);

/*INSERT DE ALGUNS USUÁRIOS*/

insert into usuarios (nome, login, data_nascimento, senha, conta) values ("Rafael", "rafael-vaz", "17/01/1995", "1701", "administrador");
insert into usuarios (nome, login, data_nascimento, senha, conta) values ("Miguel", "miguel-pereira", "05/11/1998", "1802", "administrador");

insert into usuarios (nome, login, data_nascimento, senha, conta) values ("Paulo", "paulo-carvalho", "25/06/1997", "1358", "colaborador");
insert into usuarios (nome, login, data_nascimento, senha, conta) values ("Gustavo", "gustavo-ferreira", "18/07/1992", "1587", "colaborador");

insert into usuarios (nome, login, data_nascimento, senha, conta) values ("Rodrigo", "rodrigo-silva", "08/03/1996", "3601", "usuario");
insert into usuarios (nome, login, data_nascimento, senha, conta) values ("Lucas", "lucas-freitas", "15/01/1995", "2201", "usuario");

