using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_performance.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public int Inkoopprijs { get; set; }
        public int Verkoopprijs { get; set; }
        public bool Halal { get; set; }
        public bool Veganistisch { get; set; }
    }
}
