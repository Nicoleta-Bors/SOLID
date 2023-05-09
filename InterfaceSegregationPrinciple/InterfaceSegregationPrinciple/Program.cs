
namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizzaRestaurant = new PizzaRestaurant();
            pizzaRestaurant.PreparePizza();

            IHamburger pizzaAndHamburgerRestaurant = new PizzaAndHamburgerRestaurant();
            pizzaAndHamburgerRestaurant.PrepareHamburger();
        }
    }
}
