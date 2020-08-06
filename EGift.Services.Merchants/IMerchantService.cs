namespace EGift.Services.Merchants
{
    using System.Threading.Tasks;
    using EGift.Services.Merchants.Messages;

    public interface IMerchantService
    {
        Task<GetAllMerchantResponse> GetAllMerchantAsync();

        Task<GetMerchantProductResponse> GetMerchantProductsAsync(GetMerchantProductsRequest request);
    }
}
