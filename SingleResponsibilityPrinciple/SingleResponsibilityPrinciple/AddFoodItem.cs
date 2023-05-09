using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class AddFoodItem
    {
        public void Execute(List<FoodItem> menu)
        {
            Console.Write("Enter the name of the food item: ");
            var name = Console.ReadLine();

            Console.Write("Enter the price of the food item: ");
            var priceInput = Console.ReadLine();
            if (!decimal.TryParse(priceInput, out decimal price))
            {
                Console.WriteLine("Invalid price. Please try again.");
                return;
            }

            menu.Add(new FoodItem { Name = name, Price = price });

            Console.WriteLine($"{name} has been added to the menu.");
        }
    }
}
