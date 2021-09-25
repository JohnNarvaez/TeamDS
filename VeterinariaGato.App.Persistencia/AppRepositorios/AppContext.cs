using Microsoft.EntityFrameworkCore;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Persona {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = VeterinariaGato.App" );
            }
        }
    }
} 