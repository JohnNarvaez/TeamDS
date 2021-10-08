using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeterinariaGato.App.Dominio
{
    public class Historia
    {
        public int Id {get; set;}
        public string Diagnostico {get; set;}
        public string Entorno {get; set;}

        [ForeignKey("SugerenciaCuidado")]
        public int SugerenciaCuidado_id;
        public SugerenciaCuidado SugerenciaCuidado {get; set;}
    }
}