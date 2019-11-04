ALTER TABLE [Posts] ADD [ShortTitle] nvarchar(25) NOT NULL;

GO


                    UPDATE Customer
                    SET ShortTitle = SUBSTRING(Title,1,25);
                

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191104133702_AddShortTitleToBlog', N'2.2.6-servicing-10079');

GO

