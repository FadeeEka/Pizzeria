using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public abstract class Pizza3
    {
        public String name;
        public String dough;
        public String sauce;
        public List<String> toppings = new List<String>();
        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");

            foreach (String topping in toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public virtual String getName()
        {
            return name;
        }
    }

    public class NYStyleCheesePizza3 : Pizza3 
    {
        public NYStyleCheesePizza3()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
    public class NYStyleGreekPizza3 : Pizza3 { }
    public class NYStylePepperoniPizza3 : Pizza3 { }
    public class NYStyleClamPizza3 : Pizza3 { }
    public class NYStyleVeggiePizza3 : Pizza3 { }

    public class ChicagoStyleCheesePizza3 : Pizza3
    {
        public ChicagoStyleCheesePizza3()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
    public class ChicagoStyleGreekPizza3 : Pizza3 { }
    public class ChicagoStylePepperoniPizza3 : Pizza3 { }
    public class ChicagoStyleClamPizza3 : Pizza3 { }
    public class ChicagoStyleVeggiePizza3 : Pizza3 { }
}
