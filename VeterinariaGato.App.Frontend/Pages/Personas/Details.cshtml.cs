using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{

    public class DetailsModelo : PageModel
    {
        private readonly IRepositorioPersonas repositorioPersonas;
        public Persona Persona { get; set; }

        public DetailsModelo(IRepositorioPersonas repositorioPersonas)
        {
            this.repositorioPersonas = repositorioPersonas;
        }
        public IActionResult OnGet(int personaId)
        {
            Persona = repositorioPersonas.GetPersonaPorId(personaId);
            if(Persona==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}
