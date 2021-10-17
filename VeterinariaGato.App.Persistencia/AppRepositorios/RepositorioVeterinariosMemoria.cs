using System;
using System.Collections.Generic;
using System.Linq;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinariosMemoria : IRepositorioVeterinarios
    {
        List<Veterinario> veterinarios;

        public RepositorioVeterinariosMemoria()
        {
            veterinarios = new List<Veterinario>()
            {
                new Veterinario{Id=1001, Nombre="Edisson", Apellidos="Muñoz", NumeroTelefono="2222", Genero=Genero.masculino, Especialidad="", Codigo="", Registro=""},
                new Veterinario{Id=1003, Nombre="Kevin", Apellidos="Osorio", NumeroTelefono="4444", Genero=Genero.masculino, Especialidad="", Codigo="", Registro=""}
                
            };
        }

        public Veterinario Add(Veterinario nuevoVeterinario)
        {
           nuevoVeterinario.Codigo=veterinarios.Max(r => r.Codigo) +1; 
           veterinarios.Add(nuevoVeterinario);
           return nuevoVeterinario;
        }

        public IEnumerable<Veterinario> GetAll()
        {
            return veterinarios;
        }

        public Veterinario GetVeterinarioPorCodigo(string VeterinarioCodigo)
        {
            return veterinarios.SingleOrDefault(s => s.Codigo==VeterinarioCodigo);
        }
      
        public IEnumerable<Veterinario> GetVeterinariosPorFiltro(string filtro)
        {
            var veterinarios = GetAll(); // Obtiene todas los veterinarios
            if (veterinarios != null)  //Si se tienen veterinarios 
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    veterinarios = veterinarios.Where(s => s.Codigo.Contains(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return veterinarios;
        }

        public Veterinario Update(Veterinario VeterinarioActualizado)
        {
            var veterinario= veterinarios.SingleOrDefault(r => r.Codigo==VeterinarioActualizado.Codigo);
            if (veterinario!=null)
            {
                veterinario.Nombre = VeterinarioActualizado.Nombre;
                veterinario.Apellidos = VeterinarioActualizado.Apellidos;
                veterinario.NumeroTelefono = VeterinarioActualizado.NumeroTelefono;
                veterinario.Genero = VeterinarioActualizado.Genero; 
                veterinario.Especialidad = VeterinarioActualizado.Especialidad; 
                veterinario.Registro = VeterinarioActualizado.Registro; 
                
            }
            return veterinario;
        }
    }
}