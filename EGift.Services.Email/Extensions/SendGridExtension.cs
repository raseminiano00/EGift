namespace EGift.Services.Email.Extensions
{
    using EGift.Services.Email.Messages;
    using SendGrid;

    public static class SendGridExtension
    {
        public static SendEmailResponse AsServiceResponse(this Response response)
        {
            var result = new SendEmailResponse() {
                ApiResponse = response.StatusCode.ToString()
            };

            return result;
        }
    }
}
