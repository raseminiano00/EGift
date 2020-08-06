namespace EGift.Services.Merchants.Data.Factories
{
    using System.Data.SqlClient;
    using EGift.Infrastructure.Common;
    using EGift.Services.Merchants.Data.Entities;

    public class MerchantSqlFactory : AbstractSqlFactory, IMerchantSqlFactory
    {
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
