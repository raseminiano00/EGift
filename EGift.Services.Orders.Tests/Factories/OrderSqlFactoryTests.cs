namespace EGift.Services.Orders.Tests.Factories
{
    using EGift.Services.Orders.Data.Entities;
    using EGift.Services.Orders.Data.Factories;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OrderSqlFactoryTests
    { 
        OrderSqlFactory sut;
        [TestInitialize]
        public void Initialize()
        {
            this.sut = new OrderSqlFactory();
        }

        [TestMethod]
        public void Constructor_ShouldNotNull()
        {
            Assert.IsNotNull(this.sut);
        }

        [TestMethod]
        public void CreateGetAllOrdersCommand_ShouldCorrectStoredProcName()
        {
            Assert.IsNotNull(this.sut.CreateGetAllOrdersCommand(), "sp_GetAllOrders");
        }

        [TestMethod]
        public void CreateGetOrderCommand_ShouldCorrectStoredProcName()
        {
            Assert.IsNotNull(this.sut.CreateSearchOrderCommand(new OrderEntity()), "sp_SearchOrder");
        }

        [TestMethod]
        public void CreateNewOrderCommand_ShouldCorrectStoredProcName()
        {
            Assert.IsNotNull(this.sut.CreateNewOrderCommand(new OrderEntity()), "sp_InsertNewOrder");
        }
    }
}
