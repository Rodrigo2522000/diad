using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrabajoBas.Models;

namespace TrabajoBas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
    private Ecommerce Context;
    public ClienteController(Ecommerce Parametro)
    {
        Context = Parametro;    
    }
    
    

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return Context.Cliente.ToList();
        }

        // GET api/values/5
        [HttpGet("{userName}")]
        public ActionResult<Cliente> Get(string userName)
        {
            return Context.Cliente.FirstOrDefault(x => x.UserName == userName);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Cliente value)
        {
            Context.Cliente.Add(value);
            Context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente value)
        {

            var client= Context.Cliente.Find(id);
            if (client != null)
            {
            client.Id = value.Id;
            client.Nombre = value.Nombre;
            client.Apellido = value.Apellido;
            client.UserName = value.UserName;
            client.Email = value.Email;
            Context.SaveChanges(); 
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var client = Context.Cliente.Find(id);
            if (client != null)
            {
            Context.Cliente.Remove(client);
            Context.SaveChanges();
            }
        }
    }
}
