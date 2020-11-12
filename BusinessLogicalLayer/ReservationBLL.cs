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
    public class ReservationBLL : BaseValidator<Reservation>
    {
        private ReservationDAO reservationDAO = new ReservationDAO();
        public Response Insert(Reservation item)
        {
            Response response = Validate(item);
            if (response.Success)
            {
                response = reservationDAO.IsRoomAvailiable(item.Quarto.ID);
                if (response.Success)
                {
                    return reservationDAO.Insert(item);
                }
            }
            return response;
        }
        public override Response Validate(Reservation item)
        {
            if (CheckAnyProperty.IsAnyNullOrEmpty(item))
            {
                AddError("Todos os campos devem ser informados");
                return base.Validate(item);
            }
            foreach (string err in CheckAttributeLength.AttributeLength<Reservation>(item))
            {
                AddError(err);
            }
            return base.Validate(item);
        }

        
    }
}

