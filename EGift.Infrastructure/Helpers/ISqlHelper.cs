using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace EGift.Infrastructure.Helpers
{
    public interface ISqlHelper
    {
        Task<DataTable> ExecuteReaderAsync(SqlCommand command);
    }
}
