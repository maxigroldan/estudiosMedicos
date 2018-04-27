using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Infraestructure.Common.Helpers;

namespace Infraestructure.Data
{
    public class DatabaseFactory
    {
        public Database GetDatabase(string connectionStringName)
        {
            if (!string.IsNullOrEmpty(connectionStringName))
            {
                return new SqlDatabase(ConfigurationHelper.GetConnectionString(connectionStringName));
            }
            return null;
        }
    }
}
