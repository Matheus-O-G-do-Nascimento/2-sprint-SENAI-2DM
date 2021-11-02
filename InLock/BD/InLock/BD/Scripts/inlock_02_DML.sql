USE inlock_games_manha;
GO

INSERT INTO Estudio (nomeEstudio)
VALUES ('Blizzard'),('Rockstar Studios'),('Square Enix')

INSERT INTO Jogo (idEstudio,nomeJogo,descricaoJogo,dataLancamento,valorJogo)
VALUES (1,'Diablo 3','É um jogo que contém bastante ação e é viciante, seja você um novato ou um fã','15/05/2012','R$ 99,00')

UPDATE Jogo
SET idEstudio = 2, nomeJogo = 'Red Dead Redemption II', descricaoJogo = 'Jogo eletrônico de ação-aventura western.',dataLancamento = 15/05/2012, 


INSERT INTO TipoUsuario (titulo)
VALUES ('Adminsitrador'),('Cliente')

INSERT INTO Usuario (idTipoUsuario,emailUsuario,senhaUsuario)
VALUES (1,'admin@admin.com','admin'), (