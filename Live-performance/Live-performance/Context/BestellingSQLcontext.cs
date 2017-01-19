using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_performance.Context.Interfaces;
using Live_performance.Models;

namespace Live_performance.Context
{
    public class BestellingSQLcontext : IBestellingcontext
    {
        public List<Bestelling> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> GetAll(Klant klant)
        {
            throw new NotImplementedException();
        }
    }
}
