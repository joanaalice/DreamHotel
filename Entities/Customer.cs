using Common.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        public int ID { get; set; }
        [Length(70)]
        [@MinLength(3)]
        public string Nome { get; set; }
        [Length(11)]
        [@MinLength(11)]
        public string CPF { get; set; }
        [Length(15)]
        [@MinLength(5)]
        public string RG { get; set; }
        [Length(15)]
        [@MinLength(7)]
        public string Telefone { get; set; }
        [Length(15)]
        [@MinLength(7)]
        public string Telefone_aux { get; set; } = "NÃO INFORMADO";
        [Length(60)]
        [@MinLength(10)]
        public string Email { get; set; }
        public int EnderecoId { get; set; }
        public Address Endereco { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
