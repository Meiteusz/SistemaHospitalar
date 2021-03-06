create database SistemaHospitalas;

create table ADM(
ID INT PRIMARY KEY IDENTITY,
USUARIO VARCHAR(75) NOT NULL,
SENHA VARCHAR(75) NOT NULL,
VALORDIARIOINTERNACAO FLOAT,
isAtivo bit,
CONSTRAINT UQ_UK_isAtivo UNIQUE (isAtivo),
);



create table RECEPCIONISTAS(
ID INT PRIMARY KEY IDENTITY,
NOME VARCHAR(70) NOT NULL,
EMAIL VARCHAR(250) NOT NULL,
SENHA VARCHAR(25) NOT NULL,
CPF VARCHAR(14) NOT NULL,
TURNO CHAR(1) NOT NULL,
GENERO VARCHAR(10) NOT NULL,
CELULAR VARCHAR(15) NOT NULL,
CONSTRAINT UQ_RECEPCIONISTAS_EMAIL UNIQUE (EMAIL),
CONSTRAINT UQ_RECEPCIONISTAS_CPF UNIQUE (CPF)
);



create table DOUTORES(
ID INT PRIMARY KEY IDENTITY,
NOME VARCHAR(70) NOT NULL,
EMAIL VARCHAR(250) NOT NULL,
SENHA VARCHAR(25) NOT NULL,
CPF VARCHAR(14) NOT NULL,
TURNO CHAR(1) NOT NULL,
GENERO VARCHAR(10) NOT NULL,
CELULAR VARCHAR(15) NOT NULL,
ESPECIALIDADE VARCHAR(50) NOT NULL,
VALORCONSULTA FLOAT(53) NOT NULL,
VALOREXAME FLOAT(53) NOT NULL,
CONSTRAINT UQ_DOUTORES_EMAIL UNIQUE (EMAIL),
CONSTRAINT UQ_DOUTORES_CPF UNIQUE (CPF)
);



create table PACIENTES(
ID INT PRIMARY KEY IDENTITY,
NOME VARCHAR(70) NOT NULL,
CPF VARCHAR(14) NOT NULL,
CELULAR VARCHAR(15) NOT NULL,
GENERO VARCHAR(10) NOT NULL,
CONVENIOID INT,
CONSTRAINT UQ_PACIENTES_CPF UNIQUE (CPF),
CONSTRAINT FK_CONVENIO_PACIENTE FOREIGN KEY (CONVENIOID) REFERENCES CONVENIOS(ID)
);



create table CONVENIOS(
ID INT PRIMARY KEY IDENTITY,
NOME VARCHAR(70) NOT NULL,
DESCONTO DECIMAL(10,2),
CONSTRAINT UQ_CONVENIOS UNIQUE (NOME)
);



create table CONSULTAS(
ID INT PRIMARY KEY IDENTITY,
PACIENTEID INT NOT NULL,
DOUTORID INT NOT NULL,
DATACONSULTA SMALLDATETIME NOT NULL,
PRECO FLOAT(53) NOT NULL,
CONSTRAINT FK_PACIENTE_CONSULTA FOREIGN KEY (PACIENTEID) REFERENCES PACIENTES(ID),
CONSTRAINT FK_DOUTOR_CONSULTA FOREIGN KEY (DOUTORID) REFERENCES DOUTORES(ID)
);



create table EXAMES(
ID INT PRIMARY KEY IDENTITY,
CONSULTAID INT NOT NULL,
DATAEXAME SMALLDATETIME NOT NULL,
PRECO FLOAT(53) NOT NULL,
TIPOEXAME VARCHAR(50) NOT NULL,

CONSTRAINT FK_CONSULTA_EXAME FOREIGN KEY (CONSULTAID) REFERENCES CONSULTAS(ID)
);



create table VISITANTES(
ID INT PRIMARY KEY IDENTITY,
NOME VARCHAR(70) NOT NULL,
CPF VARCHAR(14) NOT NULL,
CONSTRAINT UQ_VISITANTES_CPF UNIQUE (CPF)
);



create table VISITAS(
ID INT PRIMARY KEY IDENTITY,
VISITANTEID INT NOT NULL,
DATAVISITA DATETIME2 NOT NULL,
INTERNACAOID INT NOT NULL,
CONSTRAINT FK_VISITANTE_VISITAS FOREIGN KEY (VISITANTEID) REFERENCES VISITANTES(ID),
CONSTRAINT FK_VISITAS_INTERNACAO FOREIGN KEY (INTERNACAOID) REFERENCES INTERNACAO(ID)
);



create table DIAGNOSTICOS(
ID INT PRIMARY KEY IDENTITY,
DESCRICAO VARCHAR(500) NOT NULL,
EXAMEID INT NOT NULL,
DATADIAGNOSTICO DATETIME2 NOT NULL,
CONSTRAINT FK_EXAME_DIAGNOSTICO FOREIGN KEY (EXAMEID) REFERENCES EXAMES(ID)
);



CREATE TABLE INTERNACAO(
ID INT PRIMARY KEY IDENTITY NOT NULL,
PACIENTEID INT NOT NULL,
DOUTORID INT NOT NULL,
DESCRICAO VARCHAR(250),
TIPOINTERNACAO INT NOT NULL,
QUARTOID INT NOT NULL,
DATAENTRADA DATETIME2 NOT NULL,
DATASAIDA DATETIME2,
PRECO FLOAT,
DATAULTIMAATUALIZACAO DATETIME2,
CONSTRAINT FK_QUARTO_INTERNACAO FOREIGN KEY (QUARTOID) REFERENCES QUARTO(NUMEROQUARTO),
CONSTRAINT FK_PACIENTE_INTERNADO FOREIGN KEY (PACIENTEID) REFERENCES PACIENTES(ID),
CONSTRAINT FK_DOUTOR_INTERNA FOREIGN KEY (DOUTORID) REFERENCES DOUTORES(ID)
);



CREATE TABLE QUARTOS(
NUMEROQUARTO INT PRIMARY KEY NOT NULL,
DISPONIVEL BIT NOT NULL
);



--Login de ADM para cadastro de Recepcionistas, Doutores e afins
insert into ADM values('admin', 'admin');

insert into CONVENIOS values('Nenhum', 0.00);

insert into DOUTORES values('Doutor Teste1', 'DoutorTeste1@gmail.com', '123a', '292.236.890-40', 1, 1, '(47) 90000-0000', 1, 100, 200);

insert into RECEPCIONISTAS values('Recepcionista Teste1', 'RecepcionistaTeste1@gmail.com', '123a', '468.858.480-69', 1, 1, '(47) 91111-1111');

insert into QUARTOS values(1, 1);