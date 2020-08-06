namespace EGift.Infrastructure.Common
{
    using System.Data;
    using System.Data.SqlClient;

    public abstract class AbstractSqlFactory
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
    }
}
