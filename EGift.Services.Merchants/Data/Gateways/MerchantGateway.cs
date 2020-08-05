namespace EGift.Services.Merchants.Data.Gateways
{
    using System;
    using System.Threading.Tasks;
    using EGift.Infrastructure.Helpers;
    using EGift.Services.Merchants.Data.Factories;
    using EGift.Services.Merchants.Messages;

    public class MerchantGateway : IMerchantGateway
    {
        private readonly IMerchantSqlFactory factory;
        private readonly ISqlHelper sqlHelper;

        public MerchantGateway(IMerchantSqlFactory factory,
                               ISqlHelper sqlHelper)
        {
            this.factory = factory;
            this.sqlHelper = sqlHelper;
        }

        public Task<GetAllMerchantResponse> GetAllMerchantAsync()
        {
            throw new NotImplementedException();
        }
    }
}
