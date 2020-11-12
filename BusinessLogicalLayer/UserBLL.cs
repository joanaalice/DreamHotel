using BusinessLogicalLayer.Checkers;
using Common;
using Common.Auxiliar;
using DataAccessLayer;
using Entities;
using System.Collections.Generic;
using System.Transactions;

namespace BusinessLogicalLayer
{
    public class UserBLL : BaseValidator<User>
    {
        private UserDAO userDAO = new UserDAO();
        public Response Insert(User item)
        {
            item.CPF = CPFMask.CPFUnmasked(item.CPF);
            Response response = Validate(item);
            if (response.Success)
            {
                response = userDAO.IsCpfUnique(item.CPF);
                if (response.Success)
                {
                    return userDAO.Insert(item);
                }
            }
            return response;
        }
        public Response Update(User user)
        {
            return userDAO.Update(user);
<<<<<<< HEAD
        }
        public Response Delete(User user)
        {
            return userDAO.Delete(user.ID);
        }
        public QueryResponse<User> GetAll()
        {
            QueryResponse<User> responseUser = userDAO.GetAll();
            List<User> temp = responseUser.Data;
            foreach (User item in temp)
            {
                item.CPF = CPFMask.CPFMasked(item.CPF);
            }
            return responseUser;
        }
        //public Response GetUserLogin(string email, string senha)
        //{
        //    SingleResponse<User> usuarioResponse = userDAO.GetUserLoginCredencials(email, senha);
        //    if (usuarioResponse.Success)
        //    {
        //        IsUserLog.CurrentUser = new UserLoged() { ID = usuarioResponse.Data.ID, Email = usuarioResponse.Data.Email, Nome = usuarioResponse.Data.Nome };
        //    }
        //    return usuarioResponse;
        //}
=======
        }
        public Response Delete(User user)
        {
            return userDAO.Delete(user.ID);
        }
        public QueryResponse<User> GetAll()
        {
            QueryResponse<User> responseUser = userDAO.GetAll();
            List<User> temp = responseUser.Data;
            foreach (User item in temp)
            {
                item.CPF = CPFMask.CPFMasked(item.CPF);
            }
            return responseUser;
        }
        public Response GetUserLogin(string email, string senha)
        {
            SingleResponse<User> usuarioResponse = userDAO.GetUserLoginCredencials(email, senha);
            if (usuarioResponse.Success)
            {
                WhoIsUserLog.CurrentUser = new UserLoged() { ID = usuarioResponse.Data.ID, Email = usuarioResponse.Data.Email, Nome = usuarioResponse.Data.Nome };
            }
            return usuarioResponse;
        }
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
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
<<<<<<< HEAD

        public Response GetUserLogin(string email, string senha)
        {
            SingleResponse<User> usuarioResponse = userDAO.GetUserLoginCredencials(email, senha);
            if (usuarioResponse.Success)
            {
                IsUserLog.CurrentUser = new UserLoged() { ID = usuarioResponse.Data.ID, Email = usuarioResponse.Data.Email, Nome = usuarioResponse.Data.Nome };
            }
            return usuarioResponse;
        }
=======
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
        public SingleResponse<User> GetUserByCPF(string cpf)
        {
            return userDAO.GetUserByCPF(cpf);
        }
<<<<<<< HEAD

        public SingleResponse<User> GetUserById(int id)
        {
            return userDAO.GetUserById(id);
        }
=======
>>>>>>> d90d52c7659cca1ff2401e78ab6d7ed1c6565a96
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
            AddError(item.CPF.IsValidCPF());
            if (item.Email != "")
            {
                AddError(item.Email.IsValidEmail());
            }
            return base.Validate(item);
        }

    }
}

