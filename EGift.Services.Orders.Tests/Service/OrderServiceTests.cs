namespace EGift.Services.Orders.Tests.Service
{
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;
    using EGift.Infrastructure.Common;
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
        private Mock<IResponseHandlerFacade> mockResponseHandler;
        private List<Order> mockResult;
        private DataTable mockTable;

        [TestInitialize]
        public void Initialize()
        {
            this.mockGateway = new Mock<IOrderDataGateway>();
            this.mockResponseHandler = new Mock<IResponseHandlerFacade>();
            this.sut = new OrderService(this.mockGateway.Object, this.mockResponseHandler.Object);
            this.mockResult = new List<Order>();
            this.mockResult.Add(new Order() 
            {
                OrderProduct = new OrderProduct() 
            });
            this.mockTable = new DataTable();
            this.mockTable.Columns.Add("1");
            this.mockTable.Rows.Add("");
        }

        [TestMethod]
        [ExpectedException(typeof(OrderServiceException))]
        public void Constructor_ShouldFail_WhenArgIsNull()
        {
            this.sut = new OrderService(null,null);
        }

        [TestMethod]
        public void GetAllOrderAsync_ShouldErrorResult()
        {
            this.mockResponseHandler.Setup(m => m.Handle(It.IsAny<Response>())).Returns(404);
            this.mockGateway.Setup(m => m.GetAllOrderAsync()).Returns(Task.FromResult(new GetAllOrderResponse()
            {
                Orders = this.mockResult,
                RawData = this.mockTable
            }));

            var result = this.sut.GetAllOrderAsync().Result;

            Assert.AreEqual(result.Code, 404);
        }

        [TestMethod]
        public void NewOrderAsync_ShouldErrorResult()
        {
            this.mockResponseHandler.Setup(m => m.Handle(It.IsAny<Response>())).Returns(404);
            this.mockGateway.Setup(m => m.NewOrderAsync(It.IsAny<NewOrderRequest>())).Returns(Task.FromResult(new NewOrderResponse()
            {
                RawData = this.mockTable
            }));

            var result = this.sut.NewOrderAsync(It.IsAny<NewOrderRequest>()).Result;

            Assert.AreEqual(result.Code, 404);
        }

        [TestMethod]
        public void NewOrderAsync_ShouldOkResult()
        {
            this.mockResponseHandler.Setup(m => m.Handle(It.IsAny<Response>())).Returns(201);
            this.mockGateway.Setup(m => m.NewOrderAsync(It.IsAny<NewOrderRequest>())).Returns(Task.FromResult(new NewOrderResponse()
            {
                RawData = this.mockTable
            }));

            var result = this.sut.NewOrderAsync(It.IsAny<NewOrderRequest>()).Result;

            Assert.AreEqual(result.Code, 201);
        }

        [TestMethod]
        public void SearchOrderAsync_ShouldOkResult()
        {
            this.mockResponseHandler.Setup(m => m.Handle(It.IsAny<Response>())).Returns(204);
            this.mockGateway.Setup(m => m.SearchOrderAsync(It.IsAny<SearchOrderRequest>())).Returns(Task.FromResult(new SearchOrderResponse()
            {
                RawData = this.mockTable
            }));

            var result = this.sut.SearchOrderAsync(It.IsAny<SearchOrderRequest>()).Result;

            Assert.AreEqual(204, result.Code);
        }
    }
}
