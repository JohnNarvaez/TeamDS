using System.Collections.Generic;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public interface IRepositorioGatos
    {
        IEnumerable<Gato> GetAll();
        IEnumerable<Gato> GetGatosPorFiltro(string filtro);
        Gato GetGatoPorCodigo(int GatoCodigo);
        Gato Update(Gato GatoActualizado);
        Gato Add(Gato nuevoGato);
      
    }
}