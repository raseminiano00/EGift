namespace EGift.Services.Merchants.Data.Gateways
{
    using System;
    using System.Threading.Tasks;
    using EGift.Infrastructure.Helpers;
    using EGift.Services.Merchants.Data.Entities;
    using EGift.Services.Merchants.Data.Factories;
    using EGift.Services.Merchants.Exceptions;
    using EGift.Services.Merchants.Extensions;
    using EGift.Services.Merchants.Messages;

    public class MerchantDataGateway : IMerchantDataGateway
    {
        private readonly IMerchantSqlFactory factory;
        private readonly ISqlHelper sqlHelper;

        public MerchantDataGateway(
            IMerchantSqlFactory factory,
            ISqlHelper sqlHelper)
        {
            if (factory == null || sqlHelper == null)
            {
                throw new MerchantGatewayException(new Exception());
            }

            this.factory = factory;
            this.sqlHelper = sqlHelper;
        }

        public async Task<GetAllMerchantResponse> GetAllMerchantAsync()
        {
            try
            {
                var command = this.factory.CreateGetAllMerchantCommand();
                var result = await this.sqlHelper.ExecuteReaderAsync(command);
                return result.AsGetAllMerchantResponse();
            }
            catch (Exception ex)
            {
                throw new MerchantDataException(ex);
            }
        }

        public async Task<GetMerchantProductResponse> GetMerchantProductsAsync(MerchantEntity merchant)
        {
            try
            {
                var command = this.factory.CreateGetMerchantProduct(merchant);
                var result = await this.sqlHelper.ExecuteReaderAsync(command);
                return result.AsGetMerchantProductsResponse();
            }
            catch (Exception ex)
            {
                throw new MerchantDataException(ex);
            }
        }
    }
}
