using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example34
{
    public class Shape
    {
        public const double PI = Math.PI;
        protected double x, y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }

        public virtual double Perimeter()
        {
            return x * 2 + y * 2;
        }

        public int getEdgeLength()
        {
            return (int)x;
        }

    }

    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return PI * x * x;
        }

        public override double Perimeter()
        {
            return 2 * PI * x;
        }

    }

    public class Square : Shape
    {
        public Square(double edge) : base(edge, edge)
        {
            x = y = edge;
        }
    }

}
