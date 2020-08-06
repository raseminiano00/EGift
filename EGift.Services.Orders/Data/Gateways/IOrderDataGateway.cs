namespace EGift.Services.Orders.Data.Gateways
{
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using EGift.Services.Orders.Messages;

    public interface IOrderDataGateway
    {
        Task<GetAllOrderResponse> GetAllOrderAsync();

        Task<SearchOrderResponse> SearchOrderAsync(SearchOrderRequest request);

        Task<NewOrderResponse> NewOrderAsync(NewOrderRequest request);
    }
}
