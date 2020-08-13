namespace EGift.Services.Email.EmailSenders
{
    using System.Threading.Tasks;
    using EGift.Services.Email.Models;

    public interface IEmailApi<T>
    {
        Task<T> Send(EmailSenderModel senderModel);
    }
}
