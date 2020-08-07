namespace EGift.Services.Orders.Data.Gateways
{
    using System;
    using System.Threading.Tasks;
    using EGift.Infrastructure.Helpers;
    using EGift.Services.Orders.Data.Factories;
    using EGift.Services.Orders.Exceptions;
    using EGift.Services.Orders.Extensions;
    using EGift.Services.Orders.Messages;

    public class OrderDataGateway : IOrderDataGateway
    {
        private ISqlHelper sqlHelper;
        private IOrderSqlFactory factory;

        public OrderDataGateway(IOrderSqlFactory factory, ISqlHelper sqlHelper)
        {
            if (factory == null || sqlHelper == null)
            {
                throw new OrderDataGatewayException(new Exception());
            }

            this.sqlHelper = sqlHelper;
            this.factory = factory;
        }

        public async Task<GetAllOrderResponse> GetAllOrderAsync()
        {
            try
            {
                var command = this.factory.CreateGetAllOrdersCommand();
                var result = await this.sqlHelper.ExecuteReaderAsync(command);
                return result.AsGetAllOrderReponse();
            }
            catch (Exception ex)
            {
                throw new OrderDataGatewayException(ex);
            }
        }

        public async Task<NewOrderResponse> NewOrderAsync(NewOrderRequest request)
        {
            try
            {
                var command = this.factory.CreateNewOrderCommand(request.AsRequestEntity());

                var result = await this.sqlHelper.ExecuteReaderAsync(command);

                return result.AsNewOrderResponse();
            }
            catch (Exception ex)
            {
                throw new OrderDataGatewayException(ex);
            }
        }

        public async Task<SearchOrderResponse> SearchOrderAsync(SearchOrderRequest request)
        {
            try
            {
                var command = this.factory.CreateSearchOrderCommand(request.AsRequestEntity());

                var result = await this.sqlHelper.ExecuteReaderAsync(command);

                return result.AsSearchOrderResponse();
            }
            catch (Exception ex)
            {
                throw new OrderDataGatewayException(ex);
            }
        }
    }
}
