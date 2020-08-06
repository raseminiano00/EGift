namespace EGift.Services.Merchants.Exceptions
{
    using System;

    public class MerchantServiceException : Exception
    {
        public MerchantServiceException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
