using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class PizzaRestaurant : IPizza
    {
        public void PreparePizza()
        {
            Console.WriteLine("Pizza is being prepared.");
        }
    }
}
