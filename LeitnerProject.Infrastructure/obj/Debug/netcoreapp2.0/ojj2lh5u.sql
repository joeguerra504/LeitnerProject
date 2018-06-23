IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Categories] (
    [Id] int NOT NULL IDENTITY,
    [Description] nvarchar(max) NULL,
    [Title] nvarchar(max) NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Questions] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    CONSTRAINT [PK_Questions] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Subcategory] (
    [Id] int NOT NULL IDENTITY,
    [CategoryId] int NULL,
    [Description] nvarchar(max) NULL,
    [Title] nvarchar(max) NULL,
    CONSTRAINT [PK_Subcategory] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Subcategory_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Answers] (
    [Id] int NOT NULL IDENTITY,
    [QuestionId] int NULL,
    [Title] nvarchar(max) NULL,
    CONSTRAINT [PK_Answers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Answers_Questions_QuestionId] FOREIGN KEY ([QuestionId]) REFERENCES [Questions] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Answers_QuestionId] ON [Answers] ([QuestionId]);

GO

CREATE INDEX [IX_Subcategory_CategoryId] ON [Subcategory] ([CategoryId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180510152310_init', N'2.0.3-rtm-10026');

GO

