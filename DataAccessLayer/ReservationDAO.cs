using Common;
using DataAccessLayer.Infraestructure;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ReservationDAO
    {
        public Response Insert(Reservation reserva)
        {
            Response dbResponse = new Response();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Reservations (QUARTOID, CLIENTEID, FUNCIONARIOID, DATA_RESERVA) VALUES (@QUARTOID, @CUSTOMERID, @USERID, @DATA_RESERVA)";
            command.Parameters.AddWithValue("@QUARTOID", reserva.Quarto.ID);
            command.Parameters.AddWithValue("@CUSTOMERID", reserva.Customer.ID);
            command.Parameters.AddWithValue("@USERID", reserva.Funcionario.Id);
            command.Parameters.AddWithValue("@DATA_RESERVA", reserva.Data_Reserva);
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                dbResponse.Success = true;
                dbResponse.Message = "Reserva realizada com sucesso!";
            }
            catch (Exception ex)
            {
                dbResponse.Success = false;
                dbResponse.Message = "Erro no banco de dados, contate o administrador.";

                dbResponse.StackTrace = ex.StackTrace;
                dbResponse.ExceptionError = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return dbResponse;
        }

        public SingleResponse<Reservation> IsRoomAvailiable(int ID)
        {
            SingleResponse<Reservation> response = new SingleResponse<Reservation>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@ID", ID);
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Rooms WHERE ID = @ID AND RESERVADO = 1";

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    response.Success = false;
                    response.Message = "Quarto ocupado";
                    return response;
                }
                else
                {
                    response.Success = true;
                    response.Message = "Quarto livre para reservar";
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados, contate o administrador.";
                response.ExceptionError = ex.Message;
                response.StackTrace = ex.StackTrace;
                return response;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
