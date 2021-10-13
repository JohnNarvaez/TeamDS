using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{

    public class DetailsModel : PageModel
    {
        private readonly IRepositorioGatos repositorioGatos;
        public Gato Gato { get; set; }

        public DetailsModel(IRepositorioGatos repositorioGatos)
        {
            this.repositorioGatos = repositorioGatos;
        }
        public IActionResult OnGet(int gatoCodigo)
        {
            Gato = repositorioGatos.GetGatoPorCodigo(gatoCodigo);
            if(Gato==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
