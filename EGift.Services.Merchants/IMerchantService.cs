using EGift.Services.Merchants.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EGift.Services.Merchants
{
    public interface IMerchantService
    {
        Task<GetAllMerchantResponse> GetAllMerchantAsync();
        Task<GetMerchantProductResponse> GetMerchantProductsAsync(GetMerchantProductsRequest request);
    }
}
