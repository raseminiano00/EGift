namespace EGift.Infrastructure.Tests.Common.Handlers.Responses
{
    using System.Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using EGift.Infrastructure.Common.ResponseHandlers;
    using Moq;
    using EGift.Infrastructure.Common;

    [TestClass]
    public class EmptyResultHandlerTests
    {
        EmptyResultHandler<Response> sut;
        Mock<IHandler<Response>> mockHandler;
        Response response;

        [TestInitialize]
        public void Initialize()
        {
            this.sut = new EmptyResultHandler<Response>();
            this.mockHandler = new Mock<IHandler<Response>>();
            this.response = new Response();
            this.response.RawData = new DataTable();
            this.response.RawData.Columns.Add("1");
        }

        [TestMethod]
        public void Handle_ShouldReturn_204_WhenRawDataIsNull()
        {
            Assert.AreEqual(sut.Handle(response), 204);
        }

        [TestMethod]
        public void Handle_ShouldReturn_204_WhenRawDataIs0Count()
        {
            response.RawData = new DataTable();

            Assert.AreEqual(sut.Handle(response), 204);
        }

        [TestMethod]
        public void Handle_ShouldInvokeNext()
        {
            this.mockHandler.Setup(m => m.Handle(It.IsAny<Response>())).Returns(500);
            this.response.RawData.Rows.Add("");

            this.sut.SetNextHandler(mockHandler.Object);

            Assert.AreEqual(500, this.sut.Handle(response));
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
