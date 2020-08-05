using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace EGift.Services.Orders.Tests.Factories
{
    [TestClass]
    class OrderSqlFactoryTests
    {
        OrderSqlFactory sut;
        [TestInitialize]
        public void Initialize()
        {
            sut = new OrderSqlFactory();
        }

        [TestMethod]
        public void Constructor_ShouldNotNull()
        {
            Assert.IsNotNull(sut);
        }
    }
}
