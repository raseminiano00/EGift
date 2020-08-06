namespace EGift.Services.Merchants.Exceptions
{
    using System;

    public class MerchantGatewayException : Exception
    {
        public MerchantGatewayException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
