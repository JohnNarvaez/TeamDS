using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
         
      private readonly IRepositorioGatos repositorioGatos;
      public IEnumerable<Gato> Gatos {get;set;}

      [BindProperty(SupportsGet =true)]
      public string FiltroBusqueda { get; set; }


      public ListModel(IRepositorioGatos repositorioGatos)
      {
            this.repositorioGatos=repositorioGatos;
      }
      
        public void OnGet() //(string filtroBusqueda)
        {
          //FiltroBusqueda=filtroBusqueda;
          //Gatos=repositorioGatos.GetGatosPorFiltro(filtroBusqueda);
          Gatos=repositorioGatos.GetAll();
        }
    }
}
