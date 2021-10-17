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
                new Gato{Codigo=1, Nombre="Rufus", Raza="Himalayo", Color="Marrón", Edad="2"},
                new Gato{Codigo=2, Nombre="Pacho", Raza="Van turco", Color="Blanco", Edad="3"}

            };
        }

        public Gato Add(Gato nuevoGato)
        {
           nuevoGato.Codigo=gatos.Max(r => r.Codigo) +1; 
           gatos.Add(nuevoGato);
           return nuevoGato;
        }

        public IEnumerable<Gato> GetAll()
        {
            return gatos;
        }

        public Gato GetGatoPorCodigo(int GatoCodigo)
        {
            return gatos.SingleOrDefault(s => s.Codigo==GatoCodigo);
        }

        public IEnumerable<Gato> GetGatosPorFiltro(string filtro=null) // el parámetro es opcional 
        {
            var gatos = GetAll(); // Obtiene todos los gatos 
            if (gatos != null)  //Si se tienen gatos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    gatos = gatos.Where(s => s.Nombre.Contains(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return gatos;
        }

        public Gato Update(Gato gatoActualizado)
        {
            var gato= gatos.SingleOrDefault(r => r.Codigo==gatoActualizado.Codigo);
            if (gato!=null)
            {
                gato.Codigo = gatoActualizado.Codigo;
                gato.Nombre=gatoActualizado.Nombre;
                gato.Raza=gatoActualizado.Raza;
                gato.Color=gatoActualizado.Color;
                gato.Edad=gatoActualizado.Edad;
                gato.Veterinario=gatoActualizado.Veterinario;
                gato.SignoVital=gatoActualizado.SignoVital;
                gato.Propietario=gatoActualizado.Propietario;
                gato.Enfermera=gatoActualizado.Enfermera;
                gato.Historia=gatoActualizado.Historia;
            }
            return gato;
        }
          
    }
}