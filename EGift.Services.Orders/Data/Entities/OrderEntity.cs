namespace EGift.Services.Orders.Data.Entities
{
    using System;

    public class OrderEntity
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public string MerchantName { get; set; }

        public string ProductCode { get; set; }

        public string ProductDescription { get; set; }

        public double Price { get; set; }

        public double TotalOrderedAmount { get; set; }

        public int OrderQuantity { get; set; }

        public string SenderName { get; set; }

        public string SenderEmail { get; set; }

        public string RecipientName { get; set; }

        public string RecipientEmail { get; set; }

        public DateTime DateOrdered { get; set; }

        public string AdditionalMessage { get; set; }
    }
}
