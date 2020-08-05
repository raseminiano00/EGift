CREATE PROCEDURE [dbo].[sp_SearchOrder]
	@OrderId UNIQUEIDENTIFIER
AS
	SELECT o.Id AS Order_Id,m.Name AS Merchant_Name,p.name AS Product_Code,p.description AS Product_Description,p.price,o.OrderedQuantity,
    o.SenderName,o.SenderEmailAddress,o.RecipientName,o.RecipientEmailAddress,o.DateOrdered,o.AdditionalMessage
    FROM Orders o LEFT JOIN Products p on o.ProductId = p.Id LEFT JOIN Merchants m on p.merchantId = m.Id where o.Id = @OrderId
RETURN 0
