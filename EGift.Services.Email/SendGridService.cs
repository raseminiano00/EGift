namespace EGift.Services.Email
{
    using System;
    using System.Threading.Tasks;
    using EGift.Services.Email.EmailSenders;
    using EGift.Services.Email.Messages;
    using EGift.Services.Email.Models.Builder;
    using SendGrid;

    public class SendGridService : IEmailService
    {
        private SendGridApi sendGridClient;

        public SendGridService()
        {
            this.sendGridClient = new SendGridApi();
        }

        public async Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request)
        {
            SendEmailResponse response = new SendEmailResponse();
            var senderEmail = new SenderEmailBuilder("intensedba@gmail.com", request.SenderEmail,
                "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")
                .SetProduct(request.ProductDescription)
                .SetQuantity(request.Quantity)
                .SetOrderAmount(request.OrderAmount)
                .SetRecipientName(request.RecipientName)
                .SetSenderName(request.SenderName).Build();
            var recipientEmail = new RecipientEmailBuilder("intensedba@gmail.com", request.RecipientEmail,
               "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")
               .SetProduct(request.ProductDescription)
               .SetQuantity(request.Quantity)
               .SetOrderAmount(request.OrderAmount)
               .SetRecipientName(request.RecipientName)
               .SetSenderName(request.SenderName).Build();

            var resultSender = await this.sendGridClient.Send(senderEmail);
            var resultRecipient = await this.sendGridClient.Send(recipientEmail);

            if(resultSender.StatusCode != System.Net.HttpStatusCode.Accepted &&
               resultRecipient.StatusCode != System.Net.HttpStatusCode.Accepted)
            {
                response.ApiResponse = "Error";
                response.Code = 404;
            }
            else
            {
                response.ApiResponse = "OK";
                response.Code = 200;
            }
            return response;
        }
    }
}
