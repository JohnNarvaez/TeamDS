using System.Collections.Generic;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public interface IRepositorioHistorias
    {
        IEnumerable<Historia> GetAll();
        IEnumerable<Historia> GetHistoriasPorFiltro(string filtro);
        Historia GetHistoriaPorId(int HistoriaId);
        Historia Update(Historia HistoriaActualizada);
        Historia Add(Historia nuevaHistoria);
      
    }
}