using System.Collections.Generic;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVeterinarios
    {
        IEnumerable<Veterinario> GetAll();
        IEnumerable<Veterinario> GetVeterinariosPorFiltro(string filtro);
        Veterinario GetVeterinarioPorId(int VeterinarioId);
        Veterinario Update(Veterinario VeterinarioActualizado);
        Veterinario Add(Veterinario nuevoVeterinario);

    }
}