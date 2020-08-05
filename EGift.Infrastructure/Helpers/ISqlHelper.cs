using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace EGift.Infrastructure.Helpers
{
    public interface ISqlHelper
    {
        Task<DataTable> ExecuteQuery();
    }
}
