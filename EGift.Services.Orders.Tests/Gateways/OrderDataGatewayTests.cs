namespace EGift.Services.Orders.Tests.Gateways
{
    using EGift.Infrastructure.Helpers;
    using EGift.Services.Orders.Data.Factories;
    using EGift.Services.Orders.Data.Gateways;
    using EGift.Services.Orders.Exceptions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class OrderDataGatewayTests
    {
        OrderDataGateway sut;
        Mock<IOrderSqlFactory> mockFactory;
        Mock<ISqlHelper> mockSqlHelper;

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
            this.sut = new OrderDataGateway(null,null);
        }
    }
}
