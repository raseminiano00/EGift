namespace EGift.Api.Controllers
{
    using System.Threading.Tasks;
    using EGift.Api.Extensions;
    using EGift.Api.Messages.Merchants;
    using EGift.Services.Merchants;
    using EGift.Services.Merchants.Messages;
    using EGift.Services.Merchants.Models;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class MerchantController : ControllerBase
    {
        private readonly IMerchantService merchantService;

        public MerchantController(IMerchantService merchantService)
        {
            this.merchantService = merchantService;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public async Task<ActionResult> GetAllMerchant()
        {
            var serviceResult = await this.merchantService.GetAllMerchantAsync();

            var result = serviceResult.AsResponse();

            return this.Ok(result);
        }

        [HttpGet]
        [Route("api/merchant/{slug}")]
        public async Task<ActionResult> GetMerchantProduct(string slug)
        {
            var serviceResult = await this.merchantService.GetMerchantProductsAsync(new GetMerchantProductsRequest() 
            {
                Merchant = new Merchant() 
            {
                Slug = slug
            }
            });

            var result = serviceResult.AsResponse();

            return this.Ok(result);
        }
    }
}
