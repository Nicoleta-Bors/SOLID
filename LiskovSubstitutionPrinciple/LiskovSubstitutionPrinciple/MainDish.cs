using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class MainDish : IMenuItem
    {
        public string Name { get; }
        public decimal Price { get; }
        public string Description { get; }

        public MainDish(string name, decimal price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
