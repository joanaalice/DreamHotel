using Common;
using Common.Enums;
using DataAccessLayer.Infraestructure;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
<<<<<<< HEAD
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96

namespace DataAccessLayer
{
    public class ProductDAO
    {
        public Response Insert(Product product)
        {
            Response dbResponse = new Response();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();

            command.CommandText = "INSERT INTO Products (NOME, DESCRICAO, PRECO, QTDESTOQUE, UNIDADEMEDIDA, CATEGORIAID) VALUES (@NOME, @DESCRICAO, @PRECO, @QTDESTOQUE, @UNIDADEMEDIDA, @CATEGORIAID)";
            command.Parameters.AddWithValue("@NOME", product.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", product.Descricao);
            command.Parameters.AddWithValue("@PRECO", product.Preco);
            command.Parameters.AddWithValue("@QTDESTOQUE", product.QtdEstoque);
            command.Parameters.AddWithValue("@UNIDADEMEDIDA", (UnidadeMedida)product.UnidadeMedida);
            command.Parameters.AddWithValue("@CATEGORIAID", product.CategoriaID);

            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                dbResponse.Success = true;
                dbResponse.Message = "Produto cadastrado com sucesso!";
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
        public SingleResponse<Product> GetProductByID(int id)
        {
            SingleResponse<Product> response = new SingleResponse<Product>();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@ID", id);
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Products WHERE ID = @ID";
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    response.Data = new Product();
                    response.Data.ID = (int)reader["ID"];
                    response.Data.Nome = (string)reader["NOME"];
                    response.Data.Descricao = (string)reader["DESCRICAO"];
                    response.Data.Preco = (decimal)reader["PRECO"];
                    response.Data.QtdEstoque = (int)reader["QTDESTOQUE"];
                    response.Data.UnidadeMedida = (UnidadeMedida)reader["UNIDADEMEDIDA"];
                    response.Data.CategoriaID = (int)reader["CATEGORIAID"];
                    response.Data.Ativo = (bool)reader["ATIVO"];
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
        public QueryResponse<Product> GetAll()
        {
            QueryResponse<Product> response = new QueryResponse<Product>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Products WHERE ATIVO = 1";

            command.Connection = connection;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                List<Product> products = new List<Product>();


                while (reader.Read())
                {
                    Product product = new Product();
                    product.ID = (int)reader["ID"];
                    product.Nome = (string)reader["NOME"];
                    product.Descricao = (string)reader["DESCRICAO"];
                    product.Preco = (decimal)reader["PRECO"];
                    product.QtdEstoque = (int)reader["QTDESTOQUE"];
                    product.UnidadeMedida = (UnidadeMedida)reader["UNIDADEMEDIDA"];
                    product.CategoriaID = (int)reader["CATEGORIAID"];
                    product.Ativo = (bool)reader["ATIVO"];
                    products.Add(product);
                }
                response.Success = true;
                response.Message = "Dados selecionados com sucesso.";
                response.Data = products;
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
        public Response Update(Product product)
        {
            Response dbResponse = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE Products SET NOME = @NOME, DESCRICAO = @DESCRICAO, PRECO = @PRECO, QTDESTOQUE = @QTDESTOQUE, UNIDADEMEDIDA = @UNIDADEMEDIDA, CATEGORIAID = @CATEGORIAID WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", product.ID);
            command.Parameters.AddWithValue("@NOME", product.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", product.Descricao);
            command.Parameters.AddWithValue("@PRECO", product.Preco);
            command.Parameters.AddWithValue("@QTDESTOQUE", product.QtdEstoque);
            command.Parameters.AddWithValue("@UNIDADEMEDIDA", (UnidadeMedida)product.UnidadeMedida);
            command.Parameters.AddWithValue("@CATEGORIAID", product.CategoriaID);

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
                dbResponse.Message = "Product atualizado com sucesso!";
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
<<<<<<< HEAD
        public Response Delete(int id)
=======
        public Response Delete (int id)
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
        {
            Response dbResponse = new Response();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();

            command.CommandText = "UPDATE Products SET ATIVO = 0 WHERE ID = @ID";
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
                dbResponse.Message = "Product apagado com sucesso!";
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
<<<<<<< HEAD
=======

>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
