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
                Merchant = new Merchant
                {
                    Slug = request.Data.Slug
                }
            };

            return result;
        }

        public static MerchantWebModel AsResponse(this Merchant merchant)
        {
            var result = new MerchantWebModel()
            {
                Id = merchant.Id,
                Name = merchant.Name,
                Address = merchant.Address,
                Slug = merchant.Slug
            };
            return result;
        }

        public static MerchantProductWebModel AsResponse(this Product product)
        {
            var result = new MerchantProductWebModel()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price
            };
            return result;
        }
    }
}
