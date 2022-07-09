CREATE DATABASE CRIPT02 -- cria o banco de dados
GO -- Força a execução do comando
USE CRIPTO2

--CRIANDO A TABELA USUÁRIOS
GO
CREATE TABLE Usuarios -- Dados dos usuários:
(
UsuarioID INT PRIMARY KEY IDENTITY,  -- Chave primária não se repete (Não se repete)
Email VARCHAR(100) UNIQUE NOT NULL, -- (Não pode ser nulo) (Não pode ter dois iguais)
Senha VARCHAR(50) NOT NULL
)
-- INSERINDO VALORES NA TABELA USUÁRIO

GO
INSERT INTO Usuarios VALUES ('moniquev@yahoo.com.br', 1234) -- O ID é inserido automaticamente
-- VERIFICANDO AS INFORMAÇÕES INSERIDAS

GO
SELECT * FROM Usuarios -- Mostra tudo que está inserido na tabela usuários

-- EXEMPLOS COM OS TIPOS DE CRIPTOGRAFIA
SELECT UsuarioId, Email, HASHBYTES('MD2',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1 -- (HASHBYTE MD2)Criptografia para não mostrar a senha
SELECT UsuarioId, Email, HASHBYTES('MD4',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('MD5',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('SHA',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('SHA2_256',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1
SELECT UsuarioId, Email, HASHBYTES('SHA2_512',Senha)AS 'SENHA HASH' FROM Usuarios WHERE UsuarioId = 1