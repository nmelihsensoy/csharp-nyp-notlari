using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class SomeClass
    {
        static int value;
        int value2;

        static SomeClass()
        {
            Console.WriteLine("Static Constructor");
            value = 143;
        }

        public SomeClass(int val)
        {
            Console.WriteLine("Non-Static Constructor");
            value2 = val;
        }

        public void printData()
        {
            Console.WriteLine("Value: " + value);
            Console.WriteLine("Value2: " + value2);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            SomeClass MyClass1 = new SomeClass(100);
            SomeClass MyClass2 = new SomeClass(200);

            MyClass1.printData();
            Console.WriteLine("");
            MyClass2.printData();

            //Console Wait
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
