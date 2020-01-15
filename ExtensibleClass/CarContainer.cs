using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensibleClass
{
    public class CarContainer
    {
        public Car car;
        public CarContainer(Car c)
        {
            this.car = c;
            Console.WriteLine("\nCreated container for {0}", this.car.Name);
        }

        public void Break()
        {
            this.car.Velocity--;
            Console.WriteLine("Breaked {0} to velocity {1} (with container)", this.car.Name,car.Velocity);
        }
    }
}
