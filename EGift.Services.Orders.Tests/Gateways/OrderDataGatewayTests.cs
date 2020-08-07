namespace EGift.Services.Orders.Tests.Gateways
{
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    using EGift.Infrastructure.Helpers;
    using EGift.Services.Orders.Data.Entities;
    using EGift.Services.Orders.Data.Factories;
    using EGift.Services.Orders.Data.Gateways;
    using EGift.Services.Orders.Exceptions;
    using EGift.Services.Orders.Messages;
    using EGift.Services.Orders.Models.Order;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class OrderDataGatewayTests
    {
        private OrderDataGateway sut;
        private Mock<IOrderSqlFactory> mockFactory;
        private Mock<ISqlHelper> mockSqlHelper;

        [TestInitialize]
        public void Initialize()
        {
            this.mockFactory = new Mock<IOrderSqlFactory>();
            this.mockSqlHelper = new Mock<ISqlHelper>();

            this.sut = new OrderDataGateway(this.mockFactory.Object, this.mockSqlHelper.Object);
        }

        [TestMethod]
        public void Constructor_ShouldInitialize()
        {
            Assert.IsNotNull(this.sut);
        }

        [TestMethod]
        [ExpectedException(typeof(OrderDataGatewayException))]
        public void Constructor_ShouldThrowException()
        {
            this.sut = new OrderDataGateway(null, null);
        }

        [TestMethod]
        public void GetAllOrderAsync_ShouldHaveValue()
        {
            this.mockFactory.Setup(m => m.CreateGetAllOrdersCommand()).Returns(new SqlCommand());
            this.mockSqlHelper.Setup(m => m.ExecuteReaderAsync(It.IsAny<SqlCommand>())).Returns(Task.FromResult(new System.Data.DataTable()));

            var result = this.sut.GetAllOrderAsync().Result;

            Assert.IsNotNull(result.Orders);
        }

        [TestMethod]
        public void NewOrderAsync_ShouldDefaultValue()
        {
            this.mockFactory.Setup(m => m.CreateNewOrderCommand(It.IsAny<OrderEntity>())).Returns(new SqlCommand());
            this.mockSqlHelper.Setup(m => m.ExecuteReaderAsync(It.IsAny<SqlCommand>())).Returns(Task.FromResult(new System.Data.DataTable()));

            var result = this.sut.NewOrderAsync(new NewOrderRequest() 
            { 
                Order = new Order() 
                { 
                    OrderProduct = new OrderProduct()
                } 
            }).Result;

            Assert.AreEqual(result.CheckRow, 0);
        }

        [TestMethod]
        public void SearchOrderAsync_ShouldNull()
        {
            this.mockFactory.Setup(m => m.CreateSearchOrderCommand(It.IsAny<OrderEntity>())).Returns(new SqlCommand());
            this.mockSqlHelper.Setup(m => m.ExecuteReaderAsync(It.IsAny<SqlCommand>())).Returns(Task.FromResult(new System.Data.DataTable()));

            var result = this.sut.SearchOrderAsync(new SearchOrderRequest() 
            {
                Order = new Order()
            }).Result;

            Assert.IsNull(result.Order);
        }
    }
}
