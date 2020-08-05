using EGift.Services.Merchants.Data.Entities;
using EGift.Services.Merchants.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EGift.Services.Merchants.Data.Factories
{
    public interface IMerchantSqlFactory
    {
        SqlCommand CreateGetAllMerchantCommand();

        SqlCommand CreateGetMerchantProduct(MerchantEntity merchantEntity);
    }
}
