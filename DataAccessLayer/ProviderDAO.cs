using Common;
using DataAccessLayer.Infraestructure;
using Entities;
using System;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProviderDAO
    {
        public Response Insert(Provider fornecedor)
        {
            Response dbResponse = new Response();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Providers (CNPJ, RAZAOSOCIAL, NOMEFANTASIA, NOMECONTATO, EMAIL, TELEFONE1, TELEFONE2, ENDERECOID) VALUES (@CNPJ, @RAZAOSOCIAL, @NOMEFANTASIA, @NOMECONTATO, @EMAIL, @TELEFONE1, @TELEFONE2, @ENDERECOID)";
            command.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@RAZAOSOCIAL", fornecedor.RazaoSocial);
            command.Parameters.AddWithValue("@NOMEFANTASIA", fornecedor.NomeFantasia);
            command.Parameters.AddWithValue("@NOMECONTATO", fornecedor.NomeContato);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);
            command.Parameters.AddWithValue("@TELEFONE1", fornecedor.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", fornecedor.Telefone_Aux);
            command.Parameters.AddWithValue("@ENDERECOID", fornecedor.EnderecoID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                dbResponse.Success = true;
                dbResponse.Message = "Fornecedor cadastrado com sucesso!";
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
        public Response IsCNPJUnique(string cnpj)
        {
            QueryResponse<Provider> response = new QueryResponse<Provider>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT ID FROM Providers WHERE CNPJ = @CNPJ";
            command.Parameters.AddWithValue("@CNPJ", cnpj);
            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    response.Success = false;
                    response.Message = "CNPJ já cadastrado.";
                }
                else
                {
                    response.Success = true;
                    response.Message = "CNPJ único.";
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados, contate o adm.";
                response.ExceptionError = ex.Message;
                response.StackTrace = ex.StackTrace;
                return response;
            }
            finally
            {
                connection.Close();
            }
        }
        public SingleResponse<Provider> GetProviderByCNPJ(string cnpj)
        {
            SingleResponse<Provider> response = new SingleResponse<Provider>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@CNPJ", cnpj);
            command.Connection = connection;
            command.CommandText = "SELECT p.*, a.*, p.ID AS 'IDPROVIDER', a.ID AS 'IDADDRESS' from Providers p INNER JOIN Addresses a ON p.EnderecoID = a.ID where CNPJ = @CNPJ";
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    response.Data = new Provider();
                    response.Data.ID = (int)reader["IDPROVIDER"];
                    response.Data.CNPJ = (string)reader["CNPJ"];
                    response.Data.RazaoSocial = (string)reader["RAZAOSOCIAL"];
                    response.Data.NomeFantasia = (string)reader["NOMEFANTASIA"];
                    response.Data.NomeContato = (string)reader["NOMECONTATO"];
                    response.Data.Email = (string)reader["EMAIL"];
                    response.Data.Telefone = (string)reader["TELEFONE1"];
                    response.Data.Telefone_Aux = (string)reader["TELEFONE2"];
                    response.Data.EnderecoID = (int)reader["ENDERECOID"];

                    response.Data.Endereco.ID = (int)reader["IDADDRESS"];
                    response.Data.Endereco.Rua = (string)reader["RUA"];
                    response.Data.Endereco.Bairro = (string)reader["BAIRRO"];
                    response.Data.Endereco.Cidade = (string)reader["CIDADE"];
                    response.Data.Endereco.UF = (string)reader["UF"];
                    response.Data.Endereco.CEP = (string)reader["CEP"];
                    response.Data.Endereco.Pais = (string)reader["PAIS"];
                    response.Data.Endereco.Numero = (string)reader["NUMERO"];
                }

                response.Success = true;
                response.Message = "Dado retornado com sucesso.";
                return response;
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
        //public Response Update(User user)
        //{
        //    Response dbResponse = new Response();

        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = ConnectionHelper.GetConnectionString();

        //    SqlCommand command = new SqlCommand();

        //    command.CommandText =
        //        "UPDATE Users SET NOME = @NOME, CPF = @CPF, RG = @RG, EMAIL = @EMAIL, TELEFONE1 = @TELEFONE1, TELEFONE2 = @TELEFONE2, ISADMIN = @ISADMIN, SENHA = @SENHA WHERE ID = @ID";
        //    command.Parameters.AddWithValue("@ID", user.ID);
        //    command.Parameters.AddWithValue("@NOME", user.Nome);
        //    command.Parameters.AddWithValue("@CPF", user.Nome);
        //    command.Parameters.AddWithValue("@RG", user.Nome);
        //    command.Parameters.AddWithValue("@EMAIL", user.Nome);
        //    command.Parameters.AddWithValue("@TELEFONE1", user.Nome);
        //    command.Parameters.AddWithValue("@TELEFONE2", user.Nome);
        //    command.Parameters.AddWithValue("@ISADMIN", user.Nome);
        //    command.Parameters.AddWithValue("@SENHA", user.Nome);

        //    command.Connection = connection;

        //    try
        //    {
        //        connection.Open();
        //        //int nLinhasAfetadas = command.ExecuteNonQuery();
        //        if (command.ExecuteNonQuery() != 1)
        //        {
        //            dbResponse.Success = false;
        //            dbResponse.Message = "Registro não encontrado!";
        //            return dbResponse;
        //        }

        //        dbResponse.Success = true;
        //        dbResponse.Message = "User atualizado com sucesso!";
        //    }
        //    catch (Exception ex)
        //    {
        //        dbResponse.Success = false;
        //        dbResponse.Message = "Erro no banco de dados, contate o administrador.";

        //        dbResponse.StackTrace = ex.StackTrace;
        //        dbResponse.ExceptionError = ex.Message;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return dbResponse;
        //}
    }
}
