namespace EGift.Services.Merchants.Tests.Factories
{
    using EGift.Services.Merchants.Data.Factories;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Data.SqlClient;

    [TestClass]
    public class MerchantSqlCommandFactoryTests
    {
        MerchantSqlFactory sut;
        [TestInitialize]
        public void Intialize()
        {
            sut = new MerchantSqlFactory();
        }

        [TestMethod]
        public void Constructor_ShouldNotNull()
        {
            Assert.IsNotNull(sut);
        }

        [TestMethod]
        public void CreateGetAllMerchantCommand_ShouldReturnSqlCommand()
        {
            Assert.IsInstanceOfType(sut.CreateGetAllMerchantCommand(),typeof(SqlCommand));
        }

        [TestMethod]
        public void CreateGetAllMerchantCommand_ShouldStoredProc()
        {
            Assert.AreEqual(sut.CreateGetAllMerchantCommand().CommandType, System.Data.CommandType.StoredProcedure);
        }

        [TestMethod]
        public void CreateGetAllMerchantCommand_ShouldStoredProcName_sp_GetAllMerchant()
        {
            Assert.AreEqual(sut.CreateGetAllMerchantCommand().CommandText, "sp_GetAllMerchant");
        }
    }
}
