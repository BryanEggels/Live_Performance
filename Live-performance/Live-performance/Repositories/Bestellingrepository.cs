using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_performance.Context.Interfaces;
using Live_performance.Models;

namespace Live_performance.Repositories
{
    public class Bestellingrepository : IBestellingcontext
    {
        IBestellingcontext context;

        public Bestellingrepository(IBestellingcontext context)
        {
            this.context = context;
        }

        public bool Add(Bestelling bestelling)
        {
            return context.Add(bestelling);
        }

        public List<Bestelling> GetAll()
        {
            return context.GetAll();
        }

        public List<Bestelling> GetAll(Klant klant)
        {
            return context.GetAll(klant);
        }
    }
}
