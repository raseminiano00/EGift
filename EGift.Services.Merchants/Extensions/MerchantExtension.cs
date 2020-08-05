namespace EGift.Services.Merchants.Extensions
{
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
                Address = merchant.Address
            };
            return result;
        }
    }
}
