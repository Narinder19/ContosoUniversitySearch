using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleClass
{
    public class InheritedCar : Car
    {

        public InheritedCar(string name):base(name)
        {
            Console.WriteLine("\nCreated InheritedClass for {0}", name);
        }

        public void Break()
        {
            Velocity--;
            Console.WriteLine("Breaked {0} to velocity {1} (with inheritance)", Name, Velocity);
        }
    }
}
