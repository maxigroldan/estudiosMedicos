using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Infraestructure.Core;
using EstudiosMedicos.Services;

namespace WebApp.api
{
    public class BaseEntityController<T> : ApiController where T : BaseEntity, new()
    {
        private readonly BaseEntityService<T> _service;

        public BaseEntityController(BaseEntityService<T> service)
        {
            _service = service;
        }
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            return Ok(_service.GetById(0));
        }


        /*// GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }*/
    }
}