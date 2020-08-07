namespace EGift.Services.Orders.Tests.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EGift.Services.Orders.Data.Gateways;
    using EGift.Services.Orders.Exceptions;
    using EGift.Services.Orders.Messages;
    using EGift.Services.Orders.Models.Order;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class OrderServiceTests
    {
        private OrderService sut;
        private Mock<IOrderDataGateway> mockGateway;
        private List<Order> mockResult;
        [TestInitialize]
        public void Initialize()
        {
            this.mockGateway = new Mock<IOrderDataGateway>();
            this.sut = new OrderService(this.mockGateway.Object);
            this.mockResult = new List<Order>();
            this.mockResult.Add(new Order() 
            {
                OrderProduct = new OrderProduct()
            });
        }

        [TestMethod]
        [ExpectedException(typeof(OrderServiceException))]
        public void Constructor_ShouldFail_WhenArgIsNull()
        {
            this.sut = new OrderService(null);
        }

        [TestMethod]
        public void GetAllOrderAsync_ShouldErrorResult()
        {
            this.mockGateway.Setup(m => m.GetAllOrderAsync()).Returns(Task.FromResult(new GetAllOrderResponse()
            {
                Orders = this.mockResult
            }));

            var result = this.sut.GetAllOrderAsync().Result;

            Assert.AreEqual(result.Code, 404);
        }

        [TestMethod]
        public void NewOrderAsync_ShouldErrorResult()
        {
            this.mockGateway.Setup(m => m.NewOrderAsync(It.IsAny<NewOrderRequest>())).Returns(Task.FromResult(new NewOrderResponse()
            {
                CheckRow = 0
            }));

            var result = this.sut.NewOrderAsync(It.IsAny<NewOrderRequest>()).Result;

            Assert.AreEqual(result.Code, 404);
        }

        [TestMethod]
        public void NewOrderAsync_ShouldOkResult()
        {
            this.mockGateway.Setup(m => m.NewOrderAsync(It.IsAny<NewOrderRequest>())).Returns(Task.FromResult(new NewOrderResponse()
            {
                CheckRow = 1
            }));

            var result = this.sut.NewOrderAsync(It.IsAny<NewOrderRequest>()).Result;

            Assert.AreEqual(result.Code, 201);
        }

        [TestMethod]
        public void SearchOrderAsync_ShouldOkResult()
        {
            this.mockGateway.Setup(m => m.SearchOrderAsync(It.IsAny<SearchOrderRequest>())).Returns(Task.FromResult(new SearchOrderResponse()
            {
                Successful = true
            }));

            var result = this.sut.SearchOrderAsync(It.IsAny<SearchOrderRequest>()).Result;

            Assert.AreEqual(result.Code, 204);
        }
    }
}
