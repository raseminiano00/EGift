namespace EGift.Services.Orders.Data.Gateways
{
    using System;
    using System.Threading.Tasks;
    using EGift.Infrastructure.Helpers;
    using EGift.Services.Orders.Data.Factories;
    using EGift.Services.Orders.Exceptions;
    using EGift.Services.Orders.Messages;

    public class OrderDataGateway : IOrderDataGateway
    {
        private ISqlHelper sqlHelper;
        private IOrderSqlFactory factory;

        public OrderDataGateway(IOrderSqlFactory factory, ISqlHelper sqlHelper)
        {
            if(factory == null || sqlHelper == null)
            {
                throw new OrderDataGatewayException(new Exception());
            }
            this.sqlHelper = sqlHelper;
            this.factory = factory;
        }

        public Task<GetAllOrderResponse> GetAllOrderAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<NewOrderResponse> NewOrderAsync(NewOrderRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<SearchOrderResponse> SearchOrderAsync(SearchOrderRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
