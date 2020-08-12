CREATE TABLE [dbo].[Orders]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[ProductId] UNIQUEIDENTIFIER NOT NULL, 
    [OrderedQuantity] INT NOT NULL, 
    [TotalOrderedAmount] decimal(13,2) NOT NULL,
    [RecipientName] NVARCHAR(MAX) NOT NULL, 
    [RecipientEmailAddress] NVARCHAR(MAX) NOT NULL, 
    [RecipientContactNumber] NVARCHAR(20) NOT NULL DEFAULT '', 
    [SenderName] NVARCHAR(MAX) NOT NULL, 
    [SenderEmailAddress] NVARCHAR(MAX) NOT NULL, 
    [SenderContactNumber] NVARCHAR(20) NOT NULL DEFAULT '', 
    [DateOrdered] DATETIME NOT NULL DEFAULT getDate(), 
    [AdditionalMessage] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Orders_Products] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id])
)
