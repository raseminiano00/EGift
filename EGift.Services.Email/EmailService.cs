namespace EGift.Services.Email
{
    using System;
    using System.Threading.Tasks;
    using EGift.Services.Email.Gateways;
    using EGift.Services.Email.Messages;

    public class EmailService : IEmailService
    {
        private IEmailGateway emailGateway;

        public EmailService(IEmailGateway emailGateway)
        {
            this.emailGateway = emailGateway;
        }

        public async Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request)
        {
            var result = await this.emailGateway.SendEmailAsync(request);

            return result;
        }
    }
}
