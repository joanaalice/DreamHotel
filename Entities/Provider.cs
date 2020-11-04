using Common.Auxiliar;
using System;

namespace Entities
{
    public class Provider
    {
        public Provider()
        {
            this.Endereco = new Address();
        }
        public int ID { get; set; }
        [Length(20)]
        [@MinLength(14)]
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
        [@MinLength(8)]
        public string Telefone { get; set; }
        public string Telefone_Aux { get; set; } = "Não informado";
        public DateTime Data_Cadastro { get; set; }
        public int EnderecoID { get; set; }
        public Address Endereco { get; set; }
        public bool Ativo { get; set; }
    }
}
