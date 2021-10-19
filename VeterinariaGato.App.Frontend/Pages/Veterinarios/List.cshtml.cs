using System.Collections.Generic;
using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class ListModelVeterinarios : PageModel
    {
         
      private readonly IRepositorioVeterinarios repositorioVeterinarios;
      public IEnumerable<Veterinario> Veterinarios {get;set;}

      [BindProperty(SupportsGet =true)]
      public string FiltroBusqueda { get; set; }


      public ListModelVeterinarios(IRepositorioVeterinarios repositorioVeterinarios)
      {
        this.repositorioVeterinarios=repositorioVeterinarios;
      }
      
        public void OnGet (string filtroBusqueda)
        {
          FiltroBusqueda=filtroBusqueda;
          Veterinarios=repositorioVeterinarios.GetVeterinariosPorFiltro(filtroBusqueda);
          
        }
    }
  
}