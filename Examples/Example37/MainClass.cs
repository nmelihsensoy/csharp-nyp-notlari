using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example37
{
    interface IHello
    {
        void helloWorld();
    }

    class MainClass : IHello
    {
        public void helloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public static void Main(String[] args)
        {
            MainClass hello = new MainClass();

            hello.helloWorld();

            Console.ReadLine();
        }
    }

}
