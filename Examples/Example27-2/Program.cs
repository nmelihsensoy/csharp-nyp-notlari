using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example27_2
{

    public class Vehicle
    {
        public string brand;
        public int price;
        public int model;

        public Vehicle(string brand, int price, int model)
        {
            this.brand = brand;
            this.price = price;
            this.model = model;
        }
    }

    public class Car : Vehicle
    {
        public int seatCapacity;

        public Car(string brand, int price, int model, int capacity) : base(brand, price, model)
        {
            seatCapacity = capacity;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\nBrand :" + brand);
            Console.WriteLine("Price :" + price);
            Console.WriteLine("Model :" + model);
            Console.WriteLine("Seating Capacity :" + seatCapacity + " peoples.");
        }
    }

    public class Truck : Vehicle
    {

        public int loadCapacity;
        public Truck(string brand, int price, int model, int load) : base(brand, price, model)
        {
            this.loadCapacity = load;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\nBrand :" + brand);
            Console.WriteLine("Price :" + price);
            Console.WriteLine("Model :" + model);
            Console.WriteLine("Load Capacity" + loadCapacity + " tons");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Tesla", 75000, 2020, 5);
            Truck truck1 = new Truck("Volvo", 400000, 2018, 300);

            car1.DisplayInfo();
            Console.WriteLine("\n");
            truck1.DisplayInfo();
            Console.ReadLine();

        }
    }
}
