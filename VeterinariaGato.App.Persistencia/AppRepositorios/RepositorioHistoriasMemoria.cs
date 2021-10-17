using System;
using System.Collections.Generic;
using System.Linq;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public class RepositorioHistoriasMemoria : IRepositorioHistorias
    {
        List<Historia> historias;

        public RepositorioHistoriasMemoria() => historias = new List<Historia>()
            {
                new Historia{Id=100, Diagnostico="Hipotenso", Entorno="Indefinido"},
                new Historia{Id=101, Diagnostico="Normotenso", Entorno="Indefinido"}
                
            };

        public Historia Add(Historia nuevaHistoria)
        {
           nuevaHistoria.Id=historias.Max(r => r.Id) +1; 
           historias.Add(nuevaHistoria);
           return nuevaHistoria;
        }

        public IEnumerable<Historia> GetAll()
        {
            return historias;
        }

        public Historia GetHistoriaPorId(int HistoriaId)
        {
            return historias.SingleOrDefault(s => s.Id==HistoriaId);
        }

        public IEnumerable<Historia> GetHistoriasPorFiltro(string filtro)
        {
            var historias = GetAll(); // Obtiene todas las historias  
            if (historias != null)  //Si se tienen historias 
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    historias = historias.Where(s => s.Diagnostico.Contains(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return historias;
        }

        public Historia Update(Historia HistoriaActualizada)
        {
            var historia= historias.SingleOrDefault(r => r.Id==HistoriaActualizada.Id);
            if (historia!=null)
            {
                historia.Diagnostico= HistoriaActualizada.Diagnostico;
                historia.Entorno = HistoriaActualizada.Entorno;
                historia.SugerenciaCuidado = HistoriaActualizada.SugerenciaCuidado;
                                
            }
            return historia;
        }

    }
}