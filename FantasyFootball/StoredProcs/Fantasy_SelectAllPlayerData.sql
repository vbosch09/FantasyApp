CREATE PROCEDURE [dbo].[Fantasy_SelectAllPlayerData]
	
AS
	SELECT PlayerId, SleeperPlayerId, FirstName, LastName, Team, Position
	FROM Players
GO
