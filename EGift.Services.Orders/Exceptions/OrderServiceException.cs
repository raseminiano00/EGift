namespace EGift.Services.Orders.Exceptions
{
    using System;

    public class OrderServiceException : Exception
    {
        public OrderServiceException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
