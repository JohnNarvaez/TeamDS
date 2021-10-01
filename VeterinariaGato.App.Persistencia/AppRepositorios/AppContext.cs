using Microsoft.EntityFrameworkCore;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Enfermera> Enfermeras {get;set;}
        public DbSet<Gato> Gatos {get;set;}
        public DbSet<Historia> Historias {get;set;}
        public DbSet<Propietario> Propietarios {get;set;}
        public DbSet<SignoVital> SignosVitales {get;set;}
        public DbSet<SugerenciaCuidado> SugerenciaCuidados {get;set;}
        public DbSet<Veterinario> Veterinarios {get;set;}
                
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = VeterinariaGato.App" );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.Entity<Enfermera>().ToTable("Enfermeras");
          modelBuilder.Entity<Gato>().ToTable("Gatos");
          modelBuilder.Entity<Historia>().ToTable("Historias");
          modelBuilder.Entity<Propietario>().ToTable("Propietarios");
          modelBuilder.Entity<SignoVital>().ToTable("SignosVitales");
          modelBuilder.Entity<SugerenciaCuidado>().ToTable("SugerenciaCuidados");
          modelBuilder.Entity<Veterinario>().ToTable("Veterinarios");

        }
    }
} 