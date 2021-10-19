using VeterinariaGato.App.Dominio;
using VeterinariaGato.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VeterinariaGato.App.Frontend.Pages
{
    public class EditModelVeterinarios : PageModel
    {
        private readonly IRepositorioVeterinarios repositorioVeterinarios;
        [BindProperty]
        public Veterinario Veterinario { get; set; }

        public EditModelVeterinarios(IRepositorioVeterinarios repositorioVeterinarios)
        {
            this.repositorioVeterinarios = repositorioVeterinarios;
        }
        public IActionResult OnGet(int? veterinarioId)
        {
            if (veterinarioId.HasValue)
            {
                Veterinario = repositorioVeterinarios.GetVeterinarioPorId(veterinarioId.Value);
            }
            else
            {
                Veterinario = new Veterinario();
            }
            if (Veterinario == null)
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
            if(Veterinario.Id>0)
            {
            Veterinario = repositorioVeterinarios.Update(Veterinario);
            }
            else
            {
             repositorioVeterinarios.Add(Veterinario);
            }
            return Page();
        }


    }
}