namespace EGift.Services.Orders.Handlers.Responses
{
    using EGift.Services.Orders.Messages;

    public class ErrorResultHandler : BaseHandler<SearchOrderResponse>
    {
        public override SearchOrderResponse Handle(SearchOrderResponse request)
        {
            if (request.Order == null) 
            {
                request.Code = 404;
            }

            return request;
        }
    }
}
