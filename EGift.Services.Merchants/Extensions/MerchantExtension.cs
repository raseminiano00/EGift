namespace EGift.Services.Merchants.Extensions
{
    using EGift.Services.Merchants.Messages;
    using Merchants.Data.Entities;
    using Merchants.Models;

    public static class MerchantExtension
    {
        public static MerchantEntity AsEntity(this Merchant merchant)
        {
            var result = new MerchantEntity()
            {
                Id = merchant.Id,
                Name = merchant.Name,
                Address = merchant.Address,
                Slug = merchant.Slug
            };
            return result;
        }

        public static MerchantEntity AsEntity(this GetMerchantProductsRequest request)
        {
            var result = new MerchantEntity()
            {
                Id = request.merchant.Id,
                Name = request.merchant.Name,
                Address = request.merchant.Address,
                Slug = request.merchant.Slug
            };
            return result;
        }
    }
}
