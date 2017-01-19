using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_performance.Repositories;
using Live_performance.Context;
using Live_performance.Context.Interfaces;

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
        public Bestelling()
        {
            pizzas = new List<Pizza>();
            producten = new List<Product>();
        }
        public void newklant()
        {
            klant = new Klantrepository(new KlantSQLcontext()).add(klant);
        }
    }
}
