namespace EGift.Services.Email
{
    using System.Threading.Tasks;
    using EGift.Services.Email.Gateways;
    using EGift.Services.Email.Messages;

    public interface IEmailService
    {
        Task<SendEmailResponse> SendEmailAsync(SendEmailRequest request);
    }
}
