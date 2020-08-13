namespace EGift.Infrastructure.Common.ResponseHandlers
{
    using EGift.Infrastructure.Common;
    using System;

    public class OkResultHandler<T> : BaseHandler<T> where T : Response
    {
        public override int Handle(T request)
        {
            int result = 200;
            if (request?.RawData.Rows.Count != 0)
            {
                return result;
            }

            return Next(request);
        }
    }
}
