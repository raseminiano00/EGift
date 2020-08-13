namespace EGift.Infrastructure.Common.ResponseHandlers
{
    using System.Threading.Tasks;

    public class EmptyResultHandler<T> : BaseHandler<T> where T : Response
    {
        public override int Handle(T request)
        {
            if (IsNull(request.RawData) || request.RawData.Rows.Count == 0)
            {
                return 204;
            }

            return Next(request);
        }
    }
}
