CREATE DATABASE db3camadas; 
USE db3camadas; 

CREATE TABLE tbl_Dados
(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	iarpp VARCHAR(50) NOT NULL,
	i3 VARCHAR(40) NOT NULL,
	p6 VARCHAR(200) NOT NULL
);

CREATE TABLE tbl_Usuario
(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(30),
	telefone INT NOT NULL, 
	rua VARCHAR(30) not null,
	bairro VARCHAR(30) not null,
	cidade VARCHAR(30) not null,
	estado VARCHAR(30) not null,
	pais VARCHAR(30) not null,
	cpf VARCHAR(30) not null,
	rg VARCHAR(30) not null,
	datanascimento datetime,
	país VARCHAR(30) not null,
    email  VARCHAR(30) not null,
	senha  VARCHAR(30) NOT NULL
	FOREIGN KEY(id) REFERENCES tbl_Dados(id) 
);