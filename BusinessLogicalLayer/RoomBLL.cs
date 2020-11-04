using BusinessLogicalLayer.Checkers;
using Common;
using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    class RoomBLL : BaseValidator<Room>
    {
        private RoomDAO roomDAO = new RoomDAO();
        public Response Insert(Room item)
        {
            Response response = Validate(item);
            if (response.Success)
            {
                response = roomDAO.IsRoomByNumBlocoUnique(item.Bloco, item.Numero);
                if (response.Success)
                {
                    return roomDAO.Insert(item);
                }
            }
            return response;
        }
        public override Response Validate(Room item)
        {
            if (CheckAnyProperty.IsAnyNullOrEmpty(item))
            {
                AddError("Todos os campos devem ser informados");
                return base.Validate(item);
            }
            foreach (string err in CheckAttributeLength.AttributeLength<Room>(item))
            {
                AddError(err);
            }
            return base.Validate(item);
        }
    }
}
