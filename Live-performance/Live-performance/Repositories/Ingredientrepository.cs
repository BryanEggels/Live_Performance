using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_performance.Context.Interfaces;
using Live_performance.Models;

namespace Live_performance.Repositories
{
    public class Ingredientrepository : IIngredientcontext
    {
        IIngredientcontext context;

        public Ingredientrepository(IIngredientcontext context)
        {
            this.context = context;
        }

        public List<Ingredient> GetAll()
        {
            return context.GetAll();
        }
    }
}
