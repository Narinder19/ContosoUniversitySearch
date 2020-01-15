using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = 37;
            double fahrenheit = 98.6;
            Console.WriteLine("Celicus {0} is equal to Fahrenheit {1}", celcius, Converter.ToFahrenheit(37));
            Console.WriteLine("Fahrenheit {0} is equal to Celcius {1}", fahrenheit, Converter.ToCelcius(86.7));
        }
    }
}
