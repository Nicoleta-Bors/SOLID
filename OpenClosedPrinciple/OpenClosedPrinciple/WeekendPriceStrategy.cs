using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class WeekendPriceStrategy : PriceStrategy
    {
        public override decimal CalculatePrice(List<FoodItem> menu)
        {
            decimal price = 0;
            foreach (var item in menu)
            {
                price += item.Price * 1.1m; // Adăugăm 10% pentru meniul de weekend
            }
            return price;
        }
    }
}
