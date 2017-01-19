using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_performance.Context.Interfaces;
using Live_performance.Models;

namespace Live_performance.Context
{
    public class PizzaMemoryContext : IPizzacontext
    {
        List<Pizza> pizzalist = new List<Pizza>();
        public Pizza AddPizza(Pizza pizza)
        {
            pizzalist.Add(pizza);
            return pizza;
        }

        public List<Pizza> standaardpizzas()
        {
            List<Pizza> memorypizzalist = new List<Pizza>();
            foreach (Pizza pizza in pizzalist)
            {
                if(pizza.naam != null)
                {
                    memorypizzalist.Add(pizza);
                }
                
            }
            return memorypizzalist;
        }
    }
}
