using Microsoft.Practices.EnterpriseLibrary.Data;
using Infraestructure.Core;
using System.Linq;
using System;

namespace Infraestructure.Data
{
    public class BaseEntityRepository<T> : BaseRepositoryConnection  where T : BaseEntity, new()
    {
        protected string connectionStringName { get; set; }

        protected override string _connectionStringName
        {
            get
            {
                return connectionStringName;
            }
        }


        protected virtual BaseMapper<T> Mapper => new BaseMapper<T>();

        public T GetById(int id)
        {
            return Db.ExecuteSprocAccessor("Usuario_GetById", Mapper.RowMapper, id).FirstOrDefault(); 
        }
    }
}
