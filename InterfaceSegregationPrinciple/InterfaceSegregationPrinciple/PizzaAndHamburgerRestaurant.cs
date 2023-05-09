using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class PizzaAndHamburgerRestaurant : IPizza, IHamburger
    {
        public void PreparePizza()
        {
            Console.WriteLine("Pizza is being prepared.");
        }

        public void PrepareHamburger()
        {
            Console.WriteLine("Hamburger is being prepared.");
        }
    }
}
