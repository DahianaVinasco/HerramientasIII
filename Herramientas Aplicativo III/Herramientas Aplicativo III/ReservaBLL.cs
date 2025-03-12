using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herramientas_Aplicativo_III.Entidades;
using Herramientas_Aplicativo_III.Datos;

namespace Herramientas_Aplicativo_III.Logica
{
        public class ReservaBLL
        {
            private ReservaDAL reservaDAL = new ReservaDAL();

            public void CrearReserva(Reserva reserva)
            {
                reservaDAL.CrearReserva(reserva);
            }

            public Reserva ConsultarReserva(int idReserva)
            {
                return reservaDAL.ConsultarReserva(idReserva);
            }
        }
    }