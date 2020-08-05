using EGift.Services.Merchants.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EGift.Services.Merchants.Data.Gateways
{
    public interface IMerchantGateway
    {
        Task<GetAllMerchantResponse>  GetAllMerchantAsync();
    }
}
