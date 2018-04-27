using Infraestructure.Data;
using Infraestructure.Core;

namespace Infraestructure.Services
{
    public class BaseEntityService<T> where T : BaseEntity, new()
    {
        private readonly BaseEntityRepository<T> _repository;

        public BaseEntityService(BaseEntityRepository<T> repository)
        {
            _repository = repository;
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
