namespace EGift.Services.Merchants.Tests.Factories
{
    using System;
    using System.Data.SqlClient;
    using EGift.Services.Merchants.Data.Entities;
    using EGift.Services.Merchants.Data.Factories;
    using EGift.Services.Merchants.Models;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class MerchantSqlCommandFactoryTests : MerchantSqlFactory
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
        public void CreateStoredProcCommand_ShouldReturnSqlCommand()
        {
            Assert.IsInstanceOfType(this.CreateStoredProcCommand("sp_sample"),typeof(SqlCommand));
        }

        [TestMethod]
        public void CreateStoredProcCommand_ShouldStoredProc()
        {
            Assert.AreEqual(this.CreateStoredProcCommand("sp_sample").CommandType, System.Data.CommandType.StoredProcedure);
        }

        [TestMethod]
        public void CreateGetAllMerchantCommand_ShouldStoredProcName_sp_GetAllMerchant()
        {
            Assert.AreEqual(sut.CreateGetAllMerchantCommand().CommandText, "sp_GetAllMerchant");
        }

        [TestMethod]
        public void CreateGetMerchantProduct_ShouldStoredProcName_sp_GetAllMerchant()
        {
            Assert.AreEqual(sut.CreateGetMerchantProduct(new MerchantEntity()).CommandText, "sp_GetMerchantProducts");
        }

       
    }
}
