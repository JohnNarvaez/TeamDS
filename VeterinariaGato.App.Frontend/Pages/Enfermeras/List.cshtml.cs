using System.Collections.Generic;
using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class ListModelEnfermeras : PageModel
    {
         
      private readonly IRepositorioEnfermeras repositorioEnfermeras;
      public IEnumerable<Enfermera> Enfermeras {get;set;}

      [BindProperty(SupportsGet =true)]
      public string FiltroBusqueda { get; set; }


      public ListModelEnfermeras(IRepositorioEnfermeras repositorioEnfermeras)
      {
        this.repositorioEnfermeras=repositorioEnfermeras;
      }
      
        public void OnGet (string filtroBusqueda)
        {
          FiltroBusqueda=filtroBusqueda;
          Enfermeras=repositorioEnfermeras.GetEnfermerasPorFiltro(filtroBusqueda);
          
        }
    }
}