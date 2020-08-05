namespace EGift.Api.Extensions
{
    using EGift.Api.Messages.Merchants;
    using EGift.Api.Models.Merchants;
    using EGift.Services.Merchants.Messages;
    using EGift.Services.Merchants.Models;

    public static class MerchantExtensions
    {
        public static GetAllMerchantWebRequest AsRequest(this GetAllMerchantWebRequest request)
        {
            if (request is null)
            {
                throw new System.ArgumentNullException(nameof(request));
            }

            var result = new GetAllMerchantWebRequest();

            return result;
        }
        public static GetMerchantProductsRequest AsRequest(this GetMerchantProductWebRequest request)
        {
            if (request is null)
            {
                throw new System.ArgumentNullException(nameof(request));
            }

            var result = new GetMerchantProductsRequest()
            {
                merchant = new Merchant
                {
                    Slug = request.Data.slug
                }
            };

            return result;
        }
        public static MerchantWebModel AsResponse(this Merchant merchant)
        {
            var result = new MerchantWebModel()
            {
                id = merchant.Id,
                name = merchant.Name,
                address = merchant.Address,
                slug = merchant.Slug
            };
            return result;
        }

        public static MerchantProductWebModel AsResponse(this Product product)
        {
            var result = new MerchantProductWebModel()
            {
                id = product.Id,
                name = product.Name,
                description = product.Description,
                price = product.Price
            };
            return result;
        }
    }
}
