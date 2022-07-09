CREATE DATABASE CRIPT02 -- cria o banco de dados
GO -- For�a a execu��o do comando
USE CRIPTO2

--CRIANDO A TABELA USU�RIOS
GO
CREATE TABLE Usuarios -- Dados dos usu�rios:
(
UsuarioID INT PRIMARY KEY IDENTITY,  -- Chave prim�ria n�o se repete (N�o se repete)
Email VARCHAR(100) UNIQUE NOT NULL, -- (N�o pode ser nulo) (N�o pode ter dois iguais)
Senha VARCHAR(50) NOT NULL
)
-- INSERINDO VALORES NA TABELA USU�RIO

GO
INSERT INTO Usuarios VALUES ('moniquev@yahoo.com.br', 1234) -- O ID � inserido automaticamente
-- VERIFICANDO AS INFORMA��ES INSERIDAS

GO
SELECT * FROM Usuarios -- Mostra tudo que est� inserido na tabela usu�rios

-- EXEMPLOS COM OS TIPOS DE CRIPTOGRAFIA
SELECT UsuarioId, Email, HASHBYTES('MD2',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1 -- (HASHBYTE MD2)Criptografia para n�o mostrar a senha
SELECT UsuarioId, Email, HASHBYTES('MD4',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('MD5',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('SHA',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('SHA2_256',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('SHA2_512',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1