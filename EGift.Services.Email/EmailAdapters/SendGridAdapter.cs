namespace EGift.Services.Email.EmailAdapters
{
    using System.Threading.Tasks;
    using EGift.Services.Email.Extensions;
    using EGift.Services.Email.EmailSenders;
    using EGift.Services.Email.Gateways;
    using EGift.Services.Email.Messages;
    using SendGrid;

    public class SendGridAdapter : IEmailGateway
    {
        private IEmailApi<Response> emailSender;
        public SendGridAdapter(IEmailApi<Response> emailSender)
        {
            this.emailSender = emailSender;
        }
        public async Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request)
        {
            var result = await emailSender.Send(request.AsSenderModel());
            return result.AsServiceResponse();
        }
    }
}
