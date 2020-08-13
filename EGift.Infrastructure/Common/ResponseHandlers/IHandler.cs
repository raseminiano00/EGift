namespace EGift.Infrastructure.Common.ResponseHandlers
{
    using System.Threading.Tasks;

    public interface IHandler<T>
    {
        int Handle(T toHandle);

        IHandler<T> SetNextHandler(IHandler<T> nextHandler);
    }
}
