using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_performance.Models;

namespace Live_performance.Context.Interfaces
{
    public interface IPizzacontext
    {
        Pizza AddPizza(Pizza pizza);
        List<Pizza> standaardpizzas();
    }
}
