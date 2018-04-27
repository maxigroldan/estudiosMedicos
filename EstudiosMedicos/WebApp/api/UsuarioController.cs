using System.Web.Http;
using EstudiosMedicos.Services;
using EstudiosMedicos.Core.Entities;

namespace WebApp.api
{
    public class UsuarioController : BaseEntityController<Usuario>
    {
        //private readonly BaseEntityService<Usuario> _usuarioService;

        //public UsuarioController(BaseEntityService<Usuario> usuarioService)
        //{
        //    _usuarioService = usuarioService;
        //}
        //// GET api/<controller>
        //public IHttpActionResult Get()
        //{
        //    return Ok(_usuarioService.GetById(0));
        //}
        public UsuarioController(BaseEntityService<Usuario> service) : base(service)
        {
        }
    }
}