using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{

    public class DetailModelSignosVitales : PageModel
    {
        private readonly IRepositorioSignosVitales repositorioSignosVitales;
        public SignoVital SignoVital { get; set; }

        public DetailModelSignosVitales(IRepositorioSignosVitales repositorioSignosVitales)
        {
            this.repositorioSignosVitales = repositorioSignosVitales;
        }
        public IActionResult OnGet(int SignoVitalId)
        {
            SignoVital = repositorioSignosVitales.GetSignoVitalPorId(SignoVitalId);
            if(SignoVital==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}