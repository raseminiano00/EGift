namespace EGift.Services.Email.EmailSenders
{
    using System;
    using System.Threading.Tasks;
    using EGift.Services.Email.Models;
    using SendGrid;
    using SendGrid.Helpers.Mail;

    public class SendGridApi : IEmailApi<Response>
    {
        private SendGridClient sendGrid;
        public SendGridApi()
        {
        }

        public async Task<Response> Send(EmailSenderModel emailModel)
        {
            this.sendGrid = new SendGridClient(emailModel.key);
            var msg = MailHelper.CreateSingleEmail(new EmailAddress(emailModel.sender), new EmailAddress(emailModel.recipient), emailModel.subject, emailModel.emailMessage, emailModel.emailMessage);
            var response = await sendGrid.SendEmailAsync(msg);
            return response;
        }
    }
}
