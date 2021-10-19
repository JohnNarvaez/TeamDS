using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class EditModelHistorias : PageModel
    {
        private readonly IRepositorioHistorias repositorioHistorias;
        [BindProperty]
        public Historia Historia { get; set; }

        public EditModelHistorias(IRepositorioHistorias repositorioHistorias)
        {
            this.repositorioHistorias = repositorioHistorias;
        }
        public IActionResult OnGet(int? historiaId)
        {
            if (historiaId.HasValue)
            {
                Historia = repositorioHistorias.GetHistoriaPorId(historiaId.Value);
            }
            else
            {
                Historia = new Historia();
            }
            if (Historia == null)
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
            if(Historia.Id>0)
            {
            Historia = repositorioHistorias.Update(Historia);
            }
            else
            {
             repositorioHistorias.Add(Historia);
            }
            return Page();
        }


    }
}