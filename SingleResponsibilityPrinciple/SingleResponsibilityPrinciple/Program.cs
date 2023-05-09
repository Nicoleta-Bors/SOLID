using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new List<FoodItem>();

            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Add a food item to the menu");
                Console.WriteLine("2. View the menu");
                Console.WriteLine("3. Exit");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var addFoodItem = new AddFoodItem();
                        addFoodItem.Execute(menu);
                        break;
                    case "2":
                        var viewMenu = new ViewMenu();
                        viewMenu.Execute(menu);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
}
