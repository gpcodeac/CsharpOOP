using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture205.Class_library
{
    internal class Circle : Shape
    {
        private double radius;
        public double Radius { get { return radius; } private set { radius = value; } }

        public Circle(double radius) 
        {
            Radius = radius;
        }

        public sealed override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public sealed override void PrintArea()
        {
            Console.WriteLine($"The area of the circle is {CalculateArea()}");
        }
    }
}
