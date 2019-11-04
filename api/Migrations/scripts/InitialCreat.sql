IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Blogs] (
    [BlogId] int NOT NULL IDENTITY,
    [Url] nvarchar(500) NOT NULL,
    [Timestamp] rowversion NULL,
    CONSTRAINT [PK_Blogs] PRIMARY KEY ([BlogId])
);

GO

CREATE TABLE [Posts] (
    [PostId] int NOT NULL IDENTITY,
    [Title] nvarchar(255) NOT NULL,
    [Content] nvarchar(max) NULL,
    [BlogId] int NOT NULL,
    CONSTRAINT [PK_Posts] PRIMARY KEY ([PostId]),
    CONSTRAINT [FK_Posts_Blogs_BlogId] FOREIGN KEY ([BlogId]) REFERENCES [Blogs] ([BlogId]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Posts_BlogId] ON [Posts] ([BlogId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191104132202_InitialCreate', N'2.2.6-servicing-10079');

GO

ALTER TABLE [Posts] ADD [ShortTitle] nvarchar(25) NOT NULL;

GO


                    UPDATE Customer
                    SET ShortTitle = SUBSTRING(Title,1,25);
                

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191104133702_AddShortTitleToBlog', N'2.2.6-servicing-10079');

GO

