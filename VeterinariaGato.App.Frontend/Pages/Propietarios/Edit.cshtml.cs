using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class EditModelPropietarios : PageModel
    {
        private readonly IRepositorioPropietarios repositorioPropietarios;
        [BindProperty]
        public Propietario Propietario { get; set; }

        public EditModelPropietarios(IRepositorioPropietarios repositorioPropietarios)
        {
            this.repositorioPropietarios = repositorioPropietarios;
        }
        public IActionResult OnGet(int? propietarioId)
        {
            if (propietarioId.HasValue)
            {
                Propietario = repositorioPropietarios.GetPropietarioPorId(propietarioId.Value);
            }
            else
            {
                Propietario = new Propietario();
            }
            if (Propietario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Propietario.Id>0)
            {
            Propietario = repositorioPropietarios.Update(Propietario);
            }
            else
            {
             repositorioPropietarios.Add(Propietario);
            }
            return Page();
        }


    }
}