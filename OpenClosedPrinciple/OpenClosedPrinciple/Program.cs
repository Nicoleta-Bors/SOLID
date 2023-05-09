using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new List<FoodItem>();

            // Adăugarea unor produse la meniu
            menu.Add(new FoodItem { Name = "Pizza", Price = 120 });
            menu.Add(new FoodItem { Name = "Salad", Price = 50 });
            menu.Add(new FoodItem { Name = "CocaCola", Price = 20 });

            // Crearea unui obiect pentru calcularea prețului
            var priceCalculator = new PriceCalculator();

            // Calcularea prețului pentru meniul standard
            Console.WriteLine("Price for standard menu:");
            Console.WriteLine(priceCalculator.CalculatePrice(menu, new StandardPriceStrategy()));

            // Calcularea prețului pentru meniul de weekend
            Console.WriteLine("Price for weekend menu:");
            Console.WriteLine(priceCalculator.CalculatePrice(menu, new WeekendPriceStrategy()));
        }
    }
}
