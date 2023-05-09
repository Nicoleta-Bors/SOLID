namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a payment method (1 for online, 2 for cash):");
            int choice = int.Parse(Console.ReadLine());

            IPayment paymentMethod;
            if (choice == 1)
            {
                paymentMethod = new OnlinePayment();
            }
            else if (choice == 2)
            {
                paymentMethod = new CashPayment();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            PaymentService paymentService = new PaymentService(paymentMethod);
            paymentService.PerformPayment(111.0);
        }
    }
}