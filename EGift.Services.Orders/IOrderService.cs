namespace EGift.Services.Orders
{
    using EGift.Services.Orders.Messages;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IOrderService
    {
        Task<NewOrderResponse> NewOrderAsync(NewOrderRequest request);

        Task<GetAllOrderResponse> GetAllOrderAsync();

        Task<SearchOrderResponse> SearchOrderAsync(SearchOrderRequest request);
    }
}
