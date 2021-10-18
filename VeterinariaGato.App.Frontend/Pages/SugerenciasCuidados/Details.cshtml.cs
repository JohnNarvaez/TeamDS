using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{

    public class DetailModelSugerenciaCuidados : PageModel
    {
        private readonly IRepositorioSugerenciaCuidados repositorioSugerenciaCuidados;
        public SugerenciaCuidado SugerenciaCuidado { get; set; }

        public DetailModelSugerenciaCuidados(IRepositorioSugerenciaCuidados repositorioSugerenciaCuidados)
        {
            this.repositorioSugerenciaCuidados = repositorioSugerenciaCuidados;
        }
        public IActionResult OnGet(int SugerenciaCuidadoSugeCuidadoId)
        {
            SugerenciaCuidado = repositorioSugerenciaCuidados.GetSugerenciaCuidadoPorSugeCuidadoId(SugerenciaCuidadoSugeCuidadoId);
            if(SugerenciaCuidado==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}