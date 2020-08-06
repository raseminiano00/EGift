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
	DECLARE @check int;

	SET @check = 0;

	INSERT INTO Orders (ProductId,OrderedQuantity,TotalOrderedAmount,RecipientName,RecipientEmailAddress,SenderName,SenderEmailAddress,AdditionalMessage) values
	(@ProductId,@OrderedQuantity,@TotalOrderedAmount,@RecipientName,@RecipientEmail,@SenderName,@SenderEmail,@AdditionalMes);
	
	if(@@ROWCOUNT>0) SET @check=1;

	SELECT @check;
RETURN 0