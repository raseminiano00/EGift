using System;
using System.Collections.Generic;
using System.Text;

namespace EGift.Services.Merchants.Exceptions
{
    public class MerchantServiceException : Exception
    {
        public MerchantServiceException(Exception innerException) : base(string.Empty, innerException)
        {

        }
    }
}
