using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{   
    public interface Pizza2
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
    public class CheesePizza2 : Pizza2 {
        public void Prepare() { }
        public void Bake() { }
        public void Cut() { }
        public void Box() { }
    }
    public class GreekPizza2 : Pizza2 {
        public void Prepare() { }
        public void Bake() { }
        public void Cut() { }
        public void Box() { }
    }
    public class PepperoniPizza2 : Pizza2 {
        public void Prepare() { }
        public void Bake() { }
        public void Cut() { }
        public void Box() { }
    }
    public class ClamPizza2 : Pizza2 {
        public void Prepare() { }
        public void Bake() { }
        public void Cut() { }
        public void Box() { }
    }
    public class VeggiePizza2 : Pizza2 {
        public void Prepare() { }
        public void Bake() { }
        public void Cut() { }
        public void Box() { }
    }

}
