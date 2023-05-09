using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class CashPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Waiting for cash payment of {0} lei...", amount);
        }
    }
}
