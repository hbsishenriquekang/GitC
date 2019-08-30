CREATE TABLE [dbo].[Usuarios] (
    [Id]   INT           NOT NULL,
    [Nome] VARCHAR (100) NOT NULL,
    [Login] VARCHAR(50) NOT NULL, 
    [Senha] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Ativo] VARCHAR(50) NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL, 
    [DatAlt] DATETIME NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

