using EstudiosMedicos.Core.Entities;

namespace EstudiosMedicos.Data
{
    public class UsuarioRepository : BaseEntityRepository<Usuario>
    {
        public Usuario GetById(int id)
        {
            return base.GetById(id);
        }
    }
}
