using System.Collections.Generic;
using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class ListModelHistorias : PageModel
    {
         
      private readonly IRepositorioHistorias repositorioHistorias;
      public IEnumerable<Historia> Historias {get;set;}

      [BindProperty(SupportsGet =true)]
      public string FiltroBusqueda { get; set; }


      public ListModelHistorias(IRepositorioHistorias repositorioHistorias)
      {
        this.repositorioHistorias=repositorioHistorias;
      }
      
        public void OnGet (string filtroBusqueda)
        {
          FiltroBusqueda=filtroBusqueda;
          Historias=repositorioHistorias.GetHistoriasPorFiltro(filtroBusqueda);
          
        }
    }
  
}