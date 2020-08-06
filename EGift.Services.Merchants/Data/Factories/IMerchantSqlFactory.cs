namespace EGift.Services.Merchants.Data.Factories
{
    using System.Data.SqlClient;
    using EGift.Services.Merchants.Data.Entities;

    public interface IMerchantSqlFactory
    {
        SqlCommand CreateGetAllMerchantCommand();

        SqlCommand CreateGetMerchantProduct(MerchantEntity merchantEntity);
    }
}
