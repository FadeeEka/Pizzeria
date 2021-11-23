using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class PizzaStore2
    {
        SimplePizzaFactory2 factory;
        public PizzaStore2(SimplePizzaFactory2 factory)
        {
            this.factory = factory;
        }
        public Pizza2 orderPizza2(String type)
        {
            Pizza2 pizza;
            pizza = factory.CreatePizza2(type);
            //конкретный экземпляр

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        // other methods here
    }
}

