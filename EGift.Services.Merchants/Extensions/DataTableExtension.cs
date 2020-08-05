namespace EGift.Services.Merchants.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;
    using System.Linq;
    using EGift.Services.Merchants.Messages;
    using EGift.Services.Merchants.Models;

    public static class DataTableExtension
    {
        public static GetAllMerchantResponse AsResponse(this DataTable data)
        {
            var result = new GetAllMerchantResponse();
            foreach (DataRow row in data.Rows)
            {
                var merchant = new Merchant
                {
                    Id = new Guid(row.ItemArray[0].ToString()),
                    Name = row.ItemArray[1].ToString(),
                    Address = row.ItemArray[2].ToString()
                };
                result.Merchants.Add(merchant);
            }
            return result;
        }
    }
}
