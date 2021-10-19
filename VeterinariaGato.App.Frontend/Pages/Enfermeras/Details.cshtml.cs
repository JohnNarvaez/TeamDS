using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{

    public class DetailModelEnfermeras : PageModel
    {
        private readonly IRepositorioEnfermeras repositorioEnfermeras;
        public Enfermera Enfermera { get; set; }

        public DetailModelEnfermeras(IRepositorioEnfermeras repositorioEnfermeras)
        {
            this.repositorioEnfermeras = repositorioEnfermeras;
        }
        public IActionResult OnGet(int EnfermeraId)
        {
            Enfermera = repositorioEnfermeras.GetEnfermeraPorId( EnfermeraId);
            if(Enfermera==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}