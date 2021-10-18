using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace VeterinariaGato.App.Frontend.Pages
{
  /*
    public class ListModelo : PageModel
    {
         
      private readonly IRepositorioPersonas repositorioPersonas;
      public IEnumerable<Persona> Personas {get;set;}

      [BindProperty(SupportsGet =true)]
      public string FiltroBusqueda { get; set; }


      public ListModelo(IRepositorioPersonas repositorioPersonas)
      {
        this.repositorioPersonas=repositorioPersonas;
      }
      
        public void OnGet (string filtroBusqueda)
        {
          FiltroBusqueda=filtroBusqueda;
          Personas=repositorioPersonas.GetPersonasPorFiltro(filtroBusqueda);
          
        }
    }*/
}