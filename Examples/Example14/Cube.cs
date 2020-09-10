using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example14
{
    class Cube
    {
        public double height;
        public double width;
        public double depth;

        public double allDimensions
        {
            set
            {
                height = width = depth = value;
            }
        }

        public double getVolume()
        {
            return height * width * depth;
        }


    }
}
