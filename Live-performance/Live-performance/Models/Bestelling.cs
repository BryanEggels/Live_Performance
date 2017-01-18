using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_performance.Models
{
    public class Bestelling
    {
        public Klant klant { get; set; }
        public List<Pizza> pizzas { get; set; }
        public List<Product> producten { get; set; }
        public void totaalprijs()
        {

        }
    }
}
