namespace EGift.Services.Merchants.Data.Gateways
{
    using System;
    using System.Threading.Tasks;
    using EGift.Infrastructure.Helpers;
    using EGift.Services.Merchants.Data.Factories;
    using EGift.Services.Merchants.Exceptions;
    using EGift.Services.Merchants.Extensions;
    using EGift.Services.Merchants.Messages;

    public class MerchantGateway : IMerchantGateway
    {
        private readonly IMerchantSqlFactory factory;
        private readonly ISqlHelper sqlHelper;

        public MerchantGateway(IMerchantSqlFactory factory,
                               ISqlHelper sqlHelper)
        {
            if (factory == null || sqlHelper == null)
                throw new MerchantGatewayException(new Exception());

            this.factory = factory;
            this.sqlHelper = sqlHelper;
        }

        public async Task<GetAllMerchantResponse> GetAllMerchantAsync()
        {
            try
            {
                var command = this.factory.CreateGetAllMerchantCommand();
                var result = await this.sqlHelper.ExecuteReaderAsync(command);
                return result.AsResponse();
            }
            catch (Exception ex)
            {
                throw new MerchantDataException(ex);
            }
        }
    }
}
