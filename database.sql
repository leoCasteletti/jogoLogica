-- 1. Criar o Banco de Dados
CREATE DATABASE ProvaTLPII_2B_107081;
GO

-- 2. Usar o Banco de Dados criado
USE ProvaTLPII_2B_107081;
GO

-- 3. Criar a Tabela Resultados
CREATE TABLE Resultados (
    ID INT PRIMARY KEY IDENTITY(1,1),
    DataHora DATETIME NOT NULL,
    NomeInformado NVARCHAR(100) NOT NULL,
    NumeroGerado INT NOT NULL,
    NumeroCorreto INT NOT NULL
);
GO

SELECT * FROM Resultados