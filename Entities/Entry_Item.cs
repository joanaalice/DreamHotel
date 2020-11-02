using Common.Auxiliar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Entry_Item
    {
        public int ID { get; set; }
        public int ProdutoID { get; set; }
        public int Quantidade { get; set; }
        public float Custo { get; set; }
        public int Product_EntryID { get; set; }
        public int ProviderID { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
