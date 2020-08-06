using System;
using System.Collections.Generic;
using System.Text;

namespace EGift.Services.Orders.Handlers.Responses
{
    public abstract class BaseHandler<T> : IHandler<T>
    {
        T toHandle;

        protected IHandler<T> nextHandler;

        protected bool IsNull(object toCheck)
        {
            return toCheck == null;
        }
        public void SetNextHandler(IHandler<T> nextHandler)
        {
            if (this.IsNull(nextHandler))
                throw new ArgumentNullException("handler", "Handler cannot be null");

            this.nextHandler = nextHandler;
        }
        public abstract T Handle(T request);
    }
}
