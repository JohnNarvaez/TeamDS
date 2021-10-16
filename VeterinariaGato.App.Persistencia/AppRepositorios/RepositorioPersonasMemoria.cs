using System;
using System.Collections.Generic;
using System.Linq;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public class RepositorioPersonasMemoria : IRepositorioPersonas
    {
        List<Persona> personas;

        public RepositorioPersonasMemoria()
        {
            personas = new List<Persona>()
            {
                new Persona{Id=1000, Nombre="John", Apellidos="Narvaez", NumeroTelefono="1111", Genero=Genero.masculino},
                new Persona{Id=1001, Nombre="Edisson", Apellidos="Muñoz", NumeroTelefono="2222", Genero=Genero.masculino},
                new Persona{Id=1002, Nombre="Sindy", Apellidos="Ovalle", NumeroTelefono="3333", Genero=Genero.femenino},
                new Persona{Id=1003, Nombre="Kevin", Apellidos="Osorio", NumeroTelefono="4444", Genero=Genero.masculino}
                
            };
        }

        public Persona Add(Persona nuevaPersona)
        {
           nuevaPersona.Id=personas.Max(r => r.Id) +1; 
           personas.Add(nuevaPersona);
           return nuevaPersona;
        }

        public IEnumerable<Persona> GetAll()
        {
            return personas;
        }

        public Persona GetPersonaPorId(int PersonaId)
        {
            return personas.SingleOrDefault(s => s.Id==PersonaId);
        }

        public IEnumerable<Persona> GetPersonasPorFiltro(string filtro=null) // el parámetro es opcional 
        {
            var personas = GetAll(); // Obtiene todas las personas 
            if (personas != null)  //Si se tienen personas 
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    personas = personas.Where(s => s.Nombre.Contains(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return personas;
        }

        public Persona Update(Persona personaActualizada)
        {
            var persona= personas.SingleOrDefault(r => r.Id==personaActualizada.Id);
            if (persona!=null)
            {
                persona.Nombre = personaActualizada.Nombre;
                persona.Apellidos = personaActualizada.Apellidos;
                persona.NumeroTelefono = personaActualizada.NumeroTelefono;
                persona.Genero = personaActualizada.Genero; 
                
            }
            return persona;
        }

    }
}