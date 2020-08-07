namespace EGift.Services.Orders.Handlers.Responses
{
    using System;

    public abstract class BaseHandler<T> : IHandler<T>
    {
        private IHandler<T> nextHandler;

        public void SetNextHandler(IHandler<T> nextHandler)
        {
            if (this.IsNull(nextHandler)) 
            {
                throw new ArgumentNullException("handler", "Handler cannot be null");
            }

            this.nextHandler = nextHandler;
        }

        public void Next(ref T request)
        {
            if (this.IsNull(nextHandler))
            {
                return;
            }

            nextHandler.Handle(ref request);
        }

        public abstract void Handle(ref T request);

        protected bool IsNull(object toCheck)
        {
            return toCheck == null;
        }
    }
}
