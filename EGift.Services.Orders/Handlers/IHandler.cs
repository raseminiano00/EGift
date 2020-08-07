namespace EGift.Services.Orders.Handlers
{
    public interface IHandler<T>
    {
        void Handle(ref T toHandle);

        void SetNextHandler(IHandler<T> nextHandler);
    }
}
