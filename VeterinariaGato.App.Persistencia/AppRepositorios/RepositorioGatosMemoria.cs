using System;
using System.Collections.Generic;
using System.Linq;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public class RepositorioGatosMemoria : IRepositorioGatos
    {
        List<Gato> gatos;

        public RepositorioGatosMemoria()
        {
            gatos = new List<Gato>()
            {
                new Gato{Id=1,EnEspañol="Gato 1",EnIngles="Cat 1",EnItaliano="Gatto 1"},
                new Gato{Id=2,EnEspañol="Gato 2",EnIngles="Cat 2",EnItaliano="Gatto 2"},
                new Gato{Id=3,EnEspañol="Gato 3",EnIngles="Cat 3",EnItaliano="Gatto 3"}

            };
        }

        public Gato Add(Gato nuevoGato)
        {
           nuevoGato.Id=gatos.Max(r => r.Id) +1; 
           gatos.Add(nuevoGato);
           return nuevoGato;
        }

        public IEnumerable<Gato> GetAll()
        {
            return gatos;
        }

        public Gato GetGatoPorId(int gatoId)
        {
            return gatos.SingleOrDefault(s => s.Id==gatoId);
        }

        public IEnumerable<Gato> GetGatosPorFiltro(string filtro=null) // el parámetro es opcional 
        {
            var gatos = GetAll(); // Obtiene todos los gatos 
            if (gatos != null)  //Si se tienen gatos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    gatos = gatos.Where(s => s.EnEspañol.Contains(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return gatos;
        }

        public Gato Update(Gato gatoActualizado)
        {
            var gato= gatos.SingleOrDefault(r => r.Id==gatoActualizado.Id);
            if (gato!=null)
            {
                gato.EnEspañol = gatoActualizado.EnEspañol;
                gato.EnIngles=gatoActualizado.EnIngles;
                gato.EnItaliano=gatoActualizado.EnItaliano;
            }
            return gato;
        }
          
    }
}