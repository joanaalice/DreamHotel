using BusinessLogicalLayer.Checkers;
using Common;
using Common.Auxiliar;
using DataAccessLayer;
using Entities;
using System.Collections.Generic;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class CustomerBLL : BaseValidator<Customer>
    {
        CustomerDAO customerDAO = new CustomerDAO();

        public Response Insert(Customer customer)
        {
            customer.CPF = CPFMask.CPFUnmasked(customer.CPF);
            Response response = Validate(customer);
            if (response.Success)
            {
                return customerDAO.Insert(customer);
            }
            return response;
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
<<<<<<< HEAD
=======
            List<Customer> temp = responseCustomer.Data;
            foreach (Customer item in temp)
            {
                item.CPF = CPFMask.CPFMasked(item.CPF);
            }
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
            return responseCustomer;
        }
        public Response Delete(Customer customer)
        {
            return customerDAO.Delete(customer.ID);
        }
        public Response Update(Customer customer)
        {
            return customerDAO.Update(customer);
        }
        public SingleResponse<Customer> GetCustomerByCPF(string cpf)
        {
            CPFMask.CPFUnmasked(cpf);
            return customerDAO.GetCustomerByCPF(cpf);
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
    }
}