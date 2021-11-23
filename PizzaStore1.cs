using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class PizzaStore1
    {
        public Pizza1 orderPizza1(String type)
        {
            Pizza1 pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza1();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza1();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza1();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza1();
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        // other methods here
    }
}

