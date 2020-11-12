using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reservation
    {
        public int ID { get; set; }
        public Room Quarto { get; set; }
        public Customer Customer { get; set; }
        public User Funcionario { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Entrada { get; set; }
        public DateTime Data_Saida { get; set; }
        public bool Status_Reserva { get; set; }
        public bool Ativo { get; set; }
    }
}
