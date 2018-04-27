using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Infraestructure.Data
{
    public abstract class BaseRepositoryConnection
    {
        protected abstract string _connectionStringName { get; }

        private Database _db;
        protected Database Db
        {
            get
            {
                if(_db == null)
                {
                    _db = new DatabaseFactory().GetDatabase(_connectionStringName);
                }
                return _db;
            }
        }
    }
}
