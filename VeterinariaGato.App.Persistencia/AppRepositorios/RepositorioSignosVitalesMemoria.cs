using System;
using System.Collections.Generic;
using System.Linq;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public class RepositorioSignosVitalesMemoria : IRepositorioSignosVitales
    {
        List<SignoVital> signosVitales;

        public RepositorioSignosVitalesMemoria()
        {
            signosVitales= new List<SignoVital>()
            {
                new SignoVital{Id=001, FechaHora=DateTime.MaxValue, Signo=Signo.FrecuenciaCardiaca, Valor=60}, 
                new SignoVital{Id=002, FechaHora=DateTime.MinValue, Signo=Signo.Temperatura, Valor=36}    
                //Falta implementar la fecha y hora             
            };
        }

        public SignoVital Add(SignoVital nuevoSignoVital)
        {
           nuevoSignoVital.Id=signosVitales.Max(r => r.Id) +1; 
           signosVitales.Add(nuevoSignoVital);
           return nuevoSignoVital;
        }

        public IEnumerable<SignoVital> GetAll()
        {
            return signosVitales;
        }

        public IEnumerable<SignoVital> GetSignosVitalesPorFiltro(string filtro)
        {
            var signosVitales = GetAll(); // Obtiene todos los signos vitales
            if (signosVitales != null)  //Si se tienen signos vitales
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    signosVitales = signosVitales.Where(s => s.Id.Equals(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return signosVitales;
        }

        public SignoVital GetSignoVitalPorId(int SignoVitalId)
        {
            return signosVitales.SingleOrDefault(s => s.Id==SignoVitalId);
        }

        public SignoVital Update(SignoVital SignoVitalActualizado)
        {
            var signoVital= signosVitales.SingleOrDefault(r => r.Id==SignoVitalActualizado.Id);
            if (signoVital!=null)
            {
                signoVital.FechaHora = SignoVitalActualizado.FechaHora;
                signoVital.Signo = SignoVitalActualizado.Signo;
                signoVital.Valor = SignoVitalActualizado.Valor;                
            }
            return signoVital;
        }

    }
}