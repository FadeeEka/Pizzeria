using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class SimplePizzaFactory2
    {
        public Pizza2 CreatePizza2(String type)
        {
            Pizza2 Pizza2 = null;

            if (type.Equals("cheese"))
            {
                Pizza2 = new CheesePizza2();
            }
            else if (type.Equals("pepperoni"))
            {
                Pizza2 = new PepperoniPizza2();
            }
            else if (type.Equals("clam"))
            {
                Pizza2 = new ClamPizza2();
            }
            else if (type.Equals("veggie"))
            {
                Pizza2 = new VeggiePizza2();
            }

            return Pizza2;
        }
    }
}
