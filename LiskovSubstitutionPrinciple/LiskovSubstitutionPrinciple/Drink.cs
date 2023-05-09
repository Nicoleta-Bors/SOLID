using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Drink : IMenuItem
    {
        public string Name { get; }
        public decimal Price { get; }
        public string Description { get; }

        public decimal Volume { get; }

        public Drink(string name, decimal price, decimal volume)
        {
            Name = name;
            Price = price;
            Volume = volume;
            Description = $"Size: {volume}l";
        }
    }
}
