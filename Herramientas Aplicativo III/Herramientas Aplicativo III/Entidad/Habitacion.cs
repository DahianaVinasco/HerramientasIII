using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas_Aplicativo_III.Entidad
{
    internal class Habitacion
    {
        public int Numero { get; set; }
        public string Tipo { get; set; } //  "Individual", "Doble", "Suite"
        public bool EstaDisponible { get; set; }

        public Habitacion(int numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
            EstaDisponible = true; // Inicialmente está disponible
        }

    }
}
