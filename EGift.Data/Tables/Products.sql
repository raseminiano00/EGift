CREATE TABLE [dbo].[Products]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
    [merchantId] UNIQUEIDENTIFIER NOT NULL,
    [name] NVARCHAR(MAX)  NOT NULL,
    [description] NVARCHAR(MAX)  NULL,
    [price] decimal(13,2) NOT NULL, 
    CONSTRAINT [Fk_Products_ToMerchant] FOREIGN KEY ([merchantId]) REFERENCES [Merchants]([Id])
)
