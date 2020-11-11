using Common;
using Common.Enums;
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
    public class RoomDAO
    {
        public Response Insert(Room quarto)
        {
            Response dbResponse = new Response();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Rooms (BLOCO, NOME, VALOR_DIARIA, RESERVADO, TIPO_QUARTO) VALUES (@BLOCO, @NOME, @VALOR_DIARIA, @RESERVADO, @TIPO_QUARTO)";
            command.Parameters.AddWithValue("@BLOCO", quarto.Bloco);
            command.Parameters.AddWithValue("@NOME", quarto.Nome);
            command.Parameters.AddWithValue("@VALOR_DIARIA", quarto.Valor_Diaria);
            command.Parameters.AddWithValue("@RESERVADO", quarto.Reservado);
            command.Parameters.AddWithValue("@TIPO_QUARTO", quarto.Tipo_Quarto);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                dbResponse.Success = true;
                dbResponse.Message = "Quarto cadastrado com sucesso!";
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
        public SingleResponse<Room> IsRoomByNumBlocoUnique(string bloco, string numero)
        {
            SingleResponse<Room> response = new SingleResponse<Room>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@BLOCO", bloco);
            command.Parameters.AddWithValue("@NUMERO", numero);
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Rooms WHERE BLOCO = @BLOCO AND NUMERO = @NUMERO";

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    response.Success = false;
                    response.Message = "Quarto já registrado com esse numero neste bloco";
                    return response;
                }
                else
                {
                    response.Success = true;
                    response.Message = "Bloco e numero de quarto livre para cadastro";
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
        public QueryResponse<Room> GetAll()
        {
            QueryResponse<Room> response = new QueryResponse<Room>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM ROOMS WHERE ATIVO = 1";

            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                List<Room> quartos = new List<Room>();


                while (reader.Read())
                {
                    Room quarto = new Room();
                    quarto.ID = (int)reader["ID"];
                    quarto.Bloco = (string)reader["BLOCO"];
                    quarto.Nome = (string)reader["NOME"];
                    quarto.Valor_Diaria = (decimal)reader["VALOR_DIARIA"];
                    quarto.Reservado = (bool)reader["RESERVADO"];
                    quarto.Ativo = (bool)reader["ATIVO"];
                    quarto.Numero = (string)reader["NUMERO"];
                    quarto.Tipo_Quarto = (TipoEnum)reader["TIPO_QUARTO"];
                    quartos.Add(quarto);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = quartos;
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
        // public SingleResponse<Room> GetRoomByID(int id)
        //{
        //    SingleResponse<Room> response = new SingleResponse<Room>();
        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = ConnectionHelper.GetConnectionString();
        //    SqlCommand command = new SqlCommand();

        //    command.Parameters.AddWithValue("@ID", id);
        //    command.Connection = connection;
        //    command.CommandText = "SELECT * FROM Rooms WHERE ID = @ID";
        //    try
        //    {
        //        connection.Open();

        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            response.Data = new User();
        //            response.Data.ID = (int)reader["IDUSER"];
        //            response.Data.Nome = (string)reader["NOME"];
        //            response.Data.Cpf = (string)reader["CPF"];
        //            response.Data.Rg = (string)reader["RG"];
        //            response.Data.Email = (string)reader["EMAIL"];
        //            response.Data.Telefone = (string)reader["TELEFONE1"];
        //            response.Data.Telefone_Aux = (string)reader["TELEFONE2"];
        //            response.Data.EnderecoId = (int)reader["ENDERECOID"];
        //            response.Data.IsAdmin = (bool)reader["ISADMIN"];
        //            response.Data.Senha = (string)reader["SENHA"];
        //            response.Data.Ativo = (bool)reader["ATIVO"];
        //            response.Data.Endereco.ID = (int)reader["IDADDRESS"];
        //            response.Data.Endereco.Rua = (string)reader["RUA"];
        //            response.Data.Endereco.Bairro = (string)reader["BAIRRO"];
        //            response.Data.Endereco.Cidade = (string)reader["CIDADE"];
        //            response.Data.Endereco.UF = (string)reader["UF"];
        //            response.Data.Endereco.CEP = (string)reader["CEP"];
        //            response.Data.Endereco.Pais = (string)reader["PAIS"];
        //            response.Data.Endereco.Numero = (string)reader["NUMERO"];
        //        }

        //        response.Success = true;
        //        response.Message = "Dado retornado com sucesso.";
        //        return response;
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Success = false;
        //        response.Message = "Erro no banco de dados, contate o administrador.";
        //        response.ExceptionError = ex.Message;
        //        response.StackTrace = ex.StackTrace;
        //        return response;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //}
    }
}