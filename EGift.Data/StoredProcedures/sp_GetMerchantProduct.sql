CREATE PROCEDURE [dbo].[sp_GetMerchantProducts]
	@slug NVARCHAR(50)
AS
	SELECT m.Name as Merchant_Name,p.Id,p.name,p.description,p.price FROM Merchants m LEFT JOIN
	Products p on m.Id = p.merchantId
	WHERE m.Slug = @slug;
RETURN 0
