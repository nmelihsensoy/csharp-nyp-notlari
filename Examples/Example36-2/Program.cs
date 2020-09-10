using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example36_2
{
    public abstract class Vehicle
    {
        public abstract void display();
    }

    public class Bus : Vehicle
    {
        public override void display()
        {
            Console.WriteLine("Bus");
        }
    }

    public class Car : Vehicle
    {
        public override void display()
        {
            Console.WriteLine("Car");
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void display()
        {
            Console.WriteLine("Motorcycle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v;
            v = new Bus();
            v.display();
            v = new Car();
            v.display();
            v = new Motorcycle();
            v.display();

            Console.ReadLine();
        }
    }
}
