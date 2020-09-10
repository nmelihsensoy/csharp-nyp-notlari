using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8
{
    static class Operation
    {
        public static class Utility
        {
            public static int absVal(int a)
            {
                if (a < 0) return a * -1;
                else return a;
            }
        }
        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static int multiply(int a, int b)
        {
            return a * b;
        }

    }
}
