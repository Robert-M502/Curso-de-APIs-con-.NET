IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Users] (
    [Id] int NOT NULL IDENTITY,
    [Nombre] nvarchar(50) NOT NULL,
    [DescripcionCorta] nvarchar(200) NOT NULL,
    [DescripcionLarga] nvarchar(500) NOT NULL,
    [PublicoObjetivo] nvarchar(200) NOT NULL,
    [Objetivos] nvarchar(max) NOT NULL,
    [Requisitos] nvarchar(max) NOT NULL,
    [Nivel] int NOT NULL,
    [CreateBy] nvarchar(max) NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdateBy] nvarchar(max) NOT NULL,
    [UpdateAt] datetime2 NOT NULL,
    [DeleteBy] nvarchar(max) NOT NULL,
    [DeleteAt] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230412175754_Create Cursos table', N'7.0.4');
GO

COMMIT;
GO

