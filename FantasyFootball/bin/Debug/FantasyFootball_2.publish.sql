﻿/*
Deployment script for FantasyFootball

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "FantasyFootball"
:setvar DefaultFilePrefix "FantasyFootball"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
PRINT N'Starting rebuilding table [dbo].[ConfigTable]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_ConfigTable] (
    [ConfigId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (100) NOT NULL,
    [Value]    VARCHAR (100) NOT NULL,
    [ModTime]  DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([ConfigId] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[ConfigTable])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_ConfigTable] ON;
        INSERT INTO [dbo].[tmp_ms_xx_ConfigTable] ([ConfigId], [Name], [Value], [ModTime])
        SELECT   [ConfigId],
                 [Name],
                 [Value],
                 [ModTime]
        FROM     [dbo].[ConfigTable]
        ORDER BY [ConfigId] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_ConfigTable] OFF;
    END

DROP TABLE [dbo].[ConfigTable];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_ConfigTable]', N'ConfigTable';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Creating [dbo].[Fantasy_GetConfigByName]...';


GO
CREATE PROCEDURE [dbo].[Fantasy_GetConfigByName]
(
	@in_ConfigName varchar
)
AS
	SELECT ConfigId, [Name], [Value], ModTime
	FROM ConfigTable
	WHERE [Name] = @in_ConfigName
GO
PRINT N'Creating [dbo].[Fantasy_UpdateConfig]...';


GO
CREATE PROCEDURE [dbo].[Fantasy_UpdateConfig]
(
	@in_ConfigId int,
	@in_ConfigValue varchar,
	@in_ModTime datetime
)
AS
	UPDATE ConfigTable SET [Value] = @in_ConfigValue, ModTime = @in_ModTime where ConfigId = @in_ConfigId
GO
PRINT N'Update complete.';


GO
