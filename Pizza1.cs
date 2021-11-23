using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public abstract class Pizza1
    {
        public virtual void Prepare() { }
        public virtual void Bake() { }
        public virtual void Cut() { }
        public virtual void Box() { }
    }
    public class CheesePizza1 : Pizza1 { }
    public class GreekPizza1 : Pizza1 { }
    public class PepperoniPizza1 : Pizza1 { }  
    public class ClamPizza1 : Pizza1 { }
    public class VeggiePizza1 : Pizza1 { }   
}
