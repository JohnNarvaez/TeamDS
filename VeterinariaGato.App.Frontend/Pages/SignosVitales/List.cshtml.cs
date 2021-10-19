using System.Collections.Generic;
using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class ListModelSignosVitales : PageModel
    {
      
      private readonly IRepositorioSignosVitales repositorioSignosVitales;
      public IEnumerable<SignoVital> SignosVitales {get;set;}

      [BindProperty(SupportsGet =true)]
      public string FiltroBusqueda { get; set; }


      public ListModelSignosVitales(IRepositorioSignosVitales repositorioSignosVitales)
      {
        this.repositorioSignosVitales=repositorioSignosVitales;
      }
      
        public void OnGet (string filtroBusqueda)
        {
          FiltroBusqueda=filtroBusqueda;
          SignosVitales=repositorioSignosVitales.GetSignosVitalesPorFiltro(filtroBusqueda);
          
        }
    }
}