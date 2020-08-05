using EGift.Infrastructure.Helpers;
using EGift.Services.Merchants.Data.Entities;
using EGift.Services.Merchants.Data.Factories;
using EGift.Services.Merchants.Data.Gateways;
using EGift.Services.Merchants.Exceptions;
using EGift.Services.Merchants.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EGift.Services.Merchants.Tests.Gateways
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
            sut = new MerchantGateway(null, null);
        }

        [TestMethod]
        public void GetAllMerchantAsync_ShouldHaveValue()
        {
            mockFactory.Setup(m => m.CreateGetAllMerchantCommand()).Returns(new SqlCommand());
            mockHelper.Setup(m => m.ExecuteReaderAsync(It.IsAny<SqlCommand>())).Returns(Task.FromResult(new System.Data.DataTable()));

            var result = sut.GetAllMerchantAsync().Result;

            Assert.IsNotNull(result.Merchants);
        }

        [TestMethod]
        public void GetAllMerchantAsync_ShouldHaveZeroMerchants()
        {
            mockFactory.Setup(m => m.CreateGetAllMerchantCommand()).Returns(new SqlCommand());
            mockHelper.Setup(m => m.ExecuteReaderAsync(It.IsAny<SqlCommand>())).Returns(Task.FromResult(new System.Data.DataTable()));

            var result = sut.GetAllMerchantAsync().Result;

            Assert.AreEqual(result.Merchants.Count,0);
        }

        [TestMethod]
        public void GetAllMerchantAsync_ShouldHaveProducts()
        {
            mockFactory.Setup(m => m.CreateGetMerchantProduct(It.IsAny<MerchantEntity>())).Returns(new SqlCommand());
            mockHelper.Setup(m => m.ExecuteReaderAsync(It.IsAny<SqlCommand>())).Returns(Task.FromResult(new System.Data.DataTable()));

            var result = sut.GetMerchantProductsAsync(It.IsAny<MerchantEntity>()).Result;

            Assert.AreEqual(result.Products.Count, 0);
        }
    }
}
