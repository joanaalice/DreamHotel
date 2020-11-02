using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Room_Service
    {
        public int ID { get; set; }
        public int QuartoID { get; set; }
        public int FuncionarioID { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public bool Limpeza_Concluida { get; set; }
        public bool Ativo { get; set; }
    }
}
