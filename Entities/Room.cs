using Common.Auxiliar;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Room
    {
        public int ID { get; set; }
        public NomeEnum Nome { get; set; }
        [Length(10)]
        [@MinLength(1)]
        public string Bloco { get; set; }
        [Length(6)]
        [@MinLength(1)]
        public string Numero { get; set; }
        public TipoEnum Tipo { get; set; }
        [Length(18)]
        [@MinLength(1)]
        public double Valor_Diaria { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public bool Reservado { get; set; } = false;
        public bool Ativo { get; set; }
    }
}
