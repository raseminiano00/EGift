using EGift.Services.Merchants.Data.Gateways;
using EGift.Services.Merchants.Exceptions;
using EGift.Services.Merchants.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EGift.Services.Merchants
{
    public class MerchantService :IMerchantService
    {
        private readonly IMerchantGateway gateway;

        public MerchantService(IMerchantGateway gateway)
        {
            this.gateway = gateway;
        }

        public async Task<GetAllMerchantResponse> GetAllMerchant()
        {
            GetAllMerchantResponse response;

            try
            {
                response = await this.gateway.GetAllMerchantAsync();
            }
            catch (Exception ex)
            {
                throw new MerchantServiceException(ex);
            }

            return response;
        }
    }
}
