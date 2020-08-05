
using System.Collections.Generic;
using System.Threading.Tasks;
using EGift.Services.Merchants.Data.Factories;
using EGift.Services.Merchants.Data.Gateways;
using EGift.Services.Merchants.Exceptions;
using EGift.Services.Merchants.Messages;
using EGift.Services.Merchants.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
        public void Constructor_ShouldSet_Gateway()
        {
            Assert.IsNotNull(sut);
        }
        [TestMethod]
        public void GetAllMerchant_ShouldNotNull()
        {
            mockGateway.Setup(m => m.GetAllMerchantAsync()).Returns(Task.FromResult(new GetAllMerchantResponse()));

            var result = sut.GetAllMerchant().Result;

            Assert.IsInstanceOfType(result,typeof(GetAllMerchantResponse));
        }

        [TestMethod]
        public void GetAllMerchant_ShouldCode404()
        {
            mockGateway.Setup(m => m.GetAllMerchantAsync()).Returns(Task.FromResult(new GetAllMerchantResponse() { Code = 404}));

            var result = sut.GetAllMerchant().Result;

            Assert.AreEqual(result.Code, 404);
        }

        [TestMethod]
        public void GetAllMerchant_ShouldHaveValues()
        {
            mockGateway.Setup(m => m.GetAllMerchantAsync()).Returns(Task.FromResult(new GetAllMerchantResponse() 
            { 
                Code = 200,
                Merchants = new List<Merchant>() { new Merchant() { Id=new System.Guid("00000000-0000-0000-0000-000000000000"),Name="Mcdo",Address="PNOVAL"} } 
            }));

            var result = sut.GetAllMerchant().Result;

            Assert.AreEqual(result.Merchants.Count, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(MerchantServiceException))]
        public async Task GetAllMerchant_ShouldHaveException()
        {
            mockGateway.Setup(m => m.GetAllMerchantAsync()).Throws(new System.Exception("sample"));

            await sut.GetAllMerchant();
        }
    }
}
