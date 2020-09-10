using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine(Calculation.sum(a, b));

            double c = 10.5;
            double d = 22.5;

            Console.WriteLine(Calculation.sum(c, d));

            Console.ReadLine();
        }
    }
}
