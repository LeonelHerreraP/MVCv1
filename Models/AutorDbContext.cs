using Microsoft.EntityFrameworkCore;

namespace ProyectoMVC3.Models
{
    public class AutorDbContext : DbContext
    {
        public AutorDbContext(DbContextOptions<AutorDbContext> options) : base(options)
        {

        }

        public DbSet<Autor> Autores { get; set; }
    }
}
