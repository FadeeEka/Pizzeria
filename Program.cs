using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сначала создается объект NYPizzaStore
            PizzaStore3 nyStore = new NYStylePizzaStore3();
            PizzaStore3 chicagoStore = new ChicagoStylePizzaStore3();

            // Пиццерия построена, теперь можно принять заказ
            // Метод OrderPizza3() вызывает метод CreatePizza3()

            Pizza3 pizza = nyStore.OrderPizza3("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.OrderPizza3("cheese");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");
        }
    }
}
