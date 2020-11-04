using BusinessLogicalLayer.Checkers;
using Common;
using DataAccessLayer;
using Entities;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class ProviderBLL : BaseValidator<Provider>
    {
        private ProviderDAO providerDAO = new ProviderDAO();

        public Response Insert(Provider item)
        {
            Response response = Validate(item);
            if (response.Success)
            {
                response = providerDAO.IsCNPJUnique(item.CNPJ);
                if (response.Success)
                {
                    return providerDAO.Insert(item);
                }
            }
            return response;
        }

        public SingleResponse<Provider> GetProviderByCNPJ(string cnpj)
        {
            return providerDAO.GetProviderByCNPJ(cnpj);
        }

        public Response InsertAddressProviderTransaction(Provider fornecedor)
        {
            Response responseFornecedor = null;
            using (TransactionScope scope = new TransactionScope())
            {
                AddressBLL addressBLL = new AddressBLL();

                SingleResponse<int> responseAddressID = addressBLL.Insert(fornecedor.Endereco);
                if (responseAddressID.Success)
                {
                    fornecedor.EnderecoID = responseAddressID.Data;
                    ProviderBLL providerBLL = new ProviderBLL();
                    responseFornecedor = providerBLL.Insert(fornecedor);
                    if (responseFornecedor.Success)
                    {
                        scope.Complete();
                    }
                }
            }
            return responseFornecedor;
        }

        public override Response Validate(Provider item)
        {
            if (CheckAnyProperty.IsAnyNullOrEmpty(item))
            {
                AddError("Todos os campos devem ser informados");
                return base.Validate(item);
            }
            foreach (string err in CheckAttributeLength.AttributeLength<Provider>(item))
            {
                AddError(err);
            }
            AddError(item.CNPJ.IsValidCnpj());
            if (item.Email != "")
            {
                AddError(item.Email.IsValidEmail());
            }
            return base.Validate(item);
        }

    }
}
