using EGift.Services.Merchants.Data.Factories;
using EGift.Services.Merchants.Data.Gateways;
using EGift.Services.Merchants.Messages;
using EGift.Services.Merchants.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EGift.Services.Merchants.Tests
{
    [TestClass]
    public class MerchantServiceTests
    {
        MerchantService sut;
        Mock<IMerchantGateway> mockGateway;
        [TestInitialize]
        public void Initialize()
        {
            mockGateway = new Mock<IMerchantGateway>();
            sut = new MerchantService(mockGateway.Object);
        }
        [TestMethod]
        public async void Constructor_ShouldSet_Gateway()
        {
            mockGateway.Setup(m => m.GetAllMerchantAsync()).Returns());
            var result = await sut.GetAllMerchant();

            Assert.AreEqual(result.Successful,true);
        }
    }
}
