//-----------------------------------------------------------------------
// <summary>
//      Sql Helper Class intends to encapsulate sql native functionalities
// </summary>
//-----------------------------------------------------------------------
namespace EGift.Infrastructure.Helpers
{
    using System.Data;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    public class SqlHelper : ISqlHelper
    {
        private readonly ISqlConnectionHelper<SqlConnection> connectionHelper;
        private readonly DataTable dataResult;
        public SqlHelper(ISqlConnectionHelper<SqlConnection> connectionHelper)
        {
            this.connectionHelper = connectionHelper;
            dataResult = new DataTable();
        }

        public async Task ExecuteAsync(SqlCommand command)
        {

            using (SqlConnection connection = connectionHelper.EstablishConnection())
            {
                command.Connection = connection;
                await command.ExecuteReaderAsync();
            }
        }

        public async Task<DataTable> ExecuteReaderAsync(SqlCommand command)
        {
            ClearDataResult();
            using (SqlConnection connection = connectionHelper.EstablishConnection())
            {
                command.Connection = connection;
                var reader = await command.ExecuteReaderAsync();
                loadToDataResult(reader);
            }
            return dataResult;
        }

        private void ClearDataResult()
        {
            dataResult.Clear();
        }

        private void loadToDataResult(SqlDataReader reader)
        {
            dataResult.Load(reader);
        }
    }
}
