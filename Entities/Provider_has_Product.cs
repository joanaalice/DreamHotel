using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Provider_has_Product
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int ProviderID { get; set; }
    }
}
