using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas_Aplicativo_III.Entidad
{
    internal class Cliente
    {
        public string DocumentoIdentidad { get; set; }
        public string Nombre { get; set; }

        public Cliente(string documentoIdentidad, string nombre)
        {
            DocumentoIdentidad = documentoIdentidad;
            Nombre = nombre;
        }

    }
}
