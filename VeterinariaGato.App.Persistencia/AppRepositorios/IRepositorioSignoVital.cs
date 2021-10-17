using System.Collections.Generic;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSignosVitales
    {
        IEnumerable<SignoVital> GetAll();
        IEnumerable<SignoVital> GetSignosVitalesPorFiltro(string filtro);
        SignoVital GetSignoVitalPorId(int SignoVitalId);
        SignoVital Update(SignoVital SignoVitalActualizado);
        SignoVital Add(SignoVital nuevoSignoVital);
      
    }
}