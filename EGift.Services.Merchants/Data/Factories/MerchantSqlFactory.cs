namespace EGift.Services.Merchants.Data.Factories
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    
    public class MerchantSqlFactory : IMerchantSqlFactory
    {
        public SqlCommand CreateGetAllMerchantCommand()
        {
            var result = new SqlCommand("sp_GetAllMerchant")
            {
                CommandTimeout = 30,
                CommandType = CommandType.StoredProcedure
            };

            return result;
        }
    }
}
