using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1Ejercicio1.Models
{
    public class DepartamentoVehicular
    {
        private int _contador;
        private readonly List<RegistroVehiculo> _registros;
        private readonly Random _random;

        public DepartamentoVehicular()
        {
            _contador = 0;
            _registros = new List<RegistroVehiculo>();
            _random = new Random();
        }

        // Método para generar una patente aleatoria
        private string GenerarPatente()
        {
            char letra1 = (char)_random.Next('A', 'Z' + 1);
            char letra2 = (char)_random.Next('A', 'Z' + 1);
            int numeroPatente = _contador % 1000;
            return $"{letra1}{letra2}{numeroPatente:D3}";
        }

        // Método principal para registrar un vehículo
        public void RegistrarVehiculo(Persona propietario)
        {
            _contador++;
            string patente = GenerarPatente();
            var registro = new RegistroVehiculo(patente, propietario, _contador);
            _registros.Add(registro);
        }

        // Obtiene todos los registros para su visualización
        public IReadOnlyList<string> ObtenerRegistros()
        {
            var lista = new List<string>();
            foreach (var registro in _registros)
            {
                lista.Add(registro.VerDetalle());
            }
            return lista;
        }

        // Obtiene el último registro
        public string ObtenerUltimoRegistro()
        {
            if (_registros.Count > 0)
            {
                return _registros[_registros.Count - 1].VerDetalle();
            }
            return null;
        }
    }
}
