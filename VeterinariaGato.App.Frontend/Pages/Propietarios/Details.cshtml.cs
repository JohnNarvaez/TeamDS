using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{

    public class DetailModelPropietario : PageModel
    {
        private readonly IRepositorioPropietarios repositorioPropietarios;
        public Propietario Propietario { get; set; }

        public DetailModelPropietario(IRepositorioPropietarios repositorioPropietarios)
        {
            this.repositorioPropietarios = repositorioPropietarios;
        }
        public IActionResult OnGet(int PropietarioId)
        {
            Propietario = repositorioPropietarios.GetPropietarioPorId(PropietarioId);
            if(Propietario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}