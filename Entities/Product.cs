﻿using Common.Auxiliar;
using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ID { get; set; }
        [Length(70)]
        [@MinLength(3)]
        public string Nome { get; set; }
        [Length(150)]
        [@MinLength(0)]
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QtdEstoque { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public int Data_Cadastro { get; set; }
        public int CategoriaID { get; set; }
        public bool Ativo { get; set; }
    }
}
