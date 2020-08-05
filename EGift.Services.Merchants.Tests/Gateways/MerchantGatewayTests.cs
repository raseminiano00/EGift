using EGift.Infrastructure.Helpers;
using EGift.Services.Merchants.Data.Factories;
using EGift.Services.Merchants.Data.Gateways;
using EGift.Services.Merchants.Exceptions;
using EGift.Services.Merchants.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EGift.Services.Merchants.Tests
{
    [TestClass]
    public class MerchantGatewayTests
    {
        MerchantGateway sut;
        Mock<IMerchantSqlFactory> mockFactory;

        Mock<ISqlHelper> mockHelper;

        [TestInitialize]
        public void Initialize()
        {
            mockFactory = new Mock<IMerchantSqlFactory>();
            mockHelper = new Mock<ISqlHelper>();
            sut = new MerchantGateway(mockFactory.Object,mockHelper.Object);
        }


        [TestMethod]
        public void Constructor_ShouldAccept_WhenArgIsValid()
        {
            mockFactory = new Mock<IMerchantSqlFactory>();
            mockHelper = new Mock<ISqlHelper>();
            sut = new MerchantGateway(mockFactory.Object, mockHelper.Object);

            Assert.IsNotNull(sut);
        }
        [TestMethod]
        [ExpectedException(typeof(MerchantGatewayException))]
        public void Constructor_ShouldThrow_WhenArgIsNull()
        {
            sut = new MerchantGateway(mockFactory.Object, mockHelper.Object);
        }
    }
}
