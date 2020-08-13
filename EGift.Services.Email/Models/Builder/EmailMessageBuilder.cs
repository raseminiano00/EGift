using System;
using System.Collections.Generic;
using System.Text;

namespace EGift.Services.Email.Models.Builder
{
    public abstract class EmailMessageBuilder
    {
        public abstract EmailSenderModel Build();

        protected EmailSenderModel email;
        protected string emailMessage;
        protected string productDescription;
        protected int quantityOrdered;
        protected double orderAmount;
        protected string recipientName;
        protected string senderName;
        protected string emailSubject;
        public EmailMessageBuilder(string sender, string recipient, string key)
        {
            email = new EmailSenderModel
            {
                sender = sender,
                recipient = recipient,
                key = key
            };
        }

        public EmailMessageBuilder SetProduct(string productDescription)
        {
            this.productDescription = productDescription;
            return this;
        }
        public EmailMessageBuilder SetSenderName(string name)
        {
            this.senderName = name;
            return this;
        }
        public EmailMessageBuilder SetRecipientName(string name)
        {
            this.recipientName = name;
            return this;
        }

        public EmailMessageBuilder SetQuantity(int quantity)
        {
            this.quantityOrdered = quantity;
            return this;
        }
        public EmailMessageBuilder SetOrderAmount(double amount)
        {
            this.orderAmount = amount;
            return this;
        }
    }
}
