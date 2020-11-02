using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product_Sale
    {
        public int ID { get; set; }
        public DateTime DataVenda { get; set; }
        public float Valor { get; set; }
        public int ClienteID { get; set; }
        public int UserID { get; set; }
    }
}
