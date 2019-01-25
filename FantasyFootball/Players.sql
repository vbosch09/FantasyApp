CREATE TABLE [dbo].[Players]
(
	[PlayerId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SleeperPlayerId] INT NOT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(100) NOT NULL, 
    [Team] VARCHAR(5) NOT NULL, 
    [Position] VARCHAR(50) NOT NULL
)
