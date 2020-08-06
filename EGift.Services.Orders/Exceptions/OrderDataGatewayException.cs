namespace EGift.Services.Orders.Exceptions
{
    using System;

    public class OrderDataGatewayException : Exception
    {
        public OrderDataGatewayException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
