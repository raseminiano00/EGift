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
            this.dataResult = new DataTable();
        }

        public async Task ExecuteAsync(SqlCommand command)
        {
            using (SqlConnection connection = this.connectionHelper.EstablishConnection())
            {
                command.Connection = connection;
                await command.ExecuteReaderAsync();
            }
        }

        public async Task<DataTable> ExecuteReaderAsync(SqlCommand command)
        {
            this.ClearDataResult();
            using (SqlConnection connection = this.connectionHelper.EstablishConnection())
            {
                command.Connection = connection;
                var reader = await command.ExecuteReaderAsync();
                this.LoadToDataResult(reader);
            }

            return this.dataResult;
        }

        private void ClearDataResult()
        {
            this.dataResult.Clear();
        }

        private void LoadToDataResult(SqlDataReader reader)
        {
            this.dataResult.Load(reader);
        }
    }
}
