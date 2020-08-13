namespace EGift.Services.Email.Exceptions
{
    using System;

    public class EmailServiceException : Exception
    {
        public EmailServiceException(Exception ex) : base(string.Empty, ex)
        {
        }
    }
}
