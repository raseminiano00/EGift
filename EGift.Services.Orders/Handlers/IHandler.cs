namespace EGift.Services.Orders.Handlers
{
    public interface IHandler<T>
    {
        T Handle(T toHandle);

        void SetNextHandler(IHandler<T> nextHandler);
    }
}
