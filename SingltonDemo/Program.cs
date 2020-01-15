using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintStudentDetails(),
                () => PrintEmployeeDetails()
                );
            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            Singleton singleton2 = Singleton.GetInstance;
            singleton2.PrintDetails("From Employee Class");
        }

        private static void PrintStudentDetails()
        {
            Singleton singleton = Singleton.GetInstance;
            singleton.PrintDetails("From Student Class");
        }
    }
}
