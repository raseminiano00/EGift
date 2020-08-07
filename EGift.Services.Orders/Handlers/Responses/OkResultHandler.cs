namespace EGift.Services.Orders.Handlers.Responses
{
    using EGift.Infrastructure.Common;

    public class OkResultHandler<T> : BaseHandler<T> where T : Response
    {
        public override T Handle(T request)
        {
            if (request.Successful) 
            {
                request.Code = 200;
            }

            return request;
        }
    }
}
