CREATE PROCEDURE [dbo].[Fantasy_GetConfigByName]
(
	@in_ConfigName varchar(100)
)
AS
	SELECT ConfigId, [Name], [Value], ModTime
	FROM ConfigTable
	WHERE [Name] = @in_ConfigName
