using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{

    public class DetailModelHistorias : PageModel
    {
        private readonly IRepositorioHistorias repositorioHistorias;
        public Historia Historia { get; set; }

        public DetailModelHistorias(IRepositorioHistorias repositorioHistorias)
        {
            this.repositorioHistorias = repositorioHistorias;
        }
        public IActionResult OnGet(int HistoriaId)
        {
            Historia = repositorioHistorias.GetHistoriaPorId(HistoriaId);
            if(Historia==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}