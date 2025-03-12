using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas_Aplicativo_III.Entidades

{
        public class Reserva
        {
            public int Id_Reserva { get; set; }
            public int Id_Cliente { get; set; }
            public int Id_Habitacion { get; set; }
            public DateTime Fecha_Inicio { get; set; }
            public DateTime Fecha_Fin { get; set; }
            public string Estado { get; set; }
            public decimal Monto_Total { get; set; }
            public string Metodo_Pago { get; set; }
        }
    }


