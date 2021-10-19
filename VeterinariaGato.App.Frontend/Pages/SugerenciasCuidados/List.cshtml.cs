using System.Collections.Generic;
using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class ListModelSugerenciasCuidados : PageModel
    {
         
      private readonly IRepositorioSugerenciaCuidados repositorioSugerenciaCuidados;
      public IEnumerable<SugerenciaCuidado> SugerenciaCuidados {get;set;}

      [BindProperty(SupportsGet =true)]
      public string FiltroBusqueda { get; set; }


      public ListModelSugerenciasCuidados(IRepositorioSugerenciaCuidados repositorioSugerenciaCuidados)
      {
        this.repositorioSugerenciaCuidados=repositorioSugerenciaCuidados;
      }
      
        public void OnGet (string filtroBusqueda)
        {
          FiltroBusqueda=filtroBusqueda;
          SugerenciaCuidados=repositorioSugerenciaCuidados.GetSugerenciaCuidadosPorFiltro(filtroBusqueda);
          
        }
    }
}