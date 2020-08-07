namespace EGift.Services.Merchants
{
    using System;
    using System.Threading.Tasks;
    using EGift.Services.Merchants.Data.Gateways;
    using EGift.Services.Merchants.Exceptions;
    using EGift.Services.Merchants.Extensions;
    using EGift.Services.Merchants.Messages;

    public class MerchantService : IMerchantService
    {
        private readonly IMerchantDataGateway gateway;

        public MerchantService(IMerchantDataGateway gateway)
        {
            this.gateway = gateway;
        }

        public async Task<GetAllMerchantResponse> GetAllMerchantAsync()
        {
            GetAllMerchantResponse response;

            try
            {
                response = await this.gateway.GetAllMerchantAsync();
                if (response.Merchants == null)
                {
                    response.Code = 204;
                }
                else if (response.Successful == false)
                {
                    response.Code = 404;
                }
                else
                {
                    response.Code = 200;
                }
            }
            catch (Exception ex)
            {
                throw new MerchantServiceException(ex);
            }

            return response;
        }

        public async Task<GetMerchantProductResponse> GetMerchantProductsAsync(GetMerchantProductsRequest request)
        {
            GetMerchantProductResponse response;

            try
            {
                response = await this.gateway.GetMerchantProductsAsync(request.AsEntity());
                if (response.Products.Count == 0)
                {
                    response.Code = 204;
                }
                else if (response.Successful == false)
                {
                    response.Code = 404;
                }
                else
                {
                    response.Code = 200;
                }
            }
            catch (Exception ex)
            {
                throw new MerchantServiceException(ex);
            }

            return response;
        }
    }
}
