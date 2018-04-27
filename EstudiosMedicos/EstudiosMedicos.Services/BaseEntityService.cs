using EstudiosMedicos.Data;

namespace EstudiosMedicos.Services
{
    public class BaseEntityService<T> : Infraestructure.Services.BaseEntityService<T> where T : Infraestructure.Core.BaseEntity, new()
    {
        public BaseEntityService(BaseEntityRepository<T> repository) : base(repository)
        {
        }
    }
}
