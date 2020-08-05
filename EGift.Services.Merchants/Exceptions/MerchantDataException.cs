using System;
using System.Collections.Generic;
using System.Text;

namespace EGift.Services.Merchants.Exceptions
{
    public class MerchantDataException : Exception
    {
        public MerchantDataException( Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
