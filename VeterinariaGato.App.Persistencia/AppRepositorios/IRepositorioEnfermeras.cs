using System.Collections.Generic;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEnfermeras
    {
        IEnumerable<Enfermera> GetAll();
        IEnumerable<Enfermera> GetEnfermerasPorFiltro(string filtro);
        Enfermera GetEnfermeraPorTarjetaProfecional(string EnfermeraTarjetaProfecional);
        Enfermera Update(Enfermera EnfermeraActualizada);
        Enfermera Add(Enfermera nuevaEnfermera);
      
    }
}