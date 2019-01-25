CREATE TABLE [dbo].[Seasons]
(
	[SeasonId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Year] INT NOT NULL UNIQUE, 
    [DraftComplete] BIT NOT NULL DEFAULT 0, 
    [SleeperLeagueId] BIGINT NOT NULL, 
    [SleeperDraftId] BIGINT NULL 
)
