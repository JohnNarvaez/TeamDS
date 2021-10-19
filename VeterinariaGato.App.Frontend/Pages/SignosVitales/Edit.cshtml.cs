using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class EditModelSignosVitales : PageModel
    {
        private readonly IRepositorioSignosVitales repositorioSignosVitales;
        [BindProperty]
        public SignoVital SignoVital { get; set; }

        public EditModelSignosVitales(IRepositorioSignosVitales repositorioSignosVitales)
        {
            this.repositorioSignosVitales = repositorioSignosVitales;
        }
        public IActionResult OnGet(int? signoVitalId)
        {
            if (signoVitalId.HasValue)
            {
                SignoVital = repositorioSignosVitales.GetSignoVitalPorId(signoVitalId.Value);
            }
            else
            {
                SignoVital = new SignoVital();
            }
            if (SignoVital == null)
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
            if(SignoVital.Id>0)
            {
            SignoVital = repositorioSignosVitales.Update(SignoVital);
            }
            else
            {
             repositorioSignosVitales.Add(SignoVital);
            }
            return Page();
        }


    }
}