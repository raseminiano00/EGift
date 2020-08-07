namespace EGift.Services.Orders.Handlers.Responses
{
    using System;
    using EGift.Infrastructure.Common;
    using EGift.Services.Orders.Messages;

    public class ErrorResultHandler<T> : BaseHandler<T> where T : Response<T>
    {

        public override void Handle(ref T request)
        {
            if (request.Data == null)
            {
                request.Code = 404;
                return;
            }

            Next(ref request);
        }
    }
}
