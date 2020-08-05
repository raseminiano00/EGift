CREATE PROCEDURE [dbo].[sp_InsertNewOrder]
	@ProductId UNIQUEIDENTIFIER,
	@OrderedQuantity int,
	@TotalOrderedAmount decimal(13,2),
	@RecipientName NVARCHAR(MAX),
	@RecipientEmail NVARCHAR(MAX),
	@SenderName NVARCHAR(MAX),
	@SenderEmail NVARCHAR(MAX),
	@AdditionalMes NVARCHAR(MAX)
AS
	INSERT INTO Orders (ProductId,OrderedQuantity,TotalOrderedAmount,RecipientName,RecipientEmailAddress,SenderName,SenderEmailAddress,AdditionalMessage) values
	(@ProductId,@OrderedQuantity,@TotalOrderedAmount,@RecipientName,@RecipientEmail,@SenderName,@SenderEmail,@AdditionalMes);
	
RETURN 0
