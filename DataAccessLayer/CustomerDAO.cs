﻿using Common;
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
            command.Parameters.AddWithValue("@TELEFONE2", customer.Telefone_aux);
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

        public QueryResponse<Customer> GetByCPF(string cpf)
        {
            QueryResponse<Customer> response = new QueryResponse<Customer>();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionHelper.GetConnectionString();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT c.*, a.*, c.ID AS 'IDCUSTOMERS', a.ID AS 'IDADDRESSES' FROM Customers c INNER JOIN Addresses a ON c.ENDERECOID = a.ID WHERE CPF = @CPF";
            command.Parameters.AddWithValue("@CPF", cpf);
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
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
                    customer.Telefone_aux = (string)reader["TELEFONE2"];
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
                response.Message = "Dado selecionado com sucesso.";
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
                    customer.Telefone_aux = (string)reader["TELEFONE2"];
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
    }
}