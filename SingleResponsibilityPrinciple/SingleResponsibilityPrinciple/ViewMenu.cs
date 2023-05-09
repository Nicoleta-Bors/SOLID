using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class ViewMenu
    {
        public void Execute(List<FoodItem> menu)
        {
            Console.WriteLine("Menu:");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Name} - {item.Price} lei");
            }
        }
    }
}
