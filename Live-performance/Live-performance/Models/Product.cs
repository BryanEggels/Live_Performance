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
        public decimal Inkoopprijs { get; set; }
        public decimal Verkoopprijs { get; set; }
        public bool Halal { get; set; }
        public bool Veganistisch { get; set; }
        public int BTW { get; set; }
        public int aantal { get; set; }
        public bool drank { get; set; }
        public bool ingredient { get; set; }

        public override string ToString()
        {
            return Naam;
        }
    }
}
