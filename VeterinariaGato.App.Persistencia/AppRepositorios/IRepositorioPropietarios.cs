using System.Collections.Generic;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietarios
    {
        IEnumerable<Propietario> GetAll();
        IEnumerable<Propietario> GetPropietariosPorFiltro(string filtro);
        Propietario GetPropietarioPorCorreo(string PropietarioCorreo);
        Propietario Update(Propietario PropietarioActualizado);
        Propietario Add(Propietario nuevoPropietario);
      
    }
}