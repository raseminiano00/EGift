CREATE TABLE [dbo].[Orders]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	[ProductId] UNIQUEIDENTIFIER NOT NULL, 
    [EGiftId] UNIQUEIDENTIFIER NOT NULL, 
    [RecipientName] NVARCHAR(MAX) NOT NULL, 
    [RecipientEmailAddress] NVARCHAR(MAX) NOT NULL, 
    [SenderName] NVARCHAR(MAX) NOT NULL, 
    [SenderEmailAddress] NVARCHAR(MAX) NOT NULL, 
    [DateOrdered] DATETIME NOT NULL, 
    CONSTRAINT [FK_Orders_Products] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id]),
    CONSTRAINT [FK_Orders_EGifts] FOREIGN KEY ([EGiftId]) REFERENCES [EGifts]([Id])
)
