using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example18
{
    public class MyClass
    {
        private string text = "Hello";
        public int number = 15;
        public static int number2 = 10;

        public static void sum()
        {
            number2 += number2;
        }

        public void sum2()
        {
            number += number;
        }

        public string getText()
        {
            return this.text;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

    }
}
