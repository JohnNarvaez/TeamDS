using System;
using System.Collections.Generic;
using System.Linq;
using VeterinariaGato.App.Dominio;

namespace VeterinariaGato.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietariosMemoria : IRepositorioPropietarios
    {
        List<Propietario> propietarios;

        public RepositorioPropietariosMemoria()
        {
            propietarios = new List<Propietario>()
            {
                new Propietario{Id=1000, Nombre="John", Apellidos="Narvaez", NumeroTelefono="1111", Genero=Genero.masculino, Correo="propi.john@gmail.com"},
                new Propietario{Id=1001, Nombre="Edisson", Apellidos="Muñoz", NumeroTelefono="2222", Genero=Genero.masculino, Correo="propi.edisson@gmail.com"}                
            };
        }

        public Propietario Add(Propietario nuevoPropietario)
        {
           nuevoPropietario.Id=propietarios.Max(r => r.Id) +1; 
           propietarios.Add(nuevoPropietario);
           return nuevoPropietario;
        }

        public IEnumerable<Propietario> GetAll()
        {
            return propietarios;
        }


        public Propietario GetPropietarioPorId(int PropietarioId)
        {
            return propietarios.SingleOrDefault(s => s.Id==PropietarioId);
        
        }

        public IEnumerable<Propietario> GetPropietariosPorFiltro(string filtro)
        {
            var propietarios = GetAll(); // Obtiene todos los propietarios 
            if (propietarios != null)  //Si se tienen propietarios 
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    propietarios = propietarios.Where(s => s.Id.Equals(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return propietarios;
        }

     
        public Propietario Update(Propietario PropietarioActualizado)
        {
            var propietario= propietarios.SingleOrDefault(r => r.Correo==PropietarioActualizado.Correo);
            if (propietario!=null)
            {
                propietario.Nombre = PropietarioActualizado.Nombre;
                propietario.Apellidos = PropietarioActualizado.Apellidos;
                propietario.NumeroTelefono = PropietarioActualizado.NumeroTelefono;
                propietario.Genero = PropietarioActualizado.Genero; 
                propietario.Correo = PropietarioActualizado.Correo;
            }
            return propietario;
        }

    }
}