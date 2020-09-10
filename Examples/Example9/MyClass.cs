using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example9
{
    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Constructer Called!");
        }

        ~MyClass() {
            Console.WriteLine("Destructor Called!");
        }
    }
}
