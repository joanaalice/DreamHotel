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
    public class CustomerDAO
    {
        public Response Insert(Customer customer)
        {
            Response dbResponse = new Response();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Customers (NOME, CPF, RG, EMAIL, TELEFONE1, TELEFONE2, ENDERECOID) VALUES (@NOME, @CPF, @RG, @EMAIL, @TELEFONE1, @TELEFONE2, @ENDERECOID)";
            command.Parameters.AddWithValue("@NOME", customer.Nome);
            command.Parameters.AddWithValue("@CPF", customer.CPF);
            command.Parameters.AddWithValue("@RG", customer.RG);
            command.Parameters.AddWithValue("@EMAIL", customer.Email);
            command.Parameters.AddWithValue("@TELEFONE1", customer.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", customer.Telefone_Aux);
            command.Parameters.AddWithValue("@ENDERECOID", customer.EnderecoId);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                dbResponse.Success = true;
                dbResponse.Message = "Customer cadastrado com sucesso!";
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
        public SingleResponse<Customer> GetCustomerByCPF(string cpf)
        {

            {
                SingleResponse<Customer> response = new SingleResponse<Customer>();
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = ConnectionHelper.GetConnectionString();
                SqlCommand command = new SqlCommand();

                command.Parameters.AddWithValue("@CPF", cpf);
                command.Connection = connection;
                command.CommandText = "SELECT c.*, a.*, c.ID AS 'IDCUSTOMER', a.ID AS 'IDADDRESS' from Customers c INNER JOIN Addresses a ON c.EnderecoID = a.ID where CPF = @CPF";
                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        response.Data = new Customer();
                        response.Data.ID = (int)reader["IDCUSTOMER"];
                        response.Data.Nome = (string)reader["NOME"];
                        response.Data.CPF = (string)reader["CPF"];
                        response.Data.RG = (string)reader["RG"];
                        response.Data.Email = (string)reader["EMAIL"];
                        response.Data.Telefone = (string)reader["TELEFONE1"];
                        response.Data.Telefone_Aux = (string)reader["TELEFONE2"];
                        response.Data.EnderecoId = (int)reader["ENDERECOID"];
                        response.Data.Ativo = (bool)reader["ATIVO"];
                        response.Data.Endereco.ID = (int)reader["IDADDRESS"];
                        response.Data.Endereco.Rua = (string)reader["RUA"];
                        response.Data.Endereco.Bairro = (string)reader["BAIRRO"];
                        response.Data.Endereco.Cidade = (string)reader["CIDADE"];
                        response.Data.Endereco.UF = (string)reader["UF"];
                        response.Data.Endereco.CEP = (string)reader["CEP"];
                        response.Data.Endereco.Pais = (string)reader["PAIS"];
                        response.Data.Endereco.Numero = (string)reader["NUMERO"];
                        response.Success = true;
                        response.Message = "Dado retornado com sucesso.";
                        return response;
                    }
                    else
                    {
                        response.Success = false;
                        response.Message = "Registro não encontrado";
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
        public QueryResponse<Customer> GetAll()
        {
            QueryResponse<Customer> response = new QueryResponse<Customer>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT c.*, a.*, c.ID AS 'IDCUSTOMERS', a.ID AS 'IDADDRESSES' FROM Customers c INNER JOIN Addresses a ON c.ENDERECOID = a.ID WHERE ATIVO = 1";

            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                List<Customer> customers = new List<Customer>();


                while (reader.Read())
                {
                    Customer customer = new Customer();
                    Address Endereco = new Address();
                    customer.ID = (int)reader["IDCUSTOMERS"];
                    customer.Nome = (string)reader["NOME"];
                    customer.CPF = (string)reader["CPF"];
                    customer.RG = (string)reader["RG"];
                    customer.Telefone = (string)reader["TELEFONE1"];
                    customer.Telefone_Aux = (string)reader["TELEFONE2"];
                    customer.Email = (string)reader["EMAIL"];
                    customer.EnderecoId = (int)reader["ENDERECOID"];
                    customer.Data_Cadastro = (DateTime)reader["DATA_CADASTRO"];
                    customer.Ativo = (bool)reader["ATIVO"];
                    Endereco.ID = (int)reader["IDADDRESSES"];
                    Endereco.Rua = (string)reader["RUA"];
                    Endereco.Bairro = (string)reader["BAIRRO"];
                    Endereco.Cidade = (string)reader["CIDADE"];
                    Endereco.UF = (string)reader["UF"];
                    Endereco.CEP = (string)reader["CEP"];
                    Endereco.Pais = (string)reader["PAIS"];
                    Endereco.Numero = (string)reader["NUMERO"];
                    customer.Endereco = Endereco;
                    customers.Add(customer);
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
        public Response Update(Customer customer)
        {
            Response dbResponse = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE Users SET NOME = @NOME, CPF = @CPF, RG = @RG, EMAIL = @EMAIL, TELEFONE1 = @TELEFONE1, TELEFONE2 = @TELEFONE2 WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", customer.ID);
            command.Parameters.AddWithValue("@NOME", customer.Nome);
            command.Parameters.AddWithValue("@CPF", customer.CPF);
            command.Parameters.AddWithValue("@RG", customer.RG);
            command.Parameters.AddWithValue("@EMAIL", customer.Email);
            command.Parameters.AddWithValue("@TELEFONE1", customer.Telefone);
            command.Parameters.AddWithValue("@TELEFONE2", customer.Telefone_Aux);

            command.Connection = connection;

            try
            {
                connection.Open();
                //int nLinhasAfetadas = command.ExecuteNonQuery();
                if (command.ExecuteNonQuery() == 0)
                {
                    dbResponse.Success = false;
                    dbResponse.Message = "Registro não encontrado!";
                    return dbResponse;
                }

                dbResponse.Success = true;
                dbResponse.Message = "Customer atualizado com sucesso!";
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
        public Response Delete(int id)
        {
            Response dbResponse = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE Customers SET ATIVO = 0 WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);

            command.Connection = connection;

            try
            {
                connection.Open();
                //int nLinhasAfetadas = command.ExecuteNonQuery();
                if (command.ExecuteNonQuery() == 0)
                {
                    dbResponse.Success = false;
                    dbResponse.Message = "Registro não encontrado!";
                    return dbResponse;
                }

                dbResponse.Success = true;
                dbResponse.Message = "Customer apagado com sucesso!";
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
    }
}
