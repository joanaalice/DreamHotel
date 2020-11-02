//using Common;
//using DataAccessLayer.Infraestructure;
//using Entities;
//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Transactions;
//using System.Windows.Forms;

//namespace BusinessLogicalLayer
//{
//    public class AddressUserTransaction
//    {
//        public Response InsertAddressUserTransactiosn(User usuario)
//        {
//            Response responseUser = null;
//            using (TransactionScope scope = new TransactionScope())
//            {
//                AddressBLL addressBLL = new AddressBLL();

//                SingleResponse<int> responseAddressID = addressBLL.Insert(usuario.Endereco);
//                if (responseAddressID.Success)
//                {
//                    usuario.EnderecoId = responseAddressID.Data;
//                    UserBLL userBLL = new UserBLL();
//                    responseUser = userBLL.Insert(usuario);
//                    if (responseUser.Success)
//                    {
//                        scope.Complete();
//                    }
//                }
//            }
//            return responseUser;
//        }
//    }
//}

//SingleResponse<int> responseEnd = enderecoDao.Inserir(endereco);
//if (responseEnd.Sucess && responseEnd.Data != 0)
//{
//    usuario.EnderecoID = responseEnd.Data;
//    Response response = usuarioDao.Inserir(usuario);
//    if (response.Sucess) { scope.Complete() }
//}