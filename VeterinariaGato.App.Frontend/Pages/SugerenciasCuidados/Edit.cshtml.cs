using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class EditModelSugerenciaCuidados : PageModel
    {
        private readonly IRepositorioSugerenciaCuidados repositorioSugerenciaCuidados;
        [BindProperty]
        public SugerenciaCuidado SugerenciaCuidado { get; set; }

        public EditModelSugerenciaCuidados(IRepositorioSugerenciaCuidados repositorioSugerenciaCuidados)
        {
            this.repositorioSugerenciaCuidados = repositorioSugerenciaCuidados;
        }
        public IActionResult OnGet(int? SugerenciaCuidadoSugeCuidadoId)
        {
            if (SugerenciaCuidadoSugeCuidadoId.HasValue)
            {
                SugerenciaCuidado = repositorioSugerenciaCuidados.GetSugerenciaCuidadoPorSugeCuidadoId(SugerenciaCuidadoSugeCuidadoId.Value);
            }
            else
            {
                SugerenciaCuidado = new SugerenciaCuidado();
            }
            if (SugerenciaCuidado == null)
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
            if(SugerenciaCuidado.SugeCuidadoId>0)
            {
            SugerenciaCuidado = repositorioSugerenciaCuidados.Update(SugerenciaCuidado);
            }
            else
            {
             repositorioSugerenciaCuidados.Add(SugerenciaCuidado);
            }
            return Page();
        }


    }
}