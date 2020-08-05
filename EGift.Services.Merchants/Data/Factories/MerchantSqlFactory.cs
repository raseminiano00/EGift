namespace EGift.Services.Merchants.Data.Factories
{
    using EGift.Services.Merchants.Data.Entities;
    using EGift.Services.Merchants.Models;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    
    public class MerchantSqlFactory : IMerchantSqlFactory
    {
        protected SqlCommand CreateStoredProcCommand(string procedureName)
        {
            var command = new SqlCommand(procedureName)
            {
                CommandTimeout = 30,
                CommandType = CommandType.StoredProcedure
            };

            return command;
        }
        public SqlCommand CreateGetAllMerchantCommand()
        {
            var result = CreateStoredProcCommand("sp_GetAllMerchant");

            return result;
        }

        public SqlCommand CreateGetMerchantProduct(MerchantEntity merchantEntity)
        {
            var result = CreateStoredProcCommand("sp_GetMerchantProducts");

            result.Parameters.AddWithValue("@slug", merchantEntity.Slug);

            return result;
        }
    }
}
