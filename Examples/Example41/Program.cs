using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example41
{
    public delegate void myCustomHandler();

    public class NumberClass
    {
        private int _number = 0;
        public event myCustomHandler BigNumber;

        public int number
        {
            set 
            {
                _number = value;
                if (value > 10) {
                    BigNumber();
                } 
            
            }
            get { return _number; }
        }
    }
    
   
    class Program
    {
        static void bigNumberAlert()
        {
            Console.WriteLine("Event Triggered! Entered Number is bigger than 10.");
        }

        static void Main(string[] args)
        {
            NumberClass numberObj = new NumberClass();
            numberObj.BigNumber += new myCustomHandler(bigNumberAlert);

            while (true)
            {
                Console.WriteLine("Enter Number :");
                int enteredNumber = Convert.ToInt32(Console.ReadLine());
                numberObj.number = enteredNumber;
            }

        }
    }
}
