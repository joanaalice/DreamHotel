using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sale_Item
    {
        public int ID { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public int VendaId { get; set; }
        public bool Ativo { get; set; }
    }
}
