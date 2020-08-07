namespace EGift.Api.Extensions
{
    using System.Linq;
    using EGift.Api.Messages.Merchants;
    using EGift.Services.Merchants.Messages;

    public static class MerchantServiceModelExtension
    {
        public static GetAllMerchantWebResponse AsResponse(this GetAllMerchantResponse serviceResponse)
        {
            var result = new GetAllMerchantWebResponse
            {
                Data = serviceResponse.Merchants.Select(m => m.AsResponse()).ToList(),
                HttpCode = serviceResponse.Code
            };

            return result;
        }

        public static GetMerchantProductWebResponse AsResponse(this GetMerchantProductResponse serviceResponse)
        {
            var result = new GetMerchantProductWebResponse()
            {
                Data = serviceResponse.Products.Select(m => m.AsResponse()).ToList(),
                MerchantName = serviceResponse.MerchantName,
                HttpCode = serviceResponse.Code
            };

            return result;
        }
    }
}
