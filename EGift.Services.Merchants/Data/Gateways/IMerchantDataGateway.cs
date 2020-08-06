namespace EGift.Services.Merchants.Data.Gateways
{
    using System.Threading.Tasks;
    using EGift.Services.Merchants.Data.Entities;
    using EGift.Services.Merchants.Messages;

    public interface IMerchantDataGateway
    {
        Task<GetAllMerchantResponse> GetAllMerchantAsync();

        Task<GetMerchantProductResponse> GetMerchantProductsAsync(MerchantEntity merchant);
    }
}
