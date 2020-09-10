using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example13_2
{
    class Operation
    {
        readonly double Pythagoras = Math.Sqrt(2);
        private readonly int PI;

        public Operation()
        {
            PI = 22 / 7;
        }

        public double circlePerimeter(double r)
        {
            return 2 * PI * r;
        }
    }
}
