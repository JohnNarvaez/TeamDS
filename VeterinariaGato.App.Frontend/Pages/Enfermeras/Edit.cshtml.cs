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
    public class EditModelEnfermeras : PageModel
    {
        private readonly IRepositorioEnfermeras repositorioEnfermeras;
        [BindProperty]
        public Enfermera Enfermera { get; set; }

        public EditModelEnfermeras(IRepositorioEnfermeras repositorioEnfermeras)
        {
            this.repositorioEnfermeras = repositorioEnfermeras;
        }
        /*
        public IActionResult OnGet(string? EnfermeraTarjetaProfecional)
        {
            if (EnfermeraTarjetaProfecional.HasValue)
            {
                Enfermera = repositorioEnfermeras.GetEnfermeraPorTarjetaProfecional(EnfermeraTarjetaProfecional.Value);
            }
            else
            {
                Enfermera = new Enfermera();
            }
            if (Enfermera == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        } */


        /* 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Enfermera.TarjetaProfecional>0)
            {
            Enfermera = repositorioEnfermeras.Update(Enfermera);
            }
            else
            {
             repositorioEnfermeras.Add(Enfermera);
            }
            return Page();
        } */


    }
}