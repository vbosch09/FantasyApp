CREATE PROCEDURE [dbo].[Fantasy_UpdateConfig]
(
	@in_ConfigId int,
	@in_ConfigValue varchar(100),
	@in_ModTime datetime
)
AS
	UPDATE ConfigTable SET [Value] = @in_ConfigValue, ModTime = @in_ModTime where ConfigId = @in_ConfigId
	GO
