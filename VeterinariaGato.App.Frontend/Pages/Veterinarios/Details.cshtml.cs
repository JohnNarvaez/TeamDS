using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{

    public class DetailModelVeterinarios : PageModel
    {
        private readonly IRepositorioVeterinarios repositorioVeterinarios;
        public Veterinario Veterinario { get; set; }

        public DetailModelVeterinarios(IRepositorioVeterinarios repositorioVeterinarios)
        {
            this.repositorioVeterinarios = repositorioVeterinarios;
        }
        public IActionResult OnGet(int VeterinarioId)
        {
            Veterinario = repositorioVeterinarios.GetVeterinarioPorId(VeterinarioId);
            if(Veterinario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}