namespace EGift.Infrastructure.Helpers
{
    using System.Data.SqlClient;

    public class SqlConnectionHelper : ISqlConnectionHelper<SqlConnection>
    {
        public SqlConnection EstablishConnection()
        {
            var connection = new SqlConnection("Data Source=ROI-PC;Database=EGift;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False");

            connection.Open();

            return connection;
        }
    }
}
