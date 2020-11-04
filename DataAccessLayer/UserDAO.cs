using Common;
using DataAccessLayer.Infraestructure;
using Entities;
using System;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class UserDAO
    {
        public Response Insert(User user)
        {
            Response dbResponse = new Response();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Users (NOME, CPF, RG, EMAIL, TELEFONE1, TELEFONE2, ENDERECOID, SENHA, ISADMIN) VALUES (@NOME, @CPF, @RG, @EMAIL, @TELEFONE1, @TELEFONE2, @ENDERECOID, @SENHA, @ISADMIN)";
            command.Parameters.AddWithValue("@NOME", user.Nome);
            command.Parameters.AddWithValue("@CPF", user.Cpf);
            command.Parameters.AddWithValue("@RG", user.Rg);
            command.Parameters.AddWithValue("@EMAIL", user.Email);
            command.Parameters.AddWithValue("@TELEFONE1", user.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", user.Telefone_Aux);
            command.Parameters.AddWithValue("@ENDERECOID", user.EnderecoId);
            command.Parameters.AddWithValue("@ISADMIN", user.IsAdmin);
            command.Parameters.AddWithValue("@SENHA", user.Senha);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                dbResponse.Success = true;
                dbResponse.Message = "Usario cadastrado com sucesso!";
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
        public Response IsCpfUnique(string cpf)
        {
            QueryResponse<User> response = new QueryResponse<User>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();

            command.CommandText = "SELECT ID FROM Users WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@CPF", cpf);
            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    response.Success = false;
                    response.Message = "CPF já cadastrado.";
                }
                else
                {
                    response.Success = true;
                    response.Message = "CPF único.";
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
        public SingleResponse<User> GetUserByCPF(String cpf)
        {
            SingleResponse<User> response = new SingleResponse<User>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@CPF", cpf);
            command.Connection = connection;
            command.CommandText = "SELECT u.*, a.*, u.ID AS 'IDUSER', a.ID AS 'IDADDRESS' from Users u INNER JOIN Addresses a ON u.EnderecoID = a.ID where CPF = @CPF";
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    response.Data = new User();
                    response.Data.Id = (int)reader["IDUSER"];
                    response.Data.Nome = (string)reader["NOME"];
                    response.Data.Cpf = (string)reader["CPF"];
                    response.Data.Rg = (string)reader["RG"];
                    response.Data.Email = (string)reader["EMAIL"];
                    response.Data.Telefone = (string)reader["TELEFONE1"];
                    response.Data.Telefone_Aux = (string)reader["TELEFONE2"];
                    response.Data.EnderecoId = (int)reader["ENDERECOID"];
                    response.Data.IsAdmin = (bool)reader["ISADMIN"];
                    response.Data.Senha = (string)reader["SENHA"];
                    response.Data.Ativo = (bool)reader["ATIVO"];
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

        public Response Update(User user)
        {
            Response dbResponse = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();

            command.CommandText =
                "UPDATE Users SET NOME = @NOME, CPF = @CPF, RG = @RG, EMAIL = @EMAIL, TELEFONE1 = @TELEFONE1, TELEFONE2 = @TELEFONE2, ISADMIN = @ISADMIN, SENHA = @SENHA WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", user.Id);
            command.Parameters.AddWithValue("@NOME", user.Nome);
            command.Parameters.AddWithValue("@CPF", user.Nome);
            command.Parameters.AddWithValue("@RG", user.Nome);
            command.Parameters.AddWithValue("@EMAIL", user.Nome);
            command.Parameters.AddWithValue("@TELEFONE1", user.Nome);
            command.Parameters.AddWithValue("@TELEFONE2", user.Nome);
            command.Parameters.AddWithValue("@ISADMIN", user.Nome);
            command.Parameters.AddWithValue("@SENHA", user.Nome);

            command.Connection = connection;

            try
            {
                connection.Open();
                //int nLinhasAfetadas = command.ExecuteNonQuery();
                if (command.ExecuteNonQuery() != 1)
                {
                    dbResponse.Success = false;
                    dbResponse.Message = "Registro não encontrado!";
                    return dbResponse;
                }

                dbResponse.Success = true;
                dbResponse.Message = "User atualizado com sucesso!";
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

        //public Response Delete(User user)
        //{
        //    Response dbResponse = new Response();

        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = ConnectionHelper.GetConnectionString();

        //    SqlCommand command = new SqlCommand();

        //    command.CommandText =
        //        "DELETE FROM User WHERE ID = @ID";
        //    command.Parameters.AddWithValue("@ID", user.Id);

        //    command.Connection = connection;

        //    try
        //    {
        //        connection.Open();
        //        int nLinhasAfetadas = command.ExecuteNonQuery();
        //        if (nLinhasAfetadas != 1)
        //        {
        //            dbResponse.Success = false;
        //            dbResponse.Message = "Registro não encontrado!";
        //            return dbResponse;
        //        }

        //        dbResponse.Success = true;
        //        dbResponse.Message = "User excluído com sucesso!";
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

        //    public QueryResponse<User> GetAll()
        //    {
        //        QueryResponse<User> response = new QueryResponse<User>();
        //        SqlConnection connection = new SqlConnection();
        //        connection.ConnectionString = ConnectionHelper.GetConnectionString();

        //        SqlCommand command = new SqlCommand();

        //        command.CommandText =
        //            "SELECT * FROM Users WHERE ATIVO = 1";

        //        command.Connection = connection;

        //        try
        //        {
        //            connection.Open();

        //            SqlDataReader reader = command.ExecuteReader();

        //            List<User> users = new List<User>();

        //            while (reader.Read())
        //            {
        //                User user = new User();
        //                user.Id = (int)reader["ID"];
        //                user.Nome = (string)reader["NOME"];
        //                user.Cpf= (string)reader["CPF"];
        //                user.Rg = (string)reader["RG"];
        //                user.Email = (string)reader["EMAIL"];
        //                user.Telefones = (string)reader["TELEFONE1"];
        //                user.Telefones = (string)reader["TELEFONE2"];
        //                user.EnderecoId = (int)reader["ENDERECOID"];
        //                user.Data_Cadastro = (DateTime)reader["DATA_CADASTRO"];
        //                user.Ativo = (bool)reader["ATIVO"];
        //                users.Add(user);
        //            }
        //            response.Success = true;
        //            response.Message = "Dados selecionados com sucesso.";
        //            response.Data = users;
        //            return response;
        //        }
        //        catch (Exception ex)
        //        {
        //            response.Success = false;
        //            response.Message = "Erro no banco de dados, contate o administrador.";
        //            response.ExceptionError = ex.Message;
        //            response.StackTrace = ex.StackTrace;
        //            return response;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }


        //    public SingleResponse<User> GetId(User user)
        //    {
        //        SingleResponse<User> response = new SingleResponse<User>();
        //        SqlConnection connection = new SqlConnection();
        //        connection.ConnectionString = ConnectionHelper.GetConnectionString();        
        //        SqlCommand command = new SqlCommand();

        //        command.CommandText = "SELECT ID FROM Users WHERE CPF = @CPF";
        //        command.Parameters.AddWithValue("@CPF", user.Cpf);

        //        command.Connection = connection;

        //        try
        //        {
        //            connection.Open();

        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.Read())
        //            {
        //                user.Id = (int)reader["ID"];
        //            }
        //            response.Success = true;
        //            response.Message = "Dados selecionados com sucesso.";
        //            response.Data = user;
        //            return response;
        //        }
        //        catch (Exception ex)
        //        {
        //            response.Success = false;
        //            response.Message = "Erro no banco de dados, contate o administrador.";
        //            response.ExceptionError = ex.Message;
        //            response.StackTrace = ex.StackTrace;
        //            return response;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }

    }
}

