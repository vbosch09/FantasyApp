CREATE PROCEDURE [dbo].[Fantasy_SelectPlayerBySleeperId]
(
	@in_SleeperId bigint
)
AS
	SELECT PlayerId, FirstName, LastName, SleeperPlayerId, Team, Position
	FROM Players
	WHERE SleeperPlayerId = @in_SleeperId
GO
