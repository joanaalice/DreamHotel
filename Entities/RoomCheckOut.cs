using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RoomCheckOut
    {
        public int ID { get; set; }
        public int CeckInID { get; set; }
        public DateTime Data_Castro { get; set; }
        public bool Ativo { get; set; }
    }
}
