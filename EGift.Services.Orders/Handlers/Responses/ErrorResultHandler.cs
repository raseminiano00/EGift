using EGift.Infrastructure.Common;
using EGift.Services.Orders.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace EGift.Services.Orders.Handlers.Responses
{
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
