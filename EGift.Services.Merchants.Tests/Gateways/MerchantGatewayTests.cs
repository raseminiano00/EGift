namespace EGift.Services.Merchants.Tests.Gateways
{
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    using EGift.Infrastructure.Helpers;
    using EGift.Services.Merchants.Data.Entities;
    using EGift.Services.Merchants.Data.Factories;
    using EGift.Services.Merchants.Data.Gateways;
    using EGift.Services.Merchants.Exceptions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class MerchantGatewayTests
    {
        private MerchantDataGateway sut;
        private Mock<IMerchantSqlFactory> mockFactory;
        private Mock<ISqlHelper> mockHelper;

        [TestInitialize]
        public void Initialize()
        {
            this.mockFactory = new Mock<IMerchantSqlFactory>();
            this.mockHelper = new Mock<ISqlHelper>();
            this.sut = new MerchantDataGateway(this.mockFactory.Object, this.mockHelper.Object);
        }

        [TestMethod]
        public void Constructor_ShouldAccept_WhenArgIsValid()
        {
            this.mockFactory = new Mock<IMerchantSqlFactory>();
            this.mockHelper = new Mock<ISqlHelper>();
            this.sut = new MerchantDataGateway(this.mockFactory.Object, this.mockHelper.Object);

            Assert.IsNotNull(this.sut);
        }

        [TestMethod]
        [ExpectedException(typeof(MerchantGatewayException))]
        public void Constructor_ShouldThrow_WhenArgIsNull()
        {
            this.sut = new MerchantDataGateway(null, null);
        }

        [TestMethod]
        public void GetAllMerchantAsync_ShouldHaveValue()
        {
            this.mockFactory.Setup(m => m.CreateGetAllMerchantCommand()).Returns(new SqlCommand());
            this.mockHelper.Setup(m => m.ExecuteReaderAsync(It.IsAny<SqlCommand>())).Returns(Task.FromResult(new System.Data.DataTable()));

            var result = this.sut.GetAllMerchantAsync().Result;

            Assert.IsNotNull(result.Merchants);
        }

        [TestMethod]
        public void GetAllMerchantAsync_ShouldHaveZeroMerchants()
        {
            this.mockFactory.Setup(m => m.CreateGetAllMerchantCommand()).Returns(new SqlCommand());
            this.mockHelper.Setup(m => m.ExecuteReaderAsync(It.IsAny<SqlCommand>())).Returns(Task.FromResult(new System.Data.DataTable()));

            var result = this.sut.GetAllMerchantAsync().Result;

            Assert.AreEqual(result.Merchants.Count, 0);
        }

        [TestMethod]
        public void GetAllMerchantAsync_ShouldHaveProducts()
        {
            this.mockFactory.Setup(m => m.CreateGetMerchantProduct(It.IsAny<MerchantEntity>())).Returns(new SqlCommand());
            this.mockHelper.Setup(m => m.ExecuteReaderAsync(It.IsAny<SqlCommand>())).Returns(Task.FromResult(new System.Data.DataTable()));

            var result = this.sut.GetMerchantProductsAsync(It.IsAny<MerchantEntity>()).Result;

            Assert.AreEqual(result.Products.Count, 0);
        }
    }
}
