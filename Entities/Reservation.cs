﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reservation
    {
        public int ID { get; set; }
        public int QuartoID { get; set; }
        public int CustomerID { get; set; }
        public int FuncionarioID { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public DateTime Data_Reserva { get; set; }
        public bool Status_Reserva { get; set; }
        public bool Ativo { get; set; }
    }
}
