﻿CREATE TABLE [dbo].[Merchants]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[Name] NVARCHAR(256) NOT NULL DEFAULT '',
	[Address] NVARCHAR(MAX) NULL,
	[Slug] NVARCHAR(50) NOT NULL DEFAULT ''
)
