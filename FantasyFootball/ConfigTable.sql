CREATE TABLE [dbo].[ConfigTable]
(
	[ConfigId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(100) NOT NULL, 
    [Value] VARCHAR(100) NOT NULL, 
    [ModTime] DATETIME NOT NULL
)
