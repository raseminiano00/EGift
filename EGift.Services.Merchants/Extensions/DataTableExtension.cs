namespace EGift.Services.Merchants.Extensions
{
    using System;
    using System.Data;
    using EGift.Services.Merchants.Messages;
    using EGift.Services.Merchants.Models;

    public static class DataTableExtension
    {
        public static GetAllMerchantResponse AsGetAllMerchantResponse(this DataTable data)
        {
            var result = new GetAllMerchantResponse();
            foreach (DataRow row in data.Rows)
            {
                var merchant = new Merchant
                {
                    Id = new Guid(row.ItemArray[0].ToString()),
                    Name = row.ItemArray[1].ToString(),
                    Address = row.ItemArray[2].ToString(),
                    Slug = row.ItemArray[3].ToString()
                };
                result.Merchants.Add(merchant);
                result.Successful = true;
            }

            return result;
        }

        public static GetMerchantProductResponse AsGetMerchantProductsResponse(this DataTable data)
        {
            var result = new GetMerchantProductResponse();
            foreach (DataRow row in data.Rows)
            {
                var product = new Product
                {
                    Id = new Guid(row.ItemArray[1].ToString()),
                    Name = row.ItemArray[2].ToString(),
                    Description = row.ItemArray[3].ToString(),
                    Price = Convert.ToDouble(row.ItemArray[4].ToString())
                };
                result.Products.Add(product);
                result.MerchantName = row.ItemArray[0].ToString();
                result.Successful = true;
            }

            return result;
        }
    }
}
