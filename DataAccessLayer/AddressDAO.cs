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
    public class AddressDAO
    {
        //public Response Insert(Address address)
        //{
        //    Response dbResponse = new Response();
        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = ConnectionHelper.GetConnectionString();
        //    SqlCommand command = new SqlCommand();
        //    command.CommandText = "INSERT INTO ADDRESSES (NUMERO,RUA,BAIRRO,CIDADE,UF,CEP,PAIS) VALUES (@NUMERO, @RUA, @BAIRRO, @CIDADE, @UF, @CEP, @PAIS)";
        //    command.Parameters.AddWithValue("@NUMERO", address.Numero);
        //    command.Parameters.AddWithValue("@RUA", address.Rua);
        //    command.Parameters.AddWithValue("@BAIRRO", address.Bairro);
        //    command.Parameters.AddWithValue("@CIDADE", address.Cidade);
        //    command.Parameters.AddWithValue("@UF", address.UF);
        //    command.Parameters.AddWithValue("@CEP", address.CEP);
        //    command.Parameters.AddWithValue("@PAIS", address.Pais);
        //    command.Connection = connection;
        //    try
        //    {
        //        connection.Open();
        //        command.ExecuteNonQuery();                
        //        //int idGerado = Convert.ToInt32(command.ExecuteScalar());
        //        dbResponse.Success = true;
        //        dbResponse.Message = "Endereco cadastrado com sucesso!";
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
        public SingleResponse<int>Insert(Address address)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SingleResponse<int> response = new SingleResponse<int>();
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO ADDRESSES (NUMERO,RUA,BAIRRO,CIDADE,UF,CEP,PAIS) VALUES (@NUMERO, @RUA, @BAIRRO, @CIDADE, @UF, @CEP, @PAIS)" + "SELECT CAST(scope_identity() AS int)";
            command.Parameters.AddWithValue("@NUMERO", address.Numero);
            command.Parameters.AddWithValue("@RUA", address.Rua);
            command.Parameters.AddWithValue("@BAIRRO", address.Bairro);
            command.Parameters.AddWithValue("@CIDADE", address.Cidade);
            command.Parameters.AddWithValue("@UF", address.UF);
            command.Parameters.AddWithValue("@CEP", address.CEP);
            command.Parameters.AddWithValue("@PAIS", address.Pais);
            command.Connection = connection;
            try
            {
                connection.Open();
                response.Data = (int)command.ExecuteScalar();
                response.Success = true;
                response.Message = "Endereco cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Erro no banco de dados contate o ADMIN.";
                response.ExceptionError = ex.Message;
                response.StackTrace = ex.StackTrace;
                return response;
            }
            finally
            {
                connection.Close();
            }
            return response;
        }
        public Response Update(Address address)
        {
            Response dbResponse = new Response();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE Addresses SET NUMERO = @NUMERO, RUA = @RUA BAIRRO = @BAIRRO, CIDADE = @CIDADE, UF = UF, CEP = @CEP, PAIS = @PAIS WHERE ID = @ID";
            command.Parameters.AddWithValue("@NUMERO", address.Numero);
            command.Parameters.AddWithValue("@RUA", address.Rua);
            command.Parameters.AddWithValue("@BAIRRO", address.Bairro);
            command.Parameters.AddWithValue("@CIDADE", address.Cidade);
            command.Parameters.AddWithValue("@UF", address.UF);
            command.Parameters.AddWithValue("@CEP", address.CEP);
            command.Parameters.AddWithValue("@PAIS", address.Pais);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                //int idGerado = Convert.ToInt32(command.ExecuteScalar());
                dbResponse.Success = true;
                dbResponse.Message = "Endereco alterado com sucesso!";
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
