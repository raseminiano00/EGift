namespace EGift.Services.Merchants
{
    using System;
    using System.Threading.Tasks;
    using EGift.Infrastructure.Common;
    using EGift.Services.Merchants.Data.Gateways;
    using EGift.Services.Merchants.Exceptions;
    using EGift.Services.Merchants.Extensions;
    using EGift.Services.Merchants.Messages;

    public class MerchantService : IMerchantService
    {
        private readonly IMerchantDataGateway gateway;
        private readonly IResponseHandlerFacade responseHandlerFacade;
        public MerchantService(IMerchantDataGateway gateway,IResponseHandlerFacade responseHandlerFacade)
        {
            if(gateway == null || responseHandlerFacade == null)
            {
                throw new MerchantServiceException(new ArgumentNullException());
            }

            this.gateway = gateway;
            this.responseHandlerFacade = responseHandlerFacade;
        }

        public async Task<GetAllMerchantResponse> GetAllMerchantAsync()
        {
            GetAllMerchantResponse response;

            try
            {
                response = await this.gateway.GetAllMerchantAsync();

                response.Code = responseHandlerFacade.Handle(response);
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

                response.Code = responseHandlerFacade.Handle(response);
            }
            catch (Exception ex)
            {
                throw new MerchantServiceException(ex);
            }

            return response;
        }
    }
}
