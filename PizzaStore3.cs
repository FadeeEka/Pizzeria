using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public abstract class PizzaStore3
    {
        public Pizza3 OrderPizza3(String type)
        {
            Pizza3 pizza;
            pizza = CreatePizza3(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        public abstract Pizza3 CreatePizza3(String type);
    }

    public class NYStylePizzaStore3 : PizzaStore3
    {        
        public override Pizza3 CreatePizza3(string type)
        {
            Pizza3 pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza3();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new NYStylePepperoniPizza3();
            }
            else if (type.Equals("clam"))
            {
                pizza = new NYStyleClamPizza3();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new NYStyleVeggiePizza3();
            }
            return pizza;
        }
    }

    public class ChicagoStylePizzaStore3 : PizzaStore3
    {
        public override Pizza3 CreatePizza3(string type)
        {
            Pizza3 pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new ChicagoStyleCheesePizza3();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new ChicagoStylePepperoniPizza3();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ChicagoStyleClamPizza3();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new ChicagoStyleVeggiePizza3();
            }
            return pizza;
        }
    }

}

