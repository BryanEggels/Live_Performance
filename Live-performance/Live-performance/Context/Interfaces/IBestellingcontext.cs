using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_performance.Models;

namespace Live_performance.Context.Interfaces
{
    public interface IBestellingcontext
    {
        List<Bestelling> GetAll();
        List<Bestelling> GetAll(Klant klant);
        bool Add(Bestelling bestelling);
    }
}
