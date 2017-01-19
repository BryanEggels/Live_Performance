using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_performance.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        public List<Ingredient> ingredienten { get; set; }
        public string naam { get; set; }
        public string vorm { get; set; }
        public int oppervlakte { get; set; }
        public int aantal { get; set; }
        public decimal totaalprijs { get; set; }

        public Pizza()
        {
            ingredienten = new List<Ingredient>();
        }
        public override string ToString()
        {
            return naam;
        }
        public decimal prijs()
        {
            foreach (Ingredient ingredient in ingredienten)
            {
                totaalprijs = totaalprijs + ingredient.Verkoopprijs * oppervlakte;
            }
            return totaalprijs;
        }

    }
}
