CREATE TABLE [dbo].[DraftPicks]
(
	[DraftPickId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PlayerId] INT NOT NULL, 
    [DraftId] INT NOT NULL, 
    [PickNumber] INT NOT NULL, 
    [RosterId] INT NULL, 
    [Keeper] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_DraftPicks_ToPlayers] FOREIGN KEY ([PlayerId]) REFERENCES [Players]([PlayerId]), 
    CONSTRAINT [FK_DraftPicks_ToDrafts] FOREIGN KEY ([DraftId]) REFERENCES [Seasons]([SeasonId]),
	CONSTRAINT [UN_DraftPicks_PlayerIdDraftId] UNIQUE (PlayerId, DraftId)
)
