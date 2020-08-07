namespace EGift.Services.Orders
{
    using System;
    using System.Threading.Tasks;
    using EGift.Services.Orders.Data.Gateways;
    using EGift.Services.Orders.Exceptions;
    using EGift.Services.Orders.Messages;

    public class OrderService : IOrderService
    {
        private IOrderDataGateway gateway;

        public OrderService(IOrderDataGateway gateway)
        {
            if (gateway == null)
            {
                throw new OrderServiceException(new Exception());
            }

            this.gateway = gateway;
        }

        public async Task<GetAllOrderResponse> GetAllOrderAsync()
        {
            GetAllOrderResponse result;
            try
            {
                result = await this.gateway.GetAllOrderAsync();
                //if (result.Orders == null)
                //{
                //    result. = 204;
                //}
                //else if (result.Successful == false)
                //{
                //    result.Code = 404;
                //}
                //else
                //{
                //    result.Code = 200;
                //}
                return result;
            }
            catch (Exception ex)
            {
                throw new OrderServiceException(ex);
            }
        }

        public async Task<NewOrderResponse> NewOrderAsync(NewOrderRequest request)
        {
            NewOrderResponse result;
            try
            {
                result = await this.gateway.NewOrderAsync(request);
                //if (result.CheckRow == 0)
                //{
                //    result.Code = 404;
                //}
                //else if (result.CheckRow > 0)
                //{
                //    result.Code = 201;
                //}

                return result;
            }
            catch (Exception ex)
            {
                throw new OrderServiceException(ex);
            }
        }

        public async Task<SearchOrderResponse> SearchOrderAsync(SearchOrderRequest request)
        {
            SearchOrderResponse result;
            try
            {
                result = await this.gateway.SearchOrderAsync(request);
                //if (result.Successful == false)
                //{
                //    result.Code = 404;
                //}
                //else if (result.Order == null)
                //{
                //    result.Code = 204;
                //}
                //else
                //{
                //    result.Code = 200;
                //}

                return result;
            }
            catch (Exception ex)
            {
                throw new OrderServiceException(ex);
            }
        }
    }
}
