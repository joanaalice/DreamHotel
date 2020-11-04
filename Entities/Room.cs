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
        [Length(70)]
        [@MinLength(1)]
        public string Nome { get; set; }
        [Length(70)]
        [@MinLength(3)]
        public string Bloco { get; set; }
        [Length(6)]
        [@MinLength(1)]
        public string Numero { get; set; }
        public TipoEnum Tipo_Quarto { get; set; }
        [Length(10)]
        [@MinLength(3)]
        public decimal Valor_Diaria { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public bool Reservado { get; set; } = false;
        public bool Ativo { get; set; }
    }
}
