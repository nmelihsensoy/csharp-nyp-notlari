using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example9
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassInstance();
            GC.Collect(); //for seeing the destructor message

            Console.ReadLine();//preventing console from closing

        }

        public static void ClassInstance() {
            MyClass MyClass1 = new MyClass();
        }

    }
}
