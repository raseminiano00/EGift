namespace EGift.Infrastructure.Common.ResponseHandlers
{
    public interface IHandler<T>
    {
        int Handle(T toHandle);

        IHandler<T> SetNextHandler(IHandler<T> nextHandler);
    }
}
