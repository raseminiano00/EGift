using System;
using System.Collections.Generic;
using System.Text;

namespace EGift.Services.Merchants.Exceptions
{
    public class MerchantGatewayException : Exception
    {
        public MerchantGatewayException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
