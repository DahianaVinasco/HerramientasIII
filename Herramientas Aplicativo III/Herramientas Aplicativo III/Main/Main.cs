using Herramientas_Aplicativo_III.Controller;
using System;

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

