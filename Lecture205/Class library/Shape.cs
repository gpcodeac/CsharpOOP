using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture205.Class_library
{
    internal class Shape
    {
        private double area;
      
        public double Area { get { return area; } private set { area = value; } }

        public virtual double CalculateArea()
        {
            return Area;
        }

        public virtual void PrintArea()
        {
            Console.WriteLine($"The area of the shape is {Area}");
        }
    }
}
