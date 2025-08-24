using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1Ejercicio1.Models
{
    public class Persona
    {
        public int Dni { get; }
        public string Nombre { get; }

        public Persona(int dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"{Nombre}(dni {Dni})";
        }
    }
}
