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
    public class EditModelo : PageModel
    {
        private readonly IRepositorioPersonas repositorioPersonas;
        [BindProperty]
        public Persona Persona { get; set; }

        public EditModelo(IRepositorioPersonas repositorioPersonas)
        {
            this.repositorioPersonas = repositorioPersonas;
        }
        public IActionResult OnGet(int? personaId)
        {
            if (personaId.HasValue)
            {
                Persona = repositorioPersonas.GetPersonaPorId(personaId.Value);
            }
            else
            {
                Persona = new Persona();
            }
            if (Persona == null)
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
            if(Persona.Id>0)
            {
            Persona = repositorioPersonas.Update(Persona);
            }
            else
            {
             repositorioPersonas.Add(Persona);
            }
            return Page();
        }


    }
}
