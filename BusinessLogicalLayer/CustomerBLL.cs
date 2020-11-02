using BusinessLogicalLayer.Checkers;
using Common;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class CustomerBLL : BaseValidator<Customer>
    {
        CustomerDAO customerDAO = new CustomerDAO();

        public Response Insert(Customer customer)
        {
            Response response = Validate(customer);
            if (response.Success)
            {
                return customerDAO.Insert(customer);
            }
            return response;
        }
        public Response InsertAddressCustomerTransaction(Customer customer)
        {
            Response responseCustomer = null;
            using (TransactionScope scope = new TransactionScope())
            {
                AddressBLL addressBLL = new AddressBLL();

                SingleResponse<int> responseAddressID = addressBLL.Insert(customer.Endereco);
                if (responseAddressID.Success)
                {
                    customer.EnderecoId = responseAddressID.Data;
                    CustomerBLL customerBLL = new CustomerBLL();
                    responseCustomer = customerBLL.Insert(customer);
                    if (responseCustomer.Success)
                    {
                        scope.Complete();
                    }
                }
            }
            return responseCustomer;
        }

        public override Response Validate(Customer customer)
        {
            if (CheckAnyProperty.IsAnyNullOrEmpty(customer))
            {
                AddError("Todos os campos devem ser informados");
            }
            foreach (string err in CheckAttributeLength.AttributeLength<Customer>(customer))
            {
                AddError(err);
            }
            AddError(customer.CPF.IsValidCPF());
            AddError(customer.Email.IsValidEmail());
            return base.Validate(customer);
        }

        public QueryResponse<Customer> GetAll()
        {
            QueryResponse<Customer> responseCustomer = customerDAO.GetAll();
            List<Customer> temp = responseCustomer.Data;
            foreach (Customer item in temp)
            {
                item.CPF = item.CPF.Insert(3, ".").Insert(7, ".").Insert(12, "-");
            }
            return responseCustomer;
        }

        public QueryResponse<Customer> GetByCPF(string cpf)
        {
            QueryResponse<Customer> responseCustomer = customerDAO.GetByCPF(cpf);
            return responseCustomer;
        }
    }
}

