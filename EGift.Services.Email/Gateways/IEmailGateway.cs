namespace EGift.Services.Email.Gateways
{
    using System.Threading.Tasks;
    using EGift.Services.Email.Messages;

    public interface IEmailGateway
    {
        public Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request);
    }
}
