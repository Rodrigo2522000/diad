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
    public class CategoriaController : ControllerBase
    {
    private Ecommerce Context;
    public CategoriaController(Ecommerce Parametro)
    {
        Context = Parametro;    
    }
    
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            return Context.Producto.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Categoria> Get(int id)
        {
            return Context.Categorias.Find(id); 
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
