using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas_Aplicativo_III.Entidad
{
    internal class Reserva
    {

        public Cliente Cliente { get; set; }
        public Habitacion Habitacion { get; set; }
        public DateTime FechaReserva { get; set; }

        public Reserva(Cliente cliente, Habitacion habitacion, DateTime fechaReserva)
        {
            Cliente = cliente;
            Habitacion = habitacion;
            FechaReserva = fechaReserva;
        }
    }
}
