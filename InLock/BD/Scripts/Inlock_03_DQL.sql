USE inlock_games_manha;
GO

SELECT titulo
FROM TipoUsuario

SELECT nomeEstudio
FROM Estudio

SELECT nomeJogo
FROM Jogo

SELECT nomeJogo, nomeEstudio
FROM Jogo
LEFT JOIN Estudio
ON Jogo.idEstudio = Estudio.idEstudio

SELECT * FROM Estudio
LEFT JOIN Jogo
ON Jogo.idEstudio = Estudio.idEstudio

SELECT * FROM Usuario 
WHERE emailUsuario = 'cliente@cliente.com';

SELECT * FROM Usuario 
WHERE senhaUsuario = 'cliente';

SELECT * FROM Jogo
WHERE idJogo = 1

SELECT * FROM Estudio
WHERE idEstudio = 2
