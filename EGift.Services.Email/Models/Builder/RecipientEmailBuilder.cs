using System;
using System.Collections.Generic;
using System.Text;

namespace EGift.Services.Email.Models.Builder
{
    public class RecipientEmailBuilder : EmailMessageBuilder
    {
        public RecipientEmailBuilder(string sender, string recipient, string key) : base(sender, recipient, key)
        {
        }

        public override EmailSenderModel Build()
        {
            this.emailSubject += $"EGift Order";
            this.emailMessage += $"Hi Mr/Ms.{this.recipientName},{Environment.NewLine}Mr/Ms.{this.senderName} has ordered for you {this.productDescription} X {this.quantityOrdered} pc/s amounting total of Php.{this.orderAmount}";
            this.emailMessage += $"{Environment.NewLine}It will be delivered within 7 days.";
            this.emailMessage += $"{Environment.NewLine}Thank you!";
            this.email.subject = this.emailSubject;
            this.email.emailMessage = this.emailMessage;
            return this.email;
        }
    }
}
