using EGift.Services.Email.EmailAdapters;
using EGift.Services.Email.EmailSenders;
using EGift.Services.Email.Messages;
using EGift.Services.Email.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace EGift.Services.Email.Tests
{
    [TestClass]
    public class SendGridAdapterTests
    {
        SendGridAdapter sendGridAdapter;
        Mock<IEmailApi<Response>> mockApi;
        SendEmailRequest sendEmailRequest;
        [TestInitialize]
        public void TestInitialize()
        {
            mockApi = new Mock<IEmailApi<Response>>();
            sendGridAdapter = new SendGridAdapter(mockApi.Object);
            sendEmailRequest = new SendEmailRequest()
            {
                Email = new EmailModel()
                {
                    Message = "sample",
                    Sender = "intensedba@gmail.com",
                    Recipient = "rseminiano@you-source.com",
                    Subject = "sample email"
                }
            };
        }

        [TestMethod]
        public void SendEmail_ShouldOk()
        {
            mockApi.Setup(m => m.Send(It.IsAny<EmailSenderModel>())).Returns(Task.FromResult(new Response(System.Net.HttpStatusCode.OK, It.IsAny<HttpContent>(), It.IsAny<HttpResponseHeaders>())));
            //var result = sendGridAdapter.SendEmailAsync(sendEmailRequest).Result;
            //Assert.AreEqual("OK", result.ApiResponse);
        }
    }
}
