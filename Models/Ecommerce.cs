using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrabajoBas.Models
{
    public class Ecommerce : DbContext
    {
        public Ecommerce(DbContextOptions<Ecommerce> options)
            : base(options)
        { 
            
        }

        public DbSet<Producto> Producto { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Cliente {get; set;} 

    }

    public class Producto
    {
        [Key]
        public int ProductoId {get; set;}
        public int Precio { get; set; }
        public string Titulo { get; set; }

        public Categoria Categoria { get; set; }

        public string Descripcion { get; set; }


        public List<Producto> Productos { get; set; }
    }

    public class Categoria
    {
        [Key] 
        public int CategoriaId {get; set;}
        public string Titulo { get; set; }
        
    }

    public class Cliente
    {
        
        [Key]
        public int Id {get; set; }
        public string Nombre {get; set; }
        public string Apellido {get; set;}
        public string Email {get; set; }
        public string UserName {get; set; }

    }
}