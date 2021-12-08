USE Manha_Rental;
GO

SELECT * FROM Empresa
ORDER BY idEmpresa

SELECT * FROM Cliente
ORDER BY idCliente

SELECT * FROM Marca
ORDER BY idMarca

SELECT * FROM Modelo

SELECT * FROM Veiculo

SELECT * FROM Aluguel

SELECT idAluguel,dataAluguel FROM Aluguel

SELECT idCliente,nomeCliente FROM Cliente

SELECT idEmpresa,nomeEmpresa FROM Empresa

SELECT idVeiculo,idMarca,idModelo,placaVeiculo FROM Veiculo