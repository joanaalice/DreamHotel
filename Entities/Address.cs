using Common.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Address
    {
        public int ID { get; set; }
        [Length(10)]
        [@MinLength(1)]
        public string Numero { get; set; }
        [Length(120)]
        [@MinLength(3)]
        public string Rua { get; set; }
        [Length(120)]
        [@MinLength(3)]
        public string Bairro { get; set; }
        [Length(100)]
        [@MinLength(3)]
        public string Cidade { get; set; }
        [Length(2)]
        [@MinLength(2)]
        public string UF { get; set; }
        [Length(16)]
        [@MinLength(8)]
        public string CEP { get; set; }
        [Length(20)]
        [@MinLength(2)]
        public string Pais { get; set; }

    }
}
