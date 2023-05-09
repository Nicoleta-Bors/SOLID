using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new List<IMenuItem>
            {
                new MainDish("Grilled Chicken", 150m, "Marinated and grilled chicken breast"),
                new MainDish("Pasta Carbonara", 120m, "Pasta in a creamy sauce with bacon and Parmesan cheese"),
                new Drink("Coke", 20m, 0.5m),
                new Drink("Orange Juice", 20m, 0.35m)
            };

            Console.WriteLine("Menu:");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Name} - {item.Price} lei");
                Console.WriteLine(item.Description);
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
