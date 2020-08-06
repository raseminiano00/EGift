namespace EGift.Infrastructure.Helpers
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    public interface ISqlHelper
    {
        Task<DataTable> ExecuteReaderAsync(SqlCommand command);
    }
}
