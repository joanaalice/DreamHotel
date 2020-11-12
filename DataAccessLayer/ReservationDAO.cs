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
            command.CommandText = "INSERT INTO Reservations (QUARTOID, CLIENTEID, FUNCIONARIOID, DATA_ENTRADA, DATA_SAIDA) VALUES (@QUARTOID, @CUSTOMERID, @USERID, @DATA_ENTRADA, @DATA_SAIDA)";
            command.Parameters.AddWithValue("@QUARTOID", reserva.Quarto.ID);
            command.Parameters.AddWithValue("@CUSTOMERID", reserva.Customer.ID);
            command.Parameters.AddWithValue("@USERID", reserva.Funcionario.ID);
<<<<<<< HEAD
            command.Parameters.AddWithValue("@DATA_ENTRADA", reserva.Data_Entrada);
            command.Parameters.AddWithValue("@DATA_SAIDA", reserva.Data_Saida);
=======
            command.Parameters.AddWithValue("@DATA_RESERVA", reserva.Data_Reserva);
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
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

        public QueryResponse<Reservation> GetByDate(DateTime dataEntrada, DateTime dataSaida)
        {
            QueryResponse<Reservation> response = new QueryResponse<Reservation>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT re.*, 
                                           ro.ID AS 'IDROOM',
                                           re.ID AS 'IDRESERVATION', 
                                           u.ID AS 'IDUSER',
                                           c.ID AS 'IDCUSTOMER' 
                                   FROM Rooms ro INNER JOIN Reservations re ON ro.ID = re.QUARTOID 
                                   INNER JOIN Customers c ON re.CUSTOMERID = c.ID INNER JOIN Users u ON u.ID = re.FUNCIONARIOID 
                                   WHERE re.DATA_ENTRADA BETWEEN @DATA_ENTRADA AND @DATA_SAIDA";
            command.Parameters.AddWithValue("@DATA_ENTRADA", dataEntrada);
            command.Parameters.AddWithValue("@DATA_SAIDA", dataSaida);
            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                List<Reservation> customers = new List<Reservation>();


                while (reader.Read())
                {
                    Reservation reservation = new Reservation();
                    Address Endereco = new Address();
                    reservation.ID = (int)reader["IDRESERVATION"];
                    reservation.Quarto.ID = (int)reader["IDROOM"];
                    reservation.Funcionario.ID = (int)reader["IDUSER"];
                    reservation.Data_Entrada = (DateTime)reader["DATA_ENTRADA"];
                    reservation.Data_Saida = (DateTime)reader["DATA_SAIDA"];
                    reservation.Customer.ID = (int)reader["IDCUSTOMER"];
                    reservation.Status_Reserva = (bool)reader["STATUS_RESERVA"];
                    reservation.Ativo = (bool)reader["ATIVO"];
                    customers.Add(reservation);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = customers;
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o adm.";
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
