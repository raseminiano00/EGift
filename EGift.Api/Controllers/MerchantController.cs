namespace EGift.Api.Controllers
{
    using System.Threading.Tasks;
    using EGift.Api.Extensions;
    using EGift.Services.Merchants;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class MerchantController : ControllerBase
    {
        private readonly IMerchantService merchantService;

        public MerchantController(IMerchantService merchantService)
        {
            this.merchantService = merchantService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllMerchant()
        {
            var serviceResult = await this.merchantService.GetAllMerchantAsync();

            var result = serviceResult.AsResponse();

            return Ok(result);
        }

    }
}
