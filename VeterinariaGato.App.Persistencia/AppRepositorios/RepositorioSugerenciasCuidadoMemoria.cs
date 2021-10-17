using System;
using System.Collections.Generic;
using System.Linq;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public class RepositorioSugerenciasCuidadoMemoria : IRepositorioSugerenciaCuidados
    {
        List<SugerenciaCuidado> sugerenciaCuidados;

        public RepositorioSugerenciasCuidadoMemoria()
        {
            sugerenciaCuidados = new List<SugerenciaCuidado>()
            {
                new SugerenciaCuidado{SugeCuidadoId=01, Descripcion="En construcción"},
                new SugerenciaCuidado{SugeCuidadoId=02, Descripcion="En construcción"}                
            };
        }

        public SugerenciaCuidado Add(SugerenciaCuidado nuevaSugerenciaCuidado)
        {
           nuevaSugerenciaCuidado.SugeCuidadoId=sugerenciaCuidados.Max(r => r.SugeCuidadoId) +1; 
           sugerenciaCuidados.Add(nuevaSugerenciaCuidado);
           return nuevaSugerenciaCuidado;
        }

        public IEnumerable<SugerenciaCuidado> GetAll()
        {
            return sugerenciaCuidados;
        }

         public SugerenciaCuidado GetSugerenciaCuidadoPorSugeCuidadoId(int SugerenciaCuidadoSugeCuidadoId)
        {
            return sugerenciaCuidados.SingleOrDefault(s => s.SugeCuidadoId==SugerenciaCuidadoSugeCuidadoId);
        }

        
        public IEnumerable<SugerenciaCuidado> GetSugerenciaCuidadosPorFiltro(string filtro)
        {
            var sugerenciaCuidados = GetAll(); // Obtiene todas las sugerencias 
            if (sugerenciaCuidados != null)  //Si se tienen sugerencias
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    sugerenciaCuidados = sugerenciaCuidados.Where(s => s.SugeCuidadoId.Equals(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return sugerenciaCuidados;
        }

        public SugerenciaCuidado Update(SugerenciaCuidado SugerenciaCuidadoActualizado)
        {
            var sugerenciaCuidado= sugerenciaCuidados.SingleOrDefault(r => r.SugeCuidadoId==SugerenciaCuidadoActualizado.SugeCuidadoId);
            if (sugerenciaCuidado!=null)
            {
                sugerenciaCuidado.FechaHora = SugerenciaCuidadoActualizado.FechaHora;
                sugerenciaCuidado.Descripcion = SugerenciaCuidadoActualizado.Descripcion;
                
            }
            return sugerenciaCuidado;
        }

    }
}