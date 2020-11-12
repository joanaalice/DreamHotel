using Common;
<<<<<<< HEAD
=======
using Common.Enums;
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
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
    public class CategoryDAO
    {
        public Response Insert(Category categoria)
        {
            Response dbResponse = new Response();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Categories (NOME) VALUES (@NOME)";
            command.Parameters.AddWithValue("@NOME", categoria.Nome.Trim().ToLower());

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                dbResponse.Success = true;
                dbResponse.Message = "Categoria registrada!";
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
        public SingleResponse<Category> IsCategoryByNameUnique(string nome)
        {
            nome.Trim().ToLower();
            SingleResponse<Category> response = new SingleResponse<Category>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT * FROM Categories WHERE NOME = @NOME";
            command.Parameters.AddWithValue("@NOME", nome);

            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    response.Success = false;
                    response.Message = "Categoria ja registrada";
                    return response;
                }
                else
                {
                    response.Success = true;
                    response.Message = "Categoria liberada para cadastro";
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
        public QueryResponse<Category> GetAll()
        {
            QueryResponse<Category> response = new QueryResponse<Category>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Categories WHERE ATIVO = 1";

            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                List<Category> quartos = new List<Category>();


                while (reader.Read())
                {
                    Category categoria = new Category();
                    categoria.ID = (int)reader["ID"];
                    categoria.Nome = (string)reader["NOME"];
                    quartos.Add(categoria);
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
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
