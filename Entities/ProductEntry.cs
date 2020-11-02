using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductEntry
    {
        public int ID { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public int FuncionarioID { get; set; }
        public float Valor { get; set; }
        public List<Entry_Item> Items { get; set; }
    }
}
