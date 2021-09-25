using System;
namespace  VeterinariaGato.App.Dominio
{
    public class SignoVital
    {
        public int Id {get; set;}
        public FechaHora FechaHora {get; set;}
        public Signo Signo {get; set;}
        public float Valor {get; set;}
    }
}