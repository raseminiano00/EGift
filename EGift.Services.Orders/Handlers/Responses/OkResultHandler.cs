using EGift.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EGift.Services.Orders.Handlers.Responses
{
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
