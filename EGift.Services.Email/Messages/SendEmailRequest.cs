namespace EGift.Services.Email.Messages
{
    using System.Runtime.Serialization;
    using EGift.Infrastructure.Common;
    using EGift.Services.Email.Models;

    public class SendEmailRequest
    {
        [DataMember]
        public EmailModel Email { get; set; }

        [DataMember]
        public string RecipientEmail { get; set; }

        [DataMember]
        public string SenderEmail { get; set; }

        [DataMember]
        public string RecipientName { get; set; }

        [DataMember]
        public string SenderName { get; set; }

        [DataMember]
        public string ProductDescription { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public double OrderAmount { get; set; }
    }
}