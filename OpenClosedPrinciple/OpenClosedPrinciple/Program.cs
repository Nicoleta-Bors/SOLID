using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new List<FoodItem>();

            menu.Add(new FoodItem { Name = "Pizza", Price = 120 });
            menu.Add(new FoodItem { Name = "Salad", Price = 50 });
            menu.Add(new FoodItem { Name = "CocaCola", Price = 20 });

            var priceCalculator = new PriceCalculator();

            Console.WriteLine("Price for standard menu:");
            Console.WriteLine(priceCalculator.CalculatePrice(menu, new StandardPriceStrategy()));

            Console.WriteLine("Price for weekend menu:");
            Console.WriteLine(priceCalculator.CalculatePrice(menu, new WeekendPriceStrategy()));
        }
    }
}
