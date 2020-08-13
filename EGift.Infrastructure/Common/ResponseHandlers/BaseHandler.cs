namespace EGift.Infrastructure.Common.ResponseHandlers
{
    using System;
    using System.Threading.Tasks;

    public abstract class BaseHandler<T> : IHandler<T>
    {
        private IHandler<T> nextHandler;

        public IHandler<T> SetNextHandler(IHandler<T> nextHandler)
        {
            if (this.IsNull(nextHandler)) 
            {
                throw new ArgumentNullException("handler", "Handler cannot be null");
            }

            this.nextHandler = nextHandler;

            return this;
        }

        public int Next(T request)
        {
            if (this.IsNull(nextHandler))
            {
                return 0;
            }

            return nextHandler.Handle(request);
        }

        public abstract int Handle(T request);

        protected bool IsNull(object toCheck)
        {
            return toCheck == null;
        }
    }
}
