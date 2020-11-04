﻿using BusinessLogicalLayer.Checkers;
using Common;
using DataAccessLayer;
using Entities;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class UserBLL : BaseValidator<User>
    {
        private UserDAO userDAO = new UserDAO();
        public Response Insert(User item)
        {
            Response response = Validate(item);
            if (response.Success)
            {
                response = userDAO.IsCpfUnique(item.Cpf);
                if (response.Success)
                {
                    return userDAO.Insert(item);
                }
            }
            return response;
        }

        public SingleResponse<User> GetUserByCPF(string cpf)
        {
            return userDAO.GetUserByCPF(cpf);
        }

        public Response InsertAddressUserTransaction(User usuario)
        {
            Response responseUser = null;
            using (TransactionScope scope = new TransactionScope())
            {
                AddressBLL addressBLL = new AddressBLL();

                SingleResponse<int> responseAddressID = addressBLL.Insert(usuario.Endereco);
                if (responseAddressID.Success)
                {
                    usuario.EnderecoId = responseAddressID.Data;
                    UserBLL userBLL = new UserBLL();
                    responseUser = userBLL.Insert(usuario);
                    if (responseUser.Success)
                    {
                        scope.Complete();
                    }
                }
            }
            return responseUser;
        }

        public override Response Validate(User item)
        {
            if (CheckAnyProperty.IsAnyNullOrEmpty(item))
            {
                AddError("Todos os campos devem ser informados");
                return base.Validate(item);
            }
            foreach (string err in CheckAttributeLength.AttributeLength<User>(item))
            {
                AddError(err);
            }
            AddError(item.Cpf.IsValidCPF());
            if (item.Email != "")
            {
                AddError(item.Email.IsValidEmail());
            }
            return base.Validate(item);
        }
    }
}

