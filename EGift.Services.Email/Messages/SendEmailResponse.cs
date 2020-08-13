namespace EGift.Services.Email.Messages
{
    using System.Runtime.Serialization;
    using EGift.Infrastructure.Common;
    using EGift.Services.Email.Models;

    public class SendEmailResponse : Response
    {
        [DataMember]
        public EmailModel Email{get;set;}

        [DataMember]
        public string ApiResponse { get; set; }
    }
}
