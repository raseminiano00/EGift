
namespace EGift.Services.Email.Extensions
{
    using EGift.Services.Email.Messages;
    using EGift.Services.Email.Models;
    using System;
    using System.Runtime.CompilerServices;

    public static class EmailRequestExtension
    {
        public static EmailSenderModel AsSenderModel(this SendEmailRequest request)
        {
            if(request == null)
            {
                throw new ArgumentNullException();
            }

            var result = new EmailSenderModel()
            {
                sender = request.Email.Sender,
                recipient = request.Email.Recipient,
                key = "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",
                emailMessage = request.Email.Message,
                subject = request.Email.Subject
            };
            return result;
        }
    }
}
