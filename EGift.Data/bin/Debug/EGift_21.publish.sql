﻿/*
Deployment script for EGift

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "EGift"
:setvar DefaultFilePrefix "EGift"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\"

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
USE [$(DatabaseName)];


GO
/*
The column [dbo].[Merchants].[Slug] on table [dbo].[Merchants] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[Merchants])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Altering [dbo].[Merchants]...';


GO
ALTER TABLE [dbo].[Merchants]
    ADD [Slug] NVARCHAR (50) NOT NULL;


GO
PRINT N'Altering [dbo].[sp_GetMerchantProducts]...';


GO
ALTER PROCEDURE [dbo].[sp_GetMerchantProducts]
	@slug uniqueidentifier
AS
	SELECT m.Name as Merchant_Name,p.Id,p.name,p.description,p.price FROM Merchants m LEFT JOIN
	Products p on m.Id = p.merchantId
	WHERE m.Slug = @slug;
RETURN 0
GO
PRINT N'Refreshing [dbo].[sp_GetAllMerchant]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[sp_GetAllMerchant]';


GO
PRINT N'Update complete.';


GO
