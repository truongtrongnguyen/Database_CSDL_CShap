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

CREATE TABLE [Article] (
    [ArticleID] int NOT NULL IDENTITY,
    [Title] nvarchar(50) NULL,
    CONSTRAINT [PK_Article] PRIMARY KEY ([ArticleID])
);
GO

CREATE TABLE [Tags] (
    [TagID] int NOT NULL IDENTITY,
    [Content] ntext NULL,
    CONSTRAINT [PK_Tags] PRIMARY KEY ([TagID])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221127231728_V0', N'7.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

EXEC sp_rename N'[Article].[Title]', N'Name', N'COLUMN';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221128032727_V1', N'7.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Article] ADD [Content] nvarchar NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221128033619_V2', N'7.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Tags] DROP CONSTRAINT [PK_Tags];
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Tags]') AND [c].[name] = N'TagID');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Tags] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Tags] DROP COLUMN [TagID];
GO

ALTER TABLE [Tags] ADD [TagIDNew] int NOT NULL IDENTITY;
GO

ALTER TABLE [Tags] ADD CONSTRAINT [PK_Tags] PRIMARY KEY ([TagIDNew]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221128034524_V3_Remove-TagID', N'7.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

EXEC sp_rename N'[Tags].[TagIDNew]', N'TagID', N'COLUMN';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221128034739_V3-Rename-TagID', N'7.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [ArticleTag] (
    [ArticleTagID] int NOT NULL IDENTITY,
    [TagID] int NOT NULL,
    [ArticleID] int NOT NULL,
    CONSTRAINT [PK_ArticleTag] PRIMARY KEY ([ArticleTagID]),
    CONSTRAINT [FK_ArticleTag_Article_ArticleID] FOREIGN KEY ([ArticleID]) REFERENCES [Article] ([ArticleID]) ON DELETE CASCADE,
    CONSTRAINT [FK_ArticleTag_Tags_TagID] FOREIGN KEY ([TagID]) REFERENCES [Tags] ([TagID]) ON DELETE CASCADE
);
GO

CREATE UNIQUE INDEX [IX_ArticleTag_ArticleID_TagID] ON [ArticleTag] ([ArticleID], [TagID]);
GO

CREATE INDEX [IX_ArticleTag_TagID] ON [ArticleTag] ([TagID]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221128040349_V4', N'7.0.0');
GO

COMMIT;
GO

