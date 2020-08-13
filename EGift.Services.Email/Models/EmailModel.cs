namespace EGift.Services.Email.Models
{
    using System;
    using System.Runtime.Serialization;

    public class EmailModel
    {
        [DataMember]
        public string Sender { get; set; }

        [DataMember]
        public string Recipient { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Subject { get; set; }
    }
}
