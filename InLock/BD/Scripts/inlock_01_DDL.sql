CREATE DATABASE inlock_games_manha;
GO

USE inlock_games_manha;
GO

CREATE TABLE Estudio(
idEstudio TINYINT PRIMARY KEY IDENTITY(1,1),
nomeEstudio VARCHAR(20) NOT NULL UNIQUE
);

CREATE TABLE Jogo(
idJogo TINYINT PRIMARY KEY IDENTITY(1,1),
idEstudio TINYINT FOREIGN KEY REFERENCES Estudio(idEstudio),
nomeJogo VARCHAR(30) NOT NULL UNIQUE,
descricaoJogo VARCHAR(140) NOT NULL,
dataLancamento SMALLDATETIME NOT NULL,
valorJogo VARCHAR (10) NOT NULL
);

CREATE TABLE TipoUsuario(
idTipoUsuario TINYINT PRIMARY KEY IDENTITY(1,1),
titulo VARCHAR (13) NOT NULL UNIQUE
);

CREATE TABLE Usuario(
idUsuario TINYINT PRIMARY KEY IDENTITY(1,1),
idTipoUsuario TINYINT FOREIGN KEY REFERENCES TipoUsuario(idTipoUsuario),
emailUsuario VARCHAR (20) NOT NULL UNIQUE,
senhaUsuario VARCHAR (8) NOT NULL UNIQUE,
);