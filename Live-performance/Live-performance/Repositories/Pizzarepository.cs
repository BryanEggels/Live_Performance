using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_performance.Context.Interfaces;
using Live_performance.Models;

namespace Live_performance.Repositories
{
    public class Pizzarepository
    {
        IPizzacontext context;
        public Pizzarepository(IPizzacontext context)
        {
            this.context = context;
        }
    }
}
