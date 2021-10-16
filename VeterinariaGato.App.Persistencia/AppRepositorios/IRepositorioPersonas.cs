using System.Collections.Generic;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersonas
    {
        IEnumerable<Persona> GetAll();
        IEnumerable<Persona> GetPersonasPorFiltro(string filtro);
        Persona GetPersonaPorId(int PersonaId);
        Persona Update(Persona PersonaActualizada);
        Persona Add(Persona nuevaPersona);
      
    }
}