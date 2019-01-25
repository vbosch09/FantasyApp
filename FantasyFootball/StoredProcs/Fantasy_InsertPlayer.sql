CREATE PROCEDURE [dbo].[Fantasy_InsertPlayer]
	@in_SleeperPlayerId int,
	@in_FirstName varchar(100),
	@in_LastName varchar(100),
	@in_Team varchar(100),
	@in_Position varchar(100)
AS
	
INSERT INTO Players VALUES (@in_SleeperPlayerId, @in_FirstName, @in_LastName, @in_Team, @in_Position)
GO