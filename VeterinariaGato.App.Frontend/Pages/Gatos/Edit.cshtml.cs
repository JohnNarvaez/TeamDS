using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioGatos repositorioGatos;
        [BindProperty]
        public Gato Gato { get; set; }

        public EditModel(IRepositorioGatos repositorioGatos)
        {
            this.repositorioGatos = repositorioGatos;
        }
        public IActionResult OnGet(int? gatoId)
        {
            if (gatoId.HasValue)
            {
                Gato = repositorioGatos.GetGatoPorId(gatoId.Value);
            }
            else
            {
                Gato = new Gato();
            }
            if (Gato == null)
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
            if(Gato.Id>0)
            {
            Gato = repositorioGatos.Update(Gato);
            }
            else
            {
             repositorioGatos.Add(Gato);
            }
            return Page();
        }


    }
}
