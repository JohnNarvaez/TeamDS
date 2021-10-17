using System;
using System.Collections.Generic;
using System.Linq;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public class RepositorioEnfermerasMemoria : IRepositorioEnfermeras
    {
        List<Enfermera> enfermeras;

        public RepositorioEnfermerasMemoria()
        {
            enfermeras = new List<Enfermera>()
            {
                new Enfermera{Id=1002, Nombre="Sindy", Apellidos="Ovalle", NumeroTelefono="3333", Genero=Genero.femenino, TarjetaProfecional="0001", HorasLaboradas=10}
                                
            };
        }

        public Enfermera Add(Enfermera nuevaEnfermera)
        {
           nuevaEnfermera.TarjetaProfecional=enfermeras.Max(r => r.TarjetaProfecional) +1; 
           enfermeras.Add(nuevaEnfermera);
           return nuevaEnfermera;
        }

        public IEnumerable<Enfermera> GetAll()
        {
            return enfermeras;
        }

        public Enfermera GetEnfermeraPorTarjetaProfecional(string EnfermeraTarjetaProfecional)
        {
            return enfermeras.SingleOrDefault(s => s.TarjetaProfecional==EnfermeraTarjetaProfecional);
        }

        public IEnumerable<Enfermera> GetEnfermerasPorFiltro(string filtro=null) // el parámetro es opcional 
        {
        
            var enfermeras = GetAll(); // Obtiene todas las enfermeras 
            if (enfermeras != null)  //Si se tienen enfermeras
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    enfermeras = enfermeras.Where(s => s.TarjetaProfecional.Contains(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return enfermeras;
        }

        public Enfermera Update(Enfermera EnfermeraActualizada)
        {
            var enfermera= enfermeras.SingleOrDefault(r => r.TarjetaProfecional==EnfermeraActualizada.TarjetaProfecional);
            if (enfermera!=null)
            {
                enfermera.Nombre = EnfermeraActualizada.Nombre;
                enfermera.Apellidos = EnfermeraActualizada.Apellidos;
                enfermera.NumeroTelefono = EnfermeraActualizada.NumeroTelefono;
                enfermera.Genero = EnfermeraActualizada.Genero; 
                enfermera.TarjetaProfecional = EnfermeraActualizada.TarjetaProfecional; 
                enfermera.HorasLaboradas = EnfermeraActualizada.HorasLaboradas; 
            }
            return enfermera;
        }
    }
}