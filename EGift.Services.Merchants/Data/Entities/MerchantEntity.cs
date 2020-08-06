namespace EGift.Services.Merchants.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MerchantEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Slug { get; set; }
    }
}
