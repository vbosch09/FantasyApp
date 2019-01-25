CREATE TABLE [dbo].[FantasyTeams]
(
	[FantasyTeamId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SleeperTeamId] NCHAR(10) NOT NULL, 
    [OwnerId] INT NOT NULL, 
    [SeasonId] INT NOT NULL, 
    [TeamName] VARCHAR(50) NULL, 
    CONSTRAINT [FK_FantasyTeams_Owners] FOREIGN KEY ([OwnerId]) REFERENCES [Owners]([OwnerId]), 
    CONSTRAINT [FK_FantasyTeams_Seasons] FOREIGN KEY ([SeasonId]) REFERENCES [Seasons]([SeasonId])
)
