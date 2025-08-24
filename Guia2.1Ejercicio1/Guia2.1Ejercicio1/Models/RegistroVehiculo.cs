using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1Ejercicio1.Models
{
    public class RegistroVehiculo
    {
        public string Patente { get; }
        public string Serie { get; }
        public Persona Propietario { get; }

        internal RegistroVehiculo(string patente, Persona propietario, int serie)
        {
            Patente = patente;
            Serie = serie.ToString("D9"); 
            Propietario = propietario;
        }

        public string VerDetalle()
        {
            return $"{Patente} *{Serie} *{Propietario}";
        }

    }
}
