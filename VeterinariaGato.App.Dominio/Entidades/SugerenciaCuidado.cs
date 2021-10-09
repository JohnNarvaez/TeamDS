using System;
using System.ComponentModel.DataAnnotations;
namespace VeterinariaGato.App.Dominio
{
    public class SugerenciaCuidado
    {
        [Key]
        public int SugeCuidadoId {get; set;}        
        public DateTime FechaHora {get; set;}
        public string Descripcion {get; set;}
    }
}