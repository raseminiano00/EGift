namespace EGift.Services.Email.Tests
{
    using EGift.Services.Email.EmailSenders;
    using EGift.Services.Email.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SendGrid;
    using SendGrid.Helpers.Mail;
    using System;
    using System.Threading.Tasks;

    [TestClass]
    public class SendGridApiTests
    {
        SendGridApi sendGridApi;
        EmailSenderModel emailApiModel;

        [TestInitialize]
        public void TestInitialize()
        {
            emailApiModel = new EmailSenderModel()
            {
                emailMessage = "sample",
                sender = "intensedba@gmail.com",
                recipient = "rseminiano@you-source.com",
                key = "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",
                subject = "sample email"
            };
            sendGridApi = new SendGridApi();
        }
    }
}
