namespace EGift.Api.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using EGift.Api.Extensions;
    using EGift.Api.Messages.Merchants;
    using EGift.Services.Merchants.Messages;
    public static class MerchantServiceModelExtension
    {
        public static GetAllMerchantWebResponse AsResponse(this GetAllMerchantResponse serviceResponse)
        {
            var result = new GetAllMerchantWebResponse
            {
                Data = serviceResponse.Merchants.Select(m => m.AsResponse()).ToList()
            };

            return result;
        }
    }
}
