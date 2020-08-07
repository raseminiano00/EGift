namespace EGift.Services.Orders.Handlers.Responses
{
    using System;

    public abstract class BaseHandler<T> : IHandler<T>
    {
        private IHandler<T> nextHandler;
        private T toHandle;

        public void SetNextHandler(IHandler<T> nextHandler)
        {
            if (this.IsNull(nextHandler)) 
            {
                throw new ArgumentNullException("handler", "Handler cannot be null");
            }

            this.nextHandler = nextHandler;
        }

        public abstract T Handle(T request);

        protected bool IsNull(object toCheck)
        {
            return toCheck == null;
        }
    }
}
