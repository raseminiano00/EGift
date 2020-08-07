namespace EGift.Services.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using EGift.Services.Orders.Messages;

    public interface IOrderService
    {
        Task<NewOrderResponse> NewOrderAsync(NewOrderRequest request);

        Task<GetAllOrderResponse> GetAllOrderAsync();

        Task<SearchOrderResponse> SearchOrderAsync(SearchOrderRequest id);
    }
}
