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
    public class RoomBLL : BaseValidator<Room>
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

        public QueryResponse<Room> GetReservatedRoomsByDate(DateTime dataEntrada, DateTime dataSaida)
        {
            QueryResponse<Room> responseRoom = roomDAO.GetReservatedRoomsByDate(dataEntrada, dataSaida);
            return responseRoom;
        }
        public QueryResponse<Room> GetAll()
        {
            QueryResponse<Room> responseRoom = roomDAO.GetAll();
            return responseRoom;
        }

        public SingleResponse<Room> GetRoomByNumber(string nome)
        {
            SingleResponse<Room> responseRoom = roomDAO.GetRoomByNumber(nome);
            return responseRoom;
        }

        public QueryResponse<Room> GetRAvailableRoomsByDate(DateTime dataEntrada, DateTime dataSaida)
        {
            QueryResponse<Room> responseReservatedRoom = this.GetReservatedRoomsByDate(dataEntrada, dataSaida);
            QueryResponse<Room> responseRoom = this.GetAll();
            QueryResponse<Room> responseQuartosLivres = new QueryResponse<Room>();


            foreach ( Room quarto in responseRoom.Data)
            {
                foreach (Room quartoOcupado in responseReservatedRoom.Data)
                {
                    if ( quarto != quartoOcupado)
                    {
                        responseQuartosLivres.Data.Add(quarto);
                    }
                }
                if (responseReservatedRoom.Data.Count == 0)
                {
                    responseQuartosLivres.Data.Add(quarto);
                }
            }
            return responseQuartosLivres;
        }

        public QueryResponse<Room> GetRoomsByBloc(string bloco)
        {
            QueryResponse<Room> responseRoom = roomDAO.GetRoomsByBloc(bloco);
            return responseRoom;
        }
    }
}
