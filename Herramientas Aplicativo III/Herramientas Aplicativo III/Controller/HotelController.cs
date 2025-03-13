using Herramientas_Aplicativo_III.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas_Aplicativo_III.Controller
{
    internal class HotelController
    {

        private List<Cliente> clientes;
        private List<Habitacion> habitaciones;
        private List<Reserva> reservas;

        public HotelController()
        {
            clientes = new List<Cliente>();
            habitaciones = new List<Habitacion>();
            reservas = new List<Reserva>();

            // Crear algunas habitaciones para el hotel (puedes agregar más)
            habitaciones.Add(new Habitacion(101, "Individual"));
            habitaciones.Add(new Habitacion(102, "Doble"));
            habitaciones.Add(new Habitacion(103, "Suite"));
        }

        // Método para agregar un nuevo cliente
        public void AgregarCliente(string documentoIdentidad, string nombre)
        {
            Cliente nuevoCliente = new Cliente(documentoIdentidad, nombre);
            clientes.Add(nuevoCliente);
        }

        // Método para hacer una reserva
        public bool HacerReserva(string documentoIdentidad, int numeroHabitacion, DateTime fechaReserva)
        {
            // Buscar el cliente por su documento
            Cliente cliente = clientes.Find(c => c.DocumentoIdentidad == documentoIdentidad);

            if (cliente == null)
            {
                Console.WriteLine("Cliente no encontrado.");
                return false;
            }

            // Buscar la habitación por su número
            Habitacion habitacion = habitaciones.Find(h => h.Numero == numeroHabitacion);

            if (habitacion == null)
            {
                Console.WriteLine("Habitación no encontrada.");
                return false;
            }

            if (!habitacion.EstaDisponible)
            {
                Console.WriteLine("La habitación no está disponible.");
                return false;
            }

            // Crear una nueva reserva
            Reserva nuevaReserva = new Reserva(cliente, habitacion, fechaReserva);
            reservas.Add(nuevaReserva);

            // Marcar la habitación como no disponible
            habitacion.EstaDisponible = false;

            Console.WriteLine($"Reserva realizada con éxito para el cliente {cliente.Nombre} en la habitación {habitacion.Numero}.");
            return true;
        }

        // Método para obtener la lista de habitaciones disponibles
        public List<Habitacion> ObtenerHabitacionesDisponibles()
        {
            return habitaciones.FindAll(h => h.EstaDisponible);
        }

        // Método para mostrar todas las reservas
        public void MostrarReservas()
        {
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"Cliente: {reserva.Cliente.Nombre}, Habitación: {reserva.Habitacion.Numero}, Fecha: {reserva.FechaReserva.ToShortDateString()}");
            }
        }
    }
public class Program
    {
        public static void Main(string[] args)
        {
            HotelController hotel = new HotelController();

            // Agregar algunos clientes
            hotel.AgregarCliente("123456789", "Juan Pérez");
            hotel.AgregarCliente("987654321", "Ana Gómez");

            // Mostrar habitaciones disponibles
            Console.WriteLine("Habitaciones disponibles:");
            foreach (var habitacion in hotel.ObtenerHabitacionesDisponibles())
            {
                Console.WriteLine($"Número: {habitacion.Numero}, Tipo: {habitacion.Tipo}");
            }

            // Realizar una reserva
            hotel.HacerReserva("123456789", 101, DateTime.Now);

            // Mostrar todas las reservas
            Console.WriteLine("\nReservas realizadas:");
            hotel.MostrarReservas();
        }
    }
}
