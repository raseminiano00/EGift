namespace EGift.Infrastructure.Tests.Common.Handlers.Responses
{
    using System.Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using EGift.Infrastructure.Common.ResponseHandlers;
    using Moq;
    using EGift.Infrastructure.Common;
    using System.Reflection.Metadata;

    [TestClass]
    public class OkResultHandlerTests
    {
        OkResultHandler<Response> sut;
        Mock<IHandler<Response>> mockHandler;
        Response response;

        [TestInitialize]
        public void Initialize()
        {
            this.sut = new OkResultHandler<Response>();
            this.mockHandler = new Mock<IHandler<Response>>();
            this.response = new Response();
            this.response.RawData = new DataTable();
            this.response.RawData.Columns.Add("1");
        }

        [TestMethod]
        public void Handle_ShouldReturn_200_WhenRawDataIs1Count()
        {
            this.response.RawData.Rows.Add("P.O Of Ingredients");

            Assert.AreEqual(200, this.sut.Handle(response));
        }


        [TestMethod]
        public void Handle_ShouldInvokeNext()
        {
            this.mockHandler.Setup(m => m.Handle(It.IsAny<Response>())).Returns(500);
            this.sut.SetNextHandler(mockHandler.Object);

            Assert.AreEqual(500, this.sut.Handle(response));
        }

        [TestCleanup]
        public void CleanUp()
        {

        }
    }
}
