using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VeterinariaGato.App.Dominio
{
    public class Gato
    {
        [Key]
        public int Codigo {get; set;}
        public string Nombre {get; set;}
        public string Raza {get; set;}
        public string Color {get; set;}
        public string Edad {get; set;}
        
        //[Required, StringLength(50)]
        public string EnEspañol {get;set;}
        //[Required, StringLength(50)]
        public string EnIngles {get;set;}
        //[Required, StringLength(50)]
        public string EnItaliano {get;set;}

                        
        [ForeignKey("Veterinario")]
        public int Veterinario_id;
        public Veterinario Veterinario {get; set;}

        [ForeignKey("SignoVital")]
        public int SignoVital_id;
        public SignoVital SignoVital {get; set;}

        [ForeignKey("Propietario")]
        public int Propietario_id;
        public Propietario Propietario {get; set;}

        [ForeignKey("Enfermera")]
        public int Enfermera_id;
        public Enfermera Enfermera {get; set;}

        [ForeignKey("Historia")]
        public int Historia_id;
        public Historia Historia {get; set;}


    }
}