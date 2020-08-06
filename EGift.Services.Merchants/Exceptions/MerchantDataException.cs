namespace EGift.Services.Merchants.Exceptions
{
    using System;

    public class MerchantDataException : Exception
    {
        public MerchantDataException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
