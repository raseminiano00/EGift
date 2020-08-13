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

        public SendGridService(SendGridApi sendGrid)
        {
            this.sendGridClient = sendGrid;
        }

        public async Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request)
        {
            SendEmailResponse response = new SendEmailResponse();
            var senderEmail = new SenderEmailBuilder("intensedba@gmail.com", request.SenderEmail,
                "SG.HBgGVXmdQjeRf1ktf6R - 1g.yrywaDmi3N_FGywQonmsgqh8quldeXrRuEhoKQFHC8k")
                .SetProduct(request.ProductDescription)
                .SetQuantity(request.Quantity)
                .SetOrderAmount(request.OrderAmount)
                .SetRecipientName(request.RecipientName)
                .SetSenderName(request.SenderName).Build();
            var recipientEmail = new RecipientEmailBuilder("intensedba@gmail.com", request.RecipientEmail,
               "SG.HBgGVXmdQjeRf1ktf6R - 1g.yrywaDmi3N_FGywQonmsgqh8quldeXrRuEhoKQFHC8k")
               .SetProduct(request.ProductDescription)
               .SetQuantity(request.Quantity)
               .SetOrderAmount(request.OrderAmount)
               .SetRecipientName(request.RecipientName)
               .SetSenderName(request.SenderName).Build();

            var resultSender = await this.sendGridClient.Send(senderEmail);
            var resultRecipient = await this.sendGridClient.Send(recipientEmail);

            if(resultSender.StatusCode != System.Net.HttpStatusCode.OK &&
               resultRecipient.StatusCode != System.Net.HttpStatusCode.OK)
            {
                response.ApiResponse = "Error";
                response.Code = 404;
            }
            response.ApiResponse = "OK";
            response.Code = 204;
            return response;
        }
    }
}
