using System.Collections.Generic;
using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class ListModelPropietarios : PageModel
    {
         
      private readonly IRepositorioPropietarios repositorioPropietarios;
      public IEnumerable<Propietario> Propietarios {get;set;}

      [BindProperty(SupportsGet =true)]
      public string FiltroBusqueda { get; set; }


      public ListModelPropietarios(IRepositorioPropietarios repositorioPropietarios)
      {
        this.repositorioPropietarios=repositorioPropietarios;
      }
      
        public void OnGet (string filtroBusqueda)
        {
          FiltroBusqueda=filtroBusqueda;
          Propietarios=repositorioPropietarios.GetPropietariosPorFiltro(filtroBusqueda);
          
        }
    }
}