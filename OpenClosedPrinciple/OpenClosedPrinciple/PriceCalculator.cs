using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class PriceCalculator
    {
        public decimal CalculatePrice(List<FoodItem> menu, PriceStrategy strategy)
        {
            return strategy.CalculatePrice(menu);
        }
    }
}
