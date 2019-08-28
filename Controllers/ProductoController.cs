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
    public class ProductoController : ControllerBase
    {
    private Ecommerce Context;
    public ProductoController(Ecommerce Parametro)
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
        public ActionResult<Producto> Get(int id)
        {
            return Context.Producto.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Producto value)
        {
            Context.Producto.Add(value);
            Context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Producto value)
        {
            var product= Context.Producto.Find(id);
            if (product != null)
            {
            product.Precio = value.Precio;
            product.Titulo = value.Titulo;
            product.Categoria = value.Categoria;
            product.Descripcion = value.Descripcion;
            Context.SaveChanges(); 
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var product = Context.Producto.Find(id);
            if (product != null)
            {
                Context.Producto.Remove(product);
                Context.SaveChanges();
            }
        }
    }
}
