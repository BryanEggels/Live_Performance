using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_performance.Context.Interfaces;
using Live_performance.Models;

namespace Live_performance.Context
{
    public class BestellingMemoryContext : IBestellingcontext
    {
        List<Bestelling> bestellingen = new List<Bestelling>();

        public bool Add(Bestelling bestelling)
        {
            bestellingen.Add(bestelling);
            return true;
        }

        public List<Bestelling> GetAll()
        {
            return bestellingen;
        }

        public List<Bestelling> GetAll(Klant klant)
        {
            List<Bestelling> memorybestelling = new List<Bestelling>();
            foreach (Bestelling bestelling in bestellingen)
            {
                if (bestelling.klant.ID == klant.ID)
                {
                    memorybestelling.Add(bestelling);
                }
            }
            return memorybestelling;
        }
    }
}
