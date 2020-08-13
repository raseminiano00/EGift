namespace EGift.Services.Email.Models.Builder
{
    using System;
    using System.Collections.Generic;
    using System.Net.Mail;
    using System.Runtime.CompilerServices;
    using System.Text;
    public class SenderEmailBuilder : EmailMessageBuilder
    {
        public SenderEmailBuilder(string sender, string recipient, string key) : base(sender, recipient, key)
        {
        }

        public override EmailSenderModel Build()
        {
            emailSubject += $"EGift Order";
            emailMessage += $"Hi Mr/Ms.{this.senderName},{Environment.NewLine}You have ordered {this.productDescription} X {this.quantityOrdered} pc/s amounting total of Php.{this.orderAmount} for Mr/Ms.{this.recipientName}";
            this.emailMessage += $"{Environment.NewLine}It will be delivered within 7 days.";
            this.emailMessage += $"{Environment.NewLine}Thank you for availing our service!";
            this.email.subject = this.emailSubject;
            this.email.emailMessage = this.emailMessage;
            return this.email;
        }
    }
}
