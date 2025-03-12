using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herramientas_Aplicativo_III.Entidades;

namespace Herramientas_Aplicativo_III.Datos
{
        public class ReservaDAL
        {
            private string connectionString = "Server=TU_SERVIDOR;Database=HotelDB;User Id=tu_usuario;Password=tu_contraseña;";

            public void CrearReserva(Reserva reserva)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Reservas (Id_Cliente, Id_Habitacion, Fecha_Inicio, Fecha_Fin, Estado, Monto_Total, Metodo_Pago) " +
                                   "VALUES (@Id_Cliente, @Id_Habitacion, @Fecha_Inicio, @Fecha_Fin, @Estado, @Monto_Total, @Metodo_Pago)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id_Cliente", reserva.Id_Cliente);
                    command.Parameters.AddWithValue("@Id_Habitacion", reserva.Id_Habitacion);
                    command.Parameters.AddWithValue("@Fecha_Inicio", reserva.Fecha_Inicio);
                    command.Parameters.AddWithValue("@Fecha_Fin", reserva.Fecha_Fin);
                    command.Parameters.AddWithValue("@Estado", reserva.Estado);
                    command.Parameters.AddWithValue("@Monto_Total", reserva.Monto_Total);
                    command.Parameters.AddWithValue("@Metodo_Pago", reserva.Metodo_Pago);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            public Reserva ConsultarReserva(int idReserva)
            {
                Reserva reserva = null;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Reservas WHERE Id_Reserva = @Id_Reserva";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id_Reserva", idReserva);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        reserva = new Reserva
                        {
                            Id_Reserva = reader.GetInt32(0),
                            Id_Cliente = reader.GetInt32(1),
                            Id_Habitacion = reader.GetInt32(2),
                            Fecha_Inicio = reader.GetDateTime(3),
                            Fecha_Fin = reader.GetDateTime(4),
                            Estado = reader.GetString(5),
                            Monto_Total = reader.GetDecimal(6),
                            Metodo_Pago = reader.GetString(7)
                        };
                    }
                }
                return reserva;
            }
        }
    }
