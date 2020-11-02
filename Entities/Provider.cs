using Common.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Provider
    {
        public int ID { get; set; }
        public string CNPJ { get; set; }
        [Length(70)]
        [@MinLength(3)]
        public string RazaoSocial { get; set; }
        [Length(70)]
        [@MinLength(3)]
        public string NomeFantasia { get; set; }
        [Length(70)]
        [@MinLength(3)]
        public string NomeContato { get; set; }
        [Length(60)]
        [@MinLength(10)]
        public string Email { get; set; }
        [Length(15)]
        [@MinLength(15)]
        public List<string> Telefones { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public int EenderecoID { get; set; }
        public bool Ativo { get; set; }
    }
}
