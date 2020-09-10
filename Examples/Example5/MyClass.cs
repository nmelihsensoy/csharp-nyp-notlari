using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class MyClass
    {
        private static int result = 0;

        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static void storeResult(int val) {
            result = val;
        }

        public static int getResult()
        {
            return result;
        }

    }
}
