using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_performance.Models
{
    public class Pizza
    {
        public List<Ingredient> ingredienten { get; set; }
        public bool standaardpizza { get; set; }
        public string naam { get; set; }
    }
}
