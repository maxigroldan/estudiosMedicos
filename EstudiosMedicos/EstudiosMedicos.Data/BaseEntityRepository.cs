using Infraestructure.Data;
using Infraestructure.Core;
using EstudiosMedicos.Common;

namespace EstudiosMedicos.Data
{
    public class BaseEntityRepository<T> : Infraestructure.Data.BaseEntityRepository<T> where T : BaseEntity, new()
    {

        public BaseEntityRepository(){
            InitDatabase();
        }

        private void InitDatabase()
        {
            connectionStringName = ConfigurationKeys.IsDeploy ? "estudiosMedicosDb" : System.Environment.MachineName;
        }     

    }
}
