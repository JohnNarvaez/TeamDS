using System.Collections.Generic;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSugerenciaCuidados
    {
        IEnumerable<SugerenciaCuidado> GetAll();
        IEnumerable<SugerenciaCuidado> GetSugerenciaCuidadosPorFiltro(string filtro);
        SugerenciaCuidado GetSugerenciaCuidadoPorSugeCuidadoId(int SugerenciaCuidadoSugeCuidadoId);
        SugerenciaCuidado Update(SugerenciaCuidado SugerenciaCuidadoActualizado);
        SugerenciaCuidado Add(SugerenciaCuidado nuevaSugerenciaCuidado);
      
    }
}