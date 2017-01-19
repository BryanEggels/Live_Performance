using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_performance.Context.Interfaces;
using Live_performance.Models;

namespace Live_performance.Repositories
{
    public class Productrepository : IProductcontext
    {
        IProductcontext context;

        public Productrepository(IProductcontext context)
        {
            this.context = context;
        }



        public List<Product> AlleBodems()
        {
            return context.AlleBodems();
        }

        public List<Product> Alleproducten()
        {
            return context.Alleproducten();
        }

        public bool Edit(Product product, int id)
        {
            return context.Edit(product,id);
        }
    }
}
