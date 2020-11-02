using Common.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        public int ID { get; set; }
        public DateTime Data_Cadastro { get; set; }
        [Length(60)]
        [@MinLength(3)]
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
