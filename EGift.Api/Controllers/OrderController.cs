namespace EGift.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using EGift.Api.Extensions.Orders;
    using EGift.Api.Messages.Orders;
    using EGift.Services.Orders;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [Route("api/[controller]")]
        [HttpPost]
        public async Task<ActionResult> NewOrder([FromBody]NewOrderWebRequest request)
        {
            var serviceResult = await this.orderService.NewOrderAsync(request.AsServiceRequest());

            var result = serviceResult.AsApiResponse();

            return this.Ok(result);
        }

        [Route("api/[controller]s")]
        [HttpGet]
        public async Task<ActionResult> GetAllOrders()
        {
            var serviceResult = await this.orderService.GetAllOrderAsync();

            var result = serviceResult.AsApiResponse();

            return this.Ok(result);
        }

        [Route("api/order/{id}")]
        [HttpGet]
        public async Task<SearchOrderWebResponse> SearchOrder(string id)
        {
            var serviceResult = await this.orderService.SearchOrderAsync(id.AsServiceRequest());

            var result = serviceResult.AsApiResponse();

            return result;
        }
    }
}
