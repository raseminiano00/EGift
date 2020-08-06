namespace EGift.Api.Controllers
{
    using EGift.Services.Orders;
    using Microsoft.AspNetCore.Mvc;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpPost]
        [Route("api/[controller]")]
        public async Task<ActionResult> NewOrder()
        {
            var serviceResult = await this.orderService.NewOrderAsync();

            var result = serviceResult.AsResponse();

            return this.Ok(result);
        }

    }
}
